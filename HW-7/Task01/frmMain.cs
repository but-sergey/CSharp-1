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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    public partial class frmMain : Form
    {

        Doubler Dbl = new Doubler();

        public frmMain()
        {
            InitializeComponent();
            Dbl.NewGame();
            RefreshForm();
        }

        private void RefreshForm()
        {
            lblNumber.Text = Dbl.Number.ToString();
            lblStep.Text = Dbl.Step.ToString();
            lblTask.Text = Dbl.Task.ToString();
            lblMaxStep.Text = Dbl.MaxStep.ToString();
            btnCancel.Enabled = (Dbl.Step != 0);
            btnCommand1.Enabled = Dbl.Active;
            btnCommand2.Enabled = Dbl.Active;
            lblTask.Visible = Dbl.Active;
            lblTaskCaption.Visible = Dbl.Active;
            lblMaxStep.Visible = Dbl.Active;
            lblMaxStepCaption.Visible = Dbl.Active;

            if (Dbl.LostFlag)
            {
                Dbl.LostFlag = false;
                MessageBox.Show("Вы проиграли!", "Удвоитель", MessageBoxButtons.OK);
            }
            if (Dbl.WinFlag)
            {
                Dbl.WinFlag = false;
                MessageBox.Show("Вы выиграли!", "Удвоитель", MessageBoxButtons.OK);
            }
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            Dbl.DoIncrement();
            RefreshForm();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            Dbl.DoDouble();
            RefreshForm();
        }

        private void mnuGBegin_Click(object sender, EventArgs e)
        {
            Dbl.NewGame();
            RefreshForm();
        }

        private void GameReset()
        {
            Dbl.Reset();
            RefreshForm();
        }

        private void mnuGReset_Click(object sender, EventArgs e)
        {
            GameReset();
        }

        private void mnuFExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dbl.CancelStep();
            RefreshForm();
        }
    }
}
