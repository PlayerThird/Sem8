using System;

namespace Sem8
{
    internal class Switcher
    {
        internal static void Start()
        {
            int y = Checker.CheckInput<int>(x => x < 53 || x > 62, "Введите номер программы: ", "Такой программы нет");
            bool check = false;
            switch (y)
            {
                case 53:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM53.Start();
                    break;
                case 54:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM54.Start();
                    break;
                case 55:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM55.Start();
                    break;
                case 56:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM56.Start();
                    break;
                case 57:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM57.Start();
                    break;
                case 58:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM58.Start();
                    break;
                case 59:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM59.Start();
                    break;
                case 60:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM60.Start();
                    break;
                case 61:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM61.Start();
                    break;
                case 62:
                    DiscriptionTasks(y);
                    check = UnlockTasks();
                    CheckContinue(check);
                    Console.Clear();
                    DiscriptionTasks(y);
                    HM62.Start();
                    break;

                default:
                    Console.WriteLine("Такой программы нет");
                    Console.ReadLine();
                    CheckContinue(check);
                    break;
            }

            bool UnlockTasks()
            {
                bool check = false;
                Console.WriteLine("Это та программа, которая вам нужна?( + или - )");
                string answer = Console.ReadLine();
                string v = "+";
                if (answer == v)
                {
                    check = true;
                }
                return check;
            }
            void DiscriptionTasks(int y)
            {
                switch (y)
                {
                    case 53:
                        Console.WriteLine("//Задайте двумерный массив." +
                            "\r\n//Напишите программу, которая поменяет местами первую и последнюю строку массива.");
                        break;
                    case 54:
                        Console.WriteLine("//Задайте двумерный массив." +
                            "\r\n//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива");
                        break;
                    case 55:
                        Console.WriteLine("//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы." +
                            "\r\n//В случае, если это невозможно, программа должна вывести сообщение для пользователя");
                        break;
                    case 56:
                        Console.WriteLine("//Задайте прямоугольный двумерный массив." +
                            "\r\n//Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
                        break;
                    case 57:
                        Console.WriteLine("//Составить частотный словарь элементов двумерного массива." +
                            "\r\n//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.");
                        break;
                    case 58:
                        Console.WriteLine("//Задайте две матрицы." +
                            "\r\n//Напишите программу, которая будет находить произведение двух матриц.");
                        break;
                    case 59:
                        Console.WriteLine("//Задайте двумерный массив из целых чисел." +
                            "\r\n//Напишите программу, которая удалит строку и столбец," +
                            "\r\n//на пересечении которых расположен наименьший элемент массива.");
                        break;
                    case 60:
                        Console.WriteLine("//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел." +
                            "\r\n//Напишите программу, которая будет построчно выводить массив," +
                            "\r\n//добавляя индексы каждого элемента.");
                        break;
                    case 61:
                        Console.WriteLine("//Вывести первые N строк треугольника Паскаля." +
                            "\r\n//Сделать вывод в виде равнобедренного треугольника");
                        break;
                    case 62:
                        Console.WriteLine("//Заполните спирально массив 4 на 4.");
                        break;
                }
            }

            void CheckContinue(bool check)
            {
                if (check == false)
                {
                    Start();
                }
            }


        }
    }
}
