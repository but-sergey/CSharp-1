﻿// С#. Уровень 1
// Домашнее задание к уроку 8
// Бут Сергей
//
// === Задание 02 ===
//
// Создайте простую форму на котором свяжите свойство Text элемента
// TextBox со свойством Value элемента NumericUpDown


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nudValue_ValueChanged(object sender, EventArgs e)
        {
            txtValue.Text = nudValue.Value.ToString();
        }
    }
}
