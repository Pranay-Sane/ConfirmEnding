using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution2
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
            return Regex.Match(str, target + "$").Success;
        }
    }
}
