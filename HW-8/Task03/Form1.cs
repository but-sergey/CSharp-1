// С#. Уровень 1
// Домашнее задание к уроку 8
// Бут Сергей
//
// === Задание 03 ===
//
// а) Создать приложение, показанное на уроке, добавив в него защиту от возможных
// ошибок (не создана база данных, обращение к несуществующему вопросу, открытие
// слишком большого файла и т.д.).
// б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив
// другие «косметические» улучшения на свое усмотрение.
// в) Добавить в приложение меню «О программе» с информацией о программе (автор,
// версия, авторские права и др.).
// г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы
// данных(элемент SaveFileDialog).


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
