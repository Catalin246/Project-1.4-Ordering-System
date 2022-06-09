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
                    FoodType = MakeFoodTypeEnum((string)dr["FoodType"])
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
                    DrinkCategory = MakeDrinkCategoryEnum((string)dr["DrinkType"])
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

                        " VALUES(@Item_Id, @Order_Id, @Ordered_Item_Note, @Ordered_Item_Amount, @Ordered_Item_Status);", conn);

                command.Parameters.AddWithValue("@Item_Id", orderedItem.Item.ItemId);
                command.Parameters.AddWithValue("@Order_Id", order.OrderId);
                command.Parameters.AddWithValue("@Ordered_Item_Note", orderedItem.Note);
                command.Parameters.AddWithValue("@Ordered_Item_Amount", orderedItem.Amount);
                command.Parameters.AddWithValue("@Ordered_Item_Status", "Preparing");

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
            string query = "SELECT * FROM dbo.[OrderedItem] WHERE [Order_Id] = @orderID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("orderID", orderID);
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
                " FROM Item AS I " +
                " JOIN FOOD AS F ON F.FoodItemId = I.ItemId " +
                " JOIN OrderedItem AS OI ON OI.Item_Id = I.ItemId ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadFoodTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink2> GetAllOrderedDrinks()
        {
            string query = "SELECT I.ItemId, I.ItemName, I.ItemStock, I.ItemPrice, D.DrinkType " +
                " FROM Item AS I " +
                " JOIN Drink AS D ON D.DrinkItemId = I.ItemId " +
                " JOIN OrderedItem AS OI ON OI.Item_Id = I.ItemId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDrinkTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderedItem> GetPreparingFoods()
        {
            string query = "SELECT I.ItemId, i.ItemName, i.ItemStock,I.ItemPrice, OI.Ordered_Item_Note, F.FoodType, OI.Ordered_Item_Amount " +
                " FROM Item AS I " +
                " JOIN FOOD AS F ON F.FoodItemId = I.ItemId " +
                " JOIN OrderedItem AS OI ON OI.Item_Id = I.ItemId " +
                " WHERE Ordered_Item_Status = 'Preparing'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadKitchenTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateStatusToReady(OrderedItem orderedITem)
        {
            string query = " UPDATE OrderedItem " +
                " SET Ordered_Item_Status = 'Ready' " +
                " WHERE Item_Id = Item_Id AND Order_Id = Order_Id";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Item_Id", orderedITem.Item.ItemId),
                new SqlParameter("@Order_Id", orderedITem.OrderId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<OrderedItem> ReadKitchenTables(DataTable dataTable)
        {
            List<OrderedItem> orderedItems = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Food food = new Food()
                {
                    ItemId = (int)dr["ItemId"],
                    ItemName = (string)dr["ItemName"],
                    ItemStock = (int)dr["ItemStock"],
                    ItemPrice = (double)dr["ItemPrice"],
                    FoodType = MakeFoodTypeEnum((string)dr["FoodType"])
                };

                OrderedItem orderedItem = new OrderedItem(food)
                {
                    Note = dr["Ordered_Item_Note"].ToString(),
                    Amount = (int)dr["Ordered_Item_Amount"],
                    OrderId = (int)dr["Order_Id"],
                    Status = MakeStatusEnum((string)dr["Ordered_Item_Status"].ToString())                    

                };
                orderedItems.Add(orderedItem);
            }
            return orderedItems;
        }

        private List<OrderedItem> ReadBarTables(DataTable dataTable)
        {
            List<OrderedItem> orderedItems = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                string foodTypeString = (string)dr["FoodType"];

                Drink2 drink = new Drink2()
                {
                    ItemId = (int)dr["ItemId"],
                    ItemName = (string)dr["ItemName"],
                    ItemStock = (int)dr["ItemStock"],
                    ItemPrice = (double)dr["ItemPrice"],
                    DrinkCategory = MakeDrinkCategoryEnum((string)dr["DrinkType"])
                };

                OrderedItem orderedItem = new OrderedItem(drink)
                {
                    Note = (string)dr["Ordered_Item_Note"],
                    Amount = (int)dr["Ordered_Item_Amount"],
                    OrderId = (int)dr["Order_Id"],
                    Status = MakeStatusEnum((string)dr["Ordered_Item_Status"])
                };
                orderedItems.Add(orderedItem);
            }
            return orderedItems;
        }

        private Status MakeStatusEnum(string notEnumStatus)
        {
            switch (notEnumStatus)
            {
                case "Preparing":
                    return Status.Preparing;
                case "Ready":
                    return Status.Ready;
                case "Served":
                    return Status.Served;
                case "Paid":
                    return Status.Paid;
                default:
                    return Status.Paid;
            }            
        }

        private FoodTypes MakeFoodTypeEnum(string notEnumType)
        {
            FoodTypes foodType = new FoodTypes();

            try
            {
                switch (notEnumType)
                {
                    case "Lunch Starter":
                        foodType = FoodTypes.LunchStarter;
                        break;
                    case "Lunch Main":
                        foodType = FoodTypes.LunchMain;
                        break;
                    case "Lunch Desert":
                        foodType = FoodTypes.LunchDessert;
                        break;
                    case "Diner Starter":
                        foodType = FoodTypes.DinnerStarter;
                        break;
                    case "Diner Entrement":
                        foodType = FoodTypes.DinnerEntremets;
                        break;
                    case "Diner Main":
                        foodType = FoodTypes.DinnerMain;
                        break;
                    case "Diner Desert":
                        foodType = FoodTypes.DinnerDessert;
                        break;
                }
            }
            catch (Exception ex)
            {
                BaseDao.ErrorLogging(ex);
            }
            return foodType;
        }

        private DrinkCategories MakeDrinkCategoryEnum(string notEnumType)
        {
            DrinkCategories drinkType = new DrinkCategories();

            try
            {
                switch (notEnumType)
                {
                    case "Soft Drink":
                        drinkType = DrinkCategories.SoftDrink;
                        break;
                    case "Beer":
                        drinkType = DrinkCategories.Beer;
                        break;
                    case "Wine":
                        drinkType = DrinkCategories.Wine;
                        break;
                    case "Spirit Drink":
                        drinkType = DrinkCategories.SpiritDrink;
                        break;
                    case "Coffee Tea":
                        drinkType = DrinkCategories.CoffeeAndTea;
                        break;
                }
            }
            catch (Exception ex)
            {
                BaseDao.ErrorLogging(ex);
            }
            return drinkType;
        }

        public List<OrderedItem> GetFoodOrdersByOrderId(int orderId)
        {
            string query = " SELECT i.ItemId, i.ItemName, i.ItemStock, i.ItemPrice, oi.Ordered_Item_Note, f.FoodType, oi.Ordered_Item_Amount, oi.Order_Id, oi.Ordered_Item_Status FROM dbo.[Item] AS i JOIN Food AS f ON i.ItemId = f.FoodItemId JOIN dbo.[OrderedItem] AS oi ON i.ItemId = oi.Item_Id " +
                " WHERE oi.Order_Id = @orderId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderId", orderId);
            return ReadKitchenTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderedItem> GetDrinkOrdersByOrderId(int orderId)
        {
            string query = "SELECT i.ItemId, i.ItemName, i.ItemStock, i.ItemPrice, oi.Ordered_Item_Note, d.DrinkType, oi.Ordered_Item_Amount, oi.Order_Id, oi.Ordered_Item_Status FROM dbo.[Item] AS i JOIN Drink AS d ON i.ItemId = d.DrinkItemId JOIN dbo.[OrderedItem] AS oi ON i.ItemId = oi.Item_Id " +
                " WHERE oi.Order_Id = @orderId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderId", orderId);
            return ReadBarTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateAmount(OrderedItem orderedITem, int orderId)
        {
            string query = "UPDATE OrderedItem " +
                " SET Ordered_Item_Amount = @Ordered_Item_Amount, Ordered_Item_Note = @Ordered_Item_Note " +
                "WHERE Item_Id = @Item_Id AND Order_Id = @Order_Id";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Item_Id", orderedITem.Item.ItemId),
                new SqlParameter("@Order_Id", orderId),
                new SqlParameter("@Ordered_Item_Amount", orderedITem.Amount),
                new SqlParameter("@Ordered_Item_Note", orderedITem.Note)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        //private List<> ReadKitchenTables()
        //{
        //    //i will fill in this
        //}

        public List<OrderedItem> GetPreparingFoodItemsFromDatabase()
        {
            string query = "select o.order_id, Table_Id, Order_Time, f.FoodType, Ordered_Item_Amount, ItemName,oi.Ordered_Item_Note,oi.Ordered_Item_Status from [Order] as o join OrderedItem as oi on o.Order_Id = oi.Order_Id join food as f on f.FoodItemId = oi.Item_Id join Item as i on i.ItemId=oi.Item_Id where oi.Ordered_Item_Status = 'Preparing' order by o.Order_Time desc";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderedFoodItemTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderedItem> GetFinishedFoodItemsFromDatabase()
        {
            string query = "select o.order_id, Table_Id, Order_Time, f.FoodType, Ordered_Item_Amount, ItemName,oi.Ordered_Item_Note,oi.Ordered_Item_Status from [Order] as o join OrderedItem as oi on o.Order_Id = oi.Order_Id join food as f on f.FoodItemId = oi.Item_Id join Item as i on i.ItemId=oi.Item_Id  where oi.Ordered_Item_Status != 'Preparing' AND Order_Time >= DATEADD(day, -1, GETDATE()) order by o.Order_Time desc";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderedFoodItemTable(ExecuteSelectQuery(query, sqlParameters));
        }       

        public List<OrderedItem> GetPreparingDrinkItemsFromDatabase()
        {
            string query = "select o.order_id, Table_Id, Order_Time, d.DrinkType, Ordered_Item_Amount, ItemName,oi.Ordered_Item_Note,oi.Ordered_Item_Status from [Order] as o join OrderedItem as oi on o.Order_Id = oi.Order_Id join drink as d on d.DrinkItemId = oi.Item_Id join Item as i on i.ItemId=oi.Item_Id where oi.Ordered_Item_Status = 'Preparing' order by o.Order_Time desc";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderedDrinkItemTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderedItem> GetFinishedDrinkItemsFromDatabase()
        {
            string query = "select o.order_id, Table_Id, Order_Time, d.DrinkType, Ordered_Item_Amount, ItemName,oi.Ordered_Item_Note,oi.Ordered_Item_Status from [Order] as o join OrderedItem as oi on o.Order_Id = oi.Order_Id join drink as d on d.DrinkItemId = oi.Item_Id join Item as i on i.ItemId=oi.Item_Id  where oi.Ordered_Item_Status != 'Preparing' AND Order_Time >= DATEADD(day, -1, GETDATE()) order by o.Order_Time desc";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderedDrinkItemTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderedItem> ReadOrderedFoodItemTable(DataTable dataTable)
        {
            List<OrderedItem> items = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedItem item = new OrderedItem()
                {
                    OrderId = (int)dr["order_id"],
                    TableId = (int)dr["Table_Id"],
                    OrderTime = (DateTime)dr["Order_Time"],
                    Category = (string)dr["FoodType"],
                    Amount = (int)dr["Ordered_Item_Amount"],
                    Name = (string)dr["ItemName"],
                    Note = (string)dr["Ordered_Item_Note"],
                    Status = MakeStatusEnum((string)dr["Ordered_Item_Status"])
                };
                items.Add(item);
            }
            return items;
        }

        private List<OrderedItem> ReadOrderedDrinkItemTable(DataTable dataTable)
        {
            List<OrderedItem> items = new List<OrderedItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderedItem item = new OrderedItem()
                {
                    OrderId = (int)dr["order_id"],
                    TableId = (int)dr["Table_Id"],
                    OrderTime = (DateTime)dr["Order_Time"],
                    Category = (string)dr["DrinkType"],
                    Amount = (int)dr["Ordered_Item_Amount"],
                    Name = (string)dr["ItemName"],
                    Note = (string)dr["Ordered_Item_Note"],
                    Status = MakeStatusEnum((string)dr["Ordered_Item_Status"])

                };
                items.Add(item);
            }
            return items;
        }

        public void ChangeFoodAndDrinkStatusToReady(int orderNo, int itemNo)
        {
            string query = " UPDATE OrderedItem " +
                " SET Ordered_Item_Status = 'Ready' " +
                " WHERE Item_Id = Item_Id AND Order_Id = Order_Id";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Item_Id", itemNo),
                new SqlParameter("@Order_Id", orderNo)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
