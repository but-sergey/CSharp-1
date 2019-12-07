// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 02 ===
// а) С клавиатуры вводятся числа, пока не будет введен 0
// (каждое число в новой строке). Требуется подсчитать сумму
// всех нечетных положительных чисел. Сами числа и сумму вывести
// на экран, используя tryParse;
// б) Добавить обработку исключительных ситуаций на то, что могут
// быть введены некорректные данные.При возникновении ошибки
// вывести сообщение.Напишите соответствующую функцию;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static int TryInput()
        {
            int num;
            bool flag;

            do
            {
                flag = int.TryParse(Console.ReadLine(), out num);
                if (!flag)
                {
                    Console.WriteLine("Неверный ввод!");
                }
            } while (!flag);

            return num;
        }

        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            string numbers = "";

            Console.WriteLine("Введите числа (0 - для окончания ввода)");
            do
            {
                num = TryInput();
                if ((num > 0) && (num % 2 != 0))
                {
                    sum += num;
                    if(numbers.Length == 0)
                    {
                        numbers = num.ToString();
                    }
                    else
                    {
                        numbers += $", {num}";
                    }
                }
            } while (num != 0);

            Console.WriteLine("Введены следующие нечетные положительные числа: " + numbers);
            Console.WriteLine($"Их сумма равна {sum}");
            
            Console.ReadLine();
        }
    }
}
