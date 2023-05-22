using Hospital_Management.Model;
using System;
using System.Collections.Generic;

namespace Hospital_Management.Service
{
    internal class General_Medicine : Interface1
    {
        List<UI> list = new List<UI>();
        public int addName(UI temp)
        {
            list.Add(temp);
            return 1;
        }
        public List<UI> fetch_all()
        {
            if (list.Count > 0)
            {
                foreach (UI item in list)
                {
                    Console.WriteLine("Patient's Registration number     " + item.PID);
                    Console.WriteLine("Patient's First Name =    " + item.FIRSTNAME);
                    Console.WriteLine("This is the Patient's last Name    " + item.LASTNAME);
                    Console.WriteLine("Patient's Phone number " + item.PHONE);
                    Console.WriteLine("Gender" + item.GENDER);
                    Console.WriteLine("Patient's Age" + item.AGE);
                    Console.WriteLine("Patient's Address     " + item.ADDRESS);
                    Console.WriteLine("Patient's Addhar number   " + item.AADHAR);
                    Console.WriteLine("Speciality    " + item.SPLTY);
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
            return list;
        }

        class Orthopaedics : Interface1
        {
            List<UI> list = new List<UI>();
            public int addName(UI temp)
            {
                list.Add(temp);
                return 1;
            }
            public List<UI> fetch_all()
            {
                if (list.Count > 0)
                {
                    foreach (UI item in list)
                    {
                        Console.WriteLine("Patient's Registration number     " + item.PID);
                        Console.WriteLine("Patient's First Name =    " + item.FIRSTNAME);
                        Console.WriteLine("This is the Patient's last Name    " + item.LASTNAME);
                        Console.WriteLine("Patient's Phone number " + item.PHONE);
                        Console.WriteLine("Gender" + item.GENDER);
                        Console.WriteLine("Patient's Age" + item.AGE);
                        Console.WriteLine("Patient's Address     " + item.ADDRESS);
                        Console.WriteLine("Patient's Addhar number   " + item.AADHAR);
                        Console.WriteLine("Speciality    " + item.SPLTY);
                    }
                }
                else
                {
                    Console.WriteLine("List is empty");
                }
                return list;
            }

            class Dental : Interface1
            {
                List<UI> list = new List<UI>();
                public int addName(UI temp)
                {
                    list.Add(temp);
                    return 1;
                }
                public List<UI> fetch_all()
                {
                    if (list.Count > 0)
                    {
                        foreach (UI item in list)
                        {
                            Console.WriteLine("Patient's Registration number     " + item.PID);
                            Console.WriteLine("Patient's First Name =    " + item.FIRSTNAME);
                            Console.WriteLine("This is the Patient's last Name    " + item.LASTNAME);
                            Console.WriteLine("Patient's Phone number " + item.PHONE);
                            Console.WriteLine("Gender" + item.GENDER);
                            Console.WriteLine("Patient's Age" + item.AGE);
                            Console.WriteLine("Patient's Address     " + item.ADDRESS);
                            Console.WriteLine("Patient's Addhar number   " + item.AADHAR);
                            Console.WriteLine("Speciality    " + item.SPLTY);
                        }
                    }
                    else
                    {
                        Console.WriteLine("List is empty");
                    }
                    return list;
                }

            }
        }
    }
}
