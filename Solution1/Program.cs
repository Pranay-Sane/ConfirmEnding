using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConfirmEnding("hello", "o"));
            Console.WriteLine(ConfirmEnding("world", "l"));
        }

        static bool ConfirmEnding(string str, string target)
        {
            int len = target.Length;
            return str.Substring(str.Length - len, len) == target;
        }
    }
}
