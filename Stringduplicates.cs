using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            int count = 1;
            char[] dup = str.ToCharArray();
            for (int i = 0; i < dup.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < dup.Length; j++)
                {
                    if (dup[i] == dup[j] && dup[i] != 0)
                    {
                        count++;
                        dup[j] = '0';
                    }
                }
                if (count > 1 && dup[i] != '0')
                    Console.WriteLine(dup[i] +" - "+ count);
            }

        }
    }
}

