// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 03 ===
// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;
            
            do
            {
                Console.Write("Введите число (для окончания введите 0): ");
                num = Convert.ToInt32(Console.ReadLine());
                if ((num > 0) && (num % 2 != 0))
                {
                    sum += num;
                }
            } while (num != 0);
            
            Console.WriteLine($"Сумма всех нечетных положительных чисел равна {sum}");
            
            Console.ReadLine();
        }
    }
}
