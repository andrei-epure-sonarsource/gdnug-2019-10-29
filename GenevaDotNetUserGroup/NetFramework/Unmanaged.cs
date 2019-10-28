using System;
using System.Collections.Generic;
using System.Text;

namespace NetFramework
{
    public class Unmanaged
    {
        // before , constructed type(with one type argument)
        // had to be managed (on heap)

        // can be allocated on the stack (unmananged type)
        public struct Coords<T>
        {
            public T X;
            public T Y;
        }
        /*
        public void M()
        {
            Span<Coords<int>> coordinates = stackalloc[]
            {
                new Coords<int> { X = 0, Y = 0 },
                new Coords<int> { X = 0, Y = 3 },
                new Coords<int> { X = 4, Y = 0 }
            };
        }
        */
    }
}
