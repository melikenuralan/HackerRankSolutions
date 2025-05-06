using System;

class Program
{
    public static string timeConversion(string s)
    {
         string timePeriod = s.Substring(s.Length - 2); // AM veya PM
        string time = s.Substring(0, 8);               // 07:05:45 gibi
        string[] parts = time.Split(':');

        int hour = int.Parse(parts[0]);

        if (timePeriod == "AM")
        {
            if (hour == 12)
                hour = 0;
        }
        else // PM
        {
            if (hour != 12)
                hour += 12;
        }

        return $"{hour:D2}:{parts[1]}:{parts[2]}";
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = timeConversion(input);
        Console.WriteLine(result);
    }
}
