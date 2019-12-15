// С#. Уровень 1
// Домашнее задание к уроку 6
// Бут Сергей
//
// === Задание 01 ===
//
// Изменить программу вывода таблицы функции так, чтобы можно было передавать
// функции типа double (double, double). Продемонстрировать работу на функции
// с функцией a* x^2 и функцией a* sin(x).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public delegate double Fun(double a, double x);

    class Program
    {
        public static void Table2(Fun F, double a, double MaxA, double x, double MaxX)
        {
            double ta = a;
            Console.WriteLine("----- A -------- X ------- Y -----");
            while (ta <= MaxA)
            {
                double tx = x;
                while (tx <= MaxX)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", ta, tx, F(ta, tx));
                    tx++;
                }
                ta++;
            }
            Console.WriteLine("----------------------------------");
        }

        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table2(delegate (double a, double x) { return a * x * x; }, -2, 2, -2, 2);

            Console.WriteLine("Таблица функции a * sin(x):");
            Table2(MySin, -2, 2, -2, 2);

            Console.ReadLine();
        }
    }
}
