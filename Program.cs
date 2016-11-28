using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVirginia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Create By CxzLabel");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please input mode  (encrypt or decrypt)");
            Console.ForegroundColor = ConsoleColor.Gray;
            string type = Console.ReadLine();
            if (type == "encrypt")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("enter ENCRYPT Mode");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter the context");
                Console.ForegroundColor = ConsoleColor.Gray;
                string context = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter the key");
                Console.ForegroundColor = ConsoleColor.Gray;
                string key = Console.ReadLine();
                Console.WriteLine();
                VirginiaConveter.ENCRYPT(context, key);
            }
            else if (type == "decrypt")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("enter DECRYPT Mode");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter the cipherText");
                Console.ForegroundColor = ConsoleColor.Gray;
                string cipherText = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter the key");
                Console.ForegroundColor = ConsoleColor.Gray;
                string key = Console.ReadLine();
                Console.WriteLine();
                VirginiaConveter.DECRYPT(cipherText, key);
            }
        }
    }
}
