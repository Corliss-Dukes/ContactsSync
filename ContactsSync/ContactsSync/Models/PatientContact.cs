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
    }
}
