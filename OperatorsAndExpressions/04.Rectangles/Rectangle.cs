/*Problem 4. Rectangles

    Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/


using System;


    class Retangle
    {
        static void Main()
        {
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter is {0}", 2 * width + 2 * height);
            Console.WriteLine("Area is {0}", width * height);
        }
    }

