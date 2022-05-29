using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public enum DrinkType { alcoholic, nonAlcoholic};
    public class Drink
    {
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public float DrinkPrice { get; set; }

        public DrinkType drinkType { get; set; }
    }
}