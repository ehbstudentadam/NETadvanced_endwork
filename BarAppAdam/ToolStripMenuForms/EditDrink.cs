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
            LoadDrinksFromDatabaseIntoThisClassToEdit();
            LoadDetailsToForm();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CheckAllChangesAndApply();
            LoadDetailsToForm();
        }

        private void LoadDetailsToForm()
        {     
            if (beer == null || wine == null || softdrink == null || shot == null || cocktail == null)
            {
                return;
            }

            PriceBeerTextbox.Text = Convert.ToString(beer.Price);
            PriceWineTextbox.Text = Convert.ToString(wine.Price);
            PriceSoftdrinkTextbox.Text = Convert.ToString(softdrink.Price);
            PriceShotTextbox.Text = Convert.ToString(shot.Price);
            PriceCocktailTextbox.Text = Convert.ToString(cocktail.Price);

            CurrentPriceBeerLabel.Text = $"> Current price: {Convert.ToString(beer.Price)}";
            CurrentPriceWineLabel.Text = $"> Current price: {Convert.ToString(wine.Price)}";
            CurrentPriceSoftdrinkLabel.Text = $"> Current price: {Convert.ToString(softdrink.Price)}";
            CurrentPriceShotLabel.Text = $"> Current price: {Convert.ToString(shot.Price)}";
            CurrentPriceCocktailLabel.Text = $"> Current price: {Convert.ToString(cocktail.Price)}";
        }

        private void CheckAllChangesAndApply()
        {

            if (PriceBeerTextbox.Text == null || PriceWineTextbox.Text == null || PriceSoftdrinkTextbox.Text == null || PriceShotTextbox.Text == null || PriceCocktailTextbox.Text == null)
            {
                MessageBox.Show("All fields must have a price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (beer == null || wine == null || softdrink == null || shot == null || cocktail == null)
            {
                return;
            }

            if (PriceBeerTextbox.Text != Convert.ToString(beer.Price) && decimal.TryParse(PriceBeerTextbox.Text, out _))
            {
                decimal price = Convert.ToDecimal(PriceBeerTextbox.Text);
                this.beer.Price = price;
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

        private void DoneButton_Click(object sender, EventArgs e)
        {
            CheckAllChangesAndApply();
            LoadDetailsToForm();            
            LoadDrinksToDatabase();
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }

        private void LoadDrinksFromDatabaseIntoThisClassToEdit()
        {
            try
            {
                beer = (Beer?)drinkRepository.GetEntity(1);
                wine = (Wine?)drinkRepository.GetEntity(2);
                softdrink = (Softdrink?)drinkRepository.GetEntity(3);
                shot = (Shot?)drinkRepository.GetEntity(4);
                cocktail = (Cocktail?)drinkRepository.GetEntity(5);
            }
            catch (System.InvalidCastException e)
            {
                drinkRepository.TruncateTable();
                MessageBox.Show($"Drink database has been wrongly manipulated. Table will be truncated and reinitiated. ({e.Message})", "Manipulation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDetailsToForm();
                return;
            }
        }
    }
}
