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
			this.Backbtn = new System.Windows.Forms.Button();
			this.Searchbtn = new System.Windows.Forms.Button();
			this.NameTxtBox = new System.Windows.Forms.TextBox();
			this.TypeEmployeeCB = new System.Windows.Forms.ComboBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.Remove = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.AccountNumberTxtBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// DGVEmployee
			// 
			this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVEmployee.Location = new System.Drawing.Point(98, 195);
			this.DGVEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVEmployee.Name = "DGVEmployee";
			this.DGVEmployee.RowHeadersWidth = 62;
			this.DGVEmployee.Size = new System.Drawing.Size(856, 391);
			this.DGVEmployee.TabIndex = 1;
			// 
			// Account
			// 
			this.Account.AutoSize = true;
			this.Account.Location = new System.Drawing.Point(93, 34);
			this.Account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Account.Name = "Account";
			this.Account.Size = new System.Drawing.Size(68, 20);
			this.Account.TabIndex = 2;
			this.Account.Text = "Account";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(134, 83);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(134, 132);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Type of Employee";
			// 
			// Backbtn
			// 
			this.Backbtn.Location = new System.Drawing.Point(964, 615);
			this.Backbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Backbtn.Name = "Backbtn";
			this.Backbtn.Size = new System.Drawing.Size(112, 35);
			this.Backbtn.TabIndex = 5;
			this.Backbtn.Text = "Back";
			this.Backbtn.UseVisualStyleBackColor = true;
			this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
			// 
			// Searchbtn
			// 
			this.Searchbtn.Location = new System.Drawing.Point(964, 75);
			this.Searchbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Searchbtn.Name = "Searchbtn";
			this.Searchbtn.Size = new System.Drawing.Size(112, 35);
			this.Searchbtn.TabIndex = 6;
			this.Searchbtn.Text = "Search";
			this.Searchbtn.UseVisualStyleBackColor = true;
			// 
			// NameTxtBox
			// 
			this.NameTxtBox.Location = new System.Drawing.Point(195, 78);
			this.NameTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NameTxtBox.Name = "NameTxtBox";
			this.NameTxtBox.Size = new System.Drawing.Size(385, 26);
			this.NameTxtBox.TabIndex = 7;
			// 
			// TypeEmployeeCB
			// 
			this.TypeEmployeeCB.FormattingEnabled = true;
			this.TypeEmployeeCB.Location = new System.Drawing.Point(302, 128);
			this.TypeEmployeeCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TypeEmployeeCB.Name = "TypeEmployeeCB";
			this.TypeEmployeeCB.Size = new System.Drawing.Size(180, 28);
			this.TypeEmployeeCB.TabIndex = 8;
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(964, 195);
			this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(112, 35);
			this.AddBtn.TabIndex = 9;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// Remove
			// 
			this.Remove.Location = new System.Drawing.Point(963, 240);
			this.Remove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Remove.Name = "Remove";
			this.Remove.Size = new System.Drawing.Size(112, 35);
			this.Remove.TabIndex = 10;
			this.Remove.Text = "Remove";
			this.Remove.UseVisualStyleBackColor = true;
			this.Remove.Click += new System.EventHandler(this.Remove_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(612, 88);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Account Number";
			// 
			// AccountNumberTxtBox
			// 
			this.AccountNumberTxtBox.Location = new System.Drawing.Point(752, 78);
			this.AccountNumberTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AccountNumberTxtBox.Name = "AccountNumberTxtBox";
			this.AccountNumberTxtBox.Size = new System.Drawing.Size(182, 26);
			this.AccountNumberTxtBox.TabIndex = 12;
			// 
			// AdminAccounts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1173, 692);
			this.Controls.Add(this.AccountNumberTxtBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Remove);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.TypeEmployeeCB);
			this.Controls.Add(this.NameTxtBox);
			this.Controls.Add(this.Searchbtn);
			this.Controls.Add(this.Backbtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Account);
			this.Controls.Add(this.DGVEmployee);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AdminAccounts";
			this.Text = "AdminAccounts";
			((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.ComboBox TypeEmployeeCB;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountNumberTxtBox;
    }
}