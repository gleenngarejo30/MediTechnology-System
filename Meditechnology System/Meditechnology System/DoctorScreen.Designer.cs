﻿namespace Meditechnology_System
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
			this.prescriptionBTN = new System.Windows.Forms.Button();
			this.Searchbtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label16 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.refNumTXT = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NametxtBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// LogoutBtn
			// 
			this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.LogoutBtn.ForeColor = System.Drawing.Color.White;
			this.LogoutBtn.Location = new System.Drawing.Point(567, 695);
			this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.LogoutBtn.Name = "LogoutBtn";
			this.LogoutBtn.Size = new System.Drawing.Size(112, 35);
			this.LogoutBtn.TabIndex = 2;
			this.LogoutBtn.Text = "Logout";
			this.LogoutBtn.UseVisualStyleBackColor = false;
			this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
			// 
			// prescriptionBTN
			// 
			this.prescriptionBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.prescriptionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.prescriptionBTN.ForeColor = System.Drawing.Color.White;
			this.prescriptionBTN.Location = new System.Drawing.Point(392, 272);
			this.prescriptionBTN.Name = "prescriptionBTN";
			this.prescriptionBTN.Size = new System.Drawing.Size(228, 35);
			this.prescriptionBTN.TabIndex = 5;
			this.prescriptionBTN.Text = "new prescription";
			this.prescriptionBTN.UseVisualStyleBackColor = false;
			this.prescriptionBTN.Click += new System.EventHandler(this.prescriptionBTN_Click);
			// 
			// Searchbtn
			// 
			this.Searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.Searchbtn.ForeColor = System.Drawing.Color.White;
			this.Searchbtn.Location = new System.Drawing.Point(452, 268);
			this.Searchbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Searchbtn.Name = "Searchbtn";
			this.Searchbtn.Size = new System.Drawing.Size(228, 35);
			this.Searchbtn.TabIndex = 19;
			this.Searchbtn.Text = "Search";
			this.Searchbtn.UseVisualStyleBackColor = false;
			this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.prescriptionBTN);
			this.panel2.Location = new System.Drawing.Point(60, 345);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(656, 328);
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
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.reference});
			this.dataGridView1.Location = new System.Drawing.Point(27, 34);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.Size = new System.Drawing.Size(602, 231);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// name
			// 
			this.name.HeaderText = "Patient";
			this.name.MinimumWidth = 8;
			this.name.Name = "name";
			// 
			// reference
			// 
			this.reference.HeaderText = "Reference";
			this.reference.MinimumWidth = 8;
			this.reference.Name = "reference";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.refNumTXT);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.NametxtBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(58, 122);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(657, 137);
			this.panel1.TabIndex = 17;
			// 
			// refNumTXT
			// 
			this.refNumTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.refNumTXT.Location = new System.Drawing.Point(141, 92);
			this.refNumTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.refNumTXT.Name = "refNumTXT";
			this.refNumTXT.Size = new System.Drawing.Size(452, 26);
			this.refNumTXT.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label3.Location = new System.Drawing.Point(24, 94);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Reference";
			// 
			// NametxtBox
			// 
			this.NametxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.NametxtBox.Location = new System.Drawing.Point(141, 54);
			this.NametxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NametxtBox.Name = "NametxtBox";
			this.NametxtBox.Size = new System.Drawing.Size(452, 26);
			this.NametxtBox.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(54, 58);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(22, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Location = new System.Drawing.Point(-16, -6);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1215, 100);
			this.panel3.TabIndex = 33;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Meditechnology_System.Properties.Resources.MEDITECH__1_;
			this.pictureBox1.Location = new System.Drawing.Point(4, 6);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(123, 95);
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
			this.label7.Location = new System.Drawing.Point(117, 42);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(177, 36);
			this.label7.TabIndex = 27;
			this.label7.Text = "MEDITECH";
			// 
			// DoctorScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 749);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.Searchbtn);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.LogoutBtn);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "DoctorScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DoctorScreen";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorScreen_FormClosed);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LogoutBtn;
		private System.Windows.Forms.Button prescriptionBTN;
		private System.Windows.Forms.Button Searchbtn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox NametxtBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox refNumTXT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn reference;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}