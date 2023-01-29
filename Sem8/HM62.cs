//Заполните спирально массив 4 на 4.
using System;

namespace Sem8
{
    internal class HM62
    {
        internal static void Start()
        {
            int size = 4;
            int[,] spiral = new int[size, size];
            int i = 0;
            TwoMas.PrintMass(spiral);
            FillZig(0, 0);
            TwoMas.PrintMass(spiral);
            void FillZig(int row, int col)
            {

                if (col + 1 < size && spiral[row, col] == 0)//вправо
                    do
                    {
                        i++;
                        spiral[row, col] = i;
                        col++;
                    } while (col + 1 < size && spiral[row, col + 1] == 0);
                    if (row + 1 < size && spiral[row, col] == 0)//вниз
                    do
                    {
                        i++;
                        spiral[row, col] = i;
                        row++;
                    } while (row + 1 < size && spiral[row + 1, col] == 0) ;
                if (col - 1 > -1 && spiral[row, col] == 0)//влево
                    do
                    {
                        i++;
                        spiral[row, col] = i;
                        col--;
                    } while (col - 1 > -1 && spiral[row, col - 1] == 0);
                if (row - 1 > -1 && spiral[row, col] == 0)//вверх
                {
                    do
                    {
                        i++;
                        spiral[row, col] = i;
                        row--;
                    } while (row - 1 > -1 && spiral[row - 1, col] == 0);
                    FillZig(row, col);
                }
                
                else return;


            }
        }
    }
}
