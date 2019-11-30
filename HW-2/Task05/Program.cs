// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 05 ===
// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
// массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
// б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свою массу в кг: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите свой рост в см: ");
            double height = Convert.ToDouble(Console.ReadLine());
            height /= 100;   // перевод в метры

            // а
            double imt = weight / (height * height);
            Console.Write($"Ваш ИМТ = {imt:F2}. ");

            if (imt <= 16.0)
                Console.WriteLine("У вас выраженный дефицит массы тела.");
            else if ((imt > 16.0) && (imt <= 18.5))
                Console.WriteLine("У вас недостаточная масса тела");
            else if ((imt > 18.5) && (imt <= 25.0))
                Console.WriteLine("У вас нормальная масса тела");
            else if ((imt > 25.0) && (imt <= 30.0))
                Console.WriteLine("У вас избыточная масса тела (предожирение)");
            else if ((imt > 30.0) && (imt <= 35.0))
                Console.WriteLine("У вас ожирение");
            else if ((imt > 35.0) && (imt <= 40.0))
                Console.WriteLine("У вас резкое ожирение");
            else if (imt > 40.0)
                Console.WriteLine("У вас очень резкое ожирение");

            // б
            double norm = 0;

            if (imt <= 18.5)
            {
                
                norm = 18.5 * height * height;
                Console.WriteLine($"Для того, чтобы прийти в норму, необходимо набрать {(norm - weight):F1} кг. Нормальная масса - от {norm:F1} кг.");
            }
            else if (imt > 25.0)
            {
                norm = 25.0 * height * height;
                Console.WriteLine($"Для того, чтобы прийти в норму, необходимо похудеть на {(weight - norm):F1} кг. Нормальная масса - до {norm:F1} кг.");
            }

            Console.ReadLine();
        }
    }
}
