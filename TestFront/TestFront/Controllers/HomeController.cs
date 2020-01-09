using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestFront.HttpHelpers;
using TestFront.Models;

namespace TestFront.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMyHttpMethods _apiMethods;

        public HomeController(HttpClient client)
        {
            _apiMethods = new MyHttpMethods(client);
        }
        //public HomeController(IMyHttpMethods apiMethods)
        //{
        //    _apiMethods = apiMethods;
        //}


        public async Task<IActionResult> GetCustomersView()
        {
            List<Customer> customers = await _apiMethods.GetCustomersAsync();
            //List<Customer> customers = await _apiMethods.GetRoomsAsync();

            return View("", customers);
        }

        //public IActionResult Index()
        //{
        //    //var list = new List<Customer>()
        //    //return View("Index", list);
        //    return View("Index");
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
