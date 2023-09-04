using System;
using Ucu.Poo.Expert;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            ShelveBook.SendBookToShelve(book1, "A", "7");
            ShelveBook.SendBookToShelve(book2, "B", "7");
            Console.WriteLine(book2.LibrarySector);
        }
    }
}
