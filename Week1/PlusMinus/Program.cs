using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinusApp
{
    public class PlusMinus
    {
        public static void Calculate(List<int> arr)
        {
            int total = arr.Count;
            int pos = 0, neg = 0, zero = 0;

            foreach (int i in arr)
            {
                if (i > 0) pos++;
                else if (i < 0) neg++;
                else zero++;
            }

            Console.WriteLine($"{(double)pos / total:F6}");
            Console.WriteLine($"{(double)neg / total:F6}");
            Console.WriteLine($"{(double)zero / total:F6}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine()
                                   .Trim()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToList();

            PlusMinus.Calculate(arr);
        }
    }
}
