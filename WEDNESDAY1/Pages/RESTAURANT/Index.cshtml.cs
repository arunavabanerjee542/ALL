using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razorpagestutorial.Models;
using Razorpagestutorial.Services;

namespace WEDNESDAY1.Pages.EMPLOYEES
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Restaurant> e { get; set; }

        private readonly Irestaurantrepository emp;

       public IndexModel(Irestaurantrepository emp )
        {
            this.emp = emp;
        }

        public void OnGet()
        {

            e = emp.getallemployee();
        }
    }
}
