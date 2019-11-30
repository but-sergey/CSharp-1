// С#. Уровень 1
// Домашнее задание к уроку 1
// Бут Сергей
//
// === Задание 02 ===
// Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h);
// где m — масса тела в килограммах, h — рост в метрах.


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
            Console.Write("Ваша масса в килограммах: ");
            float weight = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Ваш рост в сантиметрах: ");
            float height = Convert.ToSingle(Console.ReadLine());

            float IMT = weight / (height * height / 10000);

            Console.WriteLine($"Ваш индекс массы тела (ИМТ): {IMT:F1}");

            Console.ReadLine();
        }
    }
}
