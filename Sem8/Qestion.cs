using System;

namespace Sem8
{
    internal class Qestion
    {
        internal static void Start()
        {
            Console.WriteLine("Хотите запустить что-то еще?(+ или ентер)");
            string answer = Console.ReadLine();
            string v = "+";
            if (answer == v)
            {
                Console.Clear();
                Program.Main();
            }
        }
    }
}