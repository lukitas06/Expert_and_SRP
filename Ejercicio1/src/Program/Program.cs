using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Book book3 = new Book("IT","Stephen King","011-025");
            Book book4 = new Book("Harry Potter","J.K Rowling","001-035");
            ShelveBook shelve1 = new ShelveBook("A","7");
            ShelveBook shelve2 = new ShelveBook("X","9");

            shelve1.addBook(book1);
            shelve1.addBook(book2);
            Console.WriteLine(shelve1.toString());
            shelve2.addBook(book3);
            shelve2.addBook(book4);
            Console.WriteLine(shelve2.toString());

        }
    }
}