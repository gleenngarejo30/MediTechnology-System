namespace Meditechnology_System
{
    partial class Adminstrator
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
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.Logoutbtn = new System.Windows.Forms.Button();
			this.AccountBtn = new System.Windows.Forms.Button();
			this.HistoryBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView4
			// 
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Location = new System.Drawing.Point(74, 111);
			this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.RowHeadersWidth = 62;
			this.dataGridView4.Size = new System.Drawing.Size(663, 391);
			this.dataGridView4.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(66, 55);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 37);
			this.label1.TabIndex = 4;
			this.label1.Text = "Login History";
			// 
			// Logoutbtn
			// 
			this.Logoutbtn.Location = new System.Drawing.Point(802, 508);
			this.Logoutbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Logoutbtn.Name = "Logoutbtn";
			this.Logoutbtn.Size = new System.Drawing.Size(112, 35);
			this.Logoutbtn.TabIndex = 5;
			this.Logoutbtn.Text = "Logout";
			this.Logoutbtn.UseVisualStyleBackColor = true;
			this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
			// 
			// AccountBtn
			// 
			this.AccountBtn.Location = new System.Drawing.Point(754, 111);
			this.AccountBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AccountBtn.Name = "AccountBtn";
			this.AccountBtn.Size = new System.Drawing.Size(170, 45);
			this.AccountBtn.TabIndex = 7;
			this.AccountBtn.Text = "Account";
			this.AccountBtn.UseVisualStyleBackColor = true;
			this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
			// 
			// HistoryBtn
			// 
			this.HistoryBtn.Location = new System.Drawing.Point(754, 163);
			this.HistoryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.HistoryBtn.Name = "HistoryBtn";
			this.HistoryBtn.Size = new System.Drawing.Size(170, 45);
			this.HistoryBtn.TabIndex = 11;
			this.HistoryBtn.Text = "History";
			this.HistoryBtn.UseVisualStyleBackColor = true;
			this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
			// 
			// Adminstrator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(942, 569);
			this.Controls.Add(this.HistoryBtn);
			this.Controls.Add(this.AccountBtn);
			this.Controls.Add(this.Logoutbtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView4);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Adminstrator";
			this.Text = "Adminstrator";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Adminstrator_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Button HistoryBtn;
    }
}