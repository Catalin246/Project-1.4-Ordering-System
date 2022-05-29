using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class Order
    {
        public Order(int tableID)
        {
            items = new List<OrderedItem>();
            this.TableId = tableID;
        }

        public Order()
        {

        }

        public List<OrderedItem> items;
        public int OrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public int BillId { get; set; }
        public int TableId { get; set; }

        public int determineBillID()
        {
            // List<Bill> = call get open bills getOpenBills(this.TableID)
            // if list is empty
                // create a new bill --> returns an id 
                // set BillID == that ^
            return 0;
        }
        
    }
}
