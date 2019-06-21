using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Years
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static bool IsLeapYear(int year)
        {
            bool result = false;

            if (year % 4 == 0)
            {
                result = true;
            }
            if (year % 100 == 0)
            {
                result = false;
            }
            if (year % 400 == 0)
            {
                result = true;
            }
            return result;
        }
    }
}
