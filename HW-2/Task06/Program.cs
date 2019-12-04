// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 06 ===
// * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
// Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени
// выполнения программы, используя структуру DateTime.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static int sumDigits(int num)
        {
            int sum = 0;
            do
            {
                sum += num % 10;
                num /= 10;
            } while (num != 0);
            return sum;
        }

        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Итерация 1. Цикл for");
            
            DateTime start = DateTime.Now;
            
            for (int i = 1; i <= 1000000000; i++)
            {
                if (i % sumDigits(i) == 0)
                {
                    count++;
                }
            }

            DateTime finish = DateTime.Now;

            Console.WriteLine($"Количество хороших чисел - {count}");
            Console.WriteLine($"Время вычисления {finish - start}");
            Console.WriteLine();

            count = 0;
            Console.WriteLine("Итерация 2. Цикл while");

            start = DateTime.Now;

            int j = 1;
            
            while (j <= 1000000000)
            {
                if (j % sumDigits(j) == 0)
                {
                    count++;
                }
                j++;
            }

            finish = DateTime.Now;

            Console.WriteLine($"Количество хороших чисел - {count}");
            Console.WriteLine($"Время вычисления {finish - start}");

            Console.ReadLine();
        }
    }
}
