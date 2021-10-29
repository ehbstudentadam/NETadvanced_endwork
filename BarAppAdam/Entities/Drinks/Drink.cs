using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarAppAdam.Entities
{
    public abstract class Drink : Entity
    {
        public virtual DrinkType Type { get; }
        public virtual Decimal Price { get; set; }

        public enum DrinkType
        {
            Beer,
            Wine,
            Softdrink,
            Shot,
            Cocktail            
        }
    }
}
