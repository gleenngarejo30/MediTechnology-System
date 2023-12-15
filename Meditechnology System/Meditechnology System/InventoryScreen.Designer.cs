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
			this.Searchbtn = new System.Windows.Forms.Button();
			this.SearchTxtBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.AddStockbtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(104, 197);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.Size = new System.Drawing.Size(858, 435);
			this.dataGridView1.TabIndex = 0;
			// 
			// logoutBTN
			// 
			this.logoutBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.logoutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.logoutBTN.ForeColor = System.Drawing.Color.White;
			this.logoutBTN.Location = new System.Drawing.Point(984, 597);
			this.logoutBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.logoutBTN.Name = "logoutBTN";
			this.logoutBTN.Size = new System.Drawing.Size(112, 35);
			this.logoutBTN.TabIndex = 1;
			this.logoutBTN.Text = "Logout";
			this.logoutBTN.UseVisualStyleBackColor = false;
			this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
			// 
			// Addbtn
			// 
			this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.Addbtn.ForeColor = System.Drawing.Color.White;
			this.Addbtn.Location = new System.Drawing.Point(984, 246);
			this.Addbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Addbtn.Name = "Addbtn";
			this.Addbtn.Size = new System.Drawing.Size(166, 35);
			this.Addbtn.TabIndex = 2;
			this.Addbtn.Text = "Add Stock";
			this.Addbtn.UseVisualStyleBackColor = false;
			this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
			// 
			// Searchbtn
			// 
			this.Searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.Searchbtn.ForeColor = System.Drawing.Color.White;
			this.Searchbtn.Location = new System.Drawing.Point(850, 125);
			this.Searchbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Searchbtn.Name = "Searchbtn";
			this.Searchbtn.Size = new System.Drawing.Size(112, 35);
			this.Searchbtn.TabIndex = 4;
			this.Searchbtn.Text = "Search";
			this.Searchbtn.UseVisualStyleBackColor = false;
			this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
			// 
			// SearchTxtBox
			// 
			this.SearchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.SearchTxtBox.Location = new System.Drawing.Point(267, 126);
			this.SearchTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SearchTxtBox.Name = "SearchTxtBox";
			this.SearchTxtBox.Size = new System.Drawing.Size(572, 26);
			this.SearchTxtBox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(93, 132);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Search Medicine";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(-18, -9);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1215, 100);
			this.panel2.TabIndex = 34;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Meditechnology_System.Properties.Resources.image_removebg_preview__5_;
			this.pictureBox3.Location = new System.Drawing.Point(116, 31);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(208, 46);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 32;
			this.pictureBox3.TabStop = false;
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
			// AddStockbtn
			// 
			this.AddStockbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.AddStockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.AddStockbtn.ForeColor = System.Drawing.Color.White;
			this.AddStockbtn.Location = new System.Drawing.Point(984, 197);
			this.AddStockbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddStockbtn.Name = "AddStockbtn";
			this.AddStockbtn.Size = new System.Drawing.Size(166, 35);
			this.AddStockbtn.TabIndex = 35;
			this.AddStockbtn.Text = "Add Medicine";
			this.AddStockbtn.UseVisualStyleBackColor = false;
			this.AddStockbtn.Click += new System.EventHandler(this.AddStockbtn_Click);
			// 
			// InventoryScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1185, 692);
			this.Controls.Add(this.AddStockbtn);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SearchTxtBox);
			this.Controls.Add(this.Searchbtn);
			this.Controls.Add(this.Addbtn);
			this.Controls.Add(this.logoutBTN);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "InventoryScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "InventoryScreen";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddStockbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}