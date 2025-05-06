class Program
{
    public static List<int> BreakingRecords(List<int> scores)
    {
        int min = scores[0];
        int max = scores[0];
        int minBreaks = 0;
        int maxBreaks = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > max)
            {
                max = scores[i];
                maxBreaks++;
            }
            else if (scores[i] < min)
            {
                min = scores[i];
                minBreaks++;
            }
        }

        return new List<int> { maxBreaks, minBreaks }; // doğru sıra
    }

    public static void Main()
    {
        List<int> scores = new List<int> { 12, 24, 10, 24 };
        List<int> result = BreakingRecords(scores);
        Console.WriteLine(string.Join(" ", result)); // Output: 1 1
    }
}
