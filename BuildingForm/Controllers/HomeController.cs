using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuildingForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repostory.Products);
        }


        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }




        [HttpPost]

        public IActionResult Create( Product model, string name)
        {

            return View();
        }


        [HttpGet]

    public IActionResult Search(string q)
    {
        return View();
    }





    }
}