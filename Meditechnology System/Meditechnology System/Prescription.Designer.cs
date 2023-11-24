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
            this.PrescriptionList = new System.Windows.Forms.ListBox();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameMedicineTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MedicineNameLBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IssuedDateLBL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ExpirationLBL = new System.Windows.Forms.Label();
            this.QuantityLBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrescriptionList
            // 
            this.PrescriptionList.FormattingEnabled = true;
            this.PrescriptionList.Location = new System.Drawing.Point(402, 83);
            this.PrescriptionList.Name = "PrescriptionList";
            this.PrescriptionList.Size = new System.Drawing.Size(258, 290);
            this.PrescriptionList.TabIndex = 0;
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Location = new System.Drawing.Point(585, 392);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(75, 23);
            this.ContinueBtn.TabIndex = 1;
            this.ContinueBtn.Text = "Continue";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(500, 392);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for Medicine";
            // 
            // NameMedicineTxtBox
            // 
            this.NameMedicineTxtBox.Location = new System.Drawing.Point(144, 126);
            this.NameMedicineTxtBox.Name = "NameMedicineTxtBox";
            this.NameMedicineTxtBox.Size = new System.Drawing.Size(203, 20);
            this.NameMedicineTxtBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name of Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Detail of the Medicine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name of the Medicine:";
            // 
            // MedicineNameLBL
            // 
            this.MedicineNameLBL.AutoSize = true;
            this.MedicineNameLBL.Location = new System.Drawing.Point(182, 217);
            this.MedicineNameLBL.Name = "MedicineNameLBL";
            this.MedicineNameLBL.Size = new System.Drawing.Size(35, 13);
            this.MedicineNameLBL.TabIndex = 8;
            this.MedicineNameLBL.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Issue Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Expiration Date:";
            // 
            // IssuedDateLBL
            // 
            this.IssuedDateLBL.AutoSize = true;
            this.IssuedDateLBL.Location = new System.Drawing.Point(182, 264);
            this.IssuedDateLBL.Name = "IssuedDateLBL";
            this.IssuedDateLBL.Size = new System.Drawing.Size(84, 13);
            this.IssuedDateLBL.TabIndex = 11;
            this.IssuedDateLBL.Text = "Month Day Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "List of the Presciption";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(131, 365);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // ExpirationLBL
            // 
            this.ExpirationLBL.AutoSize = true;
            this.ExpirationLBL.Location = new System.Drawing.Point(182, 295);
            this.ExpirationLBL.Name = "ExpirationLBL";
            this.ExpirationLBL.Size = new System.Drawing.Size(84, 13);
            this.ExpirationLBL.TabIndex = 15;
            this.ExpirationLBL.Text = "Month Day Year";
            // 
            // QuantityLBL
            // 
            this.QuantityLBL.AutoSize = true;
            this.QuantityLBL.Location = new System.Drawing.Point(182, 241);
            this.QuantityLBL.Name = "QuantityLBL";
            this.QuantityLBL.Size = new System.Drawing.Size(19, 13);
            this.QuantityLBL.TabIndex = 17;
            this.QuantityLBL.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantity:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 18;
            // 
            // Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 460);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuantityLBL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExpirationLBL);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IssuedDateLBL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MedicineNameLBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameMedicineTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.PrescriptionList);
            this.Name = "Prescription";
            this.Text = "Prescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PrescriptionList;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameMedicineTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MedicineNameLBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label IssuedDateLBL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label ExpirationLBL;
        private System.Windows.Forms.Label QuantityLBL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}