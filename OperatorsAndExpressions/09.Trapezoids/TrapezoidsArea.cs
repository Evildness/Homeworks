


using System;

class TrapezoidsArea
    {
        static void Main()
        {

            Console.Write("Type base a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Type base b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Type height  h = ");
            double h = double.Parse(Console.ReadLine());
            double S= ((a + b) * h) / 2;
            Console.WriteLine("Area = " + S);



        }
    }

