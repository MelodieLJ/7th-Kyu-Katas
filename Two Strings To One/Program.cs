using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Strings_To_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Longest("melodie", "lotto"));
        }
    }

    public static class Kata
    {
        public static string Longest(string s1, string s2)
        {
            string result = s1.ToLower() + s2.ToLower();
            char[] first = result.Distinct().ToArray();

            Array.Sort(first);
            return new string(first);
        }
    }
}
