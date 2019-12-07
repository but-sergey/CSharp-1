// С#. Уровень 1
// Домашнее задание к уроку 2
// Бут Сергей
//
// === Задание 01-б ===
// б) Дописать класс Complex, добавив методы вычитания и
// произведения чисел.Проверить работу класса;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01b
{
    class Complex
    {
        private double re;
        private double im;

        public Complex()
        {
            this.re = 0;
            this.im = 0;
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex Plus(Complex x)
        {
            Complex y = new Complex();
            y.re = this.re + x.re;
            y.im = this.im + x.im;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y = new Complex();
            y.re = this.re - x.re;
            y.im = this.im - x.im;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y = new Complex();
            y.re = this.re * x.re - this.im * x.im;
            y.im = this.re * x.im + this.im * x.re;
            return y;
        }

        public Complex Div(Complex x)
        {
            Complex y = new Complex();
            y.re = (this.re * x.re + this.im * x.im) / (x.re * x.re + x.im * x.im);
            y.im = (x.re * this.im - this.re * x.im) / (x.re * x.re + x.im * x.im);
            return y;
        }

        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        public override string ToString()
        {
            return $"{this.re} + {this.im}i";
        }

        public void Input(string msg)
        {
            Console.WriteLine(msg);
            Console.Write("Действительная часть a = ");
            this.re = Convert.ToDouble(Console.ReadLine());
            Console.Write("Мнимая часть b = ");
            this.im = Convert.ToDouble(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор комплексных чисел");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление\n");
            Console.WriteLine("0 - выход");

            byte oper = Convert.ToByte(Console.ReadLine());

            Complex x = new Complex();
            Complex y = new Complex();
            Complex z = new Complex();

            if ((oper >= 1) && (oper <= 4))
            {
                x.Input("Введите первое число");
                y.Input("Введите второе число");
            }

            switch (oper)
            {
                case 0:
                    break;
                case 1:
                    z = x.Plus(y);
                    Console.WriteLine("Результат: (" + x.ToString() + ") + (" + y.ToString() + ") = " + z.ToString());
                    break;
                case 2:
                    z = x.Minus(y);
                    Console.WriteLine("Результат: (" + x.ToString() + ") - (" + y.ToString() + ") = " + z.ToString());
                    break;
                case 3:
                    z = x.Multi(y);
                    Console.WriteLine("Результат: (" + x.ToString() + ") * (" + y.ToString() + ") = " + z.ToString());
                    break;
                case 4:
                    z = x.Div(y);
                    Console.WriteLine("Результат: (" + x.ToString() + ") / (" + y.ToString() + ") = " + z.ToString());
                    break;
                default:
                    Console.WriteLine("Неверный ввод!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
