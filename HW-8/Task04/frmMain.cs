using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task04
{
    public partial class frmMain : Form
    {
        TrueFalse database;
        int QuestionNumber = 1;
        int Mistakes = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            frmAbout FormAbout = new frmAbout();
            FormAbout.ShowDialog();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetEnabled(bool enabled)
        {
            lblQuestionNumber.Visible = enabled;
            txtQuestion.Visible = enabled;
            btnYes.Enabled = enabled;
            btnNo.Enabled = enabled;
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                if(database.Count < 1)
                {
                    MessageBox.Show("База данных пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    QuestionNumber = 1;
                    ShowQuestion(QuestionNumber);
                    SetEnabled(true);
                }
            }
        }

        private void ShowQuestion(int num)
        {
            lblQuestionNumber.Text = $"Вопрос №{num}";
            txtQuestion.Text = database[num - 1].text;
        }

        private void NextQuestion()
        {
            QuestionNumber++;
            if (QuestionNumber <= database.Count)
            {
                ShowQuestion(QuestionNumber);
            }
            else
            {
                if (Mistakes == 0)
                {
                    MessageBox.Show("Вы ответили на все вопросы верно!!!", "Игра");
                }
                else
                {
                    MessageBox.Show($"Вы допустили ошибок: {Mistakes}. Попробуйте ещё раз!!", "Игра");
                }
                SetEnabled(false);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (!database[QuestionNumber-1].trueFalse)
            {
                Mistakes++;
            }
            NextQuestion();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (database[QuestionNumber-1].trueFalse)
            {
                Mistakes++;
            }
            NextQuestion();
        }
    }
}
