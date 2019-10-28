using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandard
{
    using System;

    public enum MyEnum
    {
        NONE,
        A,
        B
    }
    public class SwitchExpressions
    {
        public string FromEnum(MyEnum myEnum)
        {
            switch (myEnum)
            {
                case MyEnum.NONE: return "1";
                case MyEnum.A: return "2";
                case MyEnum.B: return "3";
                default: throw new ArgumentOutOfRangeException();
            }
            // later we can add unwanted code in this method
        }

        // clearly express intent by using arrow notation
        public string FromEnumExpr(MyEnum myEnum) =>
            myEnum switch
            {
                MyEnum.NONE => "1",
                MyEnum.A => "2",
                MyEnum.B => "3",
                _ => throw new ArgumentOutOfRangeException(),
            };
    }
}
