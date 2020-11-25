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
    public class ViewrazorpageModel : PageModel
    {

        private readonly IEmployeerepository em;

        public Employee ee { get; set; }
        public ViewrazorpageModel(IEmployeerepository em)
        {
            this.em = em;

        }

        public void OnGet(int id)
        {
           ee= em.getemployee(id);

        }
    }
}
