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
            this.QuantityTxtBox = new System.Windows.Forms.TextBox();
            this.DateIssueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateExpiredDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lotNumberTxtBox = new System.Windows.Forms.TextBox();
            this.backIcon = new System.Windows.Forms.PictureBox();
            this.medCB = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(57, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(57, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(57, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Issued:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(57, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Expired:";
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.QuantityTxtBox.Location = new System.Drawing.Point(220, 158);
            this.QuantityTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(49, 20);
            this.QuantityTxtBox.TabIndex = 5;
            // 
            // DateIssueDatePicker
            // 
            this.DateIssueDatePicker.CustomFormat = "yyyy-MM-dd";
            this.DateIssueDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DateIssueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateIssueDatePicker.Location = new System.Drawing.Point(220, 191);
            this.DateIssueDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DateIssueDatePicker.Name = "DateIssueDatePicker";
            this.DateIssueDatePicker.Size = new System.Drawing.Size(233, 20);
            this.DateIssueDatePicker.TabIndex = 6;
            // 
            // DateExpiredDatePicker
            // 
            this.DateExpiredDatePicker.CustomFormat = "yyyy-MM-dd";
            this.DateExpiredDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DateExpiredDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateExpiredDatePicker.Location = new System.Drawing.Point(220, 215);
            this.DateExpiredDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DateExpiredDatePicker.Name = "DateExpiredDatePicker";
            this.DateExpiredDatePicker.Size = new System.Drawing.Size(233, 20);
            this.DateExpiredDatePicker.TabIndex = 7;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(185, 252);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(142, 27);
            this.RegisterBtn.TabIndex = 8;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-43, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 65);
            this.panel2.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Meditechnology_System.Properties.Resources.MEDITECH__1_;
            this.pictureBox1.Location = new System.Drawing.Point(275, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(219, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "MEDITECH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(57, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "LOT NUMBER";
            // 
            // lotNumberTxtBox
            // 
            this.lotNumberTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lotNumberTxtBox.Location = new System.Drawing.Point(220, 130);
            this.lotNumberTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.lotNumberTxtBox.Name = "lotNumberTxtBox";
            this.lotNumberTxtBox.Size = new System.Drawing.Size(130, 20);
            this.lotNumberTxtBox.TabIndex = 39;
            // 
            // backIcon
            // 
            this.backIcon.Image = global::Meditechnology_System.Properties.Resources.back_button;
            this.backIcon.Location = new System.Drawing.Point(247, 284);
            this.backIcon.Name = "backIcon";
            this.backIcon.Size = new System.Drawing.Size(27, 23);
            this.backIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backIcon.TabIndex = 37;
            this.backIcon.TabStop = false;
            this.backIcon.Click += new System.EventHandler(this.backIcon_Click);
            // 
            // medCB
            // 
            this.medCB.FormattingEnabled = true;
            this.medCB.Location = new System.Drawing.Point(220, 91);
            this.medCB.Margin = new System.Windows.Forms.Padding(2);
            this.medCB.Name = "medCB";
            this.medCB.Size = new System.Drawing.Size(154, 21);
            this.medCB.TabIndex = 42;
            // 
            // InventoryAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 394);
            this.Controls.Add(this.medCB);
            this.Controls.Add(this.lotNumberTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.DateExpiredDatePicker);
            this.Controls.Add(this.DateIssueDatePicker);
            this.Controls.Add(this.QuantityTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryAddItem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryAddItem_FormClosed);
            this.Load += new System.EventHandler(this.InventoryAddItem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox QuantityTxtBox;
		private System.Windows.Forms.DateTimePicker DateIssueDatePicker;
		private System.Windows.Forms.DateTimePicker DateExpiredDatePicker;
		private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox backIcon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lotNumberTxtBox;
        private System.Windows.Forms.ComboBox medCB;
    }
}