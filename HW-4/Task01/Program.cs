// С#. Уровень 1
// Домашнее задание к уроку 4
// Бут Сергей
//
// === Задание 01 ===
//
// Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать 
// целые значения  от –10 000 до 10 000 включительно.Заполнить случайными числами.
// Написать программу, позволяющую найти и вывести количество пар элементов массива,
// в которых только одно число делится на 3. В данной задаче под парой подразумевается
// два подряд идущих элемента массива.Например, для массива из пяти элементов:
// 6; 2; 9; –3; 6 ответ — 2. 


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
            int MinValue = -10000;
            int MaxValue = 10000;
            int[] arr = new int[20];
            var rand = new Random();
            int counter = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(MinValue, MaxValue);

                if (i != 0)
                {
                    int sumdiv = 0;
                    sumdiv += (arr[i - 1] % 3 == 0) ? 1 : 0;
                    sumdiv += (arr[i] % 3 == 0) ? 1 : 0;
                    if (sumdiv == 1)
                    {
                        counter++;
                        Console.WriteLine($"Пара №{counter}: {arr[i - 1]}, {arr[i]}.");
                    }
                }
            }
            Console.WriteLine($"\nИтого {counter} пар.\n");

            Console.Write("Исходный массив:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]}{((i == arr.Length - 1) ? "." : ",")}");
            }

            Console.ReadLine();
        }
    }
}
