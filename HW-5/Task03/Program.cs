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
        static bool IsInversion(string Str1, string Str2)
        {
            bool Flag = true;
            if(Str1.Length == 0 || Str1.Length != Str2.Length)
            {
                Flag = false;
            }
            else
            {
                for(int i = 0; i < Str1.Length; i++)
                {
                    int Ind = Str2.IndexOf(Str1[i]);
                    if(Ind == -1)
                    {
                        Flag = false;
                        break;
                    }
                    else
                    {
                        Str2.Remove(Ind, 1);
                    }
                }
            }
            return Flag;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string Str1 = Console.ReadLine();

            Console.Write("Введите вторую строку: ");
            string Str2 = Console.ReadLine();

            Console.WriteLine("Вариант 1");
            
            Console.WriteLine($"Введеные строки {(IsInversion(Str1, Str2) ? "" : "не ")}являются перестановками");


            Console.WriteLine("Вариант 2");

            char[] CharArr1 = Str1.ToCharArray();
            char[] CharArr2 = Str2.ToCharArray();
            Array.Sort(CharArr1);
            Array.Sort(CharArr2);
            bool isInv = Enumerable.SequenceEqual(CharArr1, CharArr2);
            
            Console.WriteLine($"Введеные строки {(isInv ? "" : "не ")}являются перестановками");
            
            Console.ReadLine();
        }
    }
}
