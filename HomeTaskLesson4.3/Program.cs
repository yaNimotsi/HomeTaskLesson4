using System;

namespace HomeTaskLesson4._3
{
    enum Seasons 
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца(1-12)");
            int userVal = Convert.ToInt32(Console.ReadLine());
            Seasons seasons; 
            GetSeason(userVal, out seasons);

            Console.WriteLine(GetRussionSeason(seasons));
        }

        static void GetSeason(int monthNumber, out Seasons seasons)
        {
            seasons = Seasons.Autumn;   //Не понял как избавиться от первичного объявления
            switch (monthNumber)        //Что ref, что out требуют объявления переменной (в разным местах правда)
            {                           //Как правильно поступить?
                case 12:
                case 1:
                case 2:
                    seasons = Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    seasons = Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    seasons = Seasons.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    seasons = Seasons.Autumn;
                    break;
            }
        }

        static string GetRussionSeason(Seasons season)
        {

            string[] russiaSeasons = { "Зима", "Весна", "Лето", "Осень" };

            int seasonsNum = (int)season;

            if (seasonsNum > 0 && seasonsNum < 13)
            {
                return $"{russiaSeasons[seasonsNum]} соответствует введенному вами норме месяца";
            }
            return "Ошибка: введите число от 1 до 12";
        }
    }
}
