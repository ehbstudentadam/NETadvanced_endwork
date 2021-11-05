using BarAppAdam.Data;
using BarAppAdam.Entities;
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

namespace BarAppAdam
{
    public partial class OrderWindow : Form
    {
        private readonly DrinkRepository drinkRepository = new();
        private readonly OrderRepository orderRepository = new();
        private readonly MemberRepository memberRepository = new();
        private readonly Member? member;

        private Beer? beer;
        private Wine? wine;
        private Softdrink? softdrink;
        private Shot? shot;
        private Cocktail? cocktail;

        private int counterBeer = 0;
        private int counterWine = 0;
        private int counterSoftdrink = 0;
        private int counterShots = 0;
        private int counterCocktail = 0;
        private decimal totalPrice = 0;

        public OrderWindow(Member? member)
        {
            InitializeComponent();
            LoadDrinksFromDatabaseIntoThisClassToRead();
            this.member = member;
            ShowMemberInMemberViewList();
        }

        private void RemoveBeer_Click(object sender, EventArgs e)
        {
            if (counterBeer == 0)
            {
                return;
            }
            ViewOrder.Items.RemoveByKey($"Beer {counterBeer}");
            counterBeer--;
            CounterBeer.Text = counterBeer.ToString();
            UpdateTotalPrice();
        }

        private void AddBeer_Click(object sender, EventArgs e)
        {
            counterBeer++;
            CounterBeer.Text = counterBeer.ToString();
            ViewOrder.Items.Add($"Beer {counterBeer}", beer?.ToString(), counterBeer.ToString());
            UpdateTotalPrice();
        }

        private void RemoveWine_Click(object sender, EventArgs e)
        {
            if (counterWine == 0)
            {
                return;
            }
            ViewOrder.Items.RemoveByKey($"Wine {counterWine}");
            counterWine--;
            CounterWine.Text = counterWine.ToString();
            UpdateTotalPrice();
        }

        private void AddWine_Click(object sender, EventArgs e)
        {
            counterWine++;
            CounterWine.Text = counterWine.ToString();
            ViewOrder.Items.Add($"Wine {counterWine}", wine?.ToString(), counterWine.ToString());
            UpdateTotalPrice();
        }

        private void RemoveSoftdrink_Click(object sender, EventArgs e)
        {
            if (counterSoftdrink == 0)
            {
                return;
            }
            ViewOrder.Items.RemoveByKey($"Softdrink {counterSoftdrink}");
            counterSoftdrink--;
            CounterSoftdrink.Text = counterSoftdrink.ToString();
            UpdateTotalPrice();
        }

        private void AddSoftdrink_Click(object sender, EventArgs e)
        {
            counterSoftdrink++;
            CounterSoftdrink.Text = counterSoftdrink.ToString();
            ViewOrder.Items.Add($"Softdrink {counterSoftdrink}", softdrink?.ToString(), counterSoftdrink.ToString());
            UpdateTotalPrice();
        }

        private void RemoveShot_Click(object sender, EventArgs e)
        {
            if (counterShots == 0)
            {
                return;
            }
            ViewOrder.Items.RemoveByKey($"Shot {counterShots}");
            counterShots--;
            CounterShot.Text = counterShots.ToString();
            UpdateTotalPrice();
        }

        private void AddShot_Click(object sender, EventArgs e)
        {
            counterShots++;
            CounterShot.Text = counterShots.ToString();
            ViewOrder.Items.Add($"Shot {counterShots}", shot?.ToString(), counterShots.ToString());
            UpdateTotalPrice();
        }

        private void RemoveCocktail_Click(object sender, EventArgs e)
        {
            if (counterCocktail == 0)
            {

            }
            ViewOrder.Items.RemoveByKey($"Cocktail {counterCocktail}");
            counterCocktail--;
            CounterCocktail.Text = counterCocktail.ToString();
            UpdateTotalPrice();
        }

        private void AddCocktail_Click(object sender, EventArgs e)
        {
            counterCocktail++;
            CounterCocktail.Text = counterCocktail.ToString();
            ViewOrder.Items.Add($"Cocktail {counterCocktail}", cocktail?.ToString(), counterCocktail.ToString());
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (beer == null || wine == null || softdrink == null || shot == null || cocktail == null)
            {
                return;                 //VSCode wont pick up on nullcheck...
            }
            totalPrice = (decimal)((beer?.Price * counterBeer) + (wine?.Price * counterWine) + (softdrink?.Price * counterSoftdrink) + (shot?.Price * counterShots) + (cocktail?.Price * counterCocktail));
            OrderTotalLabel.Text = $"ORDER TOTAL: {totalPrice} EURO";
        }

        private void ShowMemberInMemberViewList()
        {
            if (member == null)
            {
                return;
            }
            ViewMember.Items.Add($"Name: {System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(member.FirstName)} {System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(member.LastName)}");
            ViewMember.Items.Add($"Wallet: {member.Wallet}");
        }

        private void LoadDrinksFromDatabaseIntoThisClassToRead()
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
                MessageBox.Show($"Drink database has been wrongly manipulated. Table will be truncated and reinitiated. Original Prices will be set. {Environment.NewLine} ({e.Message})", "Manipulation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (beer == null)
            {
                drinkRepository.Save(new Beer());
            }
            if (wine == null)
            {
                drinkRepository.Save(new Wine());
            }
            if (softdrink == null)
            {
                drinkRepository.Save(new Softdrink());
            }
            if (shot == null)
            {
                drinkRepository.Save(new Shot());
            }
            if (cocktail == null)
            {
                drinkRepository.Save(new Cocktail());
            }
            if (beer == null || wine == null || softdrink == null || shot == null || cocktail == null)
            {
                return;
            }

            PriceBeerLabel.Text = $"Price: {beer.Price}";
            PriceWineLabel.Text = $"Price: {wine.Price}";
            PriceSoftdrinkLabel.Text = $"Price: {softdrink.Price}";
            PriceShotLabel.Text = $"Price: {shot.Price}";
            PriceCocktailLabel.Text = $"Price: {cocktail.Price}";
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (beer == null || wine == null || softdrink == null || shot == null || cocktail == null || member == null)
            {
                return;
            }

            List<KeyValuePair<Drink, int>> drinkList = new List<KeyValuePair<Drink, int>>()
            {
                new KeyValuePair<Drink, int>(beer, counterBeer),
                new KeyValuePair<Drink, int>(wine, counterWine),
                new KeyValuePair<Drink, int>(softdrink, counterSoftdrink),
                new KeyValuePair<Drink, int>(shot, counterShots),
                new KeyValuePair<Drink, int>(cocktail, counterCocktail)
            };
            Order order = new(member, drinkList);
            orderRepository.Save(order);
            member.Wallet -= totalPrice;
            memberRepository.Save(member);

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
