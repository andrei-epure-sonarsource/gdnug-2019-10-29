using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NetStandard
{
    public class BeforeAsyncStreams
    {
        static async Task Main()
        {
            foreach (var data in await GetAllProducts("file"))
            {
                Console.WriteLine(data);
            }

            var allProducts2 = GetAllProducts2("file");
            foreach (var data in allProducts2)
            {
                Console.WriteLine(await data);
            }
        }

        public static async Task<IEnumerable<string>> GetAllProducts(string f)
        {
            var result = new List<string>();
            using (StreamReader source = new StreamReader(File.Open(f, FileMode.Open)))
            {
                var line = await source.ReadLineAsync();
                while (line != null)
                {
                    result.Add(line);
                    line = await source.ReadLineAsync();
                }
            }
            return result;
        }

        public static IEnumerable<Task<string>> GetAllProducts2(string f)
        {
            using (StreamReader source = new StreamReader(File.Open(f, FileMode.Open)))
            {
                while (!source.EndOfStream)
                {
                    yield return source.ReadLineAsync();
                }
            }
        }
    }

}
