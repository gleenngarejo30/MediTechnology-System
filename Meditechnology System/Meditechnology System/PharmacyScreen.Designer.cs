namespace Meditechnology_System
{
    partial class PharmacyScreen
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
			this.LogoutBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Processbtn = new System.Windows.Forms.Button();
			this.MedicineListView = new System.Windows.Forms.ListBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// LogoutBtn
			// 
			this.LogoutBtn.Location = new System.Drawing.Point(381, 516);
			this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.LogoutBtn.Name = "LogoutBtn";
			this.LogoutBtn.Size = new System.Drawing.Size(112, 35);
			this.LogoutBtn.TabIndex = 1;
			this.LogoutBtn.Text = "Logout";
			this.LogoutBtn.UseVisualStyleBackColor = true;
			this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 45);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Reference Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 111);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Name of Patient";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(391, 111);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Age";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(393, 147);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Sex";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(45, 193);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "List of Medicine:";
			// 
			// Processbtn
			// 
			this.Processbtn.Location = new System.Drawing.Point(235, 427);
			this.Processbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Processbtn.Name = "Processbtn";
			this.Processbtn.Size = new System.Drawing.Size(112, 35);
			this.Processbtn.TabIndex = 10;
			this.Processbtn.Text = "Process";
			this.Processbtn.UseVisualStyleBackColor = true;
			// 
			// MedicineListView
			// 
			this.MedicineListView.FormattingEnabled = true;
			this.MedicineListView.ItemHeight = 20;
			this.MedicineListView.Location = new System.Drawing.Point(70, 250);
			this.MedicineListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MedicineListView.Name = "MedicineListView";
			this.MedicineListView.Size = new System.Drawing.Size(422, 144);
			this.MedicineListView.TabIndex = 11;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(214, 42);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(279, 28);
			this.comboBox1.TabIndex = 12;
			// 
			// PharmacyScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 596);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.MedicineListView);
			this.Controls.Add(this.Processbtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LogoutBtn);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "PharmacyScreen";
			this.Text = "PharmacyScreen";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Processbtn;
        private System.Windows.Forms.ListBox MedicineListView;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}