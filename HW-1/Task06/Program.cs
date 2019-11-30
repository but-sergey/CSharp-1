// С#. Уровень 1
// Домашнее задание к уроку 1
// Бут Сергей
//
// === Задание 06 ===
// * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Extras
    {
        static public void Print(int x, int y, string toOut)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(toOut);
        }

        static public void PrintLine(int x, int y, string toOut)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(toOut);
        }

        static public void PrintCenter(string toOut)
        {
            int x = (Console.WindowWidth - toOut.Length) / 2;
            int y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x, y);
            Console.Write(toOut);
        }

        static public void Pause()
        {
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Extras.PrintCenter("Сообщение в центре экрана");
            Extras.Print(0, 24, "Нажмите Enter для выхода...");
            Extras.Pause();
        }
    }
}
