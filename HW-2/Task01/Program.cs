// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 01 ===
// Написать метод, возвращающий минимальное из трех чисел.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int min = a;

            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }

            Console.WriteLine($"Минимальное число: {min}");
            
            Console.ReadLine();
        }
    }
}
