using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Book : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        private bool _isInStock;

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            _isInStock = true;
        }

        public void Borrow()
        {
            if (_isInStock)
            {
                _isInStock = false;
            }
        }

        public void Return()
        {
            _isInStock = true;
        }

        public bool IsInStock()
        {
            return _isInStock;
        }
    }
}
