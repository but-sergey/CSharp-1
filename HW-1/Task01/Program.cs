// С#. Уровень 1
// Домашнее задание к уроку 1
// Бут Сергей
//
// === Задание 01 ===
// Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.


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
            Console.WriteLine("Пожалуйста, введите свои данные");
            
            Console.Write("Имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилия: ");
            string fname = Console.ReadLine();

            Console.Write("Возраст: ");
            string age = Console.ReadLine();

            Console.Write("Рост, cм: ");
            string height = Console.ReadLine();

            Console.Write("Вес, кг: ");
            string weight = Console.ReadLine();

            Console.WriteLine();
            // а
            Console.WriteLine(fname + " " + name + ". Возраст: " + age + ". Рост: " + height + " cм, вес: " + weight + " кг.");
            // б
            Console.WriteLine("{0} {1}. Возраст: {2}. Рост: {3} cм, вес: {4} кг.", fname, name, age, height, weight);
            // в
            Console.WriteLine($"{fname} {name}. Возраст: {age}. Рост: {height} cм, вес: {weight} кг.");

            Console.ReadLine();
        }
    }
}
