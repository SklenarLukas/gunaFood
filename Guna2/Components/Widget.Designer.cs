namespace Guna2.Components
{
	partial class Widget
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
			this.widgetPanel = new Guna.UI.WinForms.GunaGradient2Panel();
			this.lblCost = new Guna.UI.WinForms.GunaLabel();
			this.imgImage = new Guna.UI.WinForms.GunaCirclePictureBox();
			this.lblTitle = new Guna.UI.WinForms.GunaLabel();
			this.widgetPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
			this.SuspendLayout();
			// 
			// widgetPanel
			// 
			this.widgetPanel.BackColor = System.Drawing.Color.Transparent;
			this.widgetPanel.Controls.Add(this.lblCost);
			this.widgetPanel.Controls.Add(this.imgImage);
			this.widgetPanel.Controls.Add(this.lblTitle);
			this.widgetPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.widgetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.widgetPanel.GradientColor1 = System.Drawing.Color.WhiteSmoke;
			this.widgetPanel.GradientColor2 = System.Drawing.Color.WhiteSmoke;
			this.widgetPanel.Location = new System.Drawing.Point(0, 0);
			this.widgetPanel.Name = "widgetPanel";
			this.widgetPanel.Radius = 12;
			this.widgetPanel.Size = new System.Drawing.Size(285, 140);
			this.widgetPanel.TabIndex = 0;
			this.widgetPanel.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
			this.widgetPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.widgetPanel_Paint);
			// 
			// lblCost
			// 
			this.lblCost.AutoSize = true;
			this.lblCost.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCost.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(124)))), ((int)(((byte)(31)))));
			this.lblCost.Location = new System.Drawing.Point(15, 87);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new System.Drawing.Size(130, 30);
			this.lblCost.TabIndex = 20;
			this.lblCost.Text = "2.70€ (150g)";
			this.lblCost.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
			// 
			// imgImage
			// 
			this.imgImage.BaseColor = System.Drawing.Color.White;
			this.imgImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgImage.ErrorImage = null;
			this.imgImage.Image = ((System.Drawing.Image)(resources.GetObject("imgImage.Image")));
			this.imgImage.ImageLocation = "";
			this.imgImage.Location = new System.Drawing.Point(157, 10);
			this.imgImage.Name = "imgImage";
			this.imgImage.Size = new System.Drawing.Size(120, 120);
			this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgImage.TabIndex = 19;
			this.imgImage.TabStop = false;
			this.imgImage.UseTransfarantBackground = false;
			this.imgImage.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click_1);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblTitle.Location = new System.Drawing.Point(13, 25);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(135, 25);
			this.lblTitle.TabIndex = 18;
			this.lblTitle.Text = "Cheese burger";
			this.lblTitle.Click += new System.EventHandler(this.gunaCirclePictureBox1_Click);
			// 
			// Widget
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.widgetPanel);
			this.Name = "Widget";
			this.Size = new System.Drawing.Size(285, 140);
			this.Load += new System.EventHandler(this.Widget_Load);
			this.widgetPanel.ResumeLayout(false);
			this.widgetPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI.WinForms.GunaGradient2Panel widgetPanel;
		public Guna.UI.WinForms.GunaLabel lblCost;
		public Guna.UI.WinForms.GunaCirclePictureBox imgImage;
		public Guna.UI.WinForms.GunaLabel lblTitle;
	}
}
