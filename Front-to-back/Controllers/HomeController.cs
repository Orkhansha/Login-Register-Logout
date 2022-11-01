using Front_to_back.Data;
using Front_to_back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {

            return View();
        }

       
    }
}
