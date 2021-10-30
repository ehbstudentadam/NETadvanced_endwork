using BarAppAdam.Entities.Drinks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarAppAdam.ToolStripMenuForms
{
    public partial class EditDrink : Form
    {
        private readonly DrinkRepository drinkRepository = new ();
        private Beer? beer;
        private Wine? wine;
        private Softdrink? softdrink;
        private Shot? shot;
        private Cocktail? cocktail;

        public EditDrink()
        {
            InitializeComponent();
            LoadDrinkDetails();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CheckAllChangesAndApply();
            LoadDrinkDetails();
        }

        private void LoadDrinkDetails()
        {
            beer = (Beer?)drinkRepository.GetEntity(0);
            wine = (Wine?)drinkRepository.GetEntity(1);
            softdrink = (Softdrink?)drinkRepository.GetEntity(2);
            shot = (Shot?)drinkRepository.GetEntity(3);
            cocktail = (Cocktail?)drinkRepository.GetEntity(4);

            if (beer == null || wine == null || softdrink == null || shot == null || cocktail == null)
            {
                return;
            }

            PriceBeerTextbox.Text = Convert.ToString(beer.Price);
            PriceWineTextbox.Text = Convert.ToString(wine.Price);
            PriceSoftdrinkTextbox.Text = Convert.ToString(softdrink.Price);
            PriceShotTextbox.Text = Convert.ToString(shot.Price);
            PriceCocktailTextbox.Text = Convert.ToString(cocktail.Price);

            CurrentPriceBeerLabel.Text = $"Euro. (Current price: {Convert.ToString(beer.Price)})";
            CurrentPriceWineLabel.Text = $"Euro. (Current price: {Convert.ToString(wine.Price)})";
            CurrentPriceSoftdrinkLabel.Text = $"Euro. (Current price: {Convert.ToString(softdrink.Price)})";
            CurrentPriceShotLabel.Text = $"Euro. (Current price: {Convert.ToString(shot.Price)})";
            CurrentPriceCocktailLabel.Text = $"Euro. (Current price: {Convert.ToString(cocktail.Price)})";
        }

        private void CheckAllChangesAndApply()
        {
            if (PriceBeerTextbox.Text == null || PriceWineTextbox.Text == null || PriceSoftdrinkTextbox.Text == null || PriceShotTextbox.Text == null || PriceCocktailTextbox.Text == null)
            {
                MessageBox.Show("All fields must have a price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(beer == null || wine == null || softdrink == null || shot == null || cocktail == null)
            {
                return;
            }

            if (PriceBeerTextbox.Text != Convert.ToString(beer.Price) && decimal.TryParse(PriceBeerTextbox.Text, out _))
            {
                decimal price = Convert.ToDecimal(PriceBeerTextbox.Text);
                beer.Price = price;
            }
            if (PriceWineTextbox.Text != Convert.ToString(wine.Price) && decimal.TryParse(PriceWineTextbox.Text, out _))
            {
                decimal price = Convert.ToDecimal(PriceWineTextbox.Text);
                wine.Price = price;
            }
            if (PriceSoftdrinkTextbox.Text != Convert.ToString(softdrink.Price) && decimal.TryParse(PriceSoftdrinkTextbox.Text, out _))
            {
                decimal price = Convert.ToDecimal(PriceSoftdrinkTextbox.Text);
                softdrink.Price = price;
            }
            if (PriceShotTextbox.Text != Convert.ToString(shot.Price) && decimal.TryParse(PriceShotTextbox.Text, out _))
            {
                decimal price = Convert.ToDecimal(PriceShotTextbox.Text);
                shot.Price = price;
            }
            if (PriceCocktailTextbox.Text != Convert.ToString(cocktail.Price) && decimal.TryParse(PriceCocktailTextbox.Text, out _))
            {
                decimal price = Convert.ToDecimal(PriceCocktailTextbox.Text);
                cocktail.Price = price;
            }
        }

        private void LoadDrinksToDatabase()
        {
            if (beer == null || wine == null || softdrink == null || shot == null || cocktail == null)
            {
                return;
            }

            drinkRepository.Save(beer);
            drinkRepository.Save(wine);
            drinkRepository.Save(softdrink);
            drinkRepository.Save(shot);
            drinkRepository.Save(cocktail);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAllChangesAndApply();
            LoadDrinkDetails();            
            LoadDrinksToDatabase();
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }
    }
}
