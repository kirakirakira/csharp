namespace Treehouse.MediaLibrary
{
    class MediaType
    {
        public string Title;
        public string Loanee;
        public bool OnLoan;

        public MediaType(string title)
        {
            Title = title;
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