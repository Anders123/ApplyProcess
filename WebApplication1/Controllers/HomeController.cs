using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplyProcess.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult DoUpdate(string applyModel)
        {
            var viewModel = JsonConvert.DeserializeObject<ApplyViewModel>(applyModel);
           // return ViewComponent("ApplyComponent", viewModel);
           return View("Index", viewModel);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
