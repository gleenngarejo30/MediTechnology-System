namespace Meditechnology_System
{
    partial class InventoryRemove
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
            this.label3 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.NameMedTxtBox = new System.Windows.Forms.TextBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.NameMedicine = new System.Windows.Forms.Label();
            this.DGVMedicine = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Remove Stock";
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(177, 348);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 24;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            // 
            // NameMedTxtBox
            // 
            this.NameMedTxtBox.Location = new System.Drawing.Point(170, 63);
            this.NameMedTxtBox.Name = "NameMedTxtBox";
            this.NameMedTxtBox.Size = new System.Drawing.Size(193, 20);
            this.NameMedTxtBox.TabIndex = 20;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(157, 320);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(112, 23);
            this.RemoveBtn.TabIndex = 19;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // NameMedicine
            // 
            this.NameMedicine.AutoSize = true;
            this.NameMedicine.Location = new System.Drawing.Point(57, 66);
            this.NameMedicine.Name = "NameMedicine";
            this.NameMedicine.Size = new System.Drawing.Size(93, 13);
            this.NameMedicine.TabIndex = 13;
            this.NameMedicine.Text = "Name of Medicine";
            // 
            // DGVMedicine
            // 
            this.DGVMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedicine.Location = new System.Drawing.Point(52, 105);
            this.DGVMedicine.Name = "DGVMedicine";
            this.DGVMedicine.Size = new System.Drawing.Size(311, 192);
            this.DGVMedicine.TabIndex = 26;
            // 
            // InventoryRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 391);
            this.Controls.Add(this.DGVMedicine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.NameMedTxtBox);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.NameMedicine);
            this.Name = "InventoryRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InventoryRemove";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox NameMedTxtBox;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Label NameMedicine;
        private System.Windows.Forms.DataGridView DGVMedicine;
    }
}