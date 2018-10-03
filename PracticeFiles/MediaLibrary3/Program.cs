using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
            {
                var media = new MediaType[5]
                {
                    new Album("Yellow Submarine", "The Beatles"),
                    new Album("The Wall", "Pink Floyd"),
                    new Album("Pet Sounds", "The Beach Boys"),
                    new Book("Moby-Dick", "Herman Melville"),
                    new Movie("Lawrence of Arabia", "David Lean")
                };

                var mediaLibrary = new MediaLibrary(media);
                
                DetectMediaType(mediaLibrary.GetItemAt(8));

                Display(mediaLibrary.GetItemAt(0));

                
                // Console.WriteLine(album1.GetDisplayText());
                // Console.WriteLine(album2.GetDisplayText());
                // Console.WriteLine(album3.GetDisplayText());
                // Console.WriteLine(book.GetDisplayText());
                // Console.WriteLine(movie.GetDisplayText());
                
                // album1.Loan("Joe Smith");
                // album2.Loan();
                // book.Loan();
                // movie.Loan();
                
                // Console.WriteLine(album1.GetDisplayText());
                // Console.WriteLine(album2.GetDisplayText());
                // Console.WriteLine(book.GetDisplayText());
                // Console.WriteLine(movie.GetDisplayText());
                
                // album1.Return();
                // album2.Return();
                // book.Return();
                // movie.Return();
                
                // Console.WriteLine(album1.GetDisplayText());
                // Console.WriteLine(album2.GetDisplayText());
                // Console.WriteLine(book.GetDisplayText());
                // Console.WriteLine(movie.GetDisplayText());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }            
        }
        
        static void Display(MediaType item) 
        {
            if (item is Album)
            {
                var album = (Album)item;
                Console.WriteLine(album.GetDisplayText());
            }
            else if (item is Book)
            {
                var book = (Album)item;
                Console.WriteLine(book.GetDisplayText());
            }
            else if (item is Movie)
            {
                var movie = (Album)item;
                Console.WriteLine(movie.GetDisplayText());
            }
            else if (item == null)
            {
                throw new Exception("Item at this index does not exist.");
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }

        static void DetectMediaType(MediaType item) 
        {
            if (item is Album)
            {
                Console.WriteLine(item.Title + " is an album!");
            }
            else if (item is Book)
            {
                Console.WriteLine(item.Title + " is a book!");
            }
            else if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a movie!");
            }
            else if (item == null)
            {
                throw new Exception("Item at this index does not exist.");
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }
    }
}
