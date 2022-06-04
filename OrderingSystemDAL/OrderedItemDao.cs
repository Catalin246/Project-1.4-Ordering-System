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

        private List<Food> ReadFoodTables(DataTable dataTable)
        {
            List<Food> foods = new List<Food>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Food food = new Food()
                {
                    ItemId = (int)dr["ItemId"],
                    ItemName = (string)dr["Item_Name"],
                    ItemPrice = (double)dr["ItemPrice"],
                    ItemStock = (int)dr["ItemStock"],                    
                    FoodType = (FoodType)dr["FoodType"]
                };
                foods.Add(food);
            }
            return foods;
        }

        private List<Drink2> ReadDrinkTables(DataTable dataTable)
        {
            List<Drink2> drinks = new List<Drink2>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink2 drink = new Drink2()
                {
                    ItemId = (int)dr["ItemId"],
                    ItemName = (string)dr["Item_Name"],
                    ItemStock = (int)dr["ItemStock"],
                    ItemPrice = (double)dr["ItemPrice"],
                    AlcoholicOrNonAlcoholic = (bool)dr["DrinkType"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public void Add(OrderedItem orderedItem, Order order)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO dbo.[OrderedItem] " +

                        " VALUES(@Item_Id, @Order_Id, @Ordered_Item_Note, @Ordered_Item_Amount);", conn);

                command.Parameters.AddWithValue("@Item_Id", orderedItem.Item.ItemId);
                command.Parameters.AddWithValue("@Order_Id", order.OrderId);
                command.Parameters.AddWithValue("@Ordered_Item_Note", orderedItem.Note);
                command.Parameters.AddWithValue("@Ordered_Item_Amount", orderedItem.Amount);

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
                    ItemID = (int)dr["Item_Id"],
                    Note = (string)dr["Ordered_Item_Note"],
                    Amount = (int)dr["Ordered_Item_Amount"]
                };
                orderedItems.Add(orderedItem);
            }
            return orderedItems;
        }

        public List<Food> GetAllOrderedFoods()
        {
            string query = "SELECT I.ItemId, I.Item_Name, I.ItemStock, I.ItemPrice, F.FoodType " +
                "FROM Item AS I " +
                "JOIN FOOD AS F ON F.FoodItemId = I.ItemId " +
                "JOIN OrderedItem AS OI ON OI.Item_Id = I.ItemId ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadFoodTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink2> GetAllOrderedDrinks()
        {
            string query = "SELECT I.ItemId, I.ItemName, I.ItemStock, I.ItemPrice, D.DrinkType " +
                "FROM Item AS I " +
                "JOIN Drink AS D ON D.DrinkItemId = I.ItemId " +
                "JOIN OrderedItem AS OI ON OI.Item_Id = I.ItemId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinkTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderedItem> GetPreparingFoods()
        {
            string query = "SELECT I.ItemId, i.ItemName, i.ItemStock,I.ItemPrice, OI.Ordered_Item_Note, F.FoodType, OI.Ordered_Item_Amount " +
                "FROM Item AS I " +
                "JOIN FOOD AS F ON F.FoodItemId = I.ItemId " +
                "JOIN OrderedItem AS OI ON OI.Item_Id = I.ItemId " +
                "WHERE Ordered_Item_Status = 'Preparing'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadKitchenTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateStatusToReady(OrderedItem orderedITem)
        {
            string query = "UPDATE OrderedItem " +
                "SET Ordered_Item_Status = 'Ready' " +
                "WHERE Item_Id = Item_Id AND Order_Id = Order_Id";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@MenuItemId", orderedITem.Item.ItemId),
                new SqlParameter("@OrderId", orderedITem.OrderId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<> ReadKitchenTables()
        {

        }
    }
}