using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_App.Controllers
{
    public class Value : Controller
    {
        public IActionResult Index()
        {///
            // hello 
            return View();
        }
    }
}
