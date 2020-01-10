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
    public partial class frmAnswer : Form
    {
        public string Answer
        {
            get { return txtAnswer.Text; }
            set { txtAnswer.Text = value; }
        }

        public frmAnswer()
        {
            InitializeComponent();
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtAnswer_Enter(object sender, EventArgs e)
        {
            txtAnswer.Text = "";
        }
    }
}
