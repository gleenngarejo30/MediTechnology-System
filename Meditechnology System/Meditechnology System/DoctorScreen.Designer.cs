namespace Meditechnology_System
{
    partial class DoctorScreen
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
			this.button1 = new System.Windows.Forms.Button();
			this.Searchbtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label16 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NametxtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LogoutBtn
			// 
			this.LogoutBtn.Location = new System.Drawing.Point(977, 565);
			this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.LogoutBtn.Name = "LogoutBtn";
			this.LogoutBtn.Size = new System.Drawing.Size(112, 35);
			this.LogoutBtn.TabIndex = 2;
			this.LogoutBtn.Text = "Logout";
			this.LogoutBtn.UseVisualStyleBackColor = true;
			this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(878, 278);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(165, 29);
			this.button1.TabIndex = 5;
			this.button1.Text = "new prescription";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Searchbtn
			// 
			this.Searchbtn.Location = new System.Drawing.Point(977, 163);
			this.Searchbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Searchbtn.Name = "Searchbtn";
			this.Searchbtn.Size = new System.Drawing.Size(112, 35);
			this.Searchbtn.TabIndex = 19;
			this.Searchbtn.Text = "Search";
			this.Searchbtn.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(11, 227);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1078, 328);
			this.panel2.TabIndex = 18;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(22, 9);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(88, 20);
			this.label16.TabIndex = 25;
			this.label16.Text = "Patient List";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(27, 34);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.Size = new System.Drawing.Size(1016, 231);
			this.dataGridView1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.NametxtBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(13, 24);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1078, 113);
			this.panel1.TabIndex = 17;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(489, 54);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(223, 26);
			this.textBox1.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(397, 58);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Reference";
			// 
			// NametxtBox
			// 
			this.NametxtBox.Location = new System.Drawing.Point(150, 55);
			this.NametxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NametxtBox.Name = "NametxtBox";
			this.NametxtBox.Size = new System.Drawing.Size(223, 26);
			this.NametxtBox.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(88, 60);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search";
			// 
			// DoctorScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1119, 614);
			this.Controls.Add(this.Searchbtn);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.LogoutBtn);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "DoctorScreen";
			this.Text = "DoctorScreen";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LogoutBtn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Searchbtn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox NametxtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
	}
}