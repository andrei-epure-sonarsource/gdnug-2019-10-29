using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandard
{
    public class Before
    {
        private Before singleton;
        public Before GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Before();
            }
            return singleton;
        }
    }

    public class After
    {
        private After singleton;
        public After GetInstance() => singleton ??= new After();
    }

    public class AnotherExample
    {
        public static string M(string value)
        {
            // OpCodes.Brtrue_S Field
            // Transfers control to a target instruction
            // (short form) if value is true, not null, or non-zero.

            value ??= "default";
            // do stuff
            return value;
        }
    }
}
