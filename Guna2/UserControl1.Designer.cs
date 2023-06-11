namespace Guna2
{
	partial class UserControl1
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
			this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
			this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
			this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
			this.gunaGradient2Panel1.SuspendLayout();
			this.gunaShadowPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gunaGradient2Panel1
			// 
			this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel1.Controls.Add(this.gunaLabel2);
			this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(161)))), ((int)(((byte)(88)))));
			this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
			this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
			this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
			this.gunaGradient2Panel1.Radius = 4;
			this.gunaGradient2Panel1.Size = new System.Drawing.Size(54, 34);
			this.gunaGradient2Panel1.TabIndex = 0;
			// 
			// gunaShadowPanel1
			// 
			this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
			this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
			this.gunaShadowPanel1.Location = new System.Drawing.Point(3, 68);
			this.gunaShadowPanel1.Name = "gunaShadowPanel1";
			this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Transparent;
			this.gunaShadowPanel1.ShadowShift = 2;
			this.gunaShadowPanel1.Size = new System.Drawing.Size(144, 41);
			this.gunaShadowPanel1.TabIndex = 1;
			// 
			// gunaLabel1
			// 
			this.gunaLabel1.AutoSize = true;
			this.gunaLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gunaLabel1.Location = new System.Drawing.Point(17, 11);
			this.gunaLabel1.Name = "gunaLabel1";
			this.gunaLabel1.Size = new System.Drawing.Size(108, 20);
			this.gunaLabel1.TabIndex = 0;
			this.gunaLabel1.Text = "Cheese burger";
			// 
			// gunaLabel2
			// 
			this.gunaLabel2.AutoSize = true;
			this.gunaLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
			this.gunaLabel2.ForeColor = System.Drawing.Color.White;
			this.gunaLabel2.Location = new System.Drawing.Point(1, 7);
			this.gunaLabel2.Name = "gunaLabel2";
			this.gunaLabel2.Size = new System.Drawing.Size(51, 20);
			this.gunaLabel2.TabIndex = 0;
			this.gunaLabel2.Text = "10.95€";
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gunaShadowPanel1);
			this.Controls.Add(this.gunaGradient2Panel1);
			this.Name = "UserControl1";
			this.gunaGradient2Panel1.ResumeLayout(false);
			this.gunaGradient2Panel1.PerformLayout();
			this.gunaShadowPanel1.ResumeLayout(false);
			this.gunaShadowPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
		private Guna.UI.WinForms.GunaLabel gunaLabel2;
		private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
		private Guna.UI.WinForms.GunaLabel gunaLabel1;
	}
}
