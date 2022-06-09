using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class Table
    {
        public int TableId { get; set; }
        public string EmployeeId { get; set; }
        public int ItemId { get; set; } 
        public string OrderStatus { get; set; }
        public DateTime Time { get; set; }
        public int OrderId { get; set; }
        public string TableStatus { get; set; }
    }
}
