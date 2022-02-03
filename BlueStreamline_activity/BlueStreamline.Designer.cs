namespace BlueStreamline_activity
{
    partial class BlueStreamline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueStreamline));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNume = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.TextBox();
            this.txtboxNume = new System.Windows.Forms.TextBox();
            this.textboxNume = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1144, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNume
            // 
            this.lblNume.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.875F);
            this.lblNume.Location = new System.Drawing.Point(328, 517);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(176, 71);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // lblParola
            // 
            this.lblParola.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.875F);
            this.lblParola.Location = new System.Drawing.Point(328, 731);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(176, 71);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola";
            // 
            // txtboxNume
            // 
            this.txtboxNume.Location = new System.Drawing.Point(656, 606);
            this.txtboxNume.Name = "txtboxNume";
            this.txtboxNume.Size = new System.Drawing.Size(0, 31);
            this.txtboxNume.TabIndex = 3;
            // 
            // textboxNume
            // 
            this.textboxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F);
            this.textboxNume.Location = new System.Drawing.Point(676, 517);
            this.textboxNume.Name = "textboxNume";
            this.textboxNume.Size = new System.Drawing.Size(518, 58);
            this.textboxNume.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F);
            this.textBox1.Location = new System.Drawing.Point(328, 3744);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(518, 58);
            this.textBox1.TabIndex = 5;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F);
            this.textBoxParola.Location = new System.Drawing.Point(676, 731);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(518, 58);
            this.textBoxParola.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.875F);
            this.button1.Location = new System.Drawing.Point(186, 927);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(470, 164);
            this.button1.TabIndex = 7;
            this.button1.Text = "Check in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.875F);
            this.button2.Location = new System.Drawing.Point(847, 927);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(470, 164);
            this.button2.TabIndex = 8;
            this.button2.Text = "Check out";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2271, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(1440, 398);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 82;
            this.dgvUser.RowTemplate.Height = 33;
            this.dgvUser.Size = new System.Drawing.Size(880, 693);
            this.dgvUser.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.875F);
            this.textBox2.Location = new System.Drawing.Point(1440, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 71);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Cauta";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.875F);
            this.textBox3.Location = new System.Drawing.Point(1705, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(615, 58);
            this.textBox3.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(186, 835);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 62);
            this.button3.TabIndex = 13;
            this.button3.Text = "Add and check in";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BlueStreamline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2429, 1241);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textboxNume);
            this.Controls.Add(this.txtboxNume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BlueStreamline";
            this.ShowIcon = false;
            this.Text = "BlueStreamline";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.BlueStreamline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lblNume;
        private System.Windows.Forms.TextBox lblParola;
        private System.Windows.Forms.TextBox txtboxNume;
        private System.Windows.Forms.TextBox textboxNume;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
    }
}

