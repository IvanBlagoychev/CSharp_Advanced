using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOfAllElementsOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(matrixSizes[0]);
            int cols = int.Parse(matrixSizes[1]);
            var matrix = new int[rows, cols];
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }
            foreach (var num in matrix)
            {
                sum += num;
            }

         
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
