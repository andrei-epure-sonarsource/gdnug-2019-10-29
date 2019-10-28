using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandard
{
    class VerbatimString
    {
        public void Foo(string x)
        {
            var first = $@"
{x}
";
            var second = @$"
{x}
";

        }
    }
}
