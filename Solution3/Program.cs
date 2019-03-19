using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
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
            return str.EndsWith(target);
        }
    }
}
