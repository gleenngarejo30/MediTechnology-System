namespace Meditechnology_System
{
	partial class InventoryAddItem
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
			this.NameMedTxtBox = new System.Windows.Forms.TextBox();
			this.QuantityTxtBox = new System.Windows.Forms.TextBox();
			this.DateIssueDatePicker = new System.Windows.Forms.DateTimePicker();
			this.DateExpiredDatePicker = new System.Windows.Forms.DateTimePicker();
			this.RegisterBtn = new System.Windows.Forms.Button();
			this.BackBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name of the Medicine";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Quantity";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Date Issued:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(56, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Date Expired:";
			// 
			// NameMedTxtBox
			// 
			this.NameMedTxtBox.Location = new System.Drawing.Point(300, 52);
			this.NameMedTxtBox.Name = "NameMedTxtBox";
			this.NameMedTxtBox.Size = new System.Drawing.Size(309, 26);
			this.NameMedTxtBox.TabIndex = 4;
			// 
			// QuantityTxtBox
			// 
			this.QuantityTxtBox.Location = new System.Drawing.Point(300, 98);
			this.QuantityTxtBox.Name = "QuantityTxtBox";
			this.QuantityTxtBox.Size = new System.Drawing.Size(71, 26);
			this.QuantityTxtBox.TabIndex = 5;
			// 
			// DateIssueDatePicker
			// 
			this.DateIssueDatePicker.Location = new System.Drawing.Point(300, 165);
			this.DateIssueDatePicker.Name = "DateIssueDatePicker";
			this.DateIssueDatePicker.Size = new System.Drawing.Size(289, 26);
			this.DateIssueDatePicker.TabIndex = 6;
			// 
			// DateExpiredDatePicker
			// 
			this.DateExpiredDatePicker.Location = new System.Drawing.Point(300, 201);
			this.DateExpiredDatePicker.Name = "DateExpiredDatePicker";
			this.DateExpiredDatePicker.Size = new System.Drawing.Size(289, 26);
			this.DateExpiredDatePicker.TabIndex = 7;
			// 
			// RegisterBtn
			// 
			this.RegisterBtn.Location = new System.Drawing.Point(367, 265);
			this.RegisterBtn.Name = "RegisterBtn";
			this.RegisterBtn.Size = new System.Drawing.Size(155, 33);
			this.RegisterBtn.TabIndex = 8;
			this.RegisterBtn.Text = "Register";
			this.RegisterBtn.UseVisualStyleBackColor = true;
			this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
			// 
			// BackBtn
			// 
			this.BackBtn.Location = new System.Drawing.Point(391, 304);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(107, 33);
			this.BackBtn.TabIndex = 9;
			this.BackBtn.Text = "Back";
			this.BackBtn.UseVisualStyleBackColor = true;
			this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
			// 
			// InventoryAddItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 363);
			this.Controls.Add(this.BackBtn);
			this.Controls.Add(this.RegisterBtn);
			this.Controls.Add(this.DateExpiredDatePicker);
			this.Controls.Add(this.DateIssueDatePicker);
			this.Controls.Add(this.QuantityTxtBox);
			this.Controls.Add(this.NameMedTxtBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "InventoryAddItem";
			this.Text = "InventoryAddItem";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryAddItem_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox NameMedTxtBox;
		private System.Windows.Forms.TextBox QuantityTxtBox;
		private System.Windows.Forms.DateTimePicker DateIssueDatePicker;
		private System.Windows.Forms.DateTimePicker DateExpiredDatePicker;
		private System.Windows.Forms.Button RegisterBtn;
		private System.Windows.Forms.Button BackBtn;
	}
}