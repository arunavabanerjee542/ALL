using System;
using System.Collections.Generic;
using System.Text;

namespace Razorpagestutorial.Models
{
   public class Restaurant
    {
        public int id { get; set; }
        public string name { get; set; }

        public string email { get; set; }

        public string path { get; set; }

        public int rooms { get; set; }

        public  Dept? department { get; set; }

    }
}

