using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveVowels
{
    class Program
    {
        //Challenge: Remove all vowels from a string
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Diwemvowel("No more vowels"));
        }
    }

    public static class Kata
    {
        public static string Diwemvowel(string str)
        {
            string vowels = "aeiouAEIOU";
            char[] temp = str.ToArray();
            List<char> result = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!vowels.Contains(str[i]))
                {
                    result.Add(str[i]);
                }
            }

            return string.Join("", result);
        }
    }
}
