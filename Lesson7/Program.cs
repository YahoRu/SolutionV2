using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[6] { 21, 2, 3, 6, 9, 12 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }

            int temp;

            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }

            // Вторая часть задания 

            int[,] array = {
                { 1, 21, 3 },
                { 4, 7, 9 },
                { 2, 8, 5 } };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int maxValue = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxValue < array[i, j])
                    {
                        maxValue = array[i, j];
                    }
                }
                Console.WriteLine(maxValue);
            }

        }
    }
}
