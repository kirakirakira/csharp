using System;

namespace Treehouse.MediaLibrary
{
    class MediaLibrary
    {
        private MediaType[] _items;
        
        public int NumberOfItems => _items.Length;
        
        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }
        
        public MediaType GetItemAt(int index)
        {
            if (index < _items.Length)
            {
                return _items[index];                
            }
            else
            {
                Console.WriteLine("An element at index " + index + " doesn't exist in the media library.");
                
                return null;
            }
        }

        public void DisplayItems()
        {
            for(int i = 0; i < _items.Length; i++)
            {
                
                DisplayItem(_items[i]);

            }
        }

        public static void DisplayItem(MediaType item) 
        {
            if (item == null)
            {
                return;
            }
            
            if (item is Album)
            {
                Console.WriteLine(((Album)item).DisplayText);
            }
            else if (item is Book)
            {
                Console.WriteLine(((Book)item).DisplayText);
            }
            else if (item is Movie)
            {
                Console.WriteLine(((Movie)item).DisplayText);
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }

        public MediaType FindItem(string criteria)
        {
            // use a foreach loop to loop through the items array contained within the MediaLibrary class

            // return the item whose 'Title' property contains the provided 'criteria' string parameter value
        }

    }
}