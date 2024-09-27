using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class Library
    {
        private List<Book> _books = new List<Book>();
        private List<Member> _members = new List<Member>();
        private NotificationSystem _notificationSystem = new NotificationSystem();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            foreach (Book b in _books)
            {
                if (b.ISBN == isbn)
                {
                    _books.Remove(b);
                    break;
                }
            }
        }

        public Book SearchBook(string isbn)
        {
            foreach (Book b in _books)
            {
                if (b.ISBN == isbn)
                {
                    return b;
                }
            }
        TODO: //Finish method
            return null;
        }

        public void AddMember(Member member)
        {
            _members.Add(member);
        }

        public void RemoveMember(string id)
        {
            foreach (Member m in _members)
            {
                if (m.Id == id)
                {
                    _members.Remove(m);
                }
            }
        }

        public Member SearchMember(string id)
        {
            foreach (Member m in _members)
            {
                if (m.Id == id)
                {
                    return m;
                }
            }
        TODO: //Finish method;
            return null;
        }

        public void BorrowBook(string isbn, string memberId)
        {
            Book bookToBorrow = SearchBook(isbn);
            if (bookToBorrow == null)
            {
                Console.WriteLine("Book not in stock");
                return;
            }

            Member member = SearchMember(memberId);
            if (member == null)
            {
                Console.WriteLine("No member with id: {0} was found.", memberId);
                return;
            }

            bookToBorrow.Borrow();
            member._borowedBooks.Add(bookToBorrow);
            member.Notify($"You successfully borrowed {bookToBorrow.Title} by {bookToBorrow.Author}");
        }
        public void ReturnBook(string isbn, string memberId)
        {
            Member member = SearchMember(memberId);
            if (member == null)
            {
                Console.WriteLine("No member with id: {0} was found.", memberId);
                return;
            }

            Book bookToReturn = null;
            foreach (Book b in _books)
            {
                if (b.ISBN == isbn)
                {
                    bookToReturn = b;
                }
            }
            if (bookToReturn == null)
            {
                Console.WriteLine($"Member {memberId}, never borrowed book {isbn}");
                return;
            }

            member._borowedBooks.Remove(bookToReturn);
            member.Notify($"You successfully returned {bookToReturn.Title} by {bookToReturn.Author}");
        }
    }
}
