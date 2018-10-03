using System;

namespace Practice
{
    class Program
    {   
        public static int FindFibonacciValue(int index)
        {
            if(index == 0)
            {
                return 0;
            }
            else if(index == 1)
            {
                return 1;
            }
            else
            {
                return FindFibonacciValue(index - 2) + FindFibonacciValue(index - 1);
            }
        }
        static void Main()
        {
            Console.WriteLine(FindFibonacciValue(0));
            Console.WriteLine(FindFibonacciValue(1));
            Console.WriteLine(FindFibonacciValue(2));
            Console.WriteLine(FindFibonacciValue(3));
            Console.WriteLine(FindFibonacciValue(4));
            Console.WriteLine(FindFibonacciValue(20));
        }
    }
}