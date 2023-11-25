namespace Meditechnology_System
{
    partial class InventoryAdd
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
			this.NameMedicine = new System.Windows.Forms.Label();
			this.IssueDate = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Quantity = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.DetailRTxtBox = new System.Windows.Forms.RichTextBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.NameMedTxtBox = new System.Windows.Forms.TextBox();
			this.IssueDateTxtBox = new System.Windows.Forms.TextBox();
			this.ExpirationDateTxtBox = new System.Windows.Forms.TextBox();
			this.QuantityTxtBox = new System.Windows.Forms.TextBox();
			this.Backbtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// NameMedicine
			// 
			this.NameMedicine.AutoSize = true;
			this.NameMedicine.Location = new System.Drawing.Point(84, 114);
			this.NameMedicine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameMedicine.Name = "NameMedicine";
			this.NameMedicine.Size = new System.Drawing.Size(136, 20);
			this.NameMedicine.TabIndex = 0;
			this.NameMedicine.Text = "Name of Medicine";
			// 
			// IssueDate
			// 
			this.IssueDate.AutoSize = true;
			this.IssueDate.Location = new System.Drawing.Point(84, 168);
			this.IssueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.IssueDate.Name = "IssueDate";
			this.IssueDate.Size = new System.Drawing.Size(91, 20);
			this.IssueDate.TabIndex = 1;
			this.IssueDate.Text = "Issue Date:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(84, 222);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Expiration Date:";
			// 
			// Quantity
			// 
			this.Quantity.AutoSize = true;
			this.Quantity.Location = new System.Drawing.Point(84, 269);
			this.Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Quantity.Name = "Quantity";
			this.Quantity.Size = new System.Drawing.Size(72, 20);
			this.Quantity.TabIndex = 3;
			this.Quantity.Text = "Quantity:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(84, 323);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Details:";
			// 
			// DetailRTxtBox
			// 
			this.DetailRTxtBox.Location = new System.Drawing.Point(88, 348);
			this.DetailRTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DetailRTxtBox.Name = "DetailRTxtBox";
			this.DetailRTxtBox.Size = new System.Drawing.Size(452, 146);
			this.DetailRTxtBox.TabIndex = 5;
			this.DetailRTxtBox.Text = "";
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(234, 505);
			this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(168, 35);
			this.AddBtn.TabIndex = 6;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			// 
			// NameMedTxtBox
			// 
			this.NameMedTxtBox.Location = new System.Drawing.Point(254, 109);
			this.NameMedTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NameMedTxtBox.Name = "NameMedTxtBox";
			this.NameMedTxtBox.Size = new System.Drawing.Size(288, 26);
			this.NameMedTxtBox.TabIndex = 7;
			// 
			// IssueDateTxtBox
			// 
			this.IssueDateTxtBox.Location = new System.Drawing.Point(254, 163);
			this.IssueDateTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.IssueDateTxtBox.Name = "IssueDateTxtBox";
			this.IssueDateTxtBox.Size = new System.Drawing.Size(288, 26);
			this.IssueDateTxtBox.TabIndex = 8;
			// 
			// ExpirationDateTxtBox
			// 
			this.ExpirationDateTxtBox.Location = new System.Drawing.Point(254, 217);
			this.ExpirationDateTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ExpirationDateTxtBox.Name = "ExpirationDateTxtBox";
			this.ExpirationDateTxtBox.Size = new System.Drawing.Size(288, 26);
			this.ExpirationDateTxtBox.TabIndex = 9;
			// 
			// QuantityTxtBox
			// 
			this.QuantityTxtBox.Location = new System.Drawing.Point(254, 265);
			this.QuantityTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.QuantityTxtBox.Name = "QuantityTxtBox";
			this.QuantityTxtBox.Size = new System.Drawing.Size(110, 26);
			this.QuantityTxtBox.TabIndex = 10;
			// 
			// Backbtn
			// 
			this.Backbtn.Location = new System.Drawing.Point(264, 548);
			this.Backbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Backbtn.Name = "Backbtn";
			this.Backbtn.Size = new System.Drawing.Size(112, 35);
			this.Backbtn.TabIndex = 11;
			this.Backbtn.Text = "Back";
			this.Backbtn.UseVisualStyleBackColor = true;
			this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(224, 42);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 37);
			this.label3.TabIndex = 12;
			this.label3.Text = "Add Stock";
			// 
			// InventoryAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 602);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Backbtn);
			this.Controls.Add(this.QuantityTxtBox);
			this.Controls.Add(this.ExpirationDateTxtBox);
			this.Controls.Add(this.IssueDateTxtBox);
			this.Controls.Add(this.NameMedTxtBox);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.DetailRTxtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Quantity);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.IssueDate);
			this.Controls.Add(this.NameMedicine);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "InventoryAdd";
			this.Text = "InventoryAdd";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryAdd_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameMedicine;
        private System.Windows.Forms.Label IssueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox DetailRTxtBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox NameMedTxtBox;
        private System.Windows.Forms.TextBox IssueDateTxtBox;
        private System.Windows.Forms.TextBox ExpirationDateTxtBox;
        private System.Windows.Forms.TextBox QuantityTxtBox;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label3;
    }
}