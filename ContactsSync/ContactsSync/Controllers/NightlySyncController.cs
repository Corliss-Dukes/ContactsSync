using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsSync.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using Microsoft.Identity.Web;

namespace ContactsSync.Controllers
{
    public class NightlySyncController : Controller
    {
        private readonly ITokenAcquisition _tokenAcquisition;
        private readonly patientInfoContext _context;


        public NightlySyncController(
            ITokenAcquisition tokenAcquisition,
            patientInfoContext context)

        {
            _tokenAcquisition = tokenAcquisition;
            _context = context;
        }
        //this is the main function that will get automated
        public async void NightlySync()
        {

            var patients = await FetchChanges();
            var converted = ConvertToContact(patients);
            if (converted != null)
            {
                PostContacts(converted);
            }
        }

        //TODO:TEST- Check DB for recent changes, return a list of patients 
        //TODO:TEST- if list is not empty, create list of MS contact objects from list
        //TODO: Loop through the list and first delete contact, then add new (updated) contact
        // ( where SQL id == FileAs ) 
        private async Task<IEnumerable<Patients>> FetchChanges()
        {
            DateTime dt = DateTime.Today.AddDays(-1);
            //TODO: Make sure CrystalDB has a field for recent edits
            //return await _context.Patients.Where(p => p.lastEdit > dt).ToListAsync();
            return await _context.Patients.Select(p => p).ToListAsync(); //this is just filler for testing
        }

        private static List<Contact> ConvertToContact( IEnumerable<Patients> patients)
        {
            //if sql query return no result, retun a null List<Contact>
            if((patients != null) && (!patients.Any()))
            {
                return null;
            }
            else
            {
                //create a new List<Contact>
                List<Contact> ContactList = new List<Contact>();
                //loop over the sql query and make new MS Contacts from each, push to new List
                foreach(var patient in patients)
                {
                Contact contact = new PatientContact().NewContact(patient);
                    ContactList.Add(contact);
                }
                return ContactList;
            }
        }

        private async void PostContacts(List<Contact> list)
        {
            //initialize the MS Graph API client to connect to Graph
            var graphClient = GraphServiceClientFactory
                .GetAuthenticatedGraphClient(async () =>
                {
                    return await _tokenAcquisition
                        .GetAccessTokenForUserAsync(GraphConstants.Scopes);
                });
            //TODO: Get all from MS Contacts, compare FileAs to list.Id, keep matches send to a list
            // with only FileAs and Id = List<> MSContacts
            var MSContacts = await graphClient.Me.Contacts
                .Request()
                //this may not work
                .Select("fileAs,id")
                .GetAsync();
            var ReadyList = prepareList(list, MSContacts);
            foreach (Contact c in ReadyList)
            {
                //TODO: Delete Contacts {ID} where FileAs = c.Id
                var id = c.Id;
                await graphClient.Me.Contacts[id]
                    .Request()
                    .DeleteAsync();
                //TODO: Post to Contacts(c)
                await graphClient.Me.Contacts
                .Request()
                .AddAsync(c);
            }
        }

        //******************************** HELPER FUNCTIONS *******************//
        private static List<Contact> prepareList(List<Contact> fromSqlList, IUserContactsCollectionPage mscontactslist)
        {
            var temp = new List<Contact>();
            foreach(Contact c in fromSqlList)
            {
                var match = mscontactslist.Where(m => m.FileAs == c.FileAs).FirstOrDefault();
                c.Id = match.Id; //set the Id property from SQL to MS Contact Id
                temp.Add(c);
            }
            return temp;
        }
              
    }
}