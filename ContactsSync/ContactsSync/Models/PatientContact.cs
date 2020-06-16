using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsSync.Models;
using Microsoft.Graph;

namespace ContactsSync.Models
{
    public class PatientContact : Contact
    {
        public Contact NewContact(Patients patient)
        {
            var newContact = new Contact()
            {
                FileAs = patient.Id.ToString(),
                GivenName = patient.FirstName,
                Surname = patient.LastName,
                MiddleName = patient.MiddleName,
                NickName = patient.Nickname,
                BusinessPhones = new List<String>()
                {
                    patient.WorkPhone
                },
                HomePhones = new List<String>()
                {
                    patient.HomePhone
                },
                MobilePhone = patient.CellPhone,
                HomeAddress = new PhysicalAddress()
                {
                    City = patient.City,
                    PostalCode = patient.Zipcode,
                    State = patient.State,
                    Street = patient.Address1
                },
                Birthday = new DateTimeOffset(DateTime.Parse(patient.Dob))

            };
            bool formated = formatEmail(patient.Email);
            if (formated)
            {
            bool valid = validateExtension(patient.Email);
            }
            if (patient.Email != null)
            {
                //TODO: Include some regex to validate format and domain extension
                newContact.EmailAddresses = new List<EmailAddress>()
                {
                    new EmailAddress
                    {
                        Address = patient.Email,
                        Name = patient.FullName
                    }

                };
            };
            return newContact;
        }
        //******************************** HELPER FUNCTIONS ******************
        private static bool formatEmail(string email)
        {
            //TODO: check for proper email format            
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }            
        }

        private static bool validateExtension(string email)
        {
            // domain list can be found at https://data.iana.org/TLD/tlds-alpha-by-domain.txt 

            return true;
        }
    }
}
