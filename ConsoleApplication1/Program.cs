using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PV.Hash;

namespace ConsoleApplication1
{
    class Program
    {
        static string input, password;
        static string generatedHash;
        static void Main(string[] args)
        {
            IPVHash i = new PVHash();
            do
            {
                Console.WriteLine("Enter Password:");
                password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Error No Password Entered. Using Default password as 'TestPassword'");
                    password = "TestPassword";
                }
                generatedHash = i.Compute(password);
                Console.WriteLine($"Generated hash+salt combination is given below:\n");
                Console.WriteLine(generatedHash);
                Console.WriteLine("\nDo you want to create more hashsalts Y/N ?");
                input = Console.ReadLine();
            } while (input == "y" || input == "Y");

            Console.WriteLine("\nExiting from Input. Now Moving Towards Verification of hash+salts");

            do
            {
                Console.WriteLine("Enter password (plain text):");
                password = Console.ReadLine();
                Console.WriteLine("\nEnter Saved Hash+Salt from DB or File System (Encrypted)");
                string enteredSalt = Console.ReadLine();
                Console.WriteLine("Matched output is = " + i.Verify(password, enteredSalt).ToString());
                Console.WriteLine("Do you want to enter more hash combinations for checking (Y/N)");
            } while (Console.ReadLine() == "y" || Console.ReadLine() == "y");
            
        }
    }
}
