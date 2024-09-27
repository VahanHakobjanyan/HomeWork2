namespace LMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library mylibrary = new Library();

            mylibrary.AddBook(new Book("book1", "author1", "251634"));
            mylibrary.AddBook(new Book("book2", "author2", "568347"));
            mylibrary.AddBook(new Book("book3", "author3", "923078"));
            mylibrary.AddBook(new Book("book4", "author4", "123486"));
            mylibrary.AddBook(new Book("book5", "author5", "287363"));
            mylibrary.AddBook(new Book("book6", "author6", "634542"));

            mylibrary.AddMember(new Member("Vahan Hakobjanyan", "1245"));

            mylibrary.BorrowBook("923078", "1245");

            Member memberToCheck = mylibrary.SearchMember("1245");

            Console.WriteLine(memberToCheck);

            foreach (Book b in memberToCheck._borowedBooks)
            {
                Console.WriteLine(b);
            }

            //Returning non borrowed book
            mylibrary.ReturnBook("9999", "1245");

            mylibrary.ReturnBook("923078", "1245");
        }
    }
}
