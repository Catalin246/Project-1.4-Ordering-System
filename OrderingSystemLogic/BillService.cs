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
        
        public List<Bill> GetBills()
        {
            List<Bill> bills = billDb.GetAllBills();
            return bills;
        }

        public List<Bill> GetOpenBills(int tableID)
        {
            List<Bill> bills = billDb.GetOpenBills(tableID);
            return bills;
        }

        public void CloseBill(int billID)
        {
            // connect to database and set bill.ClosedBill =  1
        }

    }
}
