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
        }
    }

    public class Kata
    {
        public static int[] GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).ToArray();
        }
    }
}
