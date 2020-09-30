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
    public class testController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public testController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            testViewModel m = new testViewModel();
            List<tt> tlist = new List<tt>();
            for (int i = 0; i < 10; i++)
            {
                tt t = new tt();
                t.link = "/test2/index/" + i;
                t.userid = i.ToString();
                tlist.Add(t);
            }
            m.data = tlist;
            return View(m);
        }


    }
}
