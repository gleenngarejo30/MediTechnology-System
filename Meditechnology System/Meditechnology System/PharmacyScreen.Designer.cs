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
            this.DGVRequest = new System.Windows.Forms.DataGridView();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReferenceTxtBox = new System.Windows.Forms.TextBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Processbtn = new System.Windows.Forms.Button();
            this.MedicineListView = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRequest
            // 
            this.DGVRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRequest.Location = new System.Drawing.Point(38, 75);
            this.DGVRequest.Name = "DGVRequest";
            this.DGVRequest.Size = new System.Drawing.Size(252, 309);
            this.DGVRequest.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(601, 390);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference Number";
            // 
            // ReferenceTxtBox
            // 
            this.ReferenceTxtBox.Location = new System.Drawing.Point(416, 75);
            this.ReferenceTxtBox.Name = "ReferenceTxtBox";
            this.ReferenceTxtBox.Size = new System.Drawing.Size(123, 20);
            this.ReferenceTxtBox.TabIndex = 4;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(559, 73);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 5;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name of Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "List of Medicine:";
            // 
            // Processbtn
            // 
            this.Processbtn.Location = new System.Drawing.Point(440, 326);
            this.Processbtn.Name = "Processbtn";
            this.Processbtn.Size = new System.Drawing.Size(75, 23);
            this.Processbtn.TabIndex = 10;
            this.Processbtn.Text = "Process";
            this.Processbtn.UseVisualStyleBackColor = true;
            this.Processbtn.Click += new System.EventHandler(this.Processbtn_Click);
            // 
            // MedicineListView
            // 
            this.MedicineListView.FormattingEnabled = true;
            this.MedicineListView.Location = new System.Drawing.Point(330, 211);
            this.MedicineListView.Name = "MedicineListView";
            this.MedicineListView.Size = new System.Drawing.Size(283, 95);
            this.MedicineListView.TabIndex = 11;
            // 
            // PharmacyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 425);
            this.Controls.Add(this.MedicineListView);
            this.Controls.Add(this.Processbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.ReferenceTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.DGVRequest);
            this.Name = "PharmacyScreen";
            this.Text = "PharmacyScreen";
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRequest;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReferenceTxtBox;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Processbtn;
        private System.Windows.Forms.ListBox MedicineListView;
    }
}