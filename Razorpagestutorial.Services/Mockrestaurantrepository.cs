using Razorpagestutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Razorpagestutorial.Services
{
   public class Mockrestaurantrepository : Irestaurantrepository
    {
        private List<Restaurant> emp;

        public Mockrestaurantrepository()
        {
            emp = new List<Restaurant>()
            {
                new Restaurant(){id= 1,email="abc@gmail.com",name=" TAJ ",department=Dept.Hr,path="aa.jpg"},
            new Restaurant() { id = 2, email = "xyz@gmail.com", name = " OBEROI ", department = Dept.It,path="bb.jpg" },
            new Restaurant() { id = 3, email = "zzz@gmail.com", name = " ITC ", department = Dept.None , path="cc.jpg"}

        };
        }


        public IEnumerable<Restaurant> getallemployee()
        {
            return emp;
        }

        public Restaurant getemployee(int id)
        {

            return emp.FirstOrDefault(e => e.id == id);
        }

    }
}
