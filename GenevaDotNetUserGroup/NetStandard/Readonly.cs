using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStandard
{
    public class C
    {
        private struct PointReadonly
        {
            public double X { get; set; }
            public double Y { get; set; }
            public void Translate(int xOffset, int yOffset)
            {
                X += xOffset;
                Y += yOffset;
            }
            public readonly double Distance => Math.Sqrt(X * X + Y * Y);
            public readonly override string ToString() =>
                $"({X}, {Y}) is {Distance} from the origin";
        }

        private string ReadonlyCall(in PointReadonly value)
        {
            return value.ToString();
        }
        private string MutateCall(in PointReadonly value)
        {
            value.Translate(1, 2);
            return value.ToString();
        }
    }
}
