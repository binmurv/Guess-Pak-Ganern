namespace PakGanernVer3
{
    partial class gameOverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.againBut = new System.Windows.Forms.Button();
            this.mEnuBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PakGanernVer3.Properties.Resources.gameover;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // againBut
            // 
            this.againBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.againBut.Font = new System.Drawing.Font("Dimitri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.againBut.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.againBut.Location = new System.Drawing.Point(83, 265);
            this.againBut.Name = "againBut";
            this.againBut.Size = new System.Drawing.Size(114, 35);
            this.againBut.TabIndex = 1;
            this.againBut.Text = "Play Again?";
            this.againBut.UseVisualStyleBackColor = true;
            this.againBut.Click += new System.EventHandler(this.againBut_Click);
            // 
            // mEnuBut
            // 
            this.mEnuBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mEnuBut.Font = new System.Drawing.Font("Dimitri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mEnuBut.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mEnuBut.Location = new System.Drawing.Point(319, 265);
            this.mEnuBut.Name = "mEnuBut";
            this.mEnuBut.Size = new System.Drawing.Size(114, 35);
            this.mEnuBut.TabIndex = 2;
            this.mEnuBut.Text = "Menu";
            this.mEnuBut.UseVisualStyleBackColor = true;
            this.mEnuBut.Click += new System.EventHandler(this.mEnuBut_Click);
            // 
            // gameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 365);
            this.Controls.Add(this.mEnuBut);
            this.Controls.Add(this.againBut);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gameOverForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button againBut;
        private System.Windows.Forms.Button mEnuBut;
    }
}