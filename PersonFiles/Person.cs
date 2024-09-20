using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonFiles
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name = {Name}, Surname = {Surname}, Age = {Age}";
        }
    }
}
