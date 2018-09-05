using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void DetectMediaType(MediaType item)
        {
            if(item is Book)
            {
                Console.WriteLine(item.Title + " is a book.");
            }
            else if(item is Movie)
            {
                Console.WriteLine(item.Title + " is a movie.");
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }

        static void Main()
        {
            try
            {
                Book book1 = new Book("1984", "George Orwell", "Dystopian fiction");
                Movie movie1 = new Movie("1984", "October 1984", "Dystopian fiction");
                
                Console.WriteLine(book1.GetDisplayText());
                book1.Loan();
                Console.WriteLine(book1.GetDisplayText());
                book1.Return();
                Console.WriteLine(book1.GetDisplayText());
                book1.Loan("Ryan");
                Console.WriteLine(book1.GetDisplayText());

                Book book2 = new Book("", "George Orwell", "Dystopian fiction");

                Console.WriteLine(movie1.GetDisplayText());
                movie1.Loan("Kira");
                Console.WriteLine(movie1.GetDisplayText());
                movie1.Return();
                Console.WriteLine(movie1.GetDisplayText());
                movie1.Loan();
                Console.WriteLine(movie1.GetDisplayText());

                DetectMediaType(book1);
                DetectMediaType(movie1);
                DetectMediaType(book2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}