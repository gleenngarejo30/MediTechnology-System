namespace Meditechnology_System
{
	partial class NurseScreen
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
			this.userControl21 = new Meditechnology_System.UserControl2();
			this.userControl12 = new Meditechnology_System.nurse();
			this.SuspendLayout();
			// 
			// userControl21
			// 
			this.userControl21.Location = new System.Drawing.Point(0, 0);
			this.userControl21.Name = "userControl21";
			this.userControl21.Size = new System.Drawing.Size(867, 657);
			this.userControl21.TabIndex = 2;
			this.userControl21.Visible = false;
			this.userControl21.VisibleChanged += new System.EventHandler(this.userControl21_VisibleChanged);
			// 
			// userControl12
			// 
			this.userControl12.Location = new System.Drawing.Point(0, 0);
			this.userControl12.Name = "userControl12";
			this.userControl12.Size = new System.Drawing.Size(867, 657);
			this.userControl12.TabIndex = 1;
			this.userControl12.Visible = false;
			this.userControl12.VisibleChanged += new System.EventHandler(this.userControl12_VisibleChanged);
			// 
			// NurseScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(865, 698);
			this.Controls.Add(this.userControl12);
			this.Controls.Add(this.userControl21);
			this.Name = "NurseScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MEDITECH";
			this.Load += new System.EventHandler(this.NurseScreen_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private nurse userControl12;
		private UserControl2 userControl21;
	}
}