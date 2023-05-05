using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int n, rem, temp;
                int reverse = 0;
                Console.WriteLine("Enter the number");
                n = Convert.ToInt16(Console.ReadLine());
                temp = n;
                while (temp > 0)
                {
                    rem = temp % 10;
                    reverse = reverse * 10 + rem;
                    temp = temp / 10;
                }
                if (n == reverse)
                {
                    Console.WriteLine(n + " is a palindrome number");
                }
                else
                {
                    Console.WriteLine(n + " is not palindrome number");
                }
            }
        }
    }
    


           
        
       
    
    

