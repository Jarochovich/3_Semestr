using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    internal class Person
    {
        public string Name { get; set; }

        public string Company {  get; set; }

        public Person(string name, string company)
        {
            Name = name;
            Company = company;
        }

    }
}
