

using System;


    class Devide7AnD5
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            bool divide = ((number % 7)) == 0 && ((number % 5) == 0);
            Console.WriteLine("Number iss {0} divided by 5 and 7 at the same time -->{1}", number, divide);
        }
    }

