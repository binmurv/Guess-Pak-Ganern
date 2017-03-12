using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PakGanernVer3
{
    public partial class menuForm : Form
    {

        public menuForm()
        {
            InitializeComponent();
        }


        private void playBut_Click(object sender, EventArgs e)
        {
            gameForm frm = new gameForm();
            frm.Show();
            this.Visible = false;
        }
        private void ruleBut_Click(object sender, EventArgs e)
        {
            rulesForm rul = new rulesForm();
            rul.Show();
        }

        private void quitBut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit game ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

       
    }
}
