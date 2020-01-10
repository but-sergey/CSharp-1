// С#. Уровень 1
// Домашнее задание к уроку 8
// Бут Сергей
//
// === Задание 01 ===
//
// С помощью рефлексии выведите все свойства структуры DateTime


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task01
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static void PrintPos(int x, int y, string message)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }

        static void PrintPropInfo(int line, object obj, string prop)
        {
            PrintPos(0, line, prop);
            PrintPos(15, line, GetPropertyInfo(obj, prop).CanRead.ToString());
            PrintPos(30, line, GetPropertyInfo(obj, prop).CanWrite.ToString());
            PrintPos(45, line, (GetPropertyInfo(obj, prop).GetValue(obj, null).ToString()));
        }

        static void Main(string[] args)
        {
            PrintPos(0, 0, "PropName");
            PrintPos(15, 0, "CanRead");
            PrintPos(30, 0, "CanWrite");
            PrintPos(45, 0, "Value");
            
            // DateTime dateTime = new DateTime();
            DateTime dateTime = DateTime.Now;

            int i = 2;

            PrintPropInfo(i, dateTime, "Date"); i++;
            PrintPropInfo(i, dateTime, "Day"); i++;
            PrintPropInfo(i, dateTime, "DayOfWeek"); i++;
            PrintPropInfo(i, dateTime, "DayOfYear"); i++;
            PrintPropInfo(i, dateTime, "Hour"); i++;
            PrintPropInfo(i, dateTime, "Kind"); i++;
            PrintPropInfo(i, dateTime, "Millisecond"); i++;
            PrintPropInfo(i, dateTime, "Minute"); i++;
            PrintPropInfo(i, dateTime, "Month"); i++;
            PrintPropInfo(i, dateTime, "Second"); i++;
            PrintPropInfo(i, dateTime, "Ticks"); i++;
            PrintPropInfo(i, dateTime, "TimeOfDay"); i++;
            PrintPropInfo(i, dateTime, "Year");

            Console.ReadKey();
        }

    }
}
