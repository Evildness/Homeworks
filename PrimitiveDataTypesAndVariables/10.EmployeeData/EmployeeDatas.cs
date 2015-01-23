/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.
  */

using System;

class EmployeeDatas
{
    static void Main()
    {
        string firstName = "Birsel";
        string secondName = "Feisalov";
        byte age = 24;
        char gender = 'm';
        long idNumber = 8306112507;
        int uniqueNumber = 27569999;
        Console.WriteLine(firstName);
        Console.WriteLine(secondName);
        Console.WriteLine(age);
        Console.WriteLine(gender);
        Console.WriteLine(idNumber);
        Console.WriteLine(uniqueNumber);
        Console.Write("Press any key to continue");
        Console.ReadKey();
    }

}