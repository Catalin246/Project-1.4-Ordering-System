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
            OrderedItems = new List<OrderedItem>();
            this.TableId = tableID;
        }

        public Order()
        {
            OrderTime = DateTime.Now;
        }
        
        public int OrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public int BillId { get; set; }
        public int TableId { get; set; }

        public Boolean Status { get; set; }
        public List<OrderedItem> OrderedItems { get; set; }
        public TimeSpan TimePassed 
        { 
            get 
            { 
                return (DateTime.Now.TimeOfDay - OrderTime.TimeOfDay); 
            } 
        }


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
