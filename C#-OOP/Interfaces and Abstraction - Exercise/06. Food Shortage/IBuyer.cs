﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
   public interface IBuyer
    {
        void BuyFood();
        int Food { get; }
    }
}
