using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class OrderedItem
    {
        public OrderedItem()
        {

        }

        public OrderedItem(Item item, int amount, string note, int orderId)
        {
            this.item = item;
            this.amount = amount;
            this.note = note;
            this.orderId = orderId;
        }
        public Item item;

        public int orderId;

        public int itemID;

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
