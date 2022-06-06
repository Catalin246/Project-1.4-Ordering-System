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
        private SqlConnection conn;
        public ItemDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["2122chapeau.database.windows.net"].ConnectionString);
        }
        public List<Item> GetAllDrinks()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Drink as D on I.ItemId = D.DrinkItemId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), "DrinkType"  );
        }
        public List<Item> GetDinnerStarters()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Diner Starter' or F.FoodType = 'Diner Entrement'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), "FoodType");
        }
        public List<Item> GetLunchStarters()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Lunch Starter'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), "FoodType");
        }
        public List<Item> GetDinerMains()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Diner Main'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), "FoodType");
        }
        public List<Item> GetLunchMains()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Lunch Main'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), "FoodType");
        }
        public List<Item> GetDinerDeserts()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Diner Desert'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), "FoodType");
        }
        public List<Item> GetLunchDeserts()
        {
            string query = "SELECT * FROM dbo.Item as I join dbo.Food as F on I.ItemId = F.FoodItemId where F.FoodType = 'Lunch Desert'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), "FoodType");
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
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("Update dbo.[Item] " +
                        "SET ItemStock = @ItemStock WHERE ItemId = @ItemId;", conn);

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
            conn.Close();
        }

        
        public Item GetItem(int itemID)
        {
            string query = "SELECT * FROM dbo.Item where Item_Id = @itemID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Item> items =  ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return items[0];

        }
    }
}
