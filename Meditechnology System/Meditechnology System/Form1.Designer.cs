namespace Meditechnology_System
{
    partial class Form1
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.showPassBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(386, 260);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(94, 28);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UsernameTxtBox.Location = new System.Drawing.Point(331, 156);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(209, 20);
            this.UsernameTxtBox.TabIndex = 8;
            this.UsernameTxtBox.Text = "Username";
            this.UsernameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTxtBox_KeyDown);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PasswordTxtBox.Location = new System.Drawing.Point(331, 208);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(192, 20);
            this.PasswordTxtBox.TabIndex = 9;
            this.PasswordTxtBox.Text = "Password";
            this.PasswordTxtBox.Enter += new System.EventHandler(this.PasswordTxtBox_Enter);
            this.PasswordTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTxtBox_KeyDown);
            this.PasswordTxtBox.Leave += new System.EventHandler(this.PasswordTxtBox_Leave);
            // 
            // showPassBTN
            // 
            this.showPassBTN.BackgroundImage = global::Meditechnology_System.Properties.Resources.cross_eye_icon;
            this.showPassBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPassBTN.Location = new System.Drawing.Point(520, 203);
            this.showPassBTN.Margin = new System.Windows.Forms.Padding(2);
            this.showPassBTN.Name = "showPassBTN";
            this.showPassBTN.Size = new System.Drawing.Size(27, 27);
            this.showPassBTN.TabIndex = 10;
            this.showPassBTN.UseVisualStyleBackColor = true;
            this.showPassBTN.Click += new System.EventHandler(this.showPassBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Meditechnology_System.Properties.Resources.MEDITECH;
            this.pictureBox1.Location = new System.Drawing.Point(421, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Meditechnology_System.Properties.Resources._1e390d2e6a21096b419e3e787618a95f;
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 371);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Meditechnology_System.Properties.Resources.image_removebg_preview__4_;
            this.pictureBox2.Location = new System.Drawing.Point(346, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 364);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.showPassBTN);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UsernameTxtBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEDITECH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox UsernameTxtBox;
		private System.Windows.Forms.TextBox PasswordTxtBox;
		private System.Windows.Forms.Button showPassBTN;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

