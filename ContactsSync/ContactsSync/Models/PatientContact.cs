using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Graph;

namespace ContactsSync.Models
{
    public class PatientContact : Contact
    {
        public Contact NewContact(Patients patient)
        {
            var newContact = new Contact()
            {
                //FileAs = patient.Id.ToString(),
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
                    PostalCode = patient.Zipcode.ToString(),
                    State = patient.State,
                    Street = patient.Address1
                },
                Birthday = new DateTimeOffset(DateTime.Parse(patient.Dob.ToString()))

            };
            if (patient.Email != null)
            {
                //DONE: validate format and domain extension of email
                bool f = isFormatted(patient.Email) ? true : false;
                bool v = f ? isValidExtension(patient.Email) : false;
                newContact.EmailAddresses = v ? newEmail(patient.Email, patient.FullName) : null;
            };
            return newContact;
        }
        //******************************** HELPER METHODS ******************
        private static bool isFormatted(string email)
        {
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

        private static bool isValidExtension(string email)
        {
            // domain list can be found at https://data.iana.org/TLD/tlds-alpha-by-domain.txt 
            string[] domexts = System.IO.File.ReadAllLines(@"C:\Users\Kcils\Desktop\ContactsSync\ContactsSync\ContactsSync\wwwroot\validate.txt"); //get relative path
            string ext = getExtension(email);
            return domexts.Contains(ext) ? true : false;
        }

        private static string getExtension(string email)
        {
            char splitter = '.';
            string[] temp = email.Split(splitter, StringSplitOptions.None);
            return temp[^1].ToString().ToUpper();
            //temp.Length - 1
        }

        private static List<EmailAddress> newEmail(string email, string name)
        {
            List<EmailAddress> temp = new List<EmailAddress>()
            {
                new EmailAddress
                {
                    Address = email,
                    Name = name
                }

            };
            return temp;

        }
    }
}
