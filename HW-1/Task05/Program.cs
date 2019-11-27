// С#. Уровень 1
// Домашнее задание к уроку 1
// Бут Сергей
//
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) * Сделать задание а, только вывод организовать в центре экрана.
// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Print(int x, int y, string toOut)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(toOut);
        }

        static void Main(string[] args)
        {
            Console.Write("Ваше имя и фамилия: ");
            string name = Console.ReadLine();

            Console.Write("Город проживания: ");
            string city = Console.ReadLine();

            string toOut = $"{name}, {city}";

            // а
            Console.WriteLine(toOut);
            
            // б
            int outX = (Console.WindowWidth - toOut.Length) / 2;
            int outY = Console.WindowHeight / 2;
            Console.SetCursorPosition(outX, outY - 1);  // outY - 1 чтобы ниже вывести строку из пункта в
            Console.Write(toOut);

            // в
            Print(outX, outY, toOut);

            Console.ReadLine();
        }
    }
}
