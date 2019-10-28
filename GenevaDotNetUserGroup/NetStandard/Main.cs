using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandard
{
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

            UsingToDispose utd = new UsingToDispose();
            utd.After("temp.txt");

            IndicesRanges.M();

            Console.WriteLine(AnotherExample.M(null));
            Console.WriteLine(AnotherExample.M("not default"));

            return;
        }
    }

}
