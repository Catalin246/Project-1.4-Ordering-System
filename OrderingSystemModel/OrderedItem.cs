using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class OrderedItem
    {
        public const float AlcoholicVAT = 0.21f;
        public const float NonAlcoholicVAT = 0.06f;
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

        private float vatAmount;

        //have a calculte property in here to calculate the item amount and price
        public float TotalPriceItem
        {

            get { return totalPriceItem; }
            set { totalPriceItem = (float)(amount * item.ItemPrice); }
        }

        public float VatAmount
        {
            get { return vatAmount; }
            set
            {
                if (item.ItemCategory.ToLower() == "alcoholic")
                {
                    vatAmount = totalPriceItem * AlcoholicVAT;
                } else
                {
                    vatAmount = totalPriceItem * NonAlcoholicVAT;
                }
            }
        }

    }
}
