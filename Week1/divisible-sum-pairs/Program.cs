using System;

class Program
{
    static void Main()
    {
        int n = 6;
        int k = 3;
        int[] ar = { 1, 3, 2, 6, 1, 2 };

        int result = divisibleSumPairs(n, ar, k);
        Console.WriteLine("Geçerli çift sayısı: " + result);
    }

    static int divisibleSumPairs(int n, int[] ar, int k)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
