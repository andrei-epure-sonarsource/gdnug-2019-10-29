using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStandard
{
    public interface IPoint
    {
        double X { get; }
        double Y { get; }
        string Foo() => $"Interface {X} {Y}";
    }

    public interface IPointA : IPoint
    {
        string Foo() => $"IPointA {X} {Y}";
    }

    public interface IPointB : IPoint
    {
        string Foo() => $"IPointB {X} {Y}";
    }

    public class Point : IPointA, IPointB
    {
        public double X { get; } = 2;
        public double Y { get; } = 2;
        //public string Foo() => $"Point {X} {Y}";
    }

}
