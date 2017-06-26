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
            ModelState.Clear();

            var viewModel = JsonConvert.DeserializeObject<ApplyViewModel>(applyModel);

            var next = Request.Form["Next"];
            var previous = Request.Form["Previous"];
            if (next.Count > 0)
            {
                if (viewModel.CurrentStep < viewModel.Interview.Questions.Count - 1)
                {
                    viewModel.CurrentStep += 1;
                }
            }
            else if (previous.Count > 0)
            {
                if (viewModel.CurrentStep > 0)
                {
                    viewModel.CurrentStep -= 1;
                }
            }

  
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
