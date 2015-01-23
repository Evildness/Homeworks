/*Problem 11. Bank Account Data

    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/

using System;


class AccountData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Ivanov";
            string lastName = "Spasov";
            decimal balance = 35483248.156M;
            string bankName = "UBB";
            string IBAN = "BG99 UNFS 9090 6542 4227 11";
            ulong cardOne = 5214119936976404;
            ulong cardTwo = 3495658053299994;
            ulong cardThree = 4719966168771;
            Console.WriteLine("FirstName = {0}", firstName);
            Console.WriteLine("MiddleName = {0}", middleName);
            Console.WriteLine("LastName = {0}", lastName);
            Console.WriteLine("Balance = {0}", balance);
            Console.WriteLine("BankName = {0}", bankName);
            Console.WriteLine("IBAN = {0}", IBAN);
            Console.WriteLine("CardOne= {0}", cardOne);
            Console.WriteLine("CardTwo = {0}", cardTwo);
            Console.WriteLine("CardTree = {0}", cardThree);
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }

