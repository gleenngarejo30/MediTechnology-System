namespace Meditechnology_System
{
    partial class AdminViewEmployee
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
            this.TypeEmployeeCB = new System.Windows.Forms.ComboBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.DGVEmployee = new System.Windows.Forms.DataGridView();
            this.AccountNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeEmployeeCB
            // 
            this.TypeEmployeeCB.FormattingEnabled = true;
            this.TypeEmployeeCB.Location = new System.Drawing.Point(211, 86);
            this.TypeEmployeeCB.Name = "TypeEmployeeCB";
            this.TypeEmployeeCB.Size = new System.Drawing.Size(121, 21);
            this.TypeEmployeeCB.TabIndex = 16;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(140, 54);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(258, 20);
            this.NameTxtBox.TabIndex = 15;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(653, 54);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 23);
            this.Searchbtn.TabIndex = 14;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(653, 403);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 13;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type of Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Location = new System.Drawing.Point(72, 25);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(47, 13);
            this.Account.TabIndex = 10;
            this.Account.Text = "Account";
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.Location = new System.Drawing.Point(75, 130);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.Size = new System.Drawing.Size(653, 254);
            this.DGVEmployee.TabIndex = 9;
            // 
            // AccountNumberTxtBox
            // 
            this.AccountNumberTxtBox.Location = new System.Drawing.Point(507, 54);
            this.AccountNumberTxtBox.Name = "AccountNumberTxtBox";
            this.AccountNumberTxtBox.Size = new System.Drawing.Size(127, 20);
            this.AccountNumberTxtBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Account Number";
            // 
            // AdminViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccountNumberTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeEmployeeCB);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.DGVEmployee);
            this.Name = "AdminViewEmployee";
            this.Text = "AdminViewEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeEmployeeCB;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.TextBox AccountNumberTxtBox;
        private System.Windows.Forms.Label label3;
    }
}