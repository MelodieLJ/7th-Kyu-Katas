using System;

namespace Isogram
{
    //Challenge: An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsIsogram("byiutb")); // 0 1 2 3
        }
    }

    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            str = str.ToLower();



            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        return false;
                }
            }
            return true;


        }
    }
}