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
            orderedItemdb.AddOrderesItem(orderedItem,order);
        }

        public List<OrderedItem> GetOrderedItemsByOrder(int orderID)
        {
            return orderedItemdb.GetOrderedItemsByOrder(orderID);
        }

        public void UpdateAmount(OrderedItem orderedITem, int orderId)
        {
            orderedItemdb.UpdateAmount(orderedITem, orderId);
        }

        public List<OrderedItem> GetPreparingFoodItemsFromDaoClass()
        {
            return orderedItemdb.GetPreparingFoodItemsFromDatabase();
        }

        public List<OrderedItem> GetFinishedFoodItemsFromDaoClass()
        {
            return orderedItemdb.GetFinishedFoodItemsFromDatabase();
        }

        public List<OrderedItem> GetPreparingDrinkItemsFromDaoClass()
        {
            return orderedItemdb.GetPreparingDrinkItemsFromDatabase();
        }
        public List<OrderedItem> GetFinishedDrinkItemsFromDaoClass()
        {
            return orderedItemdb.GetFinishedDrinkItemsFromDatabase();
        }

        public void ChangeOrderStatusToReady(int orderNo, int itemId)
        {
            orderedItemdb.ChangeFoodAndDrinkStatusToReady(orderNo, itemId);
        }

        public void ChangeOrderStatusToPaid(int orderID)
        {
            orderedItemdb.MarkOrderedItemsPaid(orderID);
        }
    }
}
