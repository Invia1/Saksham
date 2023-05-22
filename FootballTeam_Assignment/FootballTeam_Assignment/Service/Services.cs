using FootballTeam_Assignment.Model;
using System;
using System.Collections.Generic;

namespace FootballTeam_Assignment.Service
{
    internal class Services : Interface1
    {
        List<PDetails> list = new List<PDetails>();
        public int addname(PDetails pname)
        {
            list.Add(pname);
            return 1;
        }
        public int delete_at(int n)
        {
            list.RemoveAt(n);
            return 1;
        }
        public List<PDetails> fetch_all()
        {
            foreach(PDetails i in  list)
            {
                Console.WriteLine("Player id =   " + i.PID);
                Console.WriteLine("Player name =   " + i.PNAME);
                Console.WriteLine("Player Team =   " + i.PTEAM);
                Console.WriteLine("Player salary =  " + i.PSALARY);
            }
            return list;
        }
        public void update()
        {
            Console.WriteLine("Enter the index which you want to update ");
            int n = Convert.ToInt32(Console.ReadLine());
            list.RemoveAt(n);
            Console.WriteLine("Enter the updated element ");
            foreach(PDetails j in list)
            {
                j.PNAME = Console.ReadLine();
                list.Insert(n, j);
            }
            Console.WriteLine("This is the updated list");
            fetch_all();
        }
        public void Search(PDetails searchingg)
        {
            Boolean check = list.Contains(searchingg);
            if(check == true)
            {
                Console.WriteLine("Yes the name is in the list");
            }
            else
            {
                Console.WriteLine("The name is not in the list");
            }
        }
    }
}
