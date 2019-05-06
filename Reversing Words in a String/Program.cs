using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_Words_in_a_String
{
    /* Challenge: You need to write a function that reverses the words in a given string. A word can also fit an empty string.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Reverse("Hello World"));
        }
    }

    public static class Kata
    {
        public static string Reverse(string text)
        {
            string[] words = text.Split(' ');
            List<string> result = new List<string>();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result.Add(words[i]);
            }
            return string.Join(" ", result.ToArray());           
        }
    }
}
