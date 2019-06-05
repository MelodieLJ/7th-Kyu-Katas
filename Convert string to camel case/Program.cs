using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_string_to_camel_case
{
    //Challenge: Create a method so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.ToCamelCase("the-stealth-warrior"));
        }
    }

    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '-' || str[i] == '_')
                {
                    result += char.ToUpper(str[i + 1]);
                    i++;
                }
                else
                {
                    result += str[i];
                }
            }
            return result;
        }
    }
}