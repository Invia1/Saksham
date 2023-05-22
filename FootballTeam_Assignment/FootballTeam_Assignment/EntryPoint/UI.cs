using FootballTeam_Assignment.Model;
using FootballTeam_Assignment.Service;
using System;
using System.Collections.Generic;

namespace FootballTeam_Assignment.EntryPoint
{
    internal class UI
    {
        public static void Main()
        {
            Interface1 objj = new Services();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1 to add element");
                Console.WriteLine("Enter 2 to remove the element");
                Console.WriteLine("Enter 3 to fetch all the elements ");
                Console.WriteLine("Enter 4 to update the element");
                Console.WriteLine("Enter 5 to search the element");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        PDetails obj = new PDetails();
                        Console.WriteLine("Enter the player id");
                        int j = Convert.ToInt32 (Console.ReadLine());
                        obj.PID = j;
                        Console.WriteLine("Enter the player name");
                        string name = Console.ReadLine();
                        obj.PNAME = name;
                        Console.WriteLine("Enter the player team");
                        string team = Console.ReadLine();
                        obj.PTEAM = team;
                        Console.WriteLine("Enter the Player salary");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        obj.PSALARY = salary;
                        objj.addname(obj);
                        break;
                        case 2:
                        Console.WriteLine("Enter the index which you want to delete");
                        int a = Convert.ToInt32(Console.ReadLine());
                        objj.delete_at(a);
                        break;
                        case 3:
                        objj.fetch_all();
                        break;
                        case 4:
                        objj.update();
                        break;
                        case 5:
                        Console.WriteLine("Enter the element you want to search");
                        PDetails ob = new PDetails();
                        objj.Search(ob);
                        break;
                        default:
                        Console.WriteLine("Enter the valid response");
                        break;
                }
                Console.WriteLine("Do you want to continue ? (Yes/No)");
                string response = Console.ReadLine();
                if (response =="Yes" || response =="yes")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }
        }
    }
}
