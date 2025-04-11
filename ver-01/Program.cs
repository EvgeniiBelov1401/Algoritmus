internal class Program
{
    /*
     * Дана строка s, найдите длину самой длинной из них. подстрокабез повторяющихся символов.
     */
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Введите строку: ");
            var str = Console.ReadLine();

            if (!string.IsNullOrEmpty(str))
            {
                var strLength = LengthOfLongestSubstring(str);
            }
            else
            {
                Console.WriteLine("Введите строчку...");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
    static int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int sLength = s.Length;
        for (int i = 0; i < sLength; i++)
        {
            HashSet<char> seen = [];
            int currentLength = 0;

            for (int j = i; j < sLength; j++)
            {
                if (!seen.Contains(s[j]))
                {
                    seen.Add(s[j]);
                    currentLength++;
                    maxLength = Math.Max(maxLength, currentLength);
                }
                else
                {
                    break;
                }
            }
        }
        return maxLength;
    }
}