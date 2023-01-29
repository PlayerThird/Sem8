//Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.
using System;

namespace Sem8
{
    internal class HM59
    {
        internal static void Start()
        {
            
            

            //int[,] DeleteMin(int[,] mas)
            //{

            //    return newMas;
            //}
            static int[] FindIndexMinValue(int[,] array)
            {
                int[] minIndexValue = new int[2];
                minIndexValue[0] = 0;
                minIndexValue[1] = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < array[minIndexValue[0], minIndexValue[1]])
                        {
                            minIndexValue[0] = i;
                            minIndexValue[1] = j;
                        }
                    }
                }
                return minIndexValue;
            }

            static int[,] CoppyChangedArray(int[,] array, int[] indexOfMinValue)
            {
                int rows = array.GetLength(0), columns = array.GetLength(1);
                int[,] newArray = new int[rows - 1, columns - 1];
                int x = 0, y = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (i == indexOfMinValue[0])
                    {
                        x = 1;
                        continue;
                    }
                    for (int j = 0; j < columns; j++)
                    {
                        if (j == indexOfMinValue[1])
                        {
                            y = 1;
                            continue;
                        }
                        if (i == 0) newArray[i, j - y] = array[i, j];
                        else if (j == 0) newArray[i - x, j] = array[i, j];
                        else newArray[i - x, j - y] = array[i, j];
                    }
                }
                return newArray;
            }
            //Console.Clear();
            //int rows = 5, columns = 6, randomMinValue = -10, randomMaxValue = 10;
            int[,] array = TwoMas.CreateArray();
            
            int[] indexOfMinValue = FindIndexMinValue(array);
            System.Console.WriteLine($"Min index Value = [{String.Join(", ", indexOfMinValue)}]");
            System.Console.WriteLine();
            int[,] newArray = CoppyChangedArray(array, indexOfMinValue);
            TwoMas.PrintMass(newArray);
        }
    }
}