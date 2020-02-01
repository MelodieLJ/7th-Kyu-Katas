using System;
using System.Collections.Generic;

namespace Multiples_of_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Multiples(3, 5));
        }
    }

    public static class Kata
    {
        public static double[] Multiples(int m, double n)
        {
            List<double> temp = new List<double>();

            for (int i = 1; i < m; i++)
            {
                temp.Add(n * i);
            }
            return temp.ToArray();
        }
    }
}
