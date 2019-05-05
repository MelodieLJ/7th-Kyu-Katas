using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingLetters
{
    //This time no story, no theory.The examples below show you how to write function accum:
    //Examples:
    //accum("abcd") -> "A-Bb-Ccc-Dddd"
    //accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
    //accum("cwAt") -> "C-Ww-Aaa-Tttt"

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Accumulation("Abcd"));
        }
    }

    public class Kata
    {
        public static string Accumulation(string s)
        {
            var sb = new StringBuilder();
            //var array = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                sb.Append(char.ToUpper(c)).Append(char.ToLower(c), i).Append("-");
            }
            return sb.ToString().TrimEnd('-');
        }
    }
}