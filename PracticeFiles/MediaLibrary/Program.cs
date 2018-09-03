using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("1984", "George Orwell", "Dystopian fiction");
            Movie movie1 = new Movie("1984", "October 1984", "Dystopian fiction");
            
            Console.WriteLine(book1.GetDisplayText());
            book1.Loan();
            Console.WriteLine(book1.GetDisplayText());
            book1.Return();
            Console.WriteLine(book1.GetDisplayText());
        }
    }
}