using Razorpagestutorial.Models;
using System;
//using Razorpagestutorial.Models;
using System.Collections.Generic;
using System.Text;

namespace Razorpagestutorial.Services
{
    public interface Irestaurantrepository
    {
        IEnumerable<Restaurant> getallemployee();
        Restaurant getemployee(int id);


    }
}
