using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public enum DrinkType
    {
        SoftDrink, Beer, Wine, SpiritDrink, CoffeeOrTea
    }

    public class Drink2 : Item
    {
        public bool AlcoholicorNonAlcoholic;
    }
}
