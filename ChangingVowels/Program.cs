using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Swap("HelloWorld!"));
        }
    }

    public static class Kata
    {
        public static string Swap(string s)
        {
            string vowels = "aeiou";
            string result = "";

            foreach (var item in s)
            {
                if (vowels.Contains(item))
                {
                    result += char.ToUpper(item);
                }
                else
                {
                    result += item;
                }
            }
            return result;                     
        }
    }
}