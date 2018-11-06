using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Employee : Person
    {
        public decimal salary;
        public Employee(string name, string lastname, int age, string Qualification,decimal salary) : base(name, lastname, age, Qualification)
        {
            this.salary = salary;
        }
    }
}
