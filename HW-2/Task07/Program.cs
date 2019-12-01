// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 07 ===
// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
// б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Print(int min, int max)
        {
            if (min == max)
            {
                Console.WriteLine($"{min}.");
            }
            else if (min > max)
            {
                Console.WriteLine($"Ошибка в параметрах, {min} > {max}!");
            }
            else
            {
                Console.Write($"{min}, ");
                Print(min + 1, max);
            }
        }

        // рекурсивный подсчет суммы сделал без использования внешней переменной
        static int CalcSum(int min, int max, int sum = 0)
        {
            if (min == max)
            {
                return sum + min;
            }
            else if (min > max)
            {
                Console.WriteLine($"Ошибка в параметрах, {min} > {max}!");
                return 0;
            }
            else
            {
                return min + CalcSum(min + 1, max, sum);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Список чисел от {a} до {b}: ");
            Print(a, b);

            Console.WriteLine($"Сумма чисел от {a} до {b} равна {CalcSum(a, b)}");

            Console.ReadLine();
        }
    }
}
