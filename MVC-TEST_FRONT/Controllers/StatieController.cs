using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_TEST_FRONT.Models;

namespace MVC_TEST_FRONT.Controllers
{
    public class StatieController : Controller
    {
        private readonly ILogger<StatieController> _logger;

        public StatieController(ILogger<StatieController> logger)
        {
            _logger = logger;
        }


        public IActionResult Adauga()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(id);
        }

        public IActionResult Delete(int id)
        {
            return View(id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
