/*Problem 1. Declare Variables

    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/

using System;


class Variables
{
    static void Main()
    {

        ushort var1 = 52130;
        sbyte var2 = -115;
        int var3 = 4825932;
        byte var4 = 97;
        short var5 = -10000;


        Console.WriteLine("ushort={0}", var1);
        Console.WriteLine("sbyte={0}", var2);
        Console.WriteLine("uint={0}", var3);
        Console.WriteLine("byte={0}", var4);
        Console.WriteLine("short={0}", var5);
        Console.Write("Press any key to continue");
        Console.ReadKey();
    }
}



