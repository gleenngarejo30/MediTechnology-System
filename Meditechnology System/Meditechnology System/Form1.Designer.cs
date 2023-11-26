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
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.UsernameTxtBox.Location = new System.Drawing.Point(331, 155);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(209, 22);
            this.UsernameTxtBox.TabIndex = 0;
            this.UsernameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTxtBox_KeyDown);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.PasswordTxtBox.Location = new System.Drawing.Point(331, 219);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(209, 22);
            this.PasswordTxtBox.TabIndex = 1;
            this.PasswordTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTxtBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label1.Location = new System.Drawing.Point(401, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label2.Location = new System.Drawing.Point(401, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoginBtn.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(386, 260);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(94, 28);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Meditechnology_System.Properties.Resources._1e390d2e6a21096b419e3e787618a95f;
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 371);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akira Expanded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(305, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "MEDITECH";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UsernameTxtBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEDITECH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

