using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class OrderedItem
    {
        public OrderedItem(Item item, int amount, string remark)
        {
            this.item = item;
            this.amount = amount;
            this.remark = remark;
        }
        public Item item;

        public int amount;

        public string remark; //note
    }
}
