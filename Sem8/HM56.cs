//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using System;

namespace Sem8
{
    internal class HM56
    {
        internal static void Start()
        {
            int[,] mass = CreateArray();
            SearchMin(mass);


            void SearchMin(int[,] array)
            {
                int sum = 0;
                int[] result= new int[array.GetLength(1)];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }
                    result[i] = sum;
                    sum = 0;
                }
                Console.WriteLine(String.Join(" ,",result));
                int max = result[0];
                foreach (var item in result)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
                int index = Array.IndexOf(result, max);
                Console.WriteLine($"Номер строки = {index+1}");
                Console.Write("Эта строка самая большая, которую впервые встретили -> ");
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    Console.Write($"{array[index,i]} ");
                }
            }

            int[,] CreateArray()
            {

                int colums = Checker.CheckInput<int>(x => x < 0, "Введите ширину прямогульного массива", "Прямоугольник не может быть меньше 0");

                
                int[,] mass = new int[colums, colums];
                mass = TwoMas.FillArray(mass);
                TwoMas.PrintMass(mass);
                return mass;
            }
        }
    }
}