using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_KYU
{
    /*Return the number (count) of vowels in the given string.
    We will consider a, e, i, o, and u as vowels for this Kata.
    The input string will only consist of lower case letters and/or spaces.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetVowelCount("Melodie"));
        }
    }

    public static class Kata
    {
        public static int GetVowelCount(string str)
        {
            string word = str.ToLower();
            string vowel = "aeiou";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (vowel.Contains(word[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
