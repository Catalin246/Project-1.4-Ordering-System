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
            string query = "SELECT Item_Id, Item_Name, Item_Amount, Item_Price, C.Category_Name FROM dbo.Item as I join dbo.Category as C on I.Item_Category = C.Category_Id where C.Category_Type = 'Drink' Order by C.Category_Name";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Item> GetAllStarters()
        {
            string query = "SELECT Item_Id, Item_Name, Item_Amount, Item_Price, Category_Name FROM dbo.Item as I join dbo.Category as C on I.Item_Category = C.Category_Id where C.Category_Name = 'Starters'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Item> GetAllMains()
        {
            string query = "SELECT Item_Id, Item_Name, Item_Amount, Item_Price, Category_Name FROM dbo.Item as I join dbo.Category as C on I.Item_Category = C.Category_Id where C.Category_Name = 'Mains'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Item> GetAllDesserts()
        {
            string query = "SELECT Item_Id, Item_Name, Item_Amount, Item_Price, Category_Name FROM dbo.Item as I join dbo.Category as C on I.Item_Category = C.Category_Id where C.Category_Name = 'Desserts'";
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
                    item.ItemName = (string)dr["Item_Name"].ToString();
                    item.ItemAmount = (int)dr["Item_Amount"];
                    item.ItemPrice = (double)dr["Item_Price"];
                    item.ItemCategory = (string)dr["Category_Name"];
                };
                items.Add(item);
            }
            return items;
        }
    }
}
