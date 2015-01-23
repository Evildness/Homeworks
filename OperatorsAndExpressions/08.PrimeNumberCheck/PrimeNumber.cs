/*Problem 8. Prime Number Check

    Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    Note: You should check if the number is positive
*/


using System;


    class PrimeNumber
    {
        static void Main()
        {

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            bool prime = false;
            if (number > 1 && number < 101)
            {
                if (number == 2 || number == 3 || number == 5 || number == 7)
                {
                    prime = true;
                }
                else if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
                {
                    prime = true;
                }
            }
            Console.WriteLine("Is number Prime? -> " + prime);



        }
    }

