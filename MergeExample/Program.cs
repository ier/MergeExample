using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeExample
{
    class Solution
    {
        public static void Main(string[] args)
        {
            var a = new List<int> {1, 2, 3, 4, 4};
            var b = new List<int> {2, 5, 5, 10};
            var merged = Merger.MergeArrays(a, b);

            var result = String.Join(" ", merged);
            Console.WriteLine(result);
        }
    }
}
