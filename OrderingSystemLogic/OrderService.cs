using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
    public class OrderService
    {
        OrderDao orderdb;

        public OrderService()
        {
            orderdb = new OrderDao();
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = orderdb.GetAllOrders();
            return orders;
        }

        public void AddOrder(Order order)
        {
            orderdb.AddOrder(order);
        }

        public List<Order> GetOrdersByTable(int TableID)
        {
            return orderdb.GetOrderIDsByTable(TableID);
        }


        public void MarkOrdersPaid(int tableID)
        {
            orderdb.MarkOrderPaid(tableID);
        }

        public int GetOrderId()
        {
            return orderdb.GetOrderId();

        }
    }
}
