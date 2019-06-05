using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_consecutives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Kata.SumConsecutives(new List<int>
            { 1, 4, 4, 4, 0, 4, 7, 3, 3 } )));
        }
    }

    public class Kata
    {
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> temp = new List<int>();

            int x = s[0];

            for (int i = 0; i < s.Count - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    x += s[i];
                }
                else if (s[i] != s[i + 1])
                {
                    temp.Add(x);
                    x = s[i + 1];
                }
            }
            temp.Add(x);
            return temp;

        }
    }

}
