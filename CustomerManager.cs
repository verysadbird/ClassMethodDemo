using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        public static void Add (Customer c)
        {
            Console.WriteLine("Customer added! : " + c.Name + " "  + c.Surname);
        }

        public static void Delete (Customer c)
        {
            Console.WriteLine("Customer deleted! : " + c.Name + " " + c.Surname);
        }

        public static void List (Customer[] c)
        {
            Console.WriteLine("Customer List:\n");
            Console.WriteLine("Name        Surname            ID");
            foreach (Customer cs in c)
            {
                Console.WriteLine(cs.Name + "           " + cs.Surname + "             " + cs.ID);
               
            }
            

        }

    }
}
