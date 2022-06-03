using System;
using System.Collections.Generic;
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

        public void Add(OrderedItem orderedItem, Order order)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO dbo.[OrderedItem] " +

                        " VALUES(@Item_Id, @Order_Id, @Ordered_Item_Note, @Ordered_Item_Amount);", conn);

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

        /// 
        /// 
        /// 
        /// 
        /// 

        //public List<Food> GetAllOrderedFoods()
        //{
        //    string query = "Fill In";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    return ReadFoodTables(ExecuteSelectQuery(query, sqlParameters));
        //}

        //private List<Food> ReadFoodTables(DataTable dataTable)
        //{
        //    List<Food> foods = new List<Food>();

        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        Food food = new Food()
        //        {
        //            //fill in
        //        };
        //        foods.Add(food);
        //    }
        //    return foods;
        //}

        //public void ChangeStatusToReady()
        //{
        //    string query = "";
        //}
    }
}