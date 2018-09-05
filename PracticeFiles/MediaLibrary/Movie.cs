namespace Treehouse.MediaLibrary
{
    class Movie : MediaType
    {
        public readonly string ReleaseDate;
        public readonly string Genre;

        public Movie(string title, string releaseDate, string genre) : base(title)
        {
            ReleaseDate = releaseDate;
            Genre = genre;
        }

        public string GetDisplayText()
        {
            if(!string.IsNullOrEmpty(Loanee))
            {
                return "Movie: " + Title + " released in " + ReleaseDate + "(Currently on loan to " + Loanee + ").";
            }
            else if(OnLoan)
            {
                return "Movie: " + Title + " released in " + ReleaseDate + "(Unavailable)";
            }
            else
            {
                return "Movie: " + Title + " released in " + ReleaseDate + "(Available)";
            }
        }
    }
}