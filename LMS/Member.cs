using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Member
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public List<Book> _borowedBooks;

        public Member(string name, string id)
        {
            Name = name;
            Id = id;
            _borowedBooks = new List<Book>();
        }

        public virtual void Notify(string message)
        {
            Console.WriteLine($"For {Name}: {message}");
        }
    }
}
