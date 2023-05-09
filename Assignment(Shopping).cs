using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class person
    {
        int pid;          //all are private variables by default 
        String pname;
        int amount;

        public int PID
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
            }
        }
        public string PNAME
        {
            get
            {
                return pname;
            }
            set
            {
                pname = value;
            }
        }
        public int AMOUNT
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                if (amount < 10000)
                {
                    Console.WriteLine("The person cannot go shopping");
                }
                else
                {
                    Console.WriteLine("The person can go shopping");
                }
            }
        }
        class pdetails
        {
            public void personinfo()
            {
                person obj = new person();
                obj.PID = 1;
                obj.PNAME = "Saksham";
                obj.AMOUNT = 10000;
                Console.WriteLine("Name " +  obj.PNAME + " id " + obj.PID);
            }
        }

        static void Main(string[] args)
        {
            pdetails obj = new pdetails();
            obj.personinfo();

        }
    }
}
