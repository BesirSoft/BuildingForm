using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewBag.Category = new SelectList(new List<string>() { "Telefon", "Tablet", "Bilgissayr", "Oyuncak", "Kulaklık" });


            return View();
        }




        [HttpPost]

        public IActionResult Create( Product model, string name)
        {


            if (!ModelState.IsValid)
            {
       

                return View();
            }
            Repostory.AddProduct(model);
            return RedirectToAction("index");
           
}


        [HttpGet]

    public IActionResult Search(string q)
    {

            if (string.IsNullOrWhiteSpace(q))
            {
                return View();
            }
            else
            {


                var list = Repostory.Products.Where(p => p.Name.Contains(q) || p.Description.Contains(q));
                return View("index", list);
            }


    
    }



        [HttpGet]

        public IActionResult Edit(int id)
        {

            ViewBag.Category = new SelectList(new List<string>() { "Telefon", "Tablet", "Bilgissayr", "Oyuncak", "Kulaklık" });
            var model = Repostory.Products.Where(p => p.Id == id).FirstOrDefault();

            //var list = Repostory.Products.Where(p => p.Name.Contains(q) || p.Description.Contains(q));
            return View(model);




        }

        [HttpPost]
        public IActionResult Edit(Product q)
        {


            ViewBag.Category = new SelectList(new List<string>() { "Telefon", "Tablet", "Bilgissayr", "Oyuncak", "Kulaklık" });

            //var list = Repostory.Products.Where(p => p.Name.Contains(q) || p.Description.Contains(q));
            return View();




        }








    }
}