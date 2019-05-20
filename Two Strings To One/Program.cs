using System;
using System.Linq;

namespace Two_Strings_To_One
{
    /* Challenge: Take 2 strings, s1 and s2, including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters, each taken only once - coming from s1 or s2.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Longest("sortingtwostrings", "usingcsharp"));
        }
    }

    public static class Kata
    {
        public static string Longest(string s1, string s2)
        {
            //Store both strings in a single string
            string result = s1.ToLower() + s2.ToLower();
            //Create a char array that will remove duplicate letters from the new string
            char[] arr = result.Distinct().ToArray();
            //Sort the array in alphabetical order
            Array.Sort(arr);
            //Return the sorted array of chars as a new string
            return new string(arr);
        }
    }
}