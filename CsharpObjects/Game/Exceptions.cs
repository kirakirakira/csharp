namespace TreehouseDefense
{
    class TreehouseDefenseException : System.Exception
    {
        public TreehouseDefenseException()
        {
            
        }
        public TreehouseDefenseException(string message)
    }

    class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException()
        {
                # change
        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}