// С#. Уровень 1
// Домашнее задание к уроку 7
// Бут Сергей
//
// === Задание 02 ===
//
// Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает
// число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
// Компьютер говорит, больше или меньше загаданное число введенного.
// a) Для ввода данных от человека используется элемент TextBox;
// б) ** Реализовать отдельную форму c TextBox для ввода числа.


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

        private int Number;
        private int Step;
        private int StepLimit1 = 7;
        private int StepLimit2 = 10;

        frmAnswer frmAns = new frmAnswer();

        private void btnStart_Click(object sender, EventArgs e)
        {
            Step = 0;
            Random rnd = new Random();
            Number = rnd.Next(1, 100);
            lblText1.Visible = true;
            btnAnswer.Enabled = true;
            lblStep.ForeColor = Color.Black;
            lblAnswer.Visible = false;
            lblResult.Visible = false;
            btnAnswer.Focus();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            frmAns.Top = this.Top + 25;
            frmAns.Left = this.Left + (this.Width - frmAns.Width) / 2;
            frmAns.Answer = "";
            frmAns.ShowDialog();

            if(frmAns.DialogResult == DialogResult.OK)
            {
                lblAnswer.Text = $"Вы ввели: {frmAns.Answer}";
                lblAnswer.Visible = true;

                int Answer;
                if(int.TryParse(frmAns.Answer, out Answer))
                {
                    if (Answer == this.Number)
                    {
                        lblResult.Text = "Вы угадали!!!";
                        btnAnswer.Enabled = false;
                    }
                    else
                    {
                        lblResult.Text = $"Это число {((Answer > this.Number) ? "больше" : "меньше")}, чем загаданное...";
                        Step++;
                        lblStep.Text = $"Использовано шагов: {Step}";
                        if (Step > StepLimit2) { lblStep.ForeColor = Color.Red; }
                        else if (Step > StepLimit1) { lblStep.ForeColor = Color.Orange; }
                    }

                    lblResult.Visible = true;
                    lblStep.Visible = true;
                }
                else
                {
                    lblResult.Visible = false;
                }
            }
        }
    }
}
