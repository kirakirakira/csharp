namespace Treehouse.MediaLibrary
{
    class Movie
    {
        public readonly string Title;
        public readonly string ReleaseDate;
        public readonly string Genre;

        public Movie(string title, string releaseDate, string genre)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Genre = genre;
        }

        public string GetDisplayText()
        {
            return "Movie: " + Title + " released in " + ReleaseDate;
        }
    }
}