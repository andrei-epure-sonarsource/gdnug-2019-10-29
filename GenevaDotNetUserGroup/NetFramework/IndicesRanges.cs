using System;
using System.Collections.Generic;
using System.Text;

namespace NetFramework
{
    /*
    class IndicesRanges
    {
        public void M()
        {
            var words = new string[]
            {
                        // index from start    index from end
            "The",      // 0                   ^9
            "quick",    // 1                   ^8
            "brown",    // 2                   ^7
            "fox",      // 3                   ^6
            "jumped",   // 4                   ^5
            "over",     // 5                   ^4
            "the",      // 6                   ^3
            "lazy",     // 7                   ^2
            "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            // Indices
            Console.WriteLine(words[words.Length - 1]); // "dog"
            Console.WriteLine(words[^1]); // "dog"

            // Ranges
            string[] allWords = words[..]; // contains all
            string[] lazyDog = words[^2..^0]; // the end is not included
                                              // contains "The" through "fox"
            string[] firstPhrase = words[..4]; // until 4
                                               // contains "the, "lazy" and "dog"
            string[] lastPhrase = words[6..]; // including 6
            Range lastTwo = ^2..^0;
            Print(words, lastTwo);
        }

        public void Print(string[] words, Range range)
        {
            // SLICE: does not create another array
            foreach (string s in words[range])
            {
                Console.WriteLine(s);
            }
        }
    }
    */
}
