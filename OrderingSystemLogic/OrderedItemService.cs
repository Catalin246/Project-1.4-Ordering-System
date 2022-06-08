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

        public List<OrderedItem> GetOrderedItemsByOrder(int orderID)
        {
            return orderedItemdb.GetOrderedItemsByOrder(orderID);
        }

        public void UpdateAmount(OrderedItem orderedITem, int orderId)
        {
            orderedItemdb.UpdateAmount(orderedITem, orderId);
        }

        //public List<OrderedItem> GetFoodOrders()
        //{
        //    //List<OrderedItem> orderedFoods = orderedItemdb.GetAllFoodOrders();
        //    return orderedFoods;
        //}

        public void ChangeStatus(OrderedItem item)
        {
            orderedItemdb.UpdateStatusToReady(orderedItem);
        }
    }
}
