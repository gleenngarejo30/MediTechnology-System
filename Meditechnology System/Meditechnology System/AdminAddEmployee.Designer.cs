﻿namespace Meditechnology_System
{
	partial class AdminAddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TypeEmpCB = new System.Windows.Forms.ComboBox();
            this.LNameTxtBox = new System.Windows.Forms.TextBox();
            this.FNameTxtBox = new System.Windows.Forms.TextBox();
            this.MNameTxtBox = new System.Windows.Forms.TextBox();
            this.AgeTxtBox = new System.Windows.Forms.TextBox();
            this.ContactNumTxtBox = new System.Windows.Forms.TextBox();
            this.MaleRB = new System.Windows.Forms.RadioButton();
            this.FemaleRB = new System.Windows.Forms.RadioButton();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(46, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(46, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(46, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(46, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middlle Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(46, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(46, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sex:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(46, 365);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contact Number:";
            // 
            // TypeEmpCB
            // 
            this.TypeEmpCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TypeEmpCB.FormattingEnabled = true;
            this.TypeEmpCB.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Inventory",
            "Pharmacy",
            "Nurse"});
            this.TypeEmpCB.Location = new System.Drawing.Point(191, 112);
            this.TypeEmpCB.Margin = new System.Windows.Forms.Padding(2);
            this.TypeEmpCB.Name = "TypeEmpCB";
            this.TypeEmpCB.Size = new System.Drawing.Size(163, 21);
            this.TypeEmpCB.TabIndex = 7;
            // 
            // LNameTxtBox
            // 
            this.LNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LNameTxtBox.Location = new System.Drawing.Point(191, 230);
            this.LNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.LNameTxtBox.Name = "LNameTxtBox";
            this.LNameTxtBox.Size = new System.Drawing.Size(163, 20);
            this.LNameTxtBox.TabIndex = 8;
            // 
            // FNameTxtBox
            // 
            this.FNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FNameTxtBox.Location = new System.Drawing.Point(191, 258);
            this.FNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.FNameTxtBox.Name = "FNameTxtBox";
            this.FNameTxtBox.Size = new System.Drawing.Size(163, 20);
            this.FNameTxtBox.TabIndex = 9;
            // 
            // MNameTxtBox
            // 
            this.MNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MNameTxtBox.Location = new System.Drawing.Point(191, 283);
            this.MNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.MNameTxtBox.Name = "MNameTxtBox";
            this.MNameTxtBox.Size = new System.Drawing.Size(163, 20);
            this.MNameTxtBox.TabIndex = 10;
            // 
            // AgeTxtBox
            // 
            this.AgeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AgeTxtBox.Location = new System.Drawing.Point(191, 307);
            this.AgeTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.AgeTxtBox.Name = "AgeTxtBox";
            this.AgeTxtBox.Size = new System.Drawing.Size(63, 20);
            this.AgeTxtBox.TabIndex = 11;
            // 
            // ContactNumTxtBox
            // 
            this.ContactNumTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ContactNumTxtBox.Location = new System.Drawing.Point(191, 363);
            this.ContactNumTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ContactNumTxtBox.Name = "ContactNumTxtBox";
            this.ContactNumTxtBox.Size = new System.Drawing.Size(163, 20);
            this.ContactNumTxtBox.TabIndex = 12;
            // 
            // MaleRB
            // 
            this.MaleRB.AutoSize = true;
            this.MaleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaleRB.Location = new System.Drawing.Point(191, 333);
            this.MaleRB.Margin = new System.Windows.Forms.Padding(2);
            this.MaleRB.Name = "MaleRB";
            this.MaleRB.Size = new System.Drawing.Size(48, 17);
            this.MaleRB.TabIndex = 13;
            this.MaleRB.TabStop = true;
            this.MaleRB.Text = "Male";
            this.MaleRB.UseVisualStyleBackColor = true;
            // 
            // FemaleRB
            // 
            this.FemaleRB.AutoSize = true;
            this.FemaleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FemaleRB.Location = new System.Drawing.Point(279, 333);
            this.FemaleRB.Margin = new System.Windows.Forms.Padding(2);
            this.FemaleRB.Name = "FemaleRB";
            this.FemaleRB.Size = new System.Drawing.Size(59, 17);
            this.FemaleRB.TabIndex = 14;
            this.FemaleRB.TabStop = true;
            this.FemaleRB.Text = "Female";
            this.FemaleRB.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(149, 445);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(150, 30);
            this.RegisterBtn.TabIndex = 15;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(191, 390);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(46, 392);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-10, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 65);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Meditechnology_System.Properties.Resources.MEDITECH__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Meditechnology_System.Properties.Resources.back_button;
            this.pictureBox2.Location = new System.Drawing.Point(209, 482);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PasswordTxtBox.Location = new System.Drawing.Point(191, 188);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(163, 20);
            this.PasswordTxtBox.TabIndex = 35;
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.UserNameTxtBox.Location = new System.Drawing.Point(191, 163);
            this.UserNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(163, 20);
            this.UserNameTxtBox.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(46, 190);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(46, 165);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Username:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Meditechnology_System.Properties.Resources.image_removebg_preview__5_;
            this.pictureBox3.Location = new System.Drawing.Point(70, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // AdminAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 537);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.FemaleRB);
            this.Controls.Add(this.MaleRB);
            this.Controls.Add(this.ContactNumTxtBox);
            this.Controls.Add(this.AgeTxtBox);
            this.Controls.Add(this.MNameTxtBox);
            this.Controls.Add(this.FNameTxtBox);
            this.Controls.Add(this.LNameTxtBox);
            this.Controls.Add(this.TypeEmpCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminAddEmployee_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox TypeEmpCB;
		private System.Windows.Forms.TextBox LNameTxtBox;
		private System.Windows.Forms.TextBox FNameTxtBox;
		private System.Windows.Forms.TextBox MNameTxtBox;
		private System.Windows.Forms.TextBox AgeTxtBox;
		private System.Windows.Forms.TextBox ContactNumTxtBox;
		private System.Windows.Forms.RadioButton MaleRB;
		private System.Windows.Forms.RadioButton FemaleRB;
		private System.Windows.Forms.Button RegisterBtn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}