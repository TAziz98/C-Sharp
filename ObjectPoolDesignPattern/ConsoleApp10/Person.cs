using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
  abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
        public string Qualification { get; set; }

        public Person(string name,string lastname,int age,string Qualification)
        {
            Name = name;
            LastName = lastname;
            this.age = age;
            this.Qualification = Qualification;

        }


    }
}
