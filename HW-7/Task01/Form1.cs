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
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString;
        }
    }
}
