// С#. Уровень 1
// Домашнее задание к уроку 4
// Бут Сергей
//
// === Задание 02 ===
//
// Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
// в)** Добавьте обработку ситуации отсутствия файла на диске.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    static class ThreeCount
    {
        static public int ArrCountThree(int[] arr)
        {
            int counter = 0;
            
            for (int i = 1; i < arr.Length; i++)
            {
                int sumdiv = 0;

                sumdiv += (arr[i - 1] % 3 == 0) ? 1 : 0;
                sumdiv += (arr[i] % 3 == 0) ? 1 : 0;

                if (sumdiv == 1)
                {
                    counter++;
                }
            }

            return counter;
        }

        static public int ArrCountThree(int[] arr, ref int[] pairs)
        {
            int counter = ArrCountThree(arr);

            Array.Resize(ref pairs, counter);

            counter = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int sumdiv = 0;

                sumdiv += (arr[i - 1] % 3 == 0) ? 1 : 0;
                sumdiv += (arr[i] % 3 == 0) ? 1 : 0;

                if (sumdiv == 1)
                {
                    pairs[counter] = i - 1;
                    counter++;
                }
            }
            return counter;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int MinValue = -10000;
            int MaxValue = 10000;
            int[] arr = new int[20];
            var rand = new Random();
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(MinValue, MaxValue);
            }

            // Вариант 1 - без вывода самих пар
            counter = ThreeCount.ArrCountThree(arr);
            Console.WriteLine($"Вариант вызова без списка пар\nКоличество найденных пар: {counter}\n");

            // Вариант 2 - с выводом пар
            int[] pairs = new int[0];
            counter = ThreeCount.ArrCountThree(arr, ref pairs);
            Console.WriteLine($"Вариант вызова со списком пар\nКоличество найденных пар: {counter}");
            for(int i = 0; i < pairs.Length; i++)
            {
                Console.WriteLine($"Пара №{i+1}: {arr[i]}, {arr[i+1]}.");
            }

            Console.Write("\nИсходный массив: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]}{((i == arr.Length - 1) ? "." : ",")}");
            }

            Console.ReadLine();
        }
    }
}
