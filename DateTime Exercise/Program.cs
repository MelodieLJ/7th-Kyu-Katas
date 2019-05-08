using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Exercise
{
    /* Challenge: Find the number of Friday the 13th's in the given year. Input: Year as an integer. Output: Number of Black Fridays in the year as an integer.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.UnluckyDays(2819));
        }
    }

    public static class Kata
    {
        public static int UnluckyDays(int year)
        {
            int count = 0;

            for (int i = 1; i < 13; i++)
            {
                DateTime date = new DateTime(year, i, 13);
                if (date.DayOfWeek == DayOfWeek.Friday)
                {
                    count++;
                }              
            }
            return count;
        }
    }
}