

using System;

namespace Rotate_Matrix_To_Left
{ //Challenge: Rotate a matrix 90 degree to the left. The matrix is an array of integers with dimension n,m
    class Program
    {
        static void Main(string[] args)
        {
            var result = Kata.Rotate(new int[2, 4] { { -1, 4, 3, 4 }, 
                { 5, 6, 7, 8 } });
        }
    }

    public class Kata
    {
        public static int[,] Rotate(int[,] matrix)
        {
            //get height of array
            var height = matrix.GetLength(0);
            //get length of array
            var length = matrix.GetLength(1); 

            //assign height and length to a new array, swopping the values
            int[,] result = new int[length, height]; 

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    //loop through the original height for each iteration of the original length
                    result[i, j] = matrix[j, length - i - 1]; 
                    //format matrix as a string to print to console
                    Console.Write(string.Format("{0} ", result[i, j]));
                }
                Console.WriteLine();
            }
            return result;
        }
    }
}