using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter 1 for factorial,2 for fibonacci and 3 for prime");
            int x = int.Parse(Console.ReadLine());
            if(x==1 || x==2 || x==3)
            {
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Enter the number");
                        int n1 = int.Parse(Console.ReadLine());
                        int s = 1;
                        while (n1 != 1)
                        {
                            s = s * n1;
                            n1--;
                        }
                        Console.WriteLine("The Factorial of "+ n1 +"is "+s);

                        break;

                    case 2:
                        Console.WriteLine("Enter the number");
                        int n2 = int.Parse(Console.ReadLine());
                        int s1 = 0;
                        int s2 = 1;
                        int s3;
                        Console.Write(s1 +" "+ s2);
                        for (int i = 2; i < n2; i++)
                        {
                            s3 = s1 + s2;
                            Console.Write(" "+s3);
                            s1 = s2;
                            s2 = s3;
                        }
                        
                        break;

                    case 3:
                        Console.WriteLine("Enter the number");
                        int n3 = int.Parse(Console.ReadLine());





                        break;
                }
            }
            

        }
    }
}
