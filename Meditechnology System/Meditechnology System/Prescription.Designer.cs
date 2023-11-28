namespace Meditechnology_System
{
    partial class Prescription
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
            this.prescribeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IssuedDateLBL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ExpirationLBL = new System.Windows.Forms.Label();
            this.QuantityLBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.reserveBTN = new System.Windows.Forms.Button();
            this.medCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patientNameLBL = new System.Windows.Forms.Label();
            this.prescriptionList = new System.Windows.Forms.DataGridView();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backIcon = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.remarksTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // prescribeBtn
            // 
            this.prescribeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.prescribeBtn.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.prescribeBtn.ForeColor = System.Drawing.Color.White;
            this.prescribeBtn.Location = new System.Drawing.Point(873, 416);
            this.prescribeBtn.Name = "prescribeBtn";
            this.prescribeBtn.Size = new System.Drawing.Size(75, 23);
            this.prescribeBtn.TabIndex = 1;
            this.prescribeBtn.Text = "Prescribe";
            this.prescribeBtn.UseVisualStyleBackColor = false;
            this.prescribeBtn.Click += new System.EventHandler(this.prescribeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label1.Location = new System.Drawing.Point(44, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label2.Location = new System.Drawing.Point(45, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name of Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label3.Location = new System.Drawing.Point(47, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Detail of the Medicine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label6.Location = new System.Drawing.Point(47, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Issue Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label7.Location = new System.Drawing.Point(47, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Expiration Date:";
            // 
            // IssuedDateLBL
            // 
            this.IssuedDateLBL.AutoSize = true;
            this.IssuedDateLBL.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.IssuedDateLBL.Location = new System.Drawing.Point(184, 242);
            this.IssuedDateLBL.Name = "IssuedDateLBL";
            this.IssuedDateLBL.Size = new System.Drawing.Size(106, 16);
            this.IssuedDateLBL.TabIndex = 11;
            this.IssuedDateLBL.Text = "Month Day Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("LEMON MILK", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(359, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "List of the Presciption";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.AddBtn.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(128, 372);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ExpirationLBL
            // 
            this.ExpirationLBL.AutoSize = true;
            this.ExpirationLBL.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.ExpirationLBL.Location = new System.Drawing.Point(184, 273);
            this.ExpirationLBL.Name = "ExpirationLBL";
            this.ExpirationLBL.Size = new System.Drawing.Size(106, 16);
            this.ExpirationLBL.TabIndex = 15;
            this.ExpirationLBL.Text = "Month Day Year";
            // 
            // QuantityLBL
            // 
            this.QuantityLBL.AutoSize = true;
            this.QuantityLBL.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.QuantityLBL.Location = new System.Drawing.Point(184, 219);
            this.QuantityLBL.Name = "QuantityLBL";
            this.QuantityLBL.Size = new System.Drawing.Size(15, 16);
            this.QuantityLBL.TabIndex = 17;
            this.QuantityLBL.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label8.Location = new System.Drawing.Point(47, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantity:";
            // 
            // quantityTB
            // 
            this.quantityTB.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.quantityTB.Location = new System.Drawing.Point(115, 344);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(101, 22);
            this.quantityTB.TabIndex = 18;
            // 
            // reserveBTN
            // 
            this.reserveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.reserveBTN.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.reserveBTN.ForeColor = System.Drawing.Color.White;
            this.reserveBTN.Location = new System.Drawing.Point(786, 416);
            this.reserveBTN.Margin = new System.Windows.Forms.Padding(2);
            this.reserveBTN.Name = "reserveBTN";
            this.reserveBTN.Size = new System.Drawing.Size(75, 23);
            this.reserveBTN.TabIndex = 19;
            this.reserveBTN.Text = "Reserve";
            this.reserveBTN.UseVisualStyleBackColor = false;
            this.reserveBTN.Click += new System.EventHandler(this.reserveBTN_Click);
            // 
            // medCB
            // 
            this.medCB.FormattingEnabled = true;
            this.medCB.Items.AddRange(new object[] {
            "Biogesic",
            "Neozep",
            "Bioflu"});
            this.medCB.Location = new System.Drawing.Point(127, 32);
            this.medCB.Margin = new System.Windows.Forms.Padding(2);
            this.medCB.Name = "medCB";
            this.medCB.Size = new System.Drawing.Size(154, 24);
            this.medCB.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LEMON MILK", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Patient: ";
            // 
            // patientNameLBL
            // 
            this.patientNameLBL.AutoSize = true;
            this.patientNameLBL.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.patientNameLBL.Location = new System.Drawing.Point(155, 86);
            this.patientNameLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientNameLBL.Name = "patientNameLBL";
            this.patientNameLBL.Size = new System.Drawing.Size(91, 16);
            this.patientNameLBL.TabIndex = 22;
            this.patientNameLBL.Text = "Patient_Name";
            // 
            // prescriptionList
            // 
            this.prescriptionList.AllowUserToResizeColumns = false;
            this.prescriptionList.AllowUserToResizeRows = false;
            this.prescriptionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prescriptionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescriptionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine,
            this.quantity,
            this.availability});
            this.prescriptionList.EnableHeadersVisualStyles = false;
            this.prescriptionList.Location = new System.Drawing.Point(362, 114);
            this.prescriptionList.Margin = new System.Windows.Forms.Padding(2);
            this.prescriptionList.MultiSelect = false;
            this.prescriptionList.Name = "prescriptionList";
            this.prescriptionList.RowHeadersWidth = 62;
            this.prescriptionList.RowTemplate.Height = 28;
            this.prescriptionList.Size = new System.Drawing.Size(366, 281);
            this.prescriptionList.TabIndex = 23;
            // 
            // Medicine
            // 
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.MinimumWidth = 8;
            this.Medicine.Name = "Medicine";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            // 
            // availability
            // 
            this.availability.HeaderText = "Available";
            this.availability.MinimumWidth = 8;
            this.availability.Name = "availability";
            // 
            // removeBTN
            // 
            this.removeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.removeBTN.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.removeBTN.ForeColor = System.Drawing.Color.White;
            this.removeBTN.Location = new System.Drawing.Point(362, 416);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(75, 23);
            this.removeBTN.TabIndex = 24;
            this.removeBTN.Text = "Remove";
            this.removeBTN.UseVisualStyleBackColor = false;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.medCB);
            this.panel1.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.panel1.Location = new System.Drawing.Point(43, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 158);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-8, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 65);
            this.panel2.TabIndex = 33;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Akira Expanded", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(78, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "MEDITECH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label9.Location = new System.Drawing.Point(126, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Add to List";
            // 
            // backIcon
            // 
            this.backIcon.Image = global::Meditechnology_System.Properties.Resources.back_button;
            this.backIcon.Location = new System.Drawing.Point(998, 416);
            this.backIcon.Name = "backIcon";
            this.backIcon.Size = new System.Drawing.Size(27, 23);
            this.backIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backIcon.TabIndex = 38;
            this.backIcon.TabStop = false;
            this.backIcon.Click += new System.EventHandler(this.backIcon_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("LEMON MILK", 6F);
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(762, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 11);
            this.label11.TabIndex = 56;
            this.label11.Text = "PRESS ENTER TO NEXT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("LEMON MILK", 6F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(943, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "remove";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(764, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 196);
            this.listBox1.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("LEMON MILK", 8.25F);
            this.label12.Location = new System.Drawing.Point(748, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "REMARKS";
            // 
            // remarksTxtBox
            // 
            this.remarksTxtBox.Location = new System.Drawing.Point(764, 116);
            this.remarksTxtBox.Name = "remarksTxtBox";
            this.remarksTxtBox.Size = new System.Drawing.Size(242, 20);
            this.remarksTxtBox.TabIndex = 52;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 460);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.backIcon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.remarksTxtBox);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.prescriptionList);
            this.Controls.Add(this.patientNameLBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reserveBTN);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.QuantityLBL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExpirationLBL);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IssuedDateLBL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prescribeBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Prescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Prescription_FormClosed);
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prescribeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label IssuedDateLBL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label ExpirationLBL;
        private System.Windows.Forms.Label QuantityLBL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantityTB;
		private System.Windows.Forms.Button reserveBTN;
		private System.Windows.Forms.ComboBox medCB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label patientNameLBL;
		private System.Windows.Forms.DataGridView prescriptionList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
		private System.Windows.Forms.Button removeBTN;
		private System.Windows.Forms.DataGridViewTextBoxColumn availability;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox backIcon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox remarksTxtBox;
    }
}