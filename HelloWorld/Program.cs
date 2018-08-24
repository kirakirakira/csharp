using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            var runningTotal = 0.0;

            while (true)
            {
                // Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type 'quit' to exit: ");
                var entry = Console.ReadLine();
                if (entry.ToLower() == "quit")
                {
                    break;
                }
                try
                {
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing!");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("Feel the burn!");
                    }
                    else
                    {
                        Console.WriteLine("Better go get a drink, you sweaty dog.");
                    }

                    // Add minutes exercised to total
                    runningTotal += minutes;

                    // Display total minutes exercised to the screen
                    Console.WriteLine("You've exercised " + runningTotal + " minutes");

                    // Repeat until the user quits
                }
                catch(FormatException)
                {
                    Console.WriteLine("That is not valid input.");
                    continue;
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}