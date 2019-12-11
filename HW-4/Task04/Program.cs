// С#. Уровень 1
// Домашнее задание к уроку 4
// Бут Сергей
//
// === Задание 04 ===
//
// Решить задачу с логинами из урока 2, только логины и пароли считать из файла в
// массив.Создайте структуру Account, содержащую Login и Password.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task04
{
    public struct Account
    {
        public string Login;
        public string Password;
    }

    class Program
    {
        static bool Check(Account UserInfo)
        {
            return ((UserInfo.Login == "root") && (UserInfo.Password == "GeekBrains"));
        }

        static void Main(string[] args)
        {
            string FileName = "users.txt";
            if (!File.Exists(FileName))
            {
                Console.WriteLine($"Файл {FileName} не найден!");
            }
            else
            {
                string[] FileLines = File.ReadAllLines(FileName);
                Account[] Users = new Account[FileLines.Length];
                
                for (int i = 0; 2*i+1 < FileLines.Length; i++)
                {
                    Users[i].Login = FileLines[2 * i];
                    Users[i].Password = FileLines[2 * i + 1];

                    Console.WriteLine($"Пользователь {Users[i].Login}/{Users[i].Password} - доступ {(Check(Users[i]) ? "разрешен" : "запрещен")}");
                }
            }
            
            Console.ReadLine();
        }
    }
}
