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
            this.ViewEmploteeBtn = new System.Windows.Forms.Button();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.HistoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(49, 72);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(442, 254);
            this.dataGridView4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login History";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Location = new System.Drawing.Point(535, 330);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(75, 23);
            this.Logoutbtn.TabIndex = 5;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // ViewEmploteeBtn
            // 
            this.ViewEmploteeBtn.Location = new System.Drawing.Point(503, 107);
            this.ViewEmploteeBtn.Name = "ViewEmploteeBtn";
            this.ViewEmploteeBtn.Size = new System.Drawing.Size(113, 29);
            this.ViewEmploteeBtn.TabIndex = 6;
            this.ViewEmploteeBtn.Text = "View Employee";
            this.ViewEmploteeBtn.UseVisualStyleBackColor = true;
            this.ViewEmploteeBtn.Click += new System.EventHandler(this.ViewEmploteeBtn_Click);
            // 
            // AccountBtn
            // 
            this.AccountBtn.Location = new System.Drawing.Point(503, 72);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(113, 29);
            this.AccountBtn.TabIndex = 7;
            this.AccountBtn.Text = "Account";
            this.AccountBtn.UseVisualStyleBackColor = true;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.Location = new System.Drawing.Point(503, 142);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(113, 29);
            this.HistoryBtn.TabIndex = 11;
            this.HistoryBtn.Text = "History";
            this.HistoryBtn.UseVisualStyleBackColor = true;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 370);
            this.Controls.Add(this.HistoryBtn);
            this.Controls.Add(this.AccountBtn);
            this.Controls.Add(this.ViewEmploteeBtn);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Adminstrator";
            this.Text = "Adminstrator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button ViewEmploteeBtn;
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Button HistoryBtn;
    }
}