using System;
using System.Collections.Generic;
using System.Text;

namespace Razorpagestutorial.Models
{
   public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public string email { get; set; }

        public string path { get; set; }
        public  Dept? department { get; set; }

    }
}

