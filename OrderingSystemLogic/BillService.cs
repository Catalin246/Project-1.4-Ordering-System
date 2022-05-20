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
    }
}
