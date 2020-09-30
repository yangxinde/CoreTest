using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class test2Controller : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public test2Controller(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string id)
        {
            ViewBag.test = id;
            return View();
        }


    }
}
