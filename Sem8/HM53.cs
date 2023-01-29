//Задайте двумерный массив.
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
using System;

namespace Sem8
{
    internal class HM53
    {
        internal static void Start()
        {
            Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] array = GetArray(rows, columns, 0, 10);
            TwoMas.PrintMass(array);
            Console.WriteLine();
            array = Change(array);
            TwoMas.PrintMass(array);


            int[,] Change(int[,] mas)
            {
                int temp = 0;
                int siz = mas.GetUpperBound(0);
                
                for (int j = 0; j < mas.GetLength(1); j++)
                {
              
                    temp = mas[siz, j];
                    mas[siz, j] = mas[0, j];
                    mas[0, j] = temp;
                }
                return mas;
            }

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
    }
}