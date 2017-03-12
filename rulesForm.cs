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
    public partial class rulesForm : Form
    {
        public rulesForm()
        {
            InitializeComponent();
        }

        private void menUBut_Click(object sender, EventArgs e)
        {
            menuForm menu = new menuForm();
            menu.Show();
            Visible = false;
        }
    }
}
