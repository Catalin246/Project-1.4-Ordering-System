using System;
using System.Collections.Generic;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
   
    public class BillService
    {
        BillDAO billDb;

        public BillService()
        {
            billDb = new BillDAO();
        }
        public List<Bill> GetOpenBills(int tableID)
        {
            List<Bill> bills = billDb.GetOpenBills(tableID);
            return bills;
        }

        public void CloseBill(Bill bill)
        {
            billDb.CloseBill(bill);
        }

        public void CloseSplitBill(Bill bill, float splitAmong)
        {
            billDb.CloseSplitBill(bill, splitAmong);
        }

    }
}
