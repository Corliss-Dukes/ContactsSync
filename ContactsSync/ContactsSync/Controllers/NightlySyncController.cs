using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContactsSync.Controllers
{
    public class NightlySyncController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}