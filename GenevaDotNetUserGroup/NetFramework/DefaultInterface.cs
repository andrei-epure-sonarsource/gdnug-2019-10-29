using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    /*
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

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Point point = new Point();
            //Console.WriteLine(point.Foo());

            IPointA pointA = point;
            Console.WriteLine(pointA.Foo());

            IPointB pointB = point;
            Console.WriteLine(pointB.Foo());

            IPoint x = point;
            Console.WriteLine(x.Foo());

            return;
        }
    }*/
}
