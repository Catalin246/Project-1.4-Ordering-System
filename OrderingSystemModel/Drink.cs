﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class Drink : Item
    {
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public float DrinkPrice { get; set; }
    }
}