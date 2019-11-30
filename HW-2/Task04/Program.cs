// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 04 ===
// Реализовать метод проверки логина и пароля.На вход подается логин и пароль.
// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root,
// Password: GeekBrains). Используя метод проверки логина и пароля, написать программу:
// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
// С помощью цикла do while ограничить ввод пароля тремя попытками.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static bool Check(string user, string pass)
        {
            return ((user == "root") && (pass == "GeekBrains"));
        }

        static string getAttemptsString(int num)
        {
            switch (num)
            {
                case 1:
                    return $"Осталась {num} попытка";
                case 2:
                case 3:
                case 4:
                    return $"Осталось {num} попытки";
                default:
                    return $"Осталось {num} попыток";

            }
        }

        static void Main(string[] args)
        {
            string user = "";
            string pass = "";
            
            int count = 0;
            int maxCount = 3;

            do
            {
                count++;
                
                Console.Clear();
                
                if (count == 1)
                    Console.WriteLine($"Введите данные для входа. {getAttemptsString(maxCount)}");
                else
                    Console.WriteLine($"Данные не верны. Повторите ввод. {getAttemptsString(maxCount - count + 1)}");

                Console.Write("Пользователь: ");
                user = Console.ReadLine();
                Console.Write("Пароль: ");
                pass = Console.ReadLine();

                if (count == maxCount) break;

            } while (! Check(user, pass));

            if (Check(user, pass))
                Console.WriteLine("Доступ разрешен!");
            else
                Console.WriteLine("ДОСТУП ЗАПРЕЩЕН!!!");

            Console.ReadLine();
        }
    }
}
