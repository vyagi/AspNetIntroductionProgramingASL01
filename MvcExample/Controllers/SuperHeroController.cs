using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcExample.Models;

namespace MvcExample.Controllers
{
    public class SuperHeroController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Super heroes !";

            
            return View(Superheroes);
        }


        public IActionResult Details(int id)
        {
            var superHero = Superheroes.First(x => x.Id == id);
            
            return View(superHero);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(SuperHeroCreateModel input)
        {
            if (!ModelState.IsValid)
            {
                return View(input);
            }
            
            var newHero = new SuperHero
            {
                Age = input.Age,
                Name = input.Name,
                Powers = input.Powers.Split(","),
                Id = Superheroes.Max(x => x.Id) + 1
            };
            Superheroes.Add(newHero);

            return RedirectToAction("Index");
        }

        private static List<SuperHero> Superheroes = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1,
                Age = 52,
                Name = "Batman",
                Powers = new List<string> { "Technology", "Intelligence", "Money" }
            },
            new SuperHero
            {
                Id = 2,
                Age = 45,
                Name = "Superman",
                Powers = new List<string> { "Flying", "Strength" }
            },
            new SuperHero
            {
                Id = 3,
                Age = 23,
                Name = "Spiderman",
                Powers = new List<string> { "Climbing", "Throwing nets" }
            }
        };

    }
}
