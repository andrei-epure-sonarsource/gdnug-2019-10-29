using System;
using System.Collections.Generic;
using System.Text;

namespace Nullability
{
    public enum Country
    {
        Unknown,
        FR,
        CH
    }

    public class Address
    {
        public Country Country { get; }
        public string Code { get; }

        public Address(Country c, string code) =>
            (Country, Code) = (c, code);
    }
}
