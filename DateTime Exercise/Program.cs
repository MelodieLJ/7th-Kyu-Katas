using System;

namespace DateTime_Exercise
{
    /*Challenge: Find the number of Friday the 13th's in the given year. Input: Year as an integer. Output: Number of Black Fridays in the year as an integer.
     */

    class Program
    {
        static void Main(string[] args)
        {
            var year = 2019;
            var result = Kata.UnluckyDays(year);

            Console.WriteLine($"Number of Unlucky days in the year {year}: {result}");
        }
    }

    public static class Kata
    {
        public static int UnluckyDays(int year)
        {
            int count = 0;
            //loop through the months
            for (int i = 1; i <= 12; i++)
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