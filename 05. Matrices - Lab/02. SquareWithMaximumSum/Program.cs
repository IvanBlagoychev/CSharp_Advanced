using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = matrixSizes[0];
            var cols = matrixSizes[1];
            var matrix = new int[rows, cols];
            int sum = int.MinValue;
            var resultMatrix = new int[2, 2];
            for (int r = 0; r < rows; r++)
            {
                var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = input[c];
                }
            }

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    var SquareSum = matrix[r, c] + matrix[r, c + 1] + matrix[r + 1, c] + matrix[r + 1, c + 1];
                    if (SquareSum > sum)
                    {
                        sum = SquareSum;
                        resultMatrix[0, 0] = matrix[r, c];
                        resultMatrix[0, 1] = matrix[r, c + 1];
                        resultMatrix[1, 0] = matrix[r + 1, c];
                        resultMatrix[1, 1] = matrix[r + 1, c + 1];
                    }
                }
            }


            for (int r = 0; r < resultMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < resultMatrix.GetLength(1); c++)
                {
                    Console.Write(resultMatrix[r,c] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(sum);
        }
    }
}
