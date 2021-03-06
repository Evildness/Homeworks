﻿/*Problem 10. Point Inside a Circle & Outside of a Rectangle

    Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/


using System;

class PointInsideCircleOutsideOfRectangle
{
    static void Main()
    {
        
        Console.Write("Enter a value for x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter a value for y: ");
        double y = double.Parse(Console.ReadLine());
        double h = 1;
        double k = 1;
        double r = 1.5;
        if (((x - h) * (x - h) + (y - k) * (y - k)) <= (r * r))
        {
            Console.WriteLine(((x > 5) || (x < -1) || (y > 1) || (y < -1)) ? "YES" : "NO");
        }
        else
        {
            Console.WriteLine("NO");
            Console.WriteLine();
        }
    }
}