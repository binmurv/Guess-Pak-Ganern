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
    public partial class gameOverForm : Form
    {
        gameForm frm = new gameForm();
        menuForm menu = new menuForm();

        public gameOverForm()
        {
            InitializeComponent();
            
        }

        private void againBut_Click(object sender, EventArgs e)
        {
            frm.Show();
            Visible = false;
        }

        private void mEnuBut_Click(object sender, EventArgs e)
        {
            menu.Show();
            Visible = false;
        }
    }
}
