using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOnePlayerMode_Click(object sender, EventArgs e)
        {
            frmApp frmApp = new frmApp();
            this.Hide();
            frmApp.ShowDialog();
            Application.Exit();

        }
    }
}
