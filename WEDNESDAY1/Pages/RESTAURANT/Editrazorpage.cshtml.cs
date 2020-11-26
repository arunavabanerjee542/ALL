using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razorpagestutorial.Models;
using Razorpagestutorial.Services;

namespace WEDNESDAY1.Pages.RESTAURANT
{
    public class EditrazorpageModel : PageModel
    {
        private Irestaurantrepository emp; 

        public EditrazorpageModel(Irestaurantrepository emp)
        {
            this.emp = emp;
        }

        public Restaurant r { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost(Restaurant rr)
        {

            r = emp.updaterestaurant(rr);
            return RedirectToPage("index");

        }

    }
}
