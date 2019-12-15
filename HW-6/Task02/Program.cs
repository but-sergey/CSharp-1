// С#. Уровень 1
// Домашнее задание к уроку 6
// Бут Сергей
//
// === Задание 02 ===
//
// Модифицировать программу нахождения минимума функции так, чтобы можно
// было передавать функцию в виде делегата.
// а) Сделать меню с различными функциями и представить пользователю выбор,
// для какой функции и на каком отрезке находить минимум.Использовать массив
// (или список) делегатов, в котором хранятся различные функции.
// б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
// Пусть она возвращает минимум через параметр(с использованием модификатора out). 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task02
{
    class Program
    {
        public delegate double Fun(double x);

        public static double myFunc (double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(string fileName, Fun F, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            double[] toOut = new double[0];
            double d;

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = br.ReadDouble();
                Array.Resize(ref toOut, toOut.Length + 1);
                toOut[toOut.Length - 1] = d;
            }
            min = toOut.Min();
            br.Close();
            fs.Close();
            return toOut;
        }

        static void Main(string[] args)
        {
            bool successful = false;
            int MaxFunNum = 6;
            Fun[] FunArr = new Fun[MaxFunNum];

            FunArr[0] = delegate (double x) { return Math.Sin(x); };
            FunArr[1] = delegate (double x) { return Math.Cos(x); };
            FunArr[2] = delegate (double x) { return x*x; };
            FunArr[3] = delegate (double x) { return Math.Pow(x, 3); };
            FunArr[4] = delegate (double x) { return Math.Exp(x); };
            FunArr[5] = delegate (double x) { return Math.Log(x); };

            int userFun = -1;
            do
            {
                Console.Clear();

                Console.WriteLine("Введите номер функции для поиска минимума (0 для выхода):");
                Console.WriteLine("1 - sin(x)");
                Console.WriteLine("2 - cos(x)");
                Console.WriteLine("3 - x^2");
                Console.WriteLine("4 - x^3");
                Console.WriteLine("5 - e^x");
                Console.WriteLine("6 - ln(x)");

                Console.Write("=> ");

                if(int.TryParse(Console.ReadLine(), out userFun))
                {
                    if((userFun >= 1) && (userFun <= MaxFunNum))
                    {
                        double min;
                        double max;
                        double step;

                        Console.Write("Минимальное значение аргумента: ");
                        string s_min = Console.ReadLine();
                        Console.Write("Максимальное значение аргумента: ");
                        string s_max = Console.ReadLine();
                        Console.Write("Шаг: ");
                        string s_step = Console.ReadLine();

                        if(double.TryParse(s_min, out min) && double.TryParse(s_max, out max) && double.TryParse(s_step, out step))
                        {
                            SaveFunc("data.bin", FunArr[userFun - 1], min, max, step);
                            double minFun;
                            double[] FunValues = Load("data.bin", out minFun);

                            Console.WriteLine("Значения функции:");
                            for(int i = 0; i < FunValues.Length; i++)
                            {
                                Console.WriteLine($"{FunValues[i],8:0.000}");
                            }
                            Console.WriteLine($"Минимальное значение функции на заданном промежутке: {minFun}");
                            successful = true;
                        }
                    }
                    else
                    {
                        successful = (userFun == 0);
                    }
                }

                if (!successful)
                {
                    Console.WriteLine("Ошибка...");
                    userFun = -1;
                }
                if(userFun != 0)
                {
                    Console.Write("Нажмите <Enter> для продолжения...");
                    Console.ReadLine();
                }

            } while (userFun != 0);
        }
    }
}
