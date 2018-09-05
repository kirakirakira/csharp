namespace Treehouse.MediaLibrary
{
    class Book : MediaType
    {
        public readonly string Author;
        public readonly string Genre;

        public Book(string title, string author, string genre): base(title)
        {
            Author = author;
            Genre = genre;
        }

        public string GetDisplayText()
        {
            if(!string.IsNullOrEmpty(Loanee))
            {
                return "Book: " + Title + " by " + Author + "(Currently on loan to " + Loanee + ").";
            }
            else if(OnLoan)
            {
                return "Book: " + Title + " by " + Author + "(Unavailable)";
            }
            else
            {
                return "Book: " + Title + " by " + Author + "(Available)";
            }
        }
    }
}