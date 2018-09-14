using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
            {
                var mediaLibrary = new MediaLibrary(new MediaType[]
                {
                    new Album("Yellow Submarine", "The Beatles"),
                    new Album("The Wall", "Pink Floyd"),
                    new Album("Pet Sounds", "The Beach Boys"),
                    new Book("Moby-Dick", "Herman Melville"),
                    new Movie("Lawrence of Arabia", "David Lean")
                });
                
                Console.WriteLine("# of items: " + mediaLibrary.NumberOfItems);
                
                mediaLibrary.DisplayItems();

                // DetectMediaType(mediaLibrary.GetItemAt(0));
                // DetectMediaType(mediaLibrary.GetItemAt(1));
                // DetectMediaType(mediaLibrary.GetItemAt(2));
                // DetectMediaType(mediaLibrary.GetItemAt(3));
                // DetectMediaType(mediaLibrary.GetItemAt(4));

                // Search the media library for an item by calling the 'FindItem()' method.
                    // If an item is found, pass it into a call to the static MediaLibrary 'DisplayItem()' method
                    // If an item isn't found, write the message 'Item not found!' to the console
    
                             
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }            
        }
        
        static void DetectMediaType(MediaType item) 
        {
            if (item == null)
            {
                return;
            }

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
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }
    }
}
