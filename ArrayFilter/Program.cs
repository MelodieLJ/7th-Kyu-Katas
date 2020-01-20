using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Kata.GetEvenNumbers(new int[] { 1,2,3,4,5})));
        }
    }

    public static class Kata
    {
        public static int[] GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).ToArray();
        }
    }
}
