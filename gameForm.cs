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
    public partial class gameForm : Form
    {
        public string text, word;
        public char letter;
        public int ctr = 0, curPoints, points, count;
        public char[] a;

        string[] words = {
        "critical",
        "accident",
        "sun",
        "calendar",
        "family",
        "profile",
        "birtmark",
        "robotic",
        "color", 
        "cuddle",
        "mohawk",
        "fatality",
        "breathless",
        "hungry",
        "useless",
        "emergency",
        "dead",
        "disease",
        "doomsday",
        "cannibalism"
            
        };

        public gameForm()
        {
            InitializeComponent();
            round();
        }
        

        public void round()
        {
            
            Random r = new Random();
            enableBut();
            
            label2.Text = "";
            label1.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label10.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
            int num = r.Next(0, 20);
            word = words[num];
            label3.Text = word;
            a = new Char[word.Length];
            curPoints = 100;
            ctr = 0;
            count = 0;
            scoreLabel.Text = "Score: " + points;
            

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = '_';
            }

            for (int i = 0; i < a.Length; i++)
            {

                label2.Text += a[i] + "  ";

            }



        }

        
        public void wordcheck()
        {
            menuBut.Select();
            if (word.Contains(letter))
            {
                char[] leWord = word.ToCharArray();
                label2.Text = " ";
                for (int i = 0; i < leWord.Length; i++)
                {

                    if (leWord[i] == letter)
                    {
                        count++;
                        a[i] = letter;
                    }
                }

                for (int i = 0; i < a.Length; i++)
                {

                    label2.Text += a[i] + "  ";

                }
                if (count == word.Length)
                {
                    menuBut.Select();

                    points += curPoints;
                    MessageBox.Show("CORRECT!!! your total score is: " + points);

                    disableBut();
                    enableBut();

                    round();

                }

            }
            else
            {
                ctr++;
                if (ctr < 9)
                {
                    curPoints -= 10;

                    switch (ctr)
                    {
                        case 1: label1.Text = "P";
                            label1.ForeColor = Color.Red;
                                break;
                        case 2: label4.Text = "A";
                            label1.ForeColor = Color.Orange;
                            break;
                        case 3: label5.Text = "K";
                            label1.ForeColor = Color.Yellow;
                            break;
                        case 4: label6.Text = "G";
                            label1.ForeColor = Color.YellowGreen;
                            break;
                        case 5: label7.Text = "A";
                            label1.ForeColor = Color.Green;
                            break;
                        case 6: label8.Text = "N";
                            label1.ForeColor = Color.Blue;
                            break;
                        case 7: label9.Text = "E";
                            label1.ForeColor = Color.Indigo;
                            break;
                        case 8: label10.Text = "R";
                            label1.ForeColor = Color.BlueViolet;
                            break;

                    }
                }
                else
                {
                    label11.Text = "N";
                    label11.ForeColor = Color.Violet;
                    label12.Text = "!";
                    label12.ForeColor = Color.Violet;
                    gameOverForm gmovr = new gameOverForm();
                    gmovr.Show();
                    this.Enabled = false;

                }
            }
        }
        private void qBut_Click(object sender, EventArgs e)
        {
            letter = 'q';
            wordcheck();
            wBut.Enabled = false;
        }

        private void wBut_Click(object sender, EventArgs e)
        {
            letter = 'w';
            wordcheck();
            wBut.Enabled = false;
        }

        private void eBut_Click(object sender, EventArgs e)
        {
            letter = 'e';
            wordcheck();
            eBut.Enabled = false;
        }

        private void rBut_Click(object sender, EventArgs e)
        {
            letter = 'r';
            wordcheck();
            rBut.Enabled = false;
        }

        private void tBut_Click(object sender, EventArgs e)
        {
            letter = 't';
            wordcheck();
            tBut.Enabled = false;
        }

        private void yBut_Click(object sender, EventArgs e)
        {
            letter = 'y';
            wordcheck();
            yBut.Enabled = false;
        }

        private void uBut_Click(object sender, EventArgs e)
        {
            letter = 'u';
            wordcheck();
            uBut.Enabled = false;
        }

        private void iBut_Click(object sender, EventArgs e)
        {
            letter = 'i';
            wordcheck();
            iBut.Enabled = false;
        }

        private void oBut_Click(object sender, EventArgs e)
        {
            letter = 'o';
            wordcheck();
            oBut.Enabled = false;
        }

        private void pBut_Click(object sender, EventArgs e)
        {
            letter = 'p';
            wordcheck();
            pBut.Enabled = false;
        }

        private void aBut_Click(object sender, EventArgs e)
        {
            letter = 'a';
            wordcheck();
            aBut.Enabled = false;
        }

        private void sBut_Click(object sender, EventArgs e)
        {
            letter = 's';
            wordcheck();
            sBut.Enabled = false;
        }

        private void dBut_Click(object sender, EventArgs e)
        {
            letter = 'd';
            wordcheck();
            dBut.Enabled = false;
        }

        private void fBut_Click(object sender, EventArgs e)
        {
            letter = 'f';
            wordcheck();
            fBut.Enabled = false;
        }

        private void gBut_Click(object sender, EventArgs e)
        {
            letter = 'g';
            wordcheck();
            gBut.Enabled = false;
        }

        private void hBut_Click(object sender, EventArgs e)
        {
            letter = 'h';
            wordcheck();
            hBut.Enabled = false;
        }

        private void jBut_Click(object sender, EventArgs e)
        {
            letter = 'j';
            wordcheck();
            jBut.Enabled = false;
        }

        private void kBut_Click(object sender, EventArgs e)
        {
            letter = 'k';
            wordcheck();
            kBut.Enabled = false;
        }

        private void lBut_Click(object sender, EventArgs e)
        {
            letter = 'l';
            wordcheck();
            lBut.Enabled = false;
        }

        private void zBut_Click(object sender, EventArgs e)
        {
            letter = 'z';
            wordcheck();
            zBut.Enabled = false;
        }

        private void xBut_Click(object sender, EventArgs e)
        {
            letter = 'x';
            wordcheck();
            xBut.Enabled = false;
        }

        private void cBut_Click(object sender, EventArgs e)
        {
            letter = 'c';
            wordcheck();
            cBut.Enabled = false;
        }

        private void vBut_Click(object sender, EventArgs e)
        {
            letter = 'v';
            wordcheck();
            vBut.Enabled = false;
        }

        private void bBut_Click(object sender, EventArgs e)
        {
            letter = 'b';
            wordcheck();
            bBut.Enabled = false;
        }

        private void nBut_Click(object sender, EventArgs e)
        {
            letter = 'n';
            wordcheck();
            nBut.Enabled = false;
        }

        private void mBut_Click(object sender, EventArgs e)
        {
            letter = 'm';
            wordcheck();
            mBut.Enabled = false;
        }

        private void menuBut_Click(object sender, EventArgs e)
        {
            menuForm menu = new menuForm();
            if (MessageBox.Show("Are you sure? Your progress will be lost", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                menu.Show();
                this.Visible = false;
            }
           
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void qBut_MouseClick(object sender, MouseEventArgs e)
        {
            Button but = sender as Button;
            letter = char.ToLower(but.Text[0]);
            but.Enabled = false;
            wordcheck();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enableBut()
        {
            foreach(Button but in this.keypanel.Controls.OfType<Button>())
            {
                but.Enabled = true;
            }

        }
        private void disableBut()
        {
            foreach (Button but in this.keypanel.Controls)
            {
                but.Enabled = false;
            }

        }
    }
}
