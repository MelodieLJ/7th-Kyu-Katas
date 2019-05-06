using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    /* Challenge: Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.ReverseWords("Hello World!"));
        }
    }

    public static class Kata
    {
        public static string ReverseWords(string str)
        {
            //split the words by the spaces
            string[] word = str.Split(' ');
            List<string> result = new List<string>();

            foreach (var x in word)
            {
                //convert each string to a char array
                char[] arr = x.ToCharArray();
                //reverse the array
                Array.Reverse(arr);

                string reverse = new string(arr);
                result.Add(reverse);
            }
            return string.Join(" ", result.ToArray());
        }
    }
}
