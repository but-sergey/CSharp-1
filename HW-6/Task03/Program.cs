// С#. Уровень 1
// Домашнее задание к уроку 6
// Бут Сергей
//
// === Задание 03 ===
//
// Переделать программу Пример использования коллекций для решения следующих задач:
// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
// в) отсортировать список по возрасту студента;
// г) * отсортировать список по курсу и возрасту студента;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task03
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;

        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
    }

    class Program
    {
        static int MyDelegate1(Student st1, Student st2)
        {
            //в
            return (st1.age - st2.age);
        }

        static int MyDelegate2(Student st1, Student st2)
        {
            //г
            if (st1.course == st2.course)
            {
                return (st1.age - st2.age);
            }
            else
            {
                return (st1.course - st2.course);
            }
        }

        static void Main(string[] args)
        {
            //int bakalavr = 0;
            //int magistr = 0;

            int minAge = 18;
            int maxAge = 20;

            List<Student> list = new List<Student>();
            DateTime dt = DateTime.Now;

            int cource5 = 0;
            int cource6 = 0;
            int[] studCources = new int[6];

            StreamReader sr = new StreamReader("students_4.csv");
            int i = 0;
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    Student st = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]);
                    list.Add(st);
                    // Задание а
                    switch (st.course)
                    {
                        case 5: cource5++; break;
                        case 6: cource6++; break;
                    }
                    // Задание б
                    if ((st.age>=minAge) && (st.age <= maxAge))
                    {
                        if (st.course > studCources.Length) Array.Resize(ref studCources, st.course);
                        studCources[st.course - 1]++;
                    }
                    i++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Ошибка! ESC - прекратить выполнение программы (порция данных {i})");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            Console.WriteLine($"Всего студентов: {list.Count}\n");
            //Console.WriteLine($"Магистров: {magistr}");
            //Console.WriteLine($"Бакалавров: {bakalavr}");
            Console.WriteLine($"Количество студентов на 5 курсе: {cource5}");
            Console.WriteLine($"Количество студентов на 6 курсе: {cource6}\n");
            Console.WriteLine($"Распределение по курсам студентов в возрасте от {minAge} до {maxAge} лет:");
            for(int j = 0; j < studCources.Length; j++)
            {
                Console.WriteLine($"На {j+1} курсе {((studCources[j] == 0) ? "нет" : studCources[j].ToString())} студентов.");
            }

            //Console.WriteLine("Нажмите <Enter> для продолжения...");
            //Console.ReadLine();

            // в
            list.Sort(new Comparison<Student>(MyDelegate1));
            StreamWriter sw = new StreamWriter("students_sort1.csv");
            foreach(var v in list) { sw.WriteLine($"{v.firstName,20};{v.course,8};{v.age,8};"); }
            sw.Close();
            Console.WriteLine("\nСписок студентов, отсортированных по возрасту выведен в файл students_sort1.csv.");

            // г
            list.Sort(new Comparison<Student>(MyDelegate2));
            sw = new StreamWriter("students_sort2.csv");
            foreach (var v in list) { sw.WriteLine($"{v.firstName,20};{v.course,8};{v.age,8};"); }
            sw.Close();
            Console.WriteLine("Список студентов, отсортированных по курсу и возрасту выведен в файл students_sort2.csv.");

            Console.WriteLine($"\nВремя выполнения: {DateTime.Now - dt}");

            Console.WriteLine("\n\nНажмите любую клавишу (кроме Power или Reset)  для завершения...");
            Console.ReadKey();
        }
    }
}
