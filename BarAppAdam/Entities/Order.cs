using BarAppAdam.Entities.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarAppAdam.Entities
{
    public class Order : Entity
    {
        public Member Member { get; set; }
        public List<KeyValuePair<Drink, int>> Drinks { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Decimal PriceTotal { get; set; }
        public string DrinksInStringFormat 
        {
            get 
            {
                return PrintAllDrinks();            //DataGridView box in ShowOrders Form wont display a column for KeyValuePair Lists.
            }                                       //It does accept strings. Here, when asked for DrinksInStringFormat it will return the converted string.
            set { DrinksInStringFormat = PrintAllDrinks(); }
        }


        public Order (Member member, List<KeyValuePair<Drink, int>> drinkList)
        {
            Member = member;
            Drinks = drinkList;
            CalculateOrderTotal(drinkList);
        }

        private void CalculateOrderTotal(List<KeyValuePair<Drink, int>> drinkList)
        {
            foreach (var item in drinkList)
            {
                decimal priceOfSpecificDrink = item.Key.Price;
                int quantityOfSpecificDrink = item.Value;
                this.PriceTotal += (priceOfSpecificDrink * quantityOfSpecificDrink);
            }
        }

        public string PrintAllDrinks()                  //Also used when order is saving the KVList of drinks to DB as a string.
        {
            StringBuilder sb = new();

            foreach (var item in Drinks)
            {
                sb.Append($"[{item.Key.Type}: {item.Value}] ");
            }
            return sb.ToString();
        }
    }
}
