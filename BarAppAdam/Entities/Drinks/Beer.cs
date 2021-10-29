﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarAppAdam.Entities.Drinks
{
    public class Beer : Drink
    {
        public override DrinkType Type { get; } = DrinkType.Beer;
        public override Decimal Price { get; set; } = 1;

    }
}
