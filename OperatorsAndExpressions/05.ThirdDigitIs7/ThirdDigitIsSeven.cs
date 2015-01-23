/*Problem 5. Third Digit is 7?

    Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/


using System;


    class ThirdDigitIsSeven
    {
        static void Main()
        {

            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());
            number /= 100;
            bool Seven = (number % 10) == 7 ;
            Console.WriteLine("Is the third digit 7?\n" + Seven);

        }
    }

