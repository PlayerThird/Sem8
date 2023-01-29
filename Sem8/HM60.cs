//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
using System;

namespace Sem8
{
    internal class HM60
    {
        internal static void Start()
        {
            int oneD = Checker.CheckInput<int>(x => x < 0, "Введите кол-во строк", "Строки не могут быть меньше 0");
            int twoD = Checker.CheckInput<int>(x => x < 0, "Введите кол-во столбцов", "Столбцы не могут быть меньше 0");
            int threeD = Checker.CheckInput<int>(x => x < 0, "Введите 3-е измерение", "3-е измерение не может быть меньше 0");

            int[,,] bigAr = new int[oneD, twoD, threeD];
            bigAr = FullMas(bigAr, oneD, twoD, threeD);
            Console.WriteLine("1) Печать по типу i,j,k" +
                "\r\n2) Печать по типу j,k,i" +
                "\r\n3) Печать по типу k,j,i");
            int x = Checker.CheckInput<int>(x => x < 0 || x > 3, "Введите вариант печати", "Неа, еще раз");
            switch (x)
            {


                case 1:
                    PrintArrayFirst(bigAr);
                    break;
                case 2:
                    PrintArrayTwo(bigAr);
                    break;
                case 3:
                    PrintArrayThree(bigAr);
                    break;
                default:
                    break;
            }


            int[,,] FullMas(int[,,] bigAr, int oneD, int twoD, int threeD)
            {
                int plus = 10;
                for (int i = 0; i < oneD; i++)
                {
                    for (int j = 0; j < twoD; j++)
                    {
                        for (int k = 0; k < threeD; k++)
                        {
                            bigAr[i, j, k] = plus;

                            if (plus < 100 || plus < -10)
                            {
                                plus++;
                            }
                            else
                            {
                                plus *= -1;
                            }

                        }
                    }

                }
                return bigAr;
            }

            void PrintArrayFirst(int[,,] mas)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        for (int k = 0; k < mas.GetLength(2); k++)
                        {
                            Console.Write($"{mas[i, j, k]}({i},{j},{k})");
                        }
                        Console.WriteLine();

                    }
                    Console.WriteLine();
                }

            }
            void PrintArrayTwo(int[,,] mas)
            {
                for (int i = 0; i < oneD; i++)
                {
                    for (int j = 0; j < twoD; j++)
                    {
                        for (int k = 0; k < threeD; k++)
                        {
                            Console.Write($"{bigAr[j, k, i]}({j},{k},{i})");
                        }
                        Console.WriteLine();

                    }
                    Console.WriteLine();
                }

            }
            void PrintArrayThree(int[,,] mas)
            {
                for (int i = 0; i < oneD; i++)
                {
                    for (int j = 0; j < twoD; j++)
                    {
                        for (int k = 0; k < threeD; k++)
                        {
                            Console.Write($"{bigAr[k, j, i]}({k},{j},{i})");
                        }
                        Console.WriteLine();

                    }
                    Console.WriteLine();
                }

            }



        }
    }
}