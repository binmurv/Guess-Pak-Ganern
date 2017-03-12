namespace PakGanernVer3
{
    partial class menuForm
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
            this.quitBut = new System.Windows.Forms.Button();
            this.ruleBut = new System.Windows.Forms.Button();
            this.playBut = new System.Windows.Forms.Button();
            this.menuBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBut
            // 
            this.quitBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.quitBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBut.Location = new System.Drawing.Point(105, 456);
            this.quitBut.Name = "quitBut";
            this.quitBut.Size = new System.Drawing.Size(245, 52);
            this.quitBut.TabIndex = 11;
            this.quitBut.Text = "Quit";
            this.quitBut.UseVisualStyleBackColor = false;
            this.quitBut.Click += new System.EventHandler(this.quitBut_Click);
            // 
            // ruleBut
            // 
            this.ruleBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ruleBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruleBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleBut.Location = new System.Drawing.Point(105, 360);
            this.ruleBut.Name = "ruleBut";
            this.ruleBut.Size = new System.Drawing.Size(245, 52);
            this.ruleBut.TabIndex = 10;
            this.ruleBut.Text = "How To Play";
            this.ruleBut.UseVisualStyleBackColor = false;
            this.ruleBut.Click += new System.EventHandler(this.ruleBut_Click);
            // 
            // playBut
            // 
            this.playBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBut.Location = new System.Drawing.Point(105, 263);
            this.playBut.Name = "playBut";
            this.playBut.Size = new System.Drawing.Size(245, 52);
            this.playBut.TabIndex = 9;
            this.playBut.Text = "Play";
            this.playBut.UseVisualStyleBackColor = false;
            this.playBut.Click += new System.EventHandler(this.playBut_Click);
            // 
            // menuBackground
            // 
            this.menuBackground.BackColor = System.Drawing.Color.Transparent;
            this.menuBackground.BackgroundImage = global::PakGanernVer3.Properties.Resources.back1kwekadsads;
            this.menuBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuBackground.Location = new System.Drawing.Point(0, 0);
            this.menuBackground.Name = "menuBackground";
            this.menuBackground.Size = new System.Drawing.Size(884, 558);
            this.menuBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBackground.TabIndex = 12;
            this.menuBackground.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(468, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitBut);
            this.Controls.Add(this.ruleBut);
            this.Controls.Add(this.playBut);
            this.Controls.Add(this.menuBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.menuBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitBut;
        private System.Windows.Forms.Button ruleBut;
        private System.Windows.Forms.Button playBut;
        private System.Windows.Forms.PictureBox menuBackground;
        private System.Windows.Forms.Label label1;
    }
}

