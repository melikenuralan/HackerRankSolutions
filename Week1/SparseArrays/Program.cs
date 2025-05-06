using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // Girdi listeleri
        List<string> strings = new List<string> { "ab", "ab", "abc" };
        List<string> queries = new List<string> { "ab", "abc", "bc" };

        // Fonksiyonu çağır
        List<int> result = matchingStrings(strings, queries);

        // Sonuçları yazdır
        foreach (int count in result)
        {
            Console.WriteLine(count);
        }
    }

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> results = new List<int>();
        foreach (string query in queries)
        {
            int count = 0;
            foreach (string str in strings)
            {
                if (str == query)
                    count++;
            }
            results.Add(count);
        }
        return results;
    }
}
