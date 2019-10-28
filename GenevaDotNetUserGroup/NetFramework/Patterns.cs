using System;
using System.Collections.Generic;
using System.Text;

namespace NetFramework
{
    using System;

    public enum Country
    {
        Unknown,
        FR,
        CH
    }

    public class Address
    {
        public Country Country { get; }
        public uint Code { get; }
    }

    public class Person
    {
        public uint ID { get; }
        public string Name { get; }
        public Address Address { get; }
    }

    public class Patterns
    {
        // Tuple pattern
        public string InsuranceType(Person p, Country work) =>
            (p.Address.Country, work) switch
            {
                (Country.CH, Country.CH) => "Swiss insurance",
                (Country.FR, Country.CH) => "Either CH or FR",
                (Country.CH, Country.FR) => "Difficult",
                (_, _) => string.Empty
            };

        // "Object pattern" or "Property pattern" - recursive
        public bool IsAnonymousSwiss1(Person p) =>
            // constant pattern
            p is { Name: null, Address: { Country: Country.CH } };

        public bool IsAnonymousSwiss2(Person p) =>
            p is { } x &&
            x.Name is null &&
            x.Address is { Country: Country.CH };

    }


    public enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }

    public class Point2D
    {
        public int X { get; }
        public int Y { get; }

        public Point2D(int x, int y) => (X, Y) = (x, y);
    }

    public class Patterns2
    {
        static Quadrant Display(Point2D point) => point switch
        {
            { X: 0, Y: 0 } => Quadrant.Origin,
            { X: var x, Y: var y } when x > 0 && y > 0
                => Quadrant.One,
            { X: var x, Y: var y } when x < 0 && y > 0
                => Quadrant.Two,
            { X: var x, Y: var y } when x < 0 && y < 0
                => Quadrant.Three,
            { X: var x, Y: var y } when x > 0 && y < 0
                => Quadrant.Four,
            { X: _, Y: _ }
                => Quadrant.OnBorder,
            _ => Quadrant.Unknown,
        };

    }
}
