/*Problem 1. Odd or Even Integers

    Write an expression that checks if given integer is odd or even.

*/

using System;

    class OddOrEven
    {
        static void Main()
        {

            Console.Write("Enter an integer number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            bool odd = (number % 2) != 0;
            Console.WriteLine("Number is  {0} odd -> {1}", number, odd);
        }
    }

