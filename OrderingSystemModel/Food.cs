using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public enum FoodTypes
    {
        LunchStarter, LunchMain, LunchDessert, DinnerStarter, DinnerEntremets, DinnerMain, DinnerDessert
    }
    public class Food : Item
    {
        public FoodTypes FoodType { get; set; }
    }
}
