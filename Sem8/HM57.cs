//Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//Сделать еще раз, сколько раз встречается каждое число с List<>
//Можно еще List.Sort();
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Sem8
{
    internal class HM57
    {
        internal static void Start()
        {
            int[,] array = TwoMas.CreateArray();
            

            Console.WriteLine("1) Просто показывает, сколько раз встречается" +
                "\r\n 2) Показывает сколько раз встречаются ВСЕ цифры");
            Console.WriteLine("Каким методом хотите найти число? 1 или 2");
            int y = int.Parse(Console.ReadLine());
            if (y==1)
            {
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Это число встречается {Check(array, number)} раз");
                TwoMas.PrintMass(array);
            }
            else {
                int[] indexes = new int[array.GetLength(1)];
                
                TwoMas.PrintMass(array);
                PrintData(indexes);
                CheckedTwo(array);
            }



            int Check(int[,] mas,int num)
            {
                int check = 0;
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        if (mas[i,j]==num)
                        {
                            check++;
                        }
                    }
                }
                return check;
            }

   
            void CheckedTwo(int[,] mas)
            {
                List<int> allNum = new List<int> ();
                int el = mas[0,0];
                int siz = 1;
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        allNum = CheckOnNum(mas[i,j],allNum,siz);
                        

                    }
                }
                //int[] masPrint = new int[allNum.Count];
                //masPrint = allNum.ToArray();
                //PrintData(masPrint);
                Console.WriteLine(String.Join(" ", allNum));
                for (int i = 0; i < allNum.Count; i += 2)
                {
                    Console.WriteLine($"{allNum[i]} - > {allNum[i + 1]}");
                }

            }
            List<int> CheckOnNum(int element, List<int> allNum,int siz)
            {
                if (allNum.IndexOf(element) % 2 == 0)
                {
                    //allNum.
                }
                if (allNum.Contains(element))
                {
                    siz = allNum.IndexOf(element);
                    allNum[siz + 1]++;
                    return allNum;
                }
                else
                {
                    allNum.Add(element);
                    allNum.Add(1);
                }
                return allNum;
            }


            void PrintData(int[] inArray)
            {
                int el = inArray[0];
                int count = 1;
                for (int i = 1; i < inArray.Length; i++)
                {
                    if (inArray[i] != el)
                    {
                        Console.WriteLine($"{el} встречается {count}");
                        el = inArray[i]; count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{el} встречается {count}");
            }

        }
    }
}