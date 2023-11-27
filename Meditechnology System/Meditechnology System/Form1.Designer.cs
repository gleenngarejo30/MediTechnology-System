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
			this.label3 = new System.Windows.Forms.Label();
			this.UsernameTxtBox = new System.Windows.Forms.TextBox();
			this.PasswordTxtBox = new System.Windows.Forms.TextBox();
			this.showPassBTN = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// LoginBtn
			// 
			this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.LoginBtn.ForeColor = System.Drawing.Color.White;
			this.LoginBtn.Location = new System.Drawing.Point(579, 400);
			this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(141, 43);
			this.LoginBtn.TabIndex = 4;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.UseVisualStyleBackColor = false;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label3.Location = new System.Drawing.Point(458, 65);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(310, 61);
			this.label3.TabIndex = 6;
			this.label3.Text = "MEDITECH";
			// 
			// UsernameTxtBox
			// 
			this.UsernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.UsernameTxtBox.Location = new System.Drawing.Point(496, 240);
			this.UsernameTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.UsernameTxtBox.Name = "UsernameTxtBox";
			this.UsernameTxtBox.Size = new System.Drawing.Size(312, 26);
			this.UsernameTxtBox.TabIndex = 8;
			this.UsernameTxtBox.Text = "Username";
			// 
			// PasswordTxtBox
			// 
			this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.PasswordTxtBox.Location = new System.Drawing.Point(496, 320);
			this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PasswordTxtBox.Name = "PasswordTxtBox";
			this.PasswordTxtBox.Size = new System.Drawing.Size(286, 26);
			this.PasswordTxtBox.TabIndex = 9;
			this.PasswordTxtBox.Text = "Password";
			this.PasswordTxtBox.Enter += new System.EventHandler(this.PasswordTxtBox_Enter);
			this.PasswordTxtBox.Leave += new System.EventHandler(this.PasswordTxtBox_Leave);
			// 
			// showPassBTN
			// 
			this.showPassBTN.BackgroundImage = global::Meditechnology_System.Properties.Resources.cross_eye_icon;
			this.showPassBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.showPassBTN.Location = new System.Drawing.Point(780, 313);
			this.showPassBTN.Name = "showPassBTN";
			this.showPassBTN.Size = new System.Drawing.Size(41, 41);
			this.showPassBTN.TabIndex = 10;
			this.showPassBTN.UseVisualStyleBackColor = true;
			this.showPassBTN.Click += new System.EventHandler(this.showPassBTN_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Meditechnology_System.Properties.Resources.MEDITECH;
			this.pictureBox1.Location = new System.Drawing.Point(632, 31);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 38);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::Meditechnology_System.Properties.Resources._1e390d2e6a21096b419e3e787618a95f;
			this.panel1.Location = new System.Drawing.Point(-12, -2);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(369, 571);
			this.panel1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(957, 560);
			this.Controls.Add(this.showPassBTN);
			this.Controls.Add(this.PasswordTxtBox);
			this.Controls.Add(this.UsernameTxtBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.LoginBtn);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MEDITECH";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox UsernameTxtBox;
		private System.Windows.Forms.TextBox PasswordTxtBox;
		private System.Windows.Forms.Button showPassBTN;
	}
}

