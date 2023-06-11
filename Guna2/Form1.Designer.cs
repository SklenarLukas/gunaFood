namespace Guna2
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
			this.gunaGradientTileButton1 = new Guna.UI.WinForms.GunaGradientTileButton();
			this.gunaPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gunaPanel1
			// 
			this.gunaPanel1.Controls.Add(this.gunaGradientTileButton1);
			this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
			this.gunaPanel1.Name = "gunaPanel1";
			this.gunaPanel1.Size = new System.Drawing.Size(101, 681);
			this.gunaPanel1.TabIndex = 0;
			// 
			// gunaGradientTileButton1
			// 
			this.gunaGradientTileButton1.AnimationHoverSpeed = 0.07F;
			this.gunaGradientTileButton1.AnimationSpeed = 0.03F;
			this.gunaGradientTileButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(117)))), ((int)(((byte)(17)))));
			this.gunaGradientTileButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.gunaGradientTileButton1.BorderColor = System.Drawing.Color.Black;
			this.gunaGradientTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.gunaGradientTileButton1.FocusedColor = System.Drawing.Color.Empty;
			this.gunaGradientTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
			this.gunaGradientTileButton1.ForeColor = System.Drawing.Color.White;
			this.gunaGradientTileButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.gunaGradientTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton1.Image")));
			this.gunaGradientTileButton1.ImageSize = new System.Drawing.Size(52, 52);
			this.gunaGradientTileButton1.Location = new System.Drawing.Point(12, 97);
			this.gunaGradientTileButton1.Name = "gunaGradientTileButton1";
			this.gunaGradientTileButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
			this.gunaGradientTileButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
			this.gunaGradientTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
			this.gunaGradientTileButton1.OnHoverForeColor = System.Drawing.Color.White;
			this.gunaGradientTileButton1.OnHoverImage = null;
			this.gunaGradientTileButton1.OnPressedColor = System.Drawing.Color.Black;
			this.gunaGradientTileButton1.Size = new System.Drawing.Size(78, 71);
			this.gunaGradientTileButton1.TabIndex = 1;
			this.gunaGradientTileButton1.Text = "gunaGradientTileButton1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1117, 681);
			this.Controls.Add(this.gunaPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.gunaPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI.WinForms.GunaPanel gunaPanel1;
		private Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton1;
	}
}

