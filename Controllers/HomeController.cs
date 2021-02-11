//This is the home controller page

using Assignment_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //I used 
        [HttpGet]
        public IActionResult SubmissionForm()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SubmissionForm(FoodResponse foodResponse)
        {
            Hold.AddFood(foodResponse);
            return View("Output", foodResponse);
        }


        public IActionResult FoodList()
        {
            //Creation of list of strings for the restaurants.
            //This will store the info that will be passed to view
            List<string> foodList = new List<string>();

            //Go through each list of restaurant objects and build an outputed statement
            foreach(Food f in Food.GetFood())
            {
                //This protects against nulls
                string? dish = f.FavoriteDish;
                string? phone = f.RestaurantPhone;
                string web = f.Website;
                foodList.Add(string.Format("#{0}: {1} | {2} | {3} | {4} | {5}", f.Rank, f.RestaurantName, dish, f.Address, phone, f.Website));
            }

            return View(foodList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Output2()
        {
            return View(Hold.Food);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
