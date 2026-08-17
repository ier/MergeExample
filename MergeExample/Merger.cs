using System;
using System.Collections.Generic;
using System.Linq;

public class Merger
{
    public static List<int> MergeArrays(List<int> a, List<int> b)
    {
        if (a == null) throw new ArgumentNullException(nameof(a));
        if (b == null) throw new ArgumentNullException(nameof(b));
        if (a.Count == 0) return b;
        if (b.Count == 0) return a;

        var head = new List<int>();
        var tail = new List<int>();
        var border = a.Last();
        var maxLen = Math.Max(a.Count, b.Count);
        var counter = 0;

        while (counter < maxLen)
        {
            if (counter < a.Count && counter < b.Count)
            {
                var min = Math.Min(a[counter], b[counter]);
                var max = Math.Max(a[counter], b[counter]);

                head.Add(min);

                if (max > border)
                    tail.Add(max);
                else
                    head.Add(max);
            }
            else if (counter >= a.Count)
            {
                tail.Add(b[counter]);
            }
            else if (counter >= b.Count)
            {
                head.Add(a[counter]);
            }

            counter++;
        }

        head.AddRange(tail);
        return head;
    }
}
