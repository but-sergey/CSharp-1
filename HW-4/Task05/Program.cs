// С#. Уровень 1
// Домашнее задание к уроку 4
// Бут Сергей
//
// === Задание 05 ===
//
// * а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать конструктор,
// заполняющий массив случайными числами.Создать методы, которые возвращают сумму всех элементов
// массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент
// массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального
// элемента массива(через параметры, используя модификатор ref или out).
// ** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
// ** в) Обработать возможные исключительные ситуации при работе с файлами.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubleDimArray;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDArray DArray = new MyDArray(10, 10, 0, 10);
            DArray.Print();
            Console.WriteLine();
            Console.WriteLine($"Сумма всех элементов: {DArray.Sum()}");
            Console.WriteLine($"Сумма всех элементов, больше 5: {DArray.SumBigger(5)}");
            Console.WriteLine($"Минимальный элемент массива: {DArray.Min}");
            int Row;
            int Col;
            DArray.MinIndex(out Row, out Col);
            Console.WriteLine($"Индекс первого минимального элемента: ({Row}, {Col})");
            Console.WriteLine($"Максимальный элемент массива: {DArray.Max}");
            DArray.MaxIndex(out Row, out Col);
            Console.WriteLine($"Индекс первого максимального элемента: ({Row}, {Col})");

            Console.ReadLine();
        }
    }
}
