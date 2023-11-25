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
			this.SuspendLayout();
			// 
			// UsernameTxtBox
			// 
			this.UsernameTxtBox.Location = new System.Drawing.Point(363, 148);
			this.UsernameTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.UsernameTxtBox.Name = "UsernameTxtBox";
			this.UsernameTxtBox.Size = new System.Drawing.Size(312, 26);
			this.UsernameTxtBox.TabIndex = 0;
			this.UsernameTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTxtBox_KeyDown);
			// 
			// PasswordTxtBox
			// 
			this.PasswordTxtBox.Location = new System.Drawing.Point(363, 246);
			this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.PasswordTxtBox.Name = "PasswordTxtBox";
			this.PasswordTxtBox.Size = new System.Drawing.Size(312, 26);
			this.PasswordTxtBox.TabIndex = 1;
			this.PasswordTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTxtBox_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(471, 123);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(471, 222);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			// 
			// LoginBtn
			// 
			this.LoginBtn.Location = new System.Drawing.Point(460, 314);
			this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(112, 35);
			this.LoginBtn.TabIndex = 4;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.UseVisualStyleBackColor = true;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1106, 463);
			this.Controls.Add(this.LoginBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PasswordTxtBox);
			this.Controls.Add(this.UsernameTxtBox);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBtn;
    }
}

