using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEndsWith
{
    /* Challenge: Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Endcheck("codewars", "wars"));
            Console.WriteLine(Kata.Endcheck("codewars", "war"));
        }
    }

    public class Kata
    {
        public static bool Endcheck(string first, string ending)
        {
            //check to ensure ending is shorter than the first input
            if (first.Length < ending.Length)
            {
                return false;
            }
            if(first.Substring(first.Length - ending.Length) == ending)
            {
                return true;
            }
            return false;
        }
    }
}
