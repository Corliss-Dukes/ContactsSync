using ContactsSync.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using Microsoft.Identity.Web;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ContactsSync.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ITokenAcquisition _tokenAcquisition;
        private readonly patientInfoContext _context;

        public ContactsController(
            ITokenAcquisition tokenAcquisition,
            patientInfoContext context)
            
        {
            _tokenAcquisition = tokenAcquisition;
            _context = context;
        }
        public async Task<IActionResult> Initialize()
        {
            var graphClient = GraphServiceClientFactory
                .GetAuthenticatedGraphClient(async () =>
                {
                    return await _tokenAcquisition
                        .GetAccessTokenForUserAsync(GraphConstants.Scopes);
                });

            //Get Data - see function below
            var sql = await GetDataFromDB();

            foreach (Patients patient in sql.Value)
            {
                try
                {
                    //make a new MS Contact Object using the patient data from sql query
                    Contact contact = new PatientContact().NewContact(patient);
                    //send the Contact Object to Microsoft People
                    await graphClient.Me.Contacts
                        .Request()
                        .AddAsync(contact);
                }
                catch (ServiceException ex)
                {
                    return RedirectToAction("Index")
                            .WithError("Error With the Contact", ex.Error.Message);
                }
            }

            return RedirectToAction("Index", "Home");

        }

        //IMPORT list of contacts from SQL and turn into JsonPerson Objects
        private async Task<ActionResult<IEnumerable<Patients>>> GetDataFromDB()
        {
            return await _context.Patients.Select(p => p).ToListAsync();
        }
    }
}