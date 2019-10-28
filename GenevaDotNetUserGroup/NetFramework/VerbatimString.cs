using System;
using System.Collections.Generic;
using System.Text;

namespace NetFramework
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
