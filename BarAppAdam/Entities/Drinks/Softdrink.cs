﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarAppAdam.Entities.Drinks
{
    public class Softdrink : Drink
    {
        public override DrinkType Type { get; } = DrinkType.Softdrink;
        public override Decimal Price { get; set; } = 1;
    }
}
