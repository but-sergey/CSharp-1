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

namespace Task04
{
    public partial class frmQuestions : Form
    {
        TrueFalse database;

        public frmQuestions()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAllEnabled(bool enabled)
        {
            miSave.Enabled = enabled;
            txtQuestion.Enabled = enabled;
            btnAdd.Enabled = enabled;
            btnDelete.Enabled = enabled;
            btnSave.Enabled = enabled;
            nudNumber.Enabled = enabled;
            chkTrue.Enabled = enabled;
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;

                SetAllEnabled(true);
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {

            txtQuestion.Text = database[(int)nudNumber.Value - 1].text;
            chkTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;
                nudNumber_ValueChanged(sender, e);
                if (nudNumber.Maximum == 1)
                {
                    btnDelete.Enabled = false;
                }
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;

                SetAllEnabled(true);
                btnDelete.Enabled = (database.Count > 1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].text = txtQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = chkTrue.Checked;
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            frmAbout FormAbout = new frmAbout();
            FormAbout.ShowDialog();
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    database.FileName = sfd.FileName;
                    database.Save();
                }
                else MessageBox.Show("База данных не создана");
            }
        }
    }
}
