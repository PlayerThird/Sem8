//Вывести первые N строк треугольника Паскаля.
//Сделать вывод в виде равнобедренного треугольника
using System;

namespace Sem8
{
    internal class HM61
    {
        internal static void Start()
        {
            int size = Checker.CheckInput<int>(x => x < 0, "Введите число Паскаля", "Ну да, ну да, отрицательный массив, молодец, еще раз");
            int[,] pascal = new int[size, size];
            pascal = FillPascal(pascal);
            TwoMas.PrintMass(pascal);

            int[,] FillPascal(int[,] pascal)
            {
                for (int i = 0; i < size; i++)
                {
                    pascal[i, 0] = 1;
                    pascal[i, i] = 1;
                }
                for (int row = 2; row < size; row++)
                {
                    for (int colum = 1; colum < size; colum++)
                    {
                        pascal[row, colum] = pascal[row-1,colum-1] + pascal[row-1,colum];
                    }
                }
                return pascal;
            }
        }
    }
}