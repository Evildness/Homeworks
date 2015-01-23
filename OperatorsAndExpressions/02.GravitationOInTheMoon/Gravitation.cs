/*Problem 2. Gravitation on the Moon

    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 
*/

using System;


    class Gravitation
    {
        static void Main()
        {
            Console.Write("Enter your weight: ");
            string input = Console.ReadLine();
            double weight = double.Parse(input);
            double weightOnMoon = weight * 0.17;
            Console.WriteLine("Your weight on the moon will be: " + weightOnMoon);


        }
    }

