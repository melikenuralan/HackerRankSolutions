using System;

class Solution
{
    static void Main(string[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != null && line != "")
        {
            string[] parts = line.Split(';');
            string op = parts[0];    // S or C
            string type = parts[1];  // M, C, V
            string data = parts[2];

            if (op == "S") // Split
            {
                if (type == "M" && data.EndsWith("()"))
                    data = data.Substring(0, data.Length - 2);

                string result = "";
                foreach (char ch in data)
                {
                    if (char.IsUpper(ch))
                    {
                        if (result.Length > 0) result += " ";
                        result += char.ToLower(ch);
                    }     
                    else
                        result += ch;
                }

                Console.WriteLine(result.Trim());
            }
            else if (op == "C") // Combine
            {
                string[] words = data.Split(' ');
                string result = "";

                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i].ToLower();
                    if (i == 0 && (type == "V" || type == "M"))
                        result += word;
                    else
                        result += char.ToUpper(word[0]) + word.Substring(1);

                }

                if (type == "M")
                    result += "()";

                Console.WriteLine(result);
            }
        }
    }
}
