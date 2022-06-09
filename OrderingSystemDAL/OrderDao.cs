using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystemModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace OrderingSystemDAL
{
    public class OrderDao : BaseDao
    {
        private SqlConnection conn;
        public OrderDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["2122chapeau.database.windows.net"].ConnectionString);
        }

        public List<Order> GetAllOrders()
        {
            string query = " SELECT Order_Id FROM dbo.[Order] ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTableOnlyOrderID(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTableOnlyOrderID(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["Order_Id"]
                };
                orders.Add(order);
            }
            return orders;
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["Order_Id"],
                    TableId = (int)dr["Table_Id"],
                    OrderTime = (DateTime)dr["Order_Time"],
                };

                order.OrderedItems = new List<OrderedItem>();

                OrderedItemDao orderedItemsdb = new OrderedItemDao();

                List<OrderedItem> orderedFoods = orderedItemsdb.GetFoodOrdersByOrderId(order.OrderId);
                List<OrderedItem> orderedDrinks = orderedItemsdb.GetDrinkOrdersByOrderId(order.OrderId);

                foreach (OrderedItem food in orderedFoods)
                {
                    order.OrderedItems.Add(food);
                }

                foreach (OrderedItem drink in orderedDrinks)
                {
                    order.OrderedItems.Add(drink);
                }

                orders.Add(order);
            }
            return orders;
        }

        public void Add(Order order)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(" INSERT INTO dbo.[Order] " +
                        " VALUES(@Order_Id, @Order_Time, @Table_Id, @Order_Status);", conn);

                command.Parameters.AddWithValue("@Order_Id", order.OrderId);
                command.Parameters.AddWithValue("@Order_Time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                command.Parameters.AddWithValue("@Table_Id", order.TableId);
                command.Parameters.AddWithValue("@Order_Status", "Preparing");

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Take order failed! " + e.Message);
            }
            conn.Close();
        }

        // Gets list of Order IDs with associated Table ID
        public List<Order> GetOrderIDsByTable(int tableID)
        {
            // string query = "SELECT Order_Id FROM dbo.[Order] WHERE Table_Id=@tableID; ";
            string query = "SELECT * FROM dbo.[Order] WHERE [Table_id]=@tableID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableID", tableID);
            return ReadTableOnlyOrderID(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetOrderByID(int orderId)
        {
            string query = "SELECT Order_Id, Table_Id, Order_Time FROM dbo.[Order] WHERE Order_Id=@Order_Id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Order_Id", orderId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetOrderByTable(int tableId)
        {
            string query = "SELECT Order_Id, Table_Id, Order_Time FROM dbo.[Order] WHERE [TableNumber]=@TableNumber ORDER BY [OrderTime]";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Table_Id", tableId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetFoodOrders()
        {
            string query = " SELECT DISTINCT O.Order_Id, Table_Id, Order_Time " +
                " FROM dbo.[Order] AS O " +
                " JOIN OrderedItem AS OI ON O.Order_Id = OI.Order_Id " +
                " WHERE OI.Ordered_Item_Status = 'Preparing' " +
                " ORDER BY O.Order_Id, O.Table_Id, O.Order_Time";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadFoodTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetFinishedFoodOrders()
        {
            string query = " SELECT DISTINCT O.Order_Id, Table_Id, Order_Time " +
                " FROM dbo.[ORDER] AS O " +
                " JOIN OrderedItem AS OI ON O.Order_Id = OI.Order_Id " +
                " WHERE OI.Ordered_Item_Status != 'Preparing' " +
                " ORDER BY O.Order_Id, O.Table_Id, O.Order_Time;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadFoodTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetDrinkOrders()
        {
            string query = "SELECT DISTINCT O.Order_Id, Table_Id, Order_Time " +
                " FROM dbo.[ORDER] as O " +
                " JOIN OrderedItem AS OI ON O.Order_Id = OI.Order_Id " +
                " WHERE oi.Ordered_Item_Status = 'Preparing' " +
                " ORDER BY o.Order_Id, o.Table_Id, o.Order_Time;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinkTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetFinishedDrinkOrders()
        {
            string query = "SELECT DISTINCT O.Order_Id, Table_Id, Order_Time " +
                " FROM dbo.[ORDER] as O " +
                " JOIN OrderedItem AS OI ON O.Order_Id = OI.Order_Id " +
                " WHERE OI.Ordered_Item_Status != 'Preparing' " +
                " ORDER BY o.Order_Id, o.Table_Id, o.Order_Time;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinkTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadFoodTables(DataTable dataTable)
        {
            List<Order> foodOrders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["Order_Id"],
                    TableId = (int)dr["Table_Id"],
                    OrderTime = (DateTime)dr["Order_Time"],
                };

                order.OrderedItems = new List<OrderedItem>();

                OrderedItemDao orderedItemdb = new OrderedItemDao();

                List<OrderedItem> orderedFoods = orderedItemdb.GetFoodOrdersByOrderId(order.OrderId);

                foreach (OrderedItem food in orderedFoods)
                {
                    order.OrderedItems.Add(food);
                }
                
                foodOrders.Add(order);
            }
            return foodOrders;
        }

        private List<Order> ReadDrinkTables(DataTable dataTable)
        {
            List<Order> drinkOrders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["Order_Id"],
                    TableId = (int)dr["Table_Id"],
                    OrderTime = (DateTime)dr["Order_Time"],
                };

                order.OrderedItems = new List<OrderedItem>();

                OrderedItemDao orderedItemdb = new OrderedItemDao();

                List<OrderedItem> orderedDrinks = orderedItemdb.GetDrinkOrdersByOrderId(order.OrderId);

                foreach (OrderedItem food in orderedDrinks)
                {
                    order.OrderedItems.Add(food);
                }

                drinkOrders.Add(order);
            }
            return drinkOrders;
        }

    }
}
