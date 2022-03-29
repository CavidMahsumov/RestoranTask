using Microsoft.AspNetCore.Mvc;
using RestoranTask.Entities;
using RestoranTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoranTask.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink{ ImgPath="img/coco.png", Name ="Cola", Price=0.70},
                new Drink{ Name="Pepsi", Price=0.70},
                new Drink{ Name="Fanta", Price=0.70}

            };

            List<Meal> Meals = new List<Meal>
            {
                new Meal{ Name="Dolma", Price=3.00},
                new Meal{ Name="Ash", Price=5.00},
                new Meal{ Name="Kabab", Price=3.20}
            };

            List<FastFood> foods = new List<FastFood>
            {
                new FastFood{ Name="Free", Price=2.20},
                new FastFood{ Name="Burger", Price=1.90},
                new FastFood{ Name="Pizza", Price=4.20}
            };   

            var model = new MealListViewModel { drinks = drinks, meals = Meals, fastfoods = foods };

            return View(model);


        }

        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink{ ImgPath="img/coco.png", Name ="Cola", Price=0.70},
                new Drink{ Name="Pepsi", Price=0.70},
                new Drink{ Name="Fanta", Price=0.70}

            };

            return View(drinks);

        }
        public IActionResult FastFoods()
        {
            List<FastFood> foods = new List<FastFood>
            {
                new FastFood{ Name="Free", Price=2.20},
                new FastFood{ Name="Burger", Price=1.90},
                new FastFood{ Name="Pizza", Price=4.20}
            };
            return View(foods);
        }

        public IActionResult Meals()
        {
            List<Meal> Meals = new List<Meal>
            {
                new Meal{ Name="Dolma", Price=3.00},
                new Meal{ Name="Ash", Price=5.00},
                new Meal{ Name="Kabab", Price=3.20}
            };

            return View(Meals);

        }
    }
}
