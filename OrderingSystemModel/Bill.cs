using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public enum PaymentType{ cash, creditCard, debitCard, mixedPayment}
    public class Bill
    {

        private List<OrderedItem> orderedItems; // to get to the list of ordered items in the order class
        public int BillId { get; set; }
        public PaymentType PaymentType { get { return this.PaymentType; } set { PaymentType = value; } }
        public string BillFeedback { get; set; }
        public float Tip { get { return tip; } set { tip = value; } }
        public int tableId;
        private float tip;
        public List<OrderedItem> OrderedItems { get { return this.orderedItems; } set { this.orderedItems = value; } }

        public float BillTotalWithoutTip
        {
            get
            {
                float total = 0;
                foreach (OrderedItem orderedItem in this.orderedItems)
                {
                    total += orderedItem.TotalPriceItem + orderedItem.VatAmount;
                }
                return total;
            }
            
        }
      

        // public List<OrderedItem> orderedItem;
        public Bill()
        {

        }
        public  Bill(int tableId)
        {
            this.tableId = tableId;
        }
        public void updateBill(PaymentType paymentType, string billFeedback)
        {
            this.BillFeedback = billFeedback;
            this.PaymentType = paymentType;
        }


    }
}
