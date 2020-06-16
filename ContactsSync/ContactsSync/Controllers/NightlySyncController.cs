using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContactsSync.Controllers
{
    public class NightlySyncController : Controller
    {
        //TODO: Check DB for recent changes, return a list of patients 
        //TODO: if list is not empty, create list of MS contact objects from list
        //TODO: Loop through the list and first delete contact, then add new (updated) contact
        // ( where SQL id == FileAs )
    }
}