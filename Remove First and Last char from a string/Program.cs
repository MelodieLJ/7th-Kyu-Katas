using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_First_and_Last_char_from_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Kata
    {
        public static string Remove_char(string s)
        {

            return s.Remove(s.Length - 1).Remove(0, 1);


            
        }
    }
}
