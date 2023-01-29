using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem8
{
    internal class TwoMas//Для двумерных массивов идёт вместе с Checker
    {

        //Создание массива и печать его
        public static int[,] CreateArray()
        {
            
            int colums = Checker.CheckInput<int>(x => x < 0, "Введите кол-во строк", "Строки не могут быть меньше 0");
            
            int row = Checker.CheckInput<int>(x => x < 0, "Введите кол-во столбцов", "СтолбцЫ не могут быть меньше 0");
            int[,] mass = new int[colums, row];
            mass = TwoMas.FillArray(mass);
            TwoMas.PrintMass(mass);
            return mass;
        }
        //Печать массива
        public static void PrintMass(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        //Печать массива стринговской формы
        public static void PrintMassString(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        //Печать массива дабл формы
        public static void PrintMassDouble(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]:f2} ");
                }
                Console.WriteLine();
            }
        }
        // Заполнить двумерный массив рандомом
        public static int[,] FillArray(int[,] array, int minRan = 1, int maxRan =10)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(minRan, maxRan);
                }
                Console.WriteLine();
            }
            return array;
        }
        // Заполнить двумерный массив рандомом типа дабл
        public static double[,] FillArrayDouble(double[,] array, int minValue, int maxValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
                }
                Console.WriteLine();
            }
            return array;
        }
    }
}

