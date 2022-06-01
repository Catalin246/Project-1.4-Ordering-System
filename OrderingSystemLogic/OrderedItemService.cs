using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
    public class OrderedItemService
    {
        OrderedItemDao orderedItemdb;

        public OrderedItemService()
        {
            orderedItemdb = new OrderedItemDao();   
        }

        public void AddOrderesItem(OrderedItem orderedItem, Order order)
        {
            orderedItemdb.Add(orderedItem,order);
        }
    }
}
