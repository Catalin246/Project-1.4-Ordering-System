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
    public class ItemDao : BaseDao
    {
        public List<Item> GetDrinks() //uses a sub-selection to get all drinks including the type of drink
                                      //(which is stored in the Item table) 
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Drink as D on I.ItemId = D.DrinkItemId";
            return ReadTables(ExecuteSelectQuery(query), "DrinkType"  );
        }
        public List<Item> GetDinnerStarters()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Diner Starter' or F.FoodType = 'Diner Entrement'";
            return ReadTables(ExecuteSelectQuery(query), "FoodType");
        }
        public List<Item> GetLunchStarters()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Lunch Starter'";
            return ReadTables(ExecuteSelectQuery(query), "FoodType");
        }
        public List<Item> GetDinerMains()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Diner Main'";
            return ReadTables(ExecuteSelectQuery(query), "FoodType");
        }
        public List<Item> GetLunchMains()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Lunch Main'";
            return ReadTables(ExecuteSelectQuery(query), "FoodType");
        }
        public List<Item> GetDinerDeserts()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Diner Desert'";
            return ReadTables(ExecuteSelectQuery(query), "FoodType");
        }
        public List<Item> GetLunchDeserts()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Lunch Desert'";
            return ReadTables(ExecuteSelectQuery(query), "FoodType");
        }

        private List<Item> ReadTables(DataTable dataTable,string type) 
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item();
                {
                    item.ItemId = (int)dr["ItemId"];
                    item.ItemName = (string)dr["ItemName"].ToString();
                    item.ItemStock = (int)dr["ItemStock"];
                    item.ItemPrice = (double)dr["ItemPrice"];
                    item.ItemType = (string)dr[type];
                };
                items.Add(item);
            }
            return items;
        }
        private List<Item> ReadTables(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item();
                {
                    item.ItemId = (int)dr["ItemId"];
                    item.ItemName = (string)dr["ItemName"].ToString();
                    item.ItemStock = (int)dr["ItemStock"];
                    item.ItemPrice = (double)dr["ItemPrice"];
                };
                items.Add(item);
            }
            return items;
        }


        public void Update(OrderedItem orderedItem)
        {
            OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("Update dbo.[Item] " +
                        "SET ItemStock = @ItemStock WHERE ItemId = @ItemId;", OpenConnection());

                command.Parameters.AddWithValue("@ItemStock", orderedItem.Item.ItemStock);
                command.Parameters.AddWithValue("@ItemId", orderedItem.Item.ItemId);

                int nrOfRowsAffected = command.ExecuteNonQuery();
                if (nrOfRowsAffected == 0)
                    throw new Exception("Update was succesful");
            }
            catch (Exception e)
            {
                throw new Exception("Update amount failed! " + e.Message);
            }
            CloseConnection();
        }

        
        public Item GetItem(int itemID)
        {
            string query = "SELECT * FROM dbo.[Item] WHERE [ItemId]=@itemID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@itemID", itemID);
            List<Item> items =  ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return items[0];

        }
    }
}
