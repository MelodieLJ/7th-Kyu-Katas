using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Spaces_From_String
{
    class Program
    {
        //Challenge: Remove spaces form a string
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.NoSpace("Coding is great !"));
        }
    }
    public static class Kata
    {
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
