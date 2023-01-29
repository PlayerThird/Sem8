//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя
using System;

namespace Sem8
{
    internal class HM55
    {
        internal static void Start()
        {
            Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int columns = int.Parse(Console.ReadLine());
            if (rows == 0 || columns==0)
            {
                Console.WriteLine("Замена не возможна");
                return;
            }
            int[,] array = GetArray(rows, columns, 0, 10);
            int[,] newArray = new int[columns, rows];
            TwoMas.PrintMass(array);
            Console.WriteLine();
            newArray = Change(array,columns, rows);
            TwoMas.PrintMass(newArray);



            int[,] GetArray(int m, int n, int minValue, int maxValue)
            {
                int[,] result = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        result[i, j] = new Random().Next(minValue, maxValue + 1);
                    }
                }
                return result;
            }
        }

        private static int[,] Change(int[,] array,int colum, int row)
        {
            int[,] newArray = new int[colum, row];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[j, i] = array[i, j];
                }
            }
            return newArray;
        }
    }
}