using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public enum PaymentType{ cash, creditCard, debitCard}
    public class Bill
    {
        public const float AlcoholicVAT = 1.21f;
        public const float nonalcoholicVAT = 1.06f;

        List<OrderedItem> orderedItems; // to get to the list of ordered items in the order class
        public int BillId { get; set; }
        public PaymentType PaymentType { get { return this.PaymentType; } set { PaymentType = value; } }
        public string BillFeedback { get; set; }
        public float Tip { get; set; }
        public int tableId;


        public float BillTotalWithoutTip
        {
            get
            {
                return this.BillTotalWithoutTip;
            }
            set
            {
                float total = 0;
                foreach (OrderedItem orderedItem in orderedItems)
                { 
                    if (orderedItem.item.ItemCategory == "Drink" && 0 == 1) // determine way to figure out if a drink is alco
                    {
                        total += orderedItem.TotalPriceItem * AlcoholicVAT; // 21% tax
                    }
                    else
                    {
                        total += orderedItem.TotalPriceItem * nonalcoholicVAT; // 6% tax
                    }
                }
                BillTotalWithoutTip = total;
            }
        }

        // public List<OrderedItem> orderedItem;
        public Bill()
        {

        }
        public  Bill(int billId)
        {
            this.BillId = billId;
        }
        public void updateBill(PaymentType paymentType, string billFeedback)
        {
            this.BillFeedback = billFeedback;
            this.PaymentType = paymentType;
        }


    }
}
