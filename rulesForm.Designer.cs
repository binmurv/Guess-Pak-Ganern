namespace PakGanernVer3
{
    partial class rulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rulesForm));
            this.ruleText = new System.Windows.Forms.TextBox();
            this.howLabel = new System.Windows.Forms.Label();
            this.menUBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ruleText
            // 
            this.ruleText.BackColor = System.Drawing.Color.White;
            this.ruleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ruleText.Enabled = false;
            this.ruleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleText.Location = new System.Drawing.Point(21, 66);
            this.ruleText.Multiline = true;
            this.ruleText.Name = "ruleText";
            this.ruleText.Size = new System.Drawing.Size(395, 355);
            this.ruleText.TabIndex = 0;
            this.ruleText.Text = resources.GetString("ruleText.Text");
            this.ruleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // howLabel
            // 
            this.howLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.howLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howLabel.Location = new System.Drawing.Point(19, 10);
            this.howLabel.Name = "howLabel";
            this.howLabel.Size = new System.Drawing.Size(396, 56);
            this.howLabel.TabIndex = 1;
            this.howLabel.Text = "How To Play";
            this.howLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menUBut
            // 
            this.menUBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menUBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menUBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menUBut.Location = new System.Drawing.Point(116, 436);
            this.menUBut.Name = "menUBut";
            this.menUBut.Size = new System.Drawing.Size(192, 38);
            this.menUBut.TabIndex = 2;
            this.menUBut.Text = "Back to menu";
            this.menUBut.UseVisualStyleBackColor = false;
            this.menUBut.Click += new System.EventHandler(this.menUBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PakGanernVer3.Properties.Resources.pbg002_dot_4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 489);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 486);
            this.Controls.Add(this.menUBut);
            this.Controls.Add(this.howLabel);
            this.Controls.Add(this.ruleText);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rulesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ruleText;
        private System.Windows.Forms.Label howLabel;
        private System.Windows.Forms.Button menUBut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}