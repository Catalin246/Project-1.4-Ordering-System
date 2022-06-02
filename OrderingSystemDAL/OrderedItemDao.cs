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
    public class OrderedItemDao : BaseDao
    {

        private SqlConnection conn;
        public OrderedItemDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["2122chapeau.database.windows.net"].ConnectionString);
        }

        //public List<Order> GetAllOrdereditems()
        //{
        //    string query = "SELECT Order_Id FROM dbo.[OrderedItem]";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //}


        //private List<Order> ReadTables(DataTable dataTable)
        //{
        //    List<Order> orders = new List<Order>();

        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        Order order = new Order(1)
        //        {
        //            OrderId = (int)dr["Order_Id"],
        //        };
        //        orders.Add(order);
        //    }
        //    return orders;
        //}

        public void Add(OrderedItem orderedItem, Order order)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO dbo.[OrderedItem] " +

                        "VALUES(@Item_Id, @Order_Id, @Ordered_Item_Note, @Ordered_Item_Amount);", conn);

                command.Parameters.AddWithValue("@Item_Id", orderedItem.item.ItemId);
                command.Parameters.AddWithValue("@Order_Id", order.OrderId);
                command.Parameters.AddWithValue("@Ordered_Item_Note", orderedItem.note);
                command.Parameters.AddWithValue("@Ordered_Item_Amount", orderedItem.amount);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Take order failed! " + e.Message);
            }
            conn.Close();
        }

        public List<OrderedItem> GetOrderedItemsByOrder(int orderID)
        {
            string query = "SELECT * FROM dbo.[OrderedItem] WHERE Order_Id = @orderID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderedItem> ReadTables(DataTable dataTable)
        {
            List<OrderedItem> orderedItems = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedItem orderedItem = new OrderedItem()
                {
                    itemID = (int)dr["Item_Id"],
                    note = (string)dr["Ordered_Item_Note"],
                    amount = (int)dr["Ordered_Item_Amount"]
                };
                orderedItems.Add(orderedItem);
            }
            return orderedItems;
        }

        public List<OrderedItem> GetAllFoodOrders()
        {
            string query = "SELECT Item_Name, Category_Name " +
                "FROM dbo.Item as I " +
                "join dbo.Category as C on I.Item_Category = C.Category_Id " +
                "where C.Category_Name = 'Starters' " +
                "OR C.Category_Name ='Mains' " +
                "OR C.Category_Name ='Desserts' " +
                "OR C.Category_Name ='Entremets'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //public int GetTableNoFromOrderedItem()
        //{
        //    string query = "select Table_Id " +
        //        "from [Order] as O " +
        //        "join OrderedItem as OI on O.Order_Id = OI.Order_Id " +
        //        "join Item as I on OI.Item_Id = I.Item_Id " +
        //        "join Category as C on I.Item_Category = C.Category_Id " +
        //        "where C.Category_Name = 'Starters' OR C.Category_Name ='Mains' OR C.Category_Name ='Desserts' OR C.Category_Name ='Entremets'";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //}        
    }
}
