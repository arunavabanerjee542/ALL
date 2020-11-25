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
        public IEnumerable<Employee> e { get; set; }

        private readonly IEmployeerepository emp;

       public IndexModel(IEmployeerepository emp )
        {
            this.emp = emp;
        }

        public void OnGet()
        {

            e = emp.getallemployee();
        }
    }
}
