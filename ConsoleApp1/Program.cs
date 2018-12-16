using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testArray = new int[2, 2];
            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                    testArray[i, j] = int.Parse(Console.ReadLine());
            }

            int[,] testArray2 = new int[2, 2];
            for (int i = 0; i < testArray2.GetLength(0); i++)
            {
                for (int j = 0; j < testArray2.GetLength(1); j++)
                    testArray2[i, j] = int.Parse(Console.ReadLine());
            }
            int[,] sumArray = new int[2, 2];
            for (int i = 0; i < sumArray.GetLength(1); i++)
            {
                for (int j = 0; j < sumArray.GetLength(1); j++)
                {
                    sumArray[i, j] = testArray[i, j] + testArray2[i, j];
                    Console.WriteLine("Element with index" + i + "" + j + "is " + sumArray[i, j]);

                }
            }
        }
    }
}
