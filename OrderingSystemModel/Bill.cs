﻿using System;
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
        public Bill(int billId, string paymentType, string billNotes)
        {
            this.BillId = billId;
            this.BillNote = billNotes;
            this.PaymentType = paymentType;
        }
    }
}
