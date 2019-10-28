using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NetFramework
{
    public class UsingToDispose
    {
        public void Before(string path)
        {
            using (var file = File.Create(path))
            {
                file.WriteByte(1);
            }
        }

        public void After(string path)
        {
            // same IL
            using var file = File.Create(path);
            file.WriteByte(1);
        }

    }
}
