// С#. Уровень 1
// Домашнее задание к уроку 1
// Бут Сергей
//
// === Задание 03 ===
// а) написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2
// по формуле r = math.sqrt(math.pow(x2 - x1, 2) + math.pow(y2 - y1, 2).вывести результат, используя
// спецификатор формата .2f(с двумя знаками после запятой);
// б) * выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }

        class Point
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета расстояния между двумя точками");

            Point p1 = new Point();
            Point p2 = new Point();

            Console.WriteLine("Координаты первой точки:");
            Console.Write("x1 = ");
            p1.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            p1.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Координаты второй точки:");
            Console.Write("x1 = ");
            p2.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            p2.y = Convert.ToInt32(Console.ReadLine());

            // а
            double r = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            Console.WriteLine($"Расстояние между точками: {r:F2}");

            // б
            Console.WriteLine($"Расстояние между точками: {Distance(p1, p2):F2}");

            Console.ReadLine();
        }
    }
}
