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
        public DateTime CreatedDate { get; } = DateTime.Now;
        public Decimal PriceTotal { get; set; }



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
                this.PriceTotal += (priceOfSpecificDrink + quantityOfSpecificDrink);
            }
        }

        public string PrintAllDrinks()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Drinks)
            {
                sb.Append($"[{item.Key.GetType}: {item.Value}] ");
            }
            return sb.ToString();
        }
    }
}
