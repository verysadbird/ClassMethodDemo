using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer a = new Customer();
            a.ID = 101;
            a.Name = "John";
            a.Surname = "Doe";

            Customer b = new Customer();
            b.ID = 102;
            b.Name = "Jane";
            b.Surname = "Doe";

            Customer c = new Customer();
            c.ID = 103;
            c.Name = "John";
            c.Surname = "Smith";

            Customer[] cs = new Customer[] {a, b, c};

            CustomerManager.Add(a);
            CustomerManager.Add(b);
            CustomerManager.Add(c);
            CustomerManager.Delete(a);
            CustomerManager.Delete(b);
            CustomerManager.Delete(c);

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            CustomerManager.List(cs);


        }
    }
}
