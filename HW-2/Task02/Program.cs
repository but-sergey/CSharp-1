// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 02 ===
// Написать метод подсчета количества цифр числа.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int num = userNum;
            int numbers = 1;
            
            while(num >= 10)
            {
                num = num / 10;
                numbers++;
            }

            Console.WriteLine($"Число {userNum} состоит из {numbers} цифр.");

            Console.ReadLine();
        }
    }
}
