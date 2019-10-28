using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NetStandard
{
    public class AfterAsyncStreams
    {
        static async Task Main()
        {
            await foreach (var data in GetAllProducts3("file"))
            {
                Console.WriteLine(data);
            }
        }

        public static async IAsyncEnumerable<string?> GetAllProducts3(string file)
        {
            using (StreamReader source = new StreamReader(File.Open(file, FileMode.Open)))
            {
                string? line;
                while (!source.EndOfStream)
                {
                    line = await source.ReadLineAsync();
                    yield return line;

                }
            }
        }
    }
}
