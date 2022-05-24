using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class Bill
    {
        public int BillId { get; set; }
        public string PaymentType { get; set; }
        public string BillNote { get; set; }
        public float Tip { get; set; }

        public float Total { get; set; }

        public List<Item> OrderItems;
        public float CalculateTotal()
        {
            float total = 0; 
            foreach(Item item in OrderItems)
            {
                if (item.ItemCategory != "Alcoholic")
                {
                    total += (float)((item.ItemPrice * item.ItemAmount) * 1.06); // 6% tax
                } else
                {
                    total += (float)((item.ItemPrice * item.ItemAmount) * 1.21); // 21% tax
                }
            }
            total += Tip;
            return total;
        }
        public  Bill()
        {

        }
        public Bill(int billId, string paymentType, string billNotes)
        {
            this.BillId = billId;
            this.BillNote = billNotes;
            this.PaymentType = paymentType;
        }
    }
}
