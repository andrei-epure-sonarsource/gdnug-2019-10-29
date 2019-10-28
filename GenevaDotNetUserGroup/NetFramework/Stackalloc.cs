using System;
using System.Collections.Generic;
using System.Text;

namespace NetFramework
{
    public class Stackalloc
    {

        public void OnHeap()
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6 };
            var ind = Array.IndexOf(numbers, new[] { 2, 4, 6, 8 });
            Console.WriteLine(ind);  // output: 1
        }

        /*
        public void OnStack()
        {
            var numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            // starting C# 8, stackalloc inside other expr
            var ind = numbers.IndexOfAny(stackalloc[] { 2, 4, 6, 8 });
            Console.WriteLine(ind);  // output: 1
        }
        */
    }
}
