// С#. Уровень 1
// Домашнее задание к уроку 7
// Бут Сергей
//
// === Задание 01 ===
//
// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
// должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
// в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте
// обобщенный класс Stack.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
