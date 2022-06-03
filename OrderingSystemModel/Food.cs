using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class Food : Item
    {
        public FoodType FoodType { get; set; }
    }

    public enum FoodType
    {
        LunchStarter, LunchMain, LunchDessert, DinnerStarter, DinnerEntremets, DinnerMain, DinnerDessert
    }
}
