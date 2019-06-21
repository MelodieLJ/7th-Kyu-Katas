using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_chars_in_a_string
{
    /* Challenge: Write a function that takes in one or more words, and returns the same string, with words that are 5 letters or more reversed. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.SpinWords("On my way to becoming a developer!"));
        }
    }

    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            string[] temp = sentence.Split(' ');
            List<string> result = new List<string>();

            for (int i = 0; i < temp.Length; i++)
            {
                if(temp[i].Length >= 5)
                {
                    char[] arr = temp[i].ToCharArray();
                    Array.Reverse(arr);

                    string reverse = new string(arr);
                    result.Add(reverse);
                }
                else
                {
                    result.Add(temp[i]);
                }
            }
            return string.Join(" ", result.ToArray());

        }
    }
}
