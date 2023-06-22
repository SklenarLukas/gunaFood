using Guna2.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace Guna2
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{


		}

		public static Form activeform = null;
		public void openchildFrom(Form childForm)
		{
			if (activeform != null)
			{
				activeform.Close();
			}
			activeform = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;

			//mainPanel.BorderRadius = 10;
			sortPanel.Controls.Add(childForm);
			sortPanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		

		public void HideElements()
		{
			

		}
		private void gunaGradientBurgers_Click(object sender, EventArgs e)
		{




			



		}

		private void gunaGradientFries_Click(object sender, EventArgs e)
		{
			BurgersSortPanel.Visible = false;
			openchildFrom(new FriesSort());
			


		}

		private void gunaGradientDrinks_Click(object sender, EventArgs e)
		{

			BurgersSortPanel.Visible = false;
			openchildFrom(new DrinksSort());

		}

		private void gunaGradientSalads_Click(object sender, EventArgs e)
		{

		}

		private void gunaGradientPackaging_Click(object sender, EventArgs e)
		{
			
		}

		private void gunaLabel1_Click(object sender, EventArgs e)
		{

		}
		private void SearchBox_TextChanged(object sender, EventArgs e)
		{
			foreach (var item in panel.Controls)
			{
				var wdg = (Widget)item;
				wdg.Visible = wdg.lblTitle.Text.ToLower().ToLower().Contains(SearchBox.Text.Trim().ToLower());
				//	&& (wdg.Tag.ToString() ==;
			}
		}

		private void SearchBox_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void SearchBox_Enter(object sender, EventArgs e)
		{
			if (SearchBox.Text == "Vyhľadať...")
			{
				SearchBox.Text = "";

			}
		}

		private void SearchBox_Leave(object sender, EventArgs e)
		{
			if (SearchBox.Text == "")
			{
				SearchBox.Text = "Vyhľadať...";
			}

		}

		private void gunaPictureBox1_Click(object sender, EventArgs e)
		{
			// totot tu skusit ze ked kliknem na lupu focusne mi okno vyhladavania

		}



		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}


		private void MainPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		public void AddItem(string name, double cost, categories category, string icon)
		{
			var w = new Widget()
			{
				Title = name,
				Cost = cost,
				Category = category,
				Icon = System.Drawing.Image.FromFile("icons/" + icon),
				Tag = category
			};
			panel.Controls.Add(w);

			w.OnSelect += (ss, ee) =>
			{
				var wdg = (Widget)ss;
				foreach (DataGridViewRow item in grid.Rows)
				{
					if (item.Cells[0].Value.ToString() == wdg.lblTitle.Text)
					{
						item.Cells[1].Value = int.Parse(item.Cells[1].Value.ToString()) + 1;
						item.Cells[2].Value = (int.Parse(item.Cells[1].Value.ToString()) * double.Parse(wdg.lblCost.Text.Replace("€", ""))).ToString("C2");
						CalculateTotal();
						return;
					}
				}
				grid.Rows.Add(new object[] { wdg.lblTitle.Text, 1, wdg.lblCost.Text });
				CalculateTotal();
			};
		}

		void CalculateTotal()
		{
			double tot = 0;
			foreach (DataGridViewRow item in grid.Rows)
			{
				tot += double.Parse(item.Cells[2].Value.ToString().Replace("€", ""));
			}
			lblTot.Text = tot.ToString("C2");
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			// burgre
			AddItem("Cheese", 10.95, categories.Burgre, "cheeseburger.jpg");
			AddItem("BBQ", 11.95, categories.Burgre, "bbqburger.jpg");
			AddItem("Beef", 11.50, categories.Burgre, "beefburger.jpg");
			AddItem("Veggie", 12.50, categories.Burgre, "veggieburger.jpg");
			AddItem("Chicken", 10.50, categories.Burgre, "chickenburger.jpg");


			// hranolky
			AddItem("Hranolky L", 1.50, categories.Hranolky, "frenchfries.jpg");
			AddItem("Hranolky XL", 2.20, categories.Hranolky, "frenchfries.jpg");

			AddItem("Steakové L", 1.80, categories.Hranolky, "steakfries.jpg");
			AddItem("Steakové XL", 2.40, categories.Hranolky, "steakfries.jpg");

			AddItem("Batátové L", 2.70, categories.Hranolky, "batatafries.jpg");
			AddItem("Batátové XL", 3.50, categories.Hranolky, "batatafries.jpg");

			// napoje
			AddItem("Fanta", 1.90, categories.Napoje, "fanta.png");
			AddItem("CocaCola", 2.20, categories.Napoje, "cocacola.jpg");
			AddItem("Pepsi", 2.40, categories.Napoje, "pepsicola.jpg");
			AddItem("Džús pomaranč", 2.40, categories.Napoje, "orangejuice.png");
			AddItem("Sprite", 2.10, categories.Napoje, "sprite.png");
			AddItem("Citronáda", 2.00, categories.Napoje, "citronade.png");

			// salaty
			AddItem("Grécky", 5.20, categories.Salaty, "greeksalad.jpg");
			AddItem("Mozzarelový", 5.80, categories.Salaty, "mozarellasalad.jpg");
			AddItem("Paradajkový", 5.00, categories.Salaty, "tomatosalad.jpg");
			AddItem("Uhorkový", 4.80, categories.Salaty, "cucumbersalad.jpg");
		}

		private void gunaLabel4_Click(object sender, EventArgs e)
		{

		}

		private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void gunaGradientTileButton1_Click(object sender, EventArgs e)
		{

		}

		private void gunaPictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void gunaPanel1_Paint(object sender, PaintEventArgs e)
		{
		}
			

		private void panel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void gunaAdvenceTileButton6_Click(object sender, EventArgs e)
		{

		}

		private void gunaGradientButton1_Click(object sender, EventArgs e)
		{
			//openchildFrom(new Payment());
			Payment open = new Payment();
			open.Show();
			this.Hide();


		}

		private void gunaGradientButton2_Click(object sender, EventArgs e)
		{
			grid.Rows.Clear();
			lblTot.Text = "€ 0";
		}
	}
}
