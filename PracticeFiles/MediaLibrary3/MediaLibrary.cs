using System;

namespace Treehouse.MediaLibrary
{
    class MediaLibrary
    {
        private MediaType[] _items;

        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }

        public MediaType GetItemAt(int index)
        {
            if(index >= 0 && index <= _items.Length)
            {
                return _items[index];
            }
            else
            {
                return null;
            }
        }
    }
}