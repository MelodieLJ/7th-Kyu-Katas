using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Split_string_into_substrings
{     //Challenge: Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Kata.Solution("Artem")));
        }
    }

    public class Kata
    {
        public static string[] Solution(string str)
        {

            List<string> temp = new List<string>();

            if (str.Length % 2 != 0)
            {
                str += "_";
            }

            for (int i = 0; i < str.Length; i++)
            {
                temp.Add(str[i].ToString() + str[i + 1].ToString());
                i++;
            }

            return temp.ToArray();

        }
    }
}
