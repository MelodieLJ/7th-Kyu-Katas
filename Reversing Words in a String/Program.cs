using System;
using System.Collections.Generic;

namespace Reversing_Words_in_a_String
{
    /* Challenge: Write a function that reverses the words in a given string.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Reverse("Day 4 of 100 days of Code"));
        }
    }

    public static class Kata
    {
        public static string Reverse(string text)
        {
            //split the words by spaces
            string[] words = text.Split(' ');
            //store the reversed words in a List
            List<string> result = new List<string>();

            //set i to the number of words - 1 to start at the last word
            for (int i = words.Length - 1; i >= 0; i--)
            {
                //add each of the words
                result.Add(words[i]);
            }
            return string.Join(" ", result.ToArray());           
        }
    }
}
