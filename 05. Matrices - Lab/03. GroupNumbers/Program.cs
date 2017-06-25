using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var sorted = input.OrderBy(x => Math.Abs(x) % 3);
            Console.WriteLine(string.Join(" ", sorted));


            //var numbers = Console.ReadLine()
            //    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            //var jaggedArray = new int[3][];
            //var arraysCurrentIndex = new int[3];


            //for (int i = 0; i < numbers.Count; ++i)
            //{
            //    var number = numbers.ElementAt(i);
            //    var remainder = Math.Abs(number % 3);

            //    switch (remainder)
            //    {
            //        case 0:
            //        case 1:
            //        case 2: arraysCurrentIndex[remainder]++; break;
            //        default: numbers.RemoveAt(i); i--; break;
            //    }
            //}

            //for (int i = 0; i < arraysCurrentIndex.Length; i++)
            //{
            //    jaggedArray[i] = new int[arraysCurrentIndex[i]];
            //    arraysCurrentIndex[i] = 0;
            //}

            //foreach (var number in numbers)
            //{
            //    var remainder = Math.Abs(number % 3);
            //    jaggedArray[remainder][arraysCurrentIndex[remainder]] = number;
            //    arraysCurrentIndex[remainder]++;
            //}

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine(string.Join(" ", jaggedArray[i]));
            //}

        }

    }

}
