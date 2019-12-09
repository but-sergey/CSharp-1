// С#. Уровень 1
// Домашнее задание к уроку 4
// Бут Сергей
//
// === Задание 03 ===
//
// а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
// массив определенного размера и заполняющий массив числами от начального значения с заданным
// шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse,
// возвращающий новый массив с измененными знаками у всех элементов массива(старый массив,
// остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое
// число, свойство MaxCount, возвращающее количество максимальных элементов.
// б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
// е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using MyArray;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Исходный массив: " + MyArray.Print(MyArray.Arr));
            //Console.WriteLine($"Сумма элементов: {MyArray.Sum}");
            //Console.WriteLine($"Количество максимальных элементов: {MyArray.MaxCount}\n");

            //MyArray.Arr = MyArray.Inverse(MyArray.Arr);
            //Console.WriteLine($"Инвертированный массив: {MyArray.Print(MyArray.Arr)}");

            //MyArray.Multi(MyArray.Arr, 5);
            //Console.WriteLine($"Массив, умноженный на 5: {MyArray.Print(MyArray.Arr)}");

            Console.ReadLine();
        }
    }
}
