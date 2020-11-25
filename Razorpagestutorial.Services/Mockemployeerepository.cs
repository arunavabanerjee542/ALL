using Razorpagestutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Employee(){id= 1,email="abc@gmail.com",name=" TAJ ",department=Dept.Hr,path="aa.jpg"},
            new Employee() { id = 2, email = "xyz@gmail.com", name = " OBEROI ", department = Dept.It,path="bb.jpg" },
            new Employee() { id = 3, email = "zzz@gmail.com", name = " ITC ", department = Dept.None , path="cc.jpg"}

        };
        }


        public IEnumerable<Employee> getallemployee()
        {
            return emp;
        }

        public Employee getemployee(int id)
        {

            return emp.FirstOrDefault(e => e.id == id);
        }

    }
}
