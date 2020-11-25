using Razorpagestutorial.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Razorpagestutorial.Services
{
   public class Mockemployeerepository : IEmployeerepository
    {
        private List<Employee> emp;

        public Mockemployeerepository()
        {
            emp = new List<Employee>()
            {
                new Employee(){id= 1,email="abc@gmail.com",name="a",department=Dept.Hr,path="a.png"},
            new Employee() { id = 2, email = "xyz@gmail.com", name = "b", department = Dept.It,path="b.png" },
            new Employee() { id = 3, email = "zzz@gmail.com", name = "d", department = Dept.None , path="c.png"}

        };
        }


        public IEnumerable<Employee> getallemployee()
        {
            return emp;
        }
    }
}
