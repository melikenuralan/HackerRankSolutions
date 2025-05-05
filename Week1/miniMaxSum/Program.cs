using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void miniMaxSum(List<int> arr)
    {
        long total = arr.Sum(x => (long)x); // long kullandık overflow olmasın diye
        long min = arr.Min();
        long max = arr.Max();

        long minSum = total - max;
        long maxSum = total - min;

        Console.WriteLine($"{minSum} {maxSum}");
    }

    static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine()
                               .Trim()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToList();

        miniMaxSum(arr);
    }
}
