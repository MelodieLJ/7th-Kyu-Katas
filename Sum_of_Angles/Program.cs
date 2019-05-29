using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Angles
{
    //Challenge: Find the total sum of angles in an n sided shape. N will be greater than 2
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Angle(5));
        }
    }

    public class Kata
    {
        public static int Angle(int n)
        {
            return 180 * (n - 2);
        }
    }
}
