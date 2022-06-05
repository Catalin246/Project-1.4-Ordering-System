using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public enum DrinkCategories
    {
        SoftDrink, Beer, Wine, SpiritDrink, CoffeeAndTea
    }
    public class Drink2 : Item
    {
        public DrinkCategories DrinkCategory { get; set; }
        public bool AlcoholicOrNonAlcoholic;
    }
}
