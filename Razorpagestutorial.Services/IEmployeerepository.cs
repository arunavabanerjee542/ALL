using Razorpagestutorial.Models;
using System;
//using Razorpagestutorial.Models;
using System.Collections.Generic;
using System.Text;

namespace Razorpagestutorial.Services
{
    public interface IEmployeerepository
    {
        IEnumerable<Employee> getallemployee();

    }
}
