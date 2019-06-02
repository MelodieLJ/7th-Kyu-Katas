using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Reverse
{
    class Program
    {
        //Challenge: A stream of data is received and needs to be reversed. Each segment is 8 bits long, meaning the order of these segments needs to be reversed.The total number of bits will always be a multiple of 8.
        static void Main(string[] args)
        {
            var newMatrix = String.Join(",", Kata.DataReverse(new int[32]
            { 1, 1, 1, 1, 1, 1, 1, 1,
              0, 0, 0, 0, 0, 0, 0, 0,
              0, 0, 0, 0, 1, 1, 1, 1,
              1, 0, 1, 0, 1, 0, 1, 0 }));
            Console.WriteLine(newMatrix);
        }
    }

    public static class Kata
    {
        public static int[] DataReverse(int[] data)
        {
            int[] result = data;

            for (int i = 0; i < data.Length; i+=8)
            {
                Array.Reverse(result, i, 8);
            }

            Array.Reverse(result);

            return result;
        }
    }
}
