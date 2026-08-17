using System;
using System.Collections.Generic;
using System.Linq;

public class Merger
{
    public static List<int> MergeArrays(List<int> a, List<int> b)
    {
        // The Guards
        if (a == null) throw new ArgumentNullException(nameof(a));
        if (b == null) throw new ArgumentNullException(nameof(b));
        if (a.Count == 0) return b;
        if (b.Count == 0) return a;

        var result = new List<int>(a.Count + b.Count);
        int i = 0, j = 0;

        // Main part processing cycle
        while (i < a.Count && j < b.Count)
        {
            if (a[i] <= b[j])
                result.Add(a[i++]);
            else
                result.Add(b[j++]);
        }

        // Adding the rest elements
        while (i < a.Count) result.Add(a[i++]);
        while (j < b.Count) result.Add(b[j++]);

        return result;
    }
}
