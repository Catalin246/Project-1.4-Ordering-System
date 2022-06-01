using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class OrderedItem
    {
        public OrderedItem(Item item, int amount, string note)
        {
            this.item = item;
            this.amount = amount;
            this.note = note;
        }
        public Item item;

        public int amount;

        public string note; //note

        private float totalPriceItem;

        //have a calculte property in here to calculate the item amount and price
        public float TotalPriceItem
        {

            get { return totalPriceItem; }
            set { totalPriceItem = (float)(amount * item.ItemPrice); }
        }
    }
}
