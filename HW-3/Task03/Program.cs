// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 03 ===
// * Описать класс дробей - рациональных чисел, являющихся отношением
// двух целых чисел.Предусмотреть методы сложения, вычитания, умножения
// и деления дробей. Написать программу, демонстрирующую все разработанные
// элементы класса.
// ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
// ArgumentException("Знаменатель не может быть равен 0");
// Добавить упрощение дробей.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Fraction
    {
        private int integer;
        private int numer;
        private int denom;

        public Fraction()
        {
            this.integer = 0;
            this.numer = 0;
            this.denom = 1;
        }

        public Fraction(int numer, int denom)
        {
            this.integer = 0;
            this.numer = numer;
            this.denom = denom;
            Check();
        }

        public Fraction(int integer, int numer, int denom)
        {
            this.integer = integer;
            this.numer = numer;
            this.denom = denom;
            Check();
        }

        private void Check()
        {
            if (this.denom == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
        }

        private static void swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        private void Simple()
        {
            this.Check();

            int a = this.numer;
            int b = this.denom;

            // Поиск НОД
            if (a != 0)
            {
                if (a < b) { swap(ref a, ref b); }

                while (a % b != 0)
                {
                    b = a % b;
                    if (a < b) { swap(ref a, ref b); }
                }

                // Деление на НОД
                this.numer /= b;
                this.denom /= b;

                // Выделение целой части
                this.integer += this.numer / this.denom;
                this.numer = this.numer % this.denom;
            }
        }

        public Fraction Plus(Fraction x)
        {
            Fraction a = new Fraction(this.integer, this.numer, this.denom);
            Fraction b = new Fraction(x.integer, x.numer, x.denom);
            Fraction c = new Fraction();

            c.integer = a.integer + b.integer;
            c.numer = a.numer * b.denom + b.numer * a.denom;
            c.denom = a.denom * b.denom;
            
            c.Simple();
            
            return c;
        }

        public Fraction Minus(Fraction x)
        {
            Fraction a = new Fraction(this.integer, this.numer, this.denom);
            Fraction b = new Fraction(x.integer, x.numer, x.denom);
            Fraction c = new Fraction();

            c.integer = a.integer - b.integer;
            c.numer = a.numer * b.denom - b.numer * a.denom;
            c.denom = a.denom * b.denom;

            c.Simple();

            return c;
        }

        public Fraction Multi(Fraction x)
        {
            Fraction a = new Fraction(this.integer, this.numer, this.denom);
            Fraction b = new Fraction(x.integer, x.numer, x.denom);
            Fraction c = new Fraction();

            // Избавление от целой части
            a.numer += a.integer * a.denom;
            b.numer += b.integer * b.denom;

            c.numer = a.numer * b.numer;
            c.denom = a.denom * b.denom;
            
            c.Simple();
            
            return c;
        }

        public Fraction Div(Fraction x)
        {
            Fraction a = new Fraction(this.integer, this.numer, this.denom);
            Fraction b = new Fraction(x.integer, x.numer, x.denom);
            Fraction c = new Fraction();

            // Избавление от целой части
            a.numer += a.integer * a.denom;
            b.numer += b.integer * b.denom;

            c.numer = a.numer * b.denom;
            c.denom = a.denom * b.numer;
            
            c.Simple();
            
            return c;
        }

        public int Num
        {
            get { return this.numer; }
            set { this.numer = value; }
        }

        public int Denom
        {
            get { return this.denom; }
            set { this.denom = value; }
        }

        public override string ToString()
        {
            string toOut;

            if (this.numer == 0)
            {
                toOut = $"{this.integer}";
            }
            else
            {
                if (this.integer == 0)
                {
                    toOut = $"{this.numer}/{this.denom}";
                }
                else
                {
                    toOut = $"{this.integer} {this.numer}/{this.denom}";
                }
            }
            if (this.numer == 0)
            {
                return toOut;
            }
            else
            {
                return "(" + toOut + ")";
            }
        }

        public void Input(string msg, bool needInteger = false)
        {
            if (msg.Length != 0) 
            { 
                Console.WriteLine(msg); 
            }
            if (needInteger)
            {
                Console.Write("Целая часть: ");
                this.integer = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Числитель: ");
            this.numer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Знаменатель: ");
            this.denom = Convert.ToInt32(Console.ReadLine());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            bool needBrackets = true;

            Console.WriteLine("Калькулятор дробных чисел");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление\n");
            Console.WriteLine("0 - выход");

            byte oper = Convert.ToByte(Console.ReadLine());

            Fraction x = new Fraction();
            Fraction y = new Fraction();
            Fraction z = new Fraction();

            if ((oper >= 1) && (oper <= 4))
            {
                x.Input("Введите первую дробь", true);
                y.Input("Введите вторую дробь", true);
            }

            switch (oper)
            {
                case 0:
                    break;
                case 1:
                    z = x.Plus(y);
                    Console.WriteLine("Результат: " + x.ToString() + " + " + y.ToString() + " = " + z.ToString());
                    break;
                case 2:
                    z = x.Minus(y);
                    Console.WriteLine("Результат: " + x.ToString() + " - " + y.ToString() + " = " + z.ToString());
                    break;
                case 3:
                    z = x.Multi(y);
                    Console.WriteLine("Результат: " + x.ToString() + " * " + y.ToString() + " = " + z.ToString());
                    break;
                case 4:
                    z = x.Div(y);
                    Console.WriteLine("Результат: " + x.ToString() + " / " + y.ToString() + " = " + z.ToString());
                    break;
                default:
                    Console.WriteLine("Неверный ввод!");
                    break;
            }

            Console.ReadKey();

        }
    }
}
