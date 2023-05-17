using System;
using System.Collections.Generic;


namespace day7
{
    class Class3
    {
        List<string> name = new List<string>();
        public void Add_data()
        {
            
            name.Add("Saksham");
            name.Add("Jatin");
            name.Add("Manoj");
            name.Add("Harshit");
            name.Add("Ravi");
        }
        public void insert_At(int i, string name)
        {
            name.Insert(i, name);
        }

        public void update(int i, string neww)
        {
            name.RemoveAt(i);
            name.Insert(i, neww);
        }
        public void search(string a)
        {
            var temp = name.Contains(a);
            if (temp == true)
            {
                Console.WriteLine("Yes" +" "+ a + "is in the list");
            }
            else
            {
                Console.WriteLine("No" +" "+ a + " " + " is not in the list" );
            }
        }

        
        public void delete(int i)
        {
            name.RemoveAt(i);
        }
        public void fetchall()
        {
            foreach (string temp in name)
            {
                Console.WriteLine(temp);
            }
        }
    }
    class ppt
    {
        public static void Main(string[] args)
        {
            Class3 obj = new Class3();

            obj.Add_data();
            obj.delete(1);
            obj.update(2, "Pawan");
            obj.insert_At(3, "Bharat");
            obj.search("Saksham");
            obj.search("Aditya");
            obj.fetchall();

            Console.ReadLine();
        }
    }
}
