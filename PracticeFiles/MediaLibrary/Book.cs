namespace Treehouse.MediaLibrary
{
    class Book
    {
        public readonly string Title;
        public readonly string Author;
        public readonly string Genre;
        public string Loanee;
        public bool OnLoan;

        public Book(string title, string author, string genre)
        {
            Title = title;
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

        public void Loan()
        {
            OnLoan = true;
        }

        public void Loan(string person)
        {
            Loan();
            Loanee = person;
        }

        public void Return()
        {
            OnLoan = false;
            Loanee = null;
        }
    }
}