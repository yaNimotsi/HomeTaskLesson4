using System;

namespace HomeTaskLesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа в строку, которые просумируются");
            string[] arrVals = Console.ReadLine().Replace('.',',').Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Сумма введенной последовательности = {SumAllVals(arrVals)}");

        }

        static double SumAllVals(string[] arrVals)
        {
            double sum = 0;
            double val;
            foreach(string str in arrVals)
            {
                bool isDouble = double.TryParse(str, out val);
                if (isDouble)
                {
                    sum += val;
                }
            }

            return sum;
        }
    }
}
