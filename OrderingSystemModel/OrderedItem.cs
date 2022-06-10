using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public enum Status
    {
        Preparing, Ready, Served, Paid
    }

    public class OrderedItem
    {
        public const float AlcoholicVAT = 0.21f;
        public const float NonAlcoholicVAT = 0.06f;
        public OrderedItem()
        {
            Amount = 1;
            Note = ""; 
        }
        public OrderedItem(Item item)
        {
            Item = item;
            Amount = 1;
            Note = ""; //or "none"
        }

        public OrderedItem(Item item, int amount, string note, int orderId)
        {
            this.Item = item;
            this.Amount = amount;
            this.Note = note;
            this.OrderId = orderId;
        }

        public Item Item { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int OrderId { get; set; }
        public Status Status { get; set; }        
        public string Note { get; set; }
        public int Amount { get; set; }

        public int TableId { get; set; }
        public DateTime OrderTime { get; set; }

        public int ItemID { get; set; }
             
        // private float totalPriceItem;       

        // private float vatAmount;

        public bool ItemAddedInDatabase = false;   

        //have a calculte property in here to calculate the item amount and price
        public float TotalPriceItem
        {

            get {
                return (float)(Amount * Item.ItemPrice); 
            }
        }

        private bool UseAlcoholicVat
        {
            get
            {
                if (Item.ItemType == "Beer" || Item.ItemType == "Wine" || Item.ItemType == "Spirit drink")
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public float VatAmount
        {
            get {
                if (UseAlcoholicVat)
                {
                    return this.TotalPriceItem * AlcoholicVAT;
                }
                else
                {
                    return this.TotalPriceItem * NonAlcoholicVAT;
                }
            }
        }
        
    }    
}

