using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class Order
    {
        public Order()
        {
            items = new List<Item>();
        }
        public List<Item> items;
        public int OrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public int BillId { get; set; }
        public int TableId { get; set; }

        
    }
}
