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
        List<Order> orders; // to get to the list of ordered items in the order class
        public int BillId { get; set; }
        public PaymentType PaymentType { get { return this.PaymentType; } set { PaymentType = value; } }
        public string BillFeedback { get; set; }
        public float Tip { get; set; }
        public int tableId;

        public bool ClosedBill;

        public float BillTotal
        {
            get
            {
                return this.BillTotal;
            }
            set
            {
                float total = 0;
                /*foreach (Order order in orders)
                {
                    foreach(OrderedItem item in order.orderedItems)
                        if (item. != "Alcoholic")
                        {
                            total += item.* nonalcoholicVAT); // 6% tax
                        }
                        else
                        {
                            total += (float)((item.ItemPrice * item.ItemAmount) * AlcoholicVAT); // 21% tax
                        }
                }
                total += Tip;*/
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
