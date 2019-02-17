using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackSU.Models;
using HackSU.ViewModels;

namespace HackSU.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponsecs guestResponsecs)
        {
            //Todo: store response from guest
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponsecs);
                var AllClasses = new List<ClassesModel>
                {
                    new ClassesModel("physical_database_design_&_opt", "Fall", 5),
                    new ClassesModel("comp_system_principles_2", "Fall", 3),
                    new ClassesModel("fund_of_software_engineerring", "Spring", 3),
                    new ClassesModel("data_structures_and_algorithms", "Spring", 5),
                    new ClassesModel("security_in_computing", "Winter", 3),
                    new ClassesModel("sw_architecture_and_design_1", "Winter", 3)
                };
                var viewModel = new StudentClassesViewModel
                {
                    Student = guestResponsecs,
                    ClassesAvailable = AllClasses
                };
                return View("Thanks", viewModel);
            } else
            {
                //there is a validation error
                return View();
            }
        }

        public ViewResult RsvpForm()
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.route == "seminar")); 
        }
    }
}
