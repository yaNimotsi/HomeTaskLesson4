using System;

namespace HomeTaskLesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usersInfoArr = new string[4];

            int i = 0;
            while(i <= 3)
            {
                usersInfoArr[i] = UserInfo();
                i++;
            }

            Console.Clear();

            foreach(string str in usersInfoArr)
            {
                PrinUser(str);
            }

            Console.ReadLine();
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return ($"{firstName} {lastName} {patronymic}");
        }

        static string GetUserInfo(string massege)
        {
            Console.WriteLine(massege);
            return Console.ReadLine();
        }

        static string UserInfo()
        {
            string firstName = GetUserInfo("Введите фамилию");
            string lastName = GetUserInfo("Введите имя");
            string patronymic = GetUserInfo("Введите отчество");

            Console.WriteLine();

            return GetFullName(firstName, lastName, patronymic);
        }

        static void PrinUser(string str)
        {
            Console.WriteLine(str);
        }
    }
}
