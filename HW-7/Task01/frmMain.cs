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
        public int task;
        public int maxStep;
        public bool gameActive = false;
        Stack<int> Steps = new Stack<int>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void IncStep()
        {
            int step = int.Parse(lblStep.Text);
            int number = int.Parse(lblNumber.Text);

            step++;
            lblStep.Text = step.ToString();
            btnCancel.Enabled = true;

            if (number == task)
            {
                MessageBox.Show("Вы выиграли!", "Удвоитель", MessageBoxButtons.OK);
                GameReset();
            }
            else if (step == maxStep)
            {
                MessageBox.Show("Вы проиграли!", "Удвоитель", MessageBoxButtons.OK);
                GameReset();                
            }
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            Steps.Push(1);
            IncStep();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            Steps.Push(2);
            IncStep();
        }

        private void mnuGBegin_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            task = rnd.Next(90) + 10;
            int tNum = task;
            maxStep = 0;
            do
            {
                if(tNum%2 == 0) { tNum /= 2; }
                else { tNum -= 1; }
                maxStep++;
            } while (tNum!=1);
            
            lblTask.Text = task.ToString();
            lblMaxStep.Text = maxStep.ToString();
            lblNumber.Text = "1";
            lblStep.Text = "0";
            
            lblTask.Visible = true;
            lblTaskCaption.Visible = true;
            lblMaxStep.Visible = true;
            lblMaxStepCaption.Visible = true;

            gameActive = true;
        }

        private void GameReset()
        {
            lblNumber.Text = "1";
            lblStep.Text = "0";

            lblTask.Visible = false;
            lblTaskCaption.Visible = false;
            lblMaxStep.Visible = false;
            lblMaxStepCaption.Visible = false;

            gameActive = false;
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
            int lastStep = Steps.Pop();
            if (lastStep == 1)
            {
                lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
            }
            else if (lastStep == 2)
            {
                lblNumber.Text = (int.Parse(lblNumber.Text) / 2).ToString();
            }
            lblStep.Text = (int.Parse(lblStep.Text) - 1).ToString();
            if(lblStep.Text == "0")
            {
                btnCancel.Enabled = false;
            }
        }
    }
}
