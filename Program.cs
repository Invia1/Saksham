using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Palindrome_String_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String name = Console.ReadLine();
            String reverse = String.Empty;
            for (int i = name.Length - 1 ; i >= 0; i--)
            {
                reverse = reverse + name[i];
            } 
            if (reverse == name)
            {
                Console.WriteLine(name + " " + "is palindrome");
            }
            else
            {
                Console.WriteLine(name + " " + "is not palindrome");
            }
        }
    }
}
