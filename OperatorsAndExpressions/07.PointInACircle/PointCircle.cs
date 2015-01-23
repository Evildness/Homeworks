/*Problem 7. Point in a Circle

    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
*/


using System;

    class PointCircle
    {
        static void Main()
        {

            Console.Write("Enter coordinate x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate y: ");
            double y = double.Parse(Console.ReadLine());
            byte radius = 2;
            bool inCircle = (x * x + y * y) <= radius * radius;
            Console.WriteLine("{0}", inCircle);

        }
    }

