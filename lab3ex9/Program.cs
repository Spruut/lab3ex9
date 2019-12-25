using System;

namespace lab3ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[9, 9];
            Random random = new Random();

            RandomMatrix(array, random);
            WriteMatrix(array);

            ChangeMatrix(array, out int sum);
            WriteMatrix(array);
        }
        static void RandomMatrix(int[,] array, Random random)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 9);
                }
            }
        }
        static void WriteMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void ChangeMatrix(int[,] array, out int sum)
        {
            int i = 1;
            sum = 0;
            for (int j = 1; j < array.GetLength(1) - 1; j++)
            {
                sum = array[i + 1, j] + array[i - 1, j] + array[i, j + 1] + array[i, j - 1];
                array[i, j] = sum;
                i++;
            }
            sum = array[0, 1] + array[1, 0];
            array[0, 0] = sum;
            sum = array[array.GetLength(0) - 1, array.GetLength(0) - 2] + array[array.GetLength(0) - 2, array.GetLength(0) - 1];
            array[array.GetLength(0) - 1, array.GetLength(0) - 1] = sum;
        }
    }
}
