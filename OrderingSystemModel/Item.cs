using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public int ItemAmount { get; set; }    // menu item 
        public double ItemPrice { get; set; }
        public float totalPriceItem;


        //have  a calculte property in here to calculate the item amount and price 
        public float CalculateItemTotalPrice
        {
            
            get { return totalPriceItem; }
            set { totalPriceItem = (float)ItemAmount * (float)ItemPrice; }
        }

    }
}
