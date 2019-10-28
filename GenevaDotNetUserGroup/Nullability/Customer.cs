using System;

namespace Nullability
{
    public class Customer
    {
        public string Name { get; set; } // not nullable
        public Address? Address { get; set; } // nullable

        public Customer(string name) =>
            Name = name;
    }
}
