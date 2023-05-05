using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static double salary;
        static string name = "Saksham";
        static void Main(string[] args)
        {
            Program.salary = 10000;
            Console.WriteLine(Program.name +" "+ "Salary is " + Program.salary);
        }
    }
}
