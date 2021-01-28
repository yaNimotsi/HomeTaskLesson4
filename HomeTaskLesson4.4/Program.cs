using System;

namespace HomeTaskLesson4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nMax = GetMaxNum();

            Console.WriteLine($"Получено значение = {Fibonachi(nMax, 0)}");
        }

        static int GetMaxNum()
        {
            Console.WriteLine("Введите максимальный номер для вычисления значения");
            int nMax;
            return int.TryParse(Console.ReadLine(), out nMax) ? nMax : 0;
        }

        static int Fibonachi(int iMax, int i)
        {

            if (i == iMax)
            {
                return i;
            }
            return i + Fibonachi(iMax, ++i);
        }
    }
}
