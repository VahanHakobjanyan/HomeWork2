using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinqImplementation.Repository
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(int personId, string name, int age, string email)
        {
            PersonId = personId;
            Name = name;
            Age = age;
            Email = email;
        }

        public override string ToString()
        {
            return $"Person(Id={PersonId}, Name={Name}, Age={Age}, Email={Email})";
        }
    }
}
