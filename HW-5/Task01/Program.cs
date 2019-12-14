// С#. Уровень 1
// Домашнее задание к уроку 5
// Бут Сергей
//
// === Задание 01 ===
//
// Создать программу, которая будет проверять корректность ввода логина.
// Корректным логином будет строка от 2 до 10 символов, содержащая только
// буквы латинского алфавита или цифры, при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) с использованием регулярных выражений.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task01
{
    class Program
    {
        static bool CheckWithoutRegex(string login)
        {
            bool flag = true;
            int MaxLength = 10;
            int MinLength = 2;
            
            // Проверяем длину логина
            if ((login.Length >= MinLength) && (login.Length <= MaxLength))
            {
                // Проверяем первый символ
                char ch = login[0];
                if (((ch >= 'a') && (ch <= 'z')) ||
                    ((ch >= 'A') && (ch <= 'Z')))
                {
                    // Проверяем последующие символы
                    for (int i = 1; i < login.Length; i++)
                    {
                        ch = login[i];
                        if (!(((ch >= 'a') && (ch <= 'z')) ||
                              ((ch >= 'A') && (ch <= 'Z')) ||
                              ((ch >= '0') && (ch <= '9'))))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                else { flag = false; }
            }
            else { flag = false; }

            return flag;
        }

        static bool CheckWithRegex(string login)
        {
            Regex MyRegex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,9}$");
            return MyRegex.IsMatch(login);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            Console.Write("Проверка без использования регулярных выражений: ");
            Console.WriteLine($"Логин {(CheckWithoutRegex(login) ? "" : "не ")}корректный.");

            Console.Write("Проверка c использованием регулярных выражений: ");
            Console.WriteLine($"Логин {(CheckWithRegex(login) ? "" : "не ")}корректный.");

            Console.ReadLine();
        }
    }
}
