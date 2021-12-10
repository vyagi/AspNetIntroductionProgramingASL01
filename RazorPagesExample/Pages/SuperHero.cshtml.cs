using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesExample.Pages
{
    public class SuperHeroModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Super heroes page";
            Heroes = new List<string>
            {
                "Batman",
                "Superman",
                "Spiderman"
            };
        }

        public List<string> Heroes;
    }
}
