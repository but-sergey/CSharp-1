// С#. Уровень 1
// Домашнее задание к уроку 1
// Бут Сергей
//
// === Задание 04 ===
// Написать программу обмена значениями двух переменных:
// а) с использованием третьей переменной;
// б) * без использования третьей переменной.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"{a} - {b}");
            
            // а
            int t = a;
            a = b;
            b = t;
            Console.WriteLine($"{a} - {b}");

            // б
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a} - {b}");

            Console.ReadLine();
        }
    }
}
