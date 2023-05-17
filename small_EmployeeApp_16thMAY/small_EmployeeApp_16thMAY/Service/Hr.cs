using small_EmployeeApp_16thMAY.Model;
using System;
using System.Collections.Generic;


namespace small_EmployeeApp_16thMAY.Service
{
    internal class Hr
    {
        List<Employee> name = new List<Employee>();
        public int CreateEmp(Employee empName)
        {
            name.Add(empName);
            return 1;
        }

        //public List<Employee> GetEmployee()
        //{
        //    return name;
        //}

        public void getall()
        {

            foreach (var temp in name)
            {
                Console.WriteLine(temp.EID + " " + temp.NAME + " " + temp.SALARY + " " + temp.DESIG);
            }

        }
        public void insert(int a, Employee temp)
        {
            Console.WriteLine("Enter the index at which you want to insert");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter the element you want to insert");
            name.Insert(a, temp);
            
        }

        public void remove()
        {
            getall();
            Console.WriteLine("Enter the element index you want to remove ");
            int b = int.Parse(Console.ReadLine());
            name.RemoveAt(b);
            getall();
        }
    }
}