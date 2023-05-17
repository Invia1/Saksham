using small_EmployeeApp_16thMAY.Model;
using small_EmployeeApp_16thMAY.Service;
using System;
using System.Collections.Generic;

namespace small_EmployeeApp_16thMAY.EntryPoint
{
    internal class Direct
    {
        public static void Main()
        {
            Employee obj = new Employee();
            obj.EID = 1;
            obj.NAME = "Test";
            obj.SALARY = 40000;
            obj.DESIG = "Aset";

            Employee obj1 = new Employee();
            obj1.EID = 2;
            obj1.NAME = "Test 2";
            obj1.SALARY = 30000;
            obj1.DESIG = "Tech";

            
            Hr occ = new Hr();
            occ.CreateEmp(obj);
            occ.CreateEmp(obj1);

            occ.getall();
            occ.insert(0,obj);
        }
    }
}
