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

        public List<Order> GetOrdersForTable(int tableID)
        {
            List<Order> orders = orderdb.GetAllOrders();
            return orders;
        }
        //public List<Order> GetDrinkOrders()
        //{
        //    List<Drink> drinkOrders = orderdb.GetDrinkOrders();

        //    return drinkOrders;
        //}
    }
}
