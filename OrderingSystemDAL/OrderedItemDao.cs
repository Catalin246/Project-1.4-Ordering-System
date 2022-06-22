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
        public void AddOrderesItem(OrderedItem orderedItem, Order order)
        {
            SqlConnection conn = this.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO dbo.[OrderedItem] " +

                        " VALUES(@Item_Id, @Order_Id, @Ordered_Item_Note, @Ordered_Item_Amount, @Ordered_Item_Status);", conn);

                command.Parameters.AddWithValue("@Item_Id", orderedItem.Item.ItemId);
                command.Parameters.AddWithValue("@Order_Id", order.OrderId);
                command.Parameters.AddWithValue("@Ordered_Item_Note", orderedItem.Note);
                command.Parameters.AddWithValue("@Ordered_Item_Amount", orderedItem.Amount);
                command.Parameters.AddWithValue("@Ordered_Item_Status", "ordered");

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Take order failed! " + e.Message);
            }
            this.CloseConnection();
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

        public void MarkOrderedItemsPaid(int orderID)
        {
            OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("Update dbo.[OrderedItem] SET [Ordered_Item_Status] = 'Paid' WHERE [Order_Id] = @orderID;", OpenConnection());

                command.Parameters.AddWithValue("@orderID", orderID);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Marking Ordered Items Paid failed! " + e.Message);
            }
            CloseConnection();
        }


        private Status MakeStatusEnum(string notEnumStatus)
        {
            switch (notEnumStatus)
            {
                case "Ordered":
                    return Status.Ordered;
                case "Ready":
                    return Status.Ready;
                case "Served":
                    return Status.Served;
                case "Paid":
                    return Status.Paid;
                default:
                    return Status.Ordered;
            }            
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

        
        public List<OrderedItem> GetPreparingFoodItemsFromDatabase()
        {
            string query = "select i.ItemId, o.order_id, Table_Id, Order_Time, f.FoodType, Ordered_Item_Amount, ItemName,oi.Ordered_Item_Note,oi.Ordered_Item_Status from [Order] as o join OrderedItem as oi on o.Order_Id = oi.Order_Id join food as f on f.FoodItemId = oi.Item_Id join Item as i on i.ItemId=oi.Item_Id where oi.Ordered_Item_Status = 'ordered' order by o.Order_Time desc";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderedFoodItemTable(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderedItem> GetFinishedFoodItemsFromDatabase()
        {
            string query = "select i.ItemId, o.order_id, Table_Id, Order_Time, f.FoodType, Ordered_Item_Amount, ItemName,oi.Ordered_Item_Note,oi.Ordered_Item_Status from [Order] as o join OrderedItem as oi on o.Order_Id = oi.Order_Id join food as f on f.FoodItemId = oi.Item_Id join Item as i on i.ItemId=oi.Item_Id  where (oi.Ordered_Item_Status = 'Ready' OR oi.Ordered_Item_Status = 'Served' OR oi.Ordered_Item_Status = 'Paid') AND Order_Time >= DATEADD(day, -1, GETDATE()) order by o.Order_Time desc";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderedFoodItemTable(ExecuteSelectQuery(query, sqlParameters));
        }       

        public List<OrderedItem> GetPreparingDrinkItemsFromDatabase()
        {
            string query = "select i.ItemId, o.order_id, Table_Id, Order_Time, d.DrinkType, Ordered_Item_Amount, ItemName,oi.Ordered_Item_Note,oi.Ordered_Item_Status from [Order] as o join OrderedItem as oi on o.Order_Id = oi.Order_Id join drink as d on d.DrinkItemId = oi.Item_Id join Item as i on i.ItemId=oi.Item_Id where oi.Ordered_Item_Status = 'Ordered' order by o.Order_Time desc";
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
                    ItemID = (int)dr["ItemId"],
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
                    ItemID = (int)dr["ItemId"],
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

        public void ChangeFoodAndDrinkStatusToReady(int orderNo, int itemId)
        {
            string query = "UPDATE OrderedItem  SET Ordered_Item_Status = 'Ready' from OrderedItem as oi join item as i on oi.Item_Id = i.ItemId WHERE ItemId = @itemId AND Order_Id = @orderId";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ItemId", itemId),
                new SqlParameter("@orderId", orderNo)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
