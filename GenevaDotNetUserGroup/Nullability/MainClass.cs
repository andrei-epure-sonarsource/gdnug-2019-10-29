using System;
using System.Collections.Generic;
using System.Text;

namespace Nullability
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer("Fred");
            Console.WriteLine(c.Address?.Code ?? "default");

            // store in local variable
            Address? address = c.Address;
            if (address != null)
            {
                Console.WriteLine(address.Country);
            }
            else
            {
                Console.WriteLine("default");
            }

            if (c.Address != null)
            {
                // another thread can change this, but compiler is ok
                Console.WriteLine(c.Address.Country);
            }
            else
            {
                Console.WriteLine("default");
            }

            Console.WriteLine(c.Address.Code);
            // null - forgiveness operator
            Console.WriteLine(c.Address!.Code);
        }
    }
}
