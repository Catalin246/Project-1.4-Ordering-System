using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    //this is Beril's OrderedItem class because i couldnt code with other one.
    public class OrderedItem2
    {
        public Item Item { get; set; }
        public int OrderId { get; set; }
        public Status Status { get; set; }
        public string Note { get; set; }
        public int Amount { get; set; }

        public OrderedItem2(Item menuItem)
        {
            Item = menuItem;
            Amount = 1;
            Note = "";
        }
        public OrderedItem2()
        {
            Amount = 1;
            Note = "";
        }
    }
    public enum Status
    {
        Preparing, Ready, Served, Paid
    }
}
