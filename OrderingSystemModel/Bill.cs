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
        public List<OrderedItem> OrderedItems { get { return this.orderedItems; } set { this.orderedItems = value; } }

        private List<Order> orders;
        public List<Order> Orders { get { return this.orders; } set { this.orders = value; } }
        public int BillId { get; set; }
        private PaymentType paymentType;
        public PaymentType PaymentType { get { return paymentType; } set { paymentType = value; } }
        public string BillFeedback { get; set; }
        public float Tip { get { return tip; } set { tip = value; } }
        public float TotalWithTIP { get { return Tip + BillTotalWithoutTip; } }
        public int tableId;
        private float tip;

        private float splitTotal;
        public float SplitTotal { get { return splitTotal; } set { splitTotal = value; } }

        public void SetPaymentType(String paymentOption)
        {
            switch (paymentOption)
            {
                case "Credit Card":
                    this.PaymentType = PaymentType.creditCard;
                    break;
                case "Debit Card":
                    this.PaymentType = PaymentType.debitCard;
                    break;
                case "Cash":
                    this.PaymentType = PaymentType.cash;
                    break;
                case "Mixed Payment":
                    this.PaymentType = PaymentType.mixedPayment;
                    break;
            }

        }

        public float BillTotalWithoutTip // returns total with vat
        {
            get
            {
                float total = 0;
                foreach (OrderedItem orderedItem in this.orderedItems)
                {
                    total += orderedItem.TotalPriceItem;
                }
                return total;
            }
            
        }

        public float TotalVatAmount
        {
            get
            {
                float total = 0;
                foreach (OrderedItem orderedItem in this.orderedItems)
                {
                    total += orderedItem.VatAmount;
                }
                return total;
            }
        }
      

        // public List<OrderedItem> orderedItem;
        public Bill() //to be able to save the bill on the data base even if the user dont enter a feedback or tip
        {
            this.BillFeedback = "";
            this.Tip = 0;
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
