namespace Meditechnology_System
{
    partial class AdminAccounts
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
            this.DGVEmployee = new System.Windows.Forms.DataGridView();
            this.Account = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.TypeEmployeeCB = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountNumberTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.Location = new System.Drawing.Point(62, 194);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.RowHeadersWidth = 62;
            this.DGVEmployee.Size = new System.Drawing.Size(571, 254);
            this.DGVEmployee.TabIndex = 1;
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Location = new System.Drawing.Point(76, 80);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(75, 20);
            this.Account.TabIndex = 2;
            this.Account.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(86, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(86, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type of Employee";
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(558, 150);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 23);
            this.Searchbtn.TabIndex = 6;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NameTxtBox.Location = new System.Drawing.Point(127, 118);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(258, 20);
            this.NameTxtBox.TabIndex = 7;
            // 
            // TypeEmployeeCB
            // 
            this.TypeEmployeeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TypeEmployeeCB.FormattingEnabled = true;
            this.TypeEmployeeCB.Location = new System.Drawing.Point(209, 150);
            this.TypeEmployeeCB.Name = "TypeEmployeeCB";
            this.TypeEmployeeCB.Size = new System.Drawing.Size(121, 21);
            this.TypeEmployeeCB.TabIndex = 8;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(640, 194);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Remove.ForeColor = System.Drawing.Color.White;
            this.Remove.Location = new System.Drawing.Point(639, 223);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(391, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Account Number";
            // 
            // AccountNumberTxtBox
            // 
            this.AccountNumberTxtBox.Location = new System.Drawing.Point(510, 119);
            this.AccountNumberTxtBox.Name = "AccountNumberTxtBox";
            this.AccountNumberTxtBox.Size = new System.Drawing.Size(123, 20);
            this.AccountNumberTxtBox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 65);
            this.panel1.TabIndex = 29;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(78, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "MEDITECH";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Meditechnology_System.Properties.Resources.back_button;
            this.pictureBox2.Location = new System.Drawing.Point(672, 465);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AdminAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(774, 518);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AccountNumberTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TypeEmployeeCB);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.DGVEmployee);
            this.Name = "AdminAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAccounts";
            this.Load += new System.EventHandler(this.AdminAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.ComboBox TypeEmployeeCB;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountNumberTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}