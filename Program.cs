using System;
using System.Collections;


namespace ConsoleApp1
{
    class data_entry
    {
        ArrayList array = new ArrayList();

        public void add_data()
        {
            array.Add("Saksham Choudhary");
            array.Add("Lokesh Rana");
            array.Add("Jatin Saini");
           
            array.Insert(0, "Raman"); 


        }
        public void remove_data()
        {
           
            Console.WriteLine("The updated array list:");
            array.Remove("Lokesh Rana");
            array.RemoveAt(2);


        }
        public void print()
        {
            foreach (var temp in array)
            {
                Console.WriteLine(temp);
            }
        }

       
        public static void Main()
        {
            var obj = new data_entry();
            obj.add_data();
            obj.print();

            obj.remove_data();
            obj.print();


            Console.ReadLine();
        }
    }
}
