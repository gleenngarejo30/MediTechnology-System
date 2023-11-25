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
			this.BackBtn = new System.Windows.Forms.Button();
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
			((System.ComponentModel.ISupportInitialize)(this.prescriptionList)).BeginInit();
			this.SuspendLayout();
			// 
			// prescribeBtn
			// 
			this.prescribeBtn.Location = new System.Drawing.Point(981, 592);
			this.prescribeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.prescribeBtn.Name = "prescribeBtn";
			this.prescribeBtn.Size = new System.Drawing.Size(112, 35);
			this.prescribeBtn.TabIndex = 1;
			this.prescribeBtn.Text = "Prescribe";
			this.prescribeBtn.UseVisualStyleBackColor = true;
			this.prescribeBtn.Click += new System.EventHandler(this.prescribeBtn_Click);
			// 
			// BackBtn
			// 
			this.BackBtn.Location = new System.Drawing.Point(722, 592);
			this.BackBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(111, 35);
			this.BackBtn.TabIndex = 2;
			this.BackBtn.Text = "Back";
			this.BackBtn.UseVisualStyleBackColor = true;
			this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(68, 128);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search for Medicine";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(69, 243);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Name of Medicine";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(72, 193);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Detail of the Medicine";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(72, 324);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "Issue Date:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(72, 372);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(122, 20);
			this.label7.TabIndex = 10;
			this.label7.Text = "Expiration Date:";
			// 
			// IssuedDateLBL
			// 
			this.IssuedDateLBL.AutoSize = true;
			this.IssuedDateLBL.Location = new System.Drawing.Point(277, 324);
			this.IssuedDateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.IssuedDateLBL.Name = "IssuedDateLBL";
			this.IssuedDateLBL.Size = new System.Drawing.Size(124, 20);
			this.IssuedDateLBL.TabIndex = 11;
			this.IssuedDateLBL.Text = "Month Day Year";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(563, 86);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(161, 20);
			this.label10.TabIndex = 13;
			this.label10.Text = "List of the Presciption";
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(183, 486);
			this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(112, 35);
			this.AddBtn.TabIndex = 14;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// ExpirationLBL
			// 
			this.ExpirationLBL.AutoSize = true;
			this.ExpirationLBL.Location = new System.Drawing.Point(277, 372);
			this.ExpirationLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ExpirationLBL.Name = "ExpirationLBL";
			this.ExpirationLBL.Size = new System.Drawing.Size(124, 20);
			this.ExpirationLBL.TabIndex = 15;
			this.ExpirationLBL.Text = "Month Day Year";
			// 
			// QuantityLBL
			// 
			this.QuantityLBL.AutoSize = true;
			this.QuantityLBL.Location = new System.Drawing.Point(277, 289);
			this.QuantityLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.QuantityLBL.Name = "QuantityLBL";
			this.QuantityLBL.Size = new System.Drawing.Size(27, 20);
			this.QuantityLBL.TabIndex = 17;
			this.QuantityLBL.Text = "10";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(72, 289);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 20);
			this.label8.TabIndex = 16;
			this.label8.Text = "Quantity:";
			// 
			// quantityTB
			// 
			this.quantityTB.Location = new System.Drawing.Point(164, 446);
			this.quantityTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.quantityTB.Name = "quantityTB";
			this.quantityTB.Size = new System.Drawing.Size(150, 26);
			this.quantityTB.TabIndex = 18;
			// 
			// reserveBTN
			// 
			this.reserveBTN.Location = new System.Drawing.Point(850, 592);
			this.reserveBTN.Name = "reserveBTN";
			this.reserveBTN.Size = new System.Drawing.Size(112, 35);
			this.reserveBTN.TabIndex = 19;
			this.reserveBTN.Text = "Reserve";
			this.reserveBTN.UseVisualStyleBackColor = true;
			this.reserveBTN.Click += new System.EventHandler(this.reserveBTN_Click);
			// 
			// medCB
			// 
			this.medCB.FormattingEnabled = true;
			this.medCB.Items.AddRange(new object[] {
            "Biogesic",
            "Neozep",
            "Bioflu"});
			this.medCB.Location = new System.Drawing.Point(251, 243);
			this.medCB.Name = "medCB";
			this.medCB.Size = new System.Drawing.Size(229, 28);
			this.medCB.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(72, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 20);
			this.label5.TabIndex = 21;
			this.label5.Text = "Patient: ";
			// 
			// patientNameLBL
			// 
			this.patientNameLBL.AutoSize = true;
			this.patientNameLBL.Location = new System.Drawing.Point(146, 85);
			this.patientNameLBL.Name = "patientNameLBL";
			this.patientNameLBL.Size = new System.Drawing.Size(110, 20);
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
			this.prescriptionList.Location = new System.Drawing.Point(544, 128);
			this.prescriptionList.MultiSelect = false;
			this.prescriptionList.Name = "prescriptionList";
			this.prescriptionList.RowHeadersWidth = 62;
			this.prescriptionList.RowTemplate.Height = 28;
			this.prescriptionList.Size = new System.Drawing.Size(549, 433);
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
			this.removeBTN.Location = new System.Drawing.Point(544, 592);
			this.removeBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.removeBTN.Name = "removeBTN";
			this.removeBTN.Size = new System.Drawing.Size(112, 35);
			this.removeBTN.TabIndex = 24;
			this.removeBTN.Text = "Remove";
			this.removeBTN.UseVisualStyleBackColor = true;
			this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(66, 186);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(439, 243);
			this.panel1.TabIndex = 25;
			// 
			// Prescription
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1191, 708);
			this.Controls.Add(this.removeBTN);
			this.Controls.Add(this.prescriptionList);
			this.Controls.Add(this.patientNameLBL);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.medCB);
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
			this.Controls.Add(this.BackBtn);
			this.Controls.Add(this.prescribeBtn);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Prescription";
			this.Text = "Prescription";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Prescription_FormClosed);
			this.Load += new System.EventHandler(this.Prescription_Load);
			((System.ComponentModel.ISupportInitialize)(this.prescriptionList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prescribeBtn;
        private System.Windows.Forms.Button BackBtn;
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
	}
}