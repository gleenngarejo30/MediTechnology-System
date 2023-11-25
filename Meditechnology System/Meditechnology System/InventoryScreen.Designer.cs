namespace Meditechnology_System
{
    partial class InventoryScreen
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.logoutBTN = new System.Windows.Forms.Button();
			this.Addbtn = new System.Windows.Forms.Button();
			this.Removebtn = new System.Windows.Forms.Button();
			this.Searchbtn = new System.Windows.Forms.Button();
			this.SearchTxtBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(99, 175);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.Size = new System.Drawing.Size(846, 435);
			this.dataGridView1.TabIndex = 0;
			// 
			// logoutBTN
			// 
			this.logoutBTN.Location = new System.Drawing.Point(966, 620);
			this.logoutBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.logoutBTN.Name = "logoutBTN";
			this.logoutBTN.Size = new System.Drawing.Size(112, 35);
			this.logoutBTN.TabIndex = 1;
			this.logoutBTN.Text = "Logout";
			this.logoutBTN.UseVisualStyleBackColor = true;
			this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
			// 
			// Addbtn
			// 
			this.Addbtn.Location = new System.Drawing.Point(966, 175);
			this.Addbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Addbtn.Name = "Addbtn";
			this.Addbtn.Size = new System.Drawing.Size(112, 35);
			this.Addbtn.TabIndex = 2;
			this.Addbtn.Text = "Add";
			this.Addbtn.UseVisualStyleBackColor = true;
			this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
			// 
			// Removebtn
			// 
			this.Removebtn.Location = new System.Drawing.Point(966, 220);
			this.Removebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Removebtn.Name = "Removebtn";
			this.Removebtn.Size = new System.Drawing.Size(112, 35);
			this.Removebtn.TabIndex = 3;
			this.Removebtn.Text = "Remove";
			this.Removebtn.UseVisualStyleBackColor = true;
			this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
			// 
			// Searchbtn
			// 
			this.Searchbtn.Location = new System.Drawing.Point(832, 100);
			this.Searchbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Searchbtn.Name = "Searchbtn";
			this.Searchbtn.Size = new System.Drawing.Size(112, 35);
			this.Searchbtn.TabIndex = 4;
			this.Searchbtn.Text = "Search";
			this.Searchbtn.UseVisualStyleBackColor = true;
			// 
			// SearchTxtBox
			// 
			this.SearchTxtBox.Location = new System.Drawing.Point(249, 105);
			this.SearchTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SearchTxtBox.Name = "SearchTxtBox";
			this.SearchTxtBox.Size = new System.Drawing.Size(572, 26);
			this.SearchTxtBox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(94, 109);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Search Medicine";
			// 
			// InventoryScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1122, 692);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SearchTxtBox);
			this.Controls.Add(this.Searchbtn);
			this.Controls.Add(this.Removebtn);
			this.Controls.Add(this.Addbtn);
			this.Controls.Add(this.logoutBTN);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "InventoryScreen";
			this.Text = "InventoryScreen";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryScreen_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label label1;
    }
}