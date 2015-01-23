﻿/*Problem 10. Reformat C# Code

    Reformat the following C# code to make it readable according to the C# best practices for code formatting. Change the casing of the identifiers in the code (e.g. use PascalCase for the class name): HorribleCode.cs
*/

using System;

class HorribleCode
{
    static void Main()
    {
        Console.WriteLine("Hi, I am horribly formatted program");
        Console.WriteLine("Numbers and squares:");
        int number = 0;
        for (int i = 0; i < 10; i++)
        {
            int sqroot = number * number;
            Console.WriteLine("{0} --> {1}", number, sqroot);
            number++;
        }
    }
}