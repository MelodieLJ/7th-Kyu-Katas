using System;

namespace Very_Even_Numbers
{
    //Challenge: Write a function that returns true if the number is a "Very Even" number. For example:
    //input(88) => returns false -> 8 + 8 = 16 -> 1 + 6 = 7 => 7 is odd 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsVeryEvenNumber(88));
        }
    }

    public static class Kata
    {
        public static bool IsVeryEvenNumber(int number)
        {
            //to reduce number to single digit
            while (number >= 10)
            {
                number = number % 10 + number / 10;
            }
            return number % 2 == 0;
        }
    }
}