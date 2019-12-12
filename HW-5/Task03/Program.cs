// С#. Уровень 1
// Домашнее задание к уроку 5
// Бут Сергей
//
// === Задание 03 ===
//
// * Для двух строк написать метод, определяющий, является ли одна строка перестановкой
// другой.Регистр можно не учитывать:
// а) с использованием методов C#;
// б) * разработав собственный алгоритм.
// Например: badc являются перестановкой abcd.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static bool IsInversion1(string Str1, string Str2)
        {   // Базовые условия: длина не нулевая и равная у обоих строк
            if(Str1.Length != 0 || Str1.Length == Str2.Length)
            {   // Берем каждый символ первой строки
                for(int i = 0; i < Str1.Length; i++)
                {
                    // Переменная для копии второй строки без совпадающего символа
                    string Str2new = "";
                    // Пробегаемся по второй строке...
                    for (int j = 0; j < Str2.Length; j++)
                    {
                        // Условие удаления символа - символ первой строки равен очередному
                        // символу второй строки и текущая позиция второй строки равна длине
                        // уже скопированной части второй строки (никакой символ ещё не
                        // удалялся, удаляем только один символ за один проход).
                        // Если это условие не верно, то копируем очередной символ в копию
                        // второй строки, если не верно - то ничего не копируем, по сути,
                        // удаляем символ.
                        if ( !((Str1[i] == Str2[j]) && (j == Str2new.Length)) )
                        {
                            Str2new += Str2[j];
                        }
                    }
                    // Если длины второй строки и её копии равны (ни один символ не удален,
                    // т. к. совпадений не найдено) то значит, в первой строке есть символ,
                    // которого нет во второй. Выход из метода результатом false
                    if(Str2.Length == Str2new.Length)
                    {
                        return false;
                    }
                    // Копируем во вторую строку новую строку, в которой удален один символ
                    Str2 = Str2new;
                }
                // Оба цикла прошли, все символы первой строки найдены во второй,
                // Строки являются перестановкой друг друга
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsInversion2(string Str1, string Str2)
        {
            char[] CharArr1 = Str1.ToCharArray();
            char[] CharArr2 = Str2.ToCharArray();
            Array.Sort(CharArr1);
            Array.Sort(CharArr2);
            return Enumerable.SequenceEqual(CharArr1, CharArr2);
        }

        static void Main()
        {
            Console.Write("Введите первую строку: ");
            string Str1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string Str2 = Console.ReadLine();

            Console.WriteLine($"Алгоритм 1. Введеные строки {(IsInversion1(Str1, Str2) ? "" : "не ")}являются перестановками друг друга");
            Console.WriteLine($"Алгоритм 2. Введеные строки {(IsInversion2(Str1, Str2) ? "" : "не ")}являются перестановками друг друга");
            
            Console.ReadLine();
        }
    }
}
