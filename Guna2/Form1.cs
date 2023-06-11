using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			// main panely jedal / drinkov
			FriesPanel.Visible = false;
			DrinksPanel.Visible = false;

			// sort panely 
			BurgersSortPanel.Visible = true;
			DrinksSortPanel.Visible = false;
			FriesSortPanel.Visible = false;


		}

		private void gunaPictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void userControl11_Load(object sender, EventArgs e)
		{

		}

		private void userControl12_Load(object sender, EventArgs e)
		{

		}

		private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
		{

		}

		private void gunaGradientBurgers_Click(object sender, EventArgs e)
		{
			// main panely jedal / drinkov
			BurgerPanel.Visible = true;
			FriesPanel.Visible = false;
			DrinksPanel.Visible = false;


			// sort panely 
			BurgersSortPanel.Visible = true;
			DrinksSortPanel.Visible = false;
			FriesSortPanel.Visible = false;
		}

		private void gunaGradientFries_Click(object sender, EventArgs e)
		{
			// main panely jedal / drinkov
			BurgerPanel.Visible = false;
			FriesPanel.Visible = true;
			DrinksPanel.Visible = false;

			// sort panely 
			FriesSortPanel.Visible = true;
			BurgersSortPanel.Visible = false;
			DrinksSortPanel.Visible = false;

		}

		private void gunaGradientDrinks_Click(object sender, EventArgs e)
		{
			// main panely jedal / drinkov
			BurgerPanel.Visible = false;
			FriesPanel.Visible = false;
			DrinksPanel.Visible = true;

			// sort panely 
			BurgersSortPanel.Visible = false;
			DrinksSortPanel.Visible = true;
			FriesSortPanel.Visible = false;
		}

		private void gunaGradientSalads_Click(object sender, EventArgs e)
		{

			// main panely jedal / drinkov
			BurgerPanel.Visible = false;
			FriesPanel.Visible = false;
			DrinksPanel.Visible = false;

			// sort panely 
			BurgersSortPanel.Visible = false;
			DrinksSortPanel.Visible = false;
			FriesSortPanel.Visible = false;
		}

		private void userControl13_Load(object sender, EventArgs e)
		{

		}

		private void gunaLabel12_Click(object sender, EventArgs e)
		{

		}

		private void gunaLabel18_Click(object sender, EventArgs e)
		{

		}

		private void gunaLabel17_Click(object sender, EventArgs e)
		{

		}

		private void gunaGradientPackaging_Click(object sender, EventArgs e)
		{
			// main panely jedal / drinkov
			BurgerPanel.Visible = false;
			FriesPanel.Visible = false;
			DrinksPanel.Visible = false;

			// sort panely 
			BurgersSortPanel.Visible = false;
			DrinksSortPanel.Visible = false;
			FriesSortPanel.Visible = false;
		}
	}
}
