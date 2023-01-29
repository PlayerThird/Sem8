//Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
using System;
using System.Linq;

namespace Sem8
{
    internal class HM54
    {
        internal static void Start()
        {
            int[,] array = TwoMas.CreateArray();
            
            Console.WriteLine("----------------------");
            array = Sort(array);
            TwoMas.PrintMass(array);

            int[,] Sort(int[,] mas)
            {
                int[] temp = new int[mas.GetLength(1)];
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        temp[j] = mas[i, j];
                        
                        if (j == mas.GetLength(1) - 1)
                        {
                            
                            temp = temp.OrderBy(x => x).ToArray();
                            
                            for (int k = 0; k < mas.GetLength(1); k++)
                            {
                                mas[i, k] = temp[k];
                            }
                        }
                    }

                }
                return mas;
            }
        }
    }
}