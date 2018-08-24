using System;

namespace Treehouse.PracticeSession
{
    class Program
    {
        public static void Main()
        {
            // TODO Declare a boolean variable named "keepGoing"
            // and assign it a value of "true". Use this variable to 
            // know when to exit the while loop.
            bool keepGoing = true;

            // TODO Define a while loop.
            // Keep looping as long as the variable "keepGoing" has a value of "true".
            while (keepGoing)
            {
                // TODO Prompt the user with the text "Enter a number:" 
                // and assign their value to an "entry" string variable.
                Console.Write("Enter a number: ");
                string entry = Console.ReadLine();
                
                // TODO If the user entered the text "quit"...
                if (entry == "quit")
                {
                    // TODO Exit the program.
                    keepGoing = false;
                }

                // TODO Else the user didn't enter the text "quit"...
                else
                {
                    try
                    {
                        // TODO Parse the user's entry to an integer
                        int entryInt = int.Parse(entry);
                        // TODO Square the user's provided number 
                        // (i.e. multiply the number by itself).
                        int square = entryInt * entryInt;
                        
                        // TODO Output the result.
                        // Example: "The square of 2 is 4." or 
                        // "2 multiplied by itself is equal to 4."
                        Console.WriteLine("The square of " + entry + " is " + square + ".");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Must enter a number.");
                    }
                }
                    
            }

            // TODO Output the text "Goodbye!" after exiting the loop.
            Console.WriteLine("Goodbye!");
        }
    }
}












