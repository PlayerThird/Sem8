//Задайте две матрицы.
//Напишите программу, которая будет находить произведение двух матриц.
using System;

namespace Sem8
{
    internal class HM58
    {
        internal static void Start()
        {
            Console.WriteLine("Матрица А:");
            int[,] matrixA = TwoMas.CreateArray();
            Console.WriteLine("Матрица В:");
            int[,] matrixB = TwoMas.CreateArray();
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В.");
                Console.ReadKey();
                Start();
            }
            int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixC[i, j] = Umnozh(matrixA, matrixB, i, j);
                }
            }
            Console.WriteLine("Новый массив = ");
            TwoMas.PrintMass(matrixC);





            int Umnozh(int[,] matrixA, int[,] matrixB, int c, int r)
            {
                int[,] allNum = new int[matrixA.GetLength(1), matrixB.GetLength(0)];
                int result = 0;
                for (int i = 0; i < matrixA.GetLength(1); i++)
                {
                    allNum[i,0] = matrixA[c,i];
                    
                }
                for (int j = 0; j < matrixB.GetLength(0); j++)
                {
                    allNum[j, 1] = matrixB[j, r];
                }
                for (int k = 0; k < allNum.GetLength(0); k++)
                {
                    result += allNum[k, 0] * allNum[k, 1];
                }
                return result;
            }
            
        }
    }
}