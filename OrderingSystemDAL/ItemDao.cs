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
        public List<Item> GetAllDrinks()
        {
            string query = "SELECT ItemID, ItemName, ItemAmount, ItemPrice, CategoryName FROM dbo.Item as I join dbo.Category as C on I.ItemCategory = C.CategoryID where C.CategoryType = 'Drink' Order by C.CategoryName";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Item> GetAllStarters()
        {
            string query = "SELECT ItemID, ItemName, ItemAmount, ItemPrice, CategoryName FROM dbo.Item as I join dbo.Category as C on I.ItemCategory = C.CategoryID where C.CategoryName = 'Starters'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Item> GetAllMains()
        {
            string query = "SELECT ItemID, ItemName, ItemAmount, ItemPrice, CategoryName FROM dbo.Item as I join dbo.Category as C on I.ItemCategory = C.CategoryID where C.CategoryName = 'Mains'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Item> GetAllDesserts()
        {
            string query = "SELECT ItemID, ItemName, ItemAmount, ItemPrice, CategoryName FROM dbo.Item as I join dbo.Category as C on I.ItemCategory = C.CategoryID where C.CategoryName = 'Desserts'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Item> ReadTables(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item();
                {
                    item.ItemName = (string)dr["ItemName"].ToString();
                    item.ItemAmount = (int)dr["ItemAmount"];
                    item.ItemPrice = (double)dr["ItemPrice"];
                    item.ItemCategory = (string)dr["CategoryName"];
                };
                items.Add(item);
            }
            return items;
        }
    }
}
