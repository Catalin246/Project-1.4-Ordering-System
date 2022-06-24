using OrderingSystemModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OrderingSystemDAL
{
    public class TableDao : BaseDao
    {

        private  SqlConnection dbConnection;//my sql connection object

        public void MarkTableOpen(int tableID)
        {
            dbConnection = this.OpenConnection();
            try
            {
                SqlCommand command = new SqlCommand("Update dbo.[Table] SET [Table_Status] = 'Open' WHERE [Table_Id] = @tableId;", dbConnection);

                command.Parameters.AddWithValue("@tableID", tableID);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Failed to open Table! " + e.Message);
            }
            this.CloseConnection();
        }

        public List<Table> GetAllTable()
        {
            string query = "SELECT t.[Table_Id], O.Order_Time, i.Ordered_Item_Status, O.Order_Id,t.Table_Status,I.Item_Id FROM dbo.[Table] as T join dbo.[Order] as O on T.Table_Id = O.Table_Id join dbo.[OrderedItem] as I on i.Order_Id = o.Order_Id;";
        
            return ReadTables(ExecuteSelectQuery(query));
        }

        public List<Table> GetTablesId()
        {
            string query = "SELECT [table_Id] FROM [Table] ";
            return readTablesId(ExecuteSelectQuery(query));
        }
        private List<Table> readTablesId(DataTable dataTable)
        {
            List<Table> tablesId = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();
                {
                    table.TableId = (int)dr["Table_Id"];
                };
                tablesId.Add(table);
            }
            return tablesId;
        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();
                {
                    table.OrderId = (int)dr["Order_Id"];
                    table.Time = (DateTime)dr["Order_Time"];
                    table.TableId = (int)dr["Table_Id"];
                    table.ItemId = (int)dr["Item_Id"];
                    table.OrderStatus = (string)dr["Ordered_Item_Status"];
                    table.TableStatus = (string)dr["Table_Status"];
                };
                tables.Add(table);
            }
            return tables;
        }
        public List<Table> GetTableStatus()
        {
            string query = "SELECT Table_Id,Table_Status FROM dbo.[Table]";
            return ReadTablesStatus(ExecuteSelectQuery(query));
        }
        private List<Table> ReadTablesStatus(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();
                {
                    table.TableId = (int)dr["Table_Id"];
                    table.TableStatus = (string)dr["Table_Status"];
                };
                tables.Add(table);
            }
            return tables;
        }
        public void Order(int number)
        {
            string query = $"UPDATE dbo.[Table] SET Table_Status = 'Close' WHERE Table_Id = {number}; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Sit(int number)
        {
            string query = $"UPDATE dbo.[Table] SET Table_Status = 'Sit' WHERE Table_Id = {number}; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void CancelSit(int number)
        {
            string query = $"UPDATE dbo.[Table] SET Table_Status = 'Open' WHERE Table_Id = {number} ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Served(Table servedOrder)
        {
            string query = "UPDATE dbo.OrderedItem SET Ordered_Item_Status = 'Served' WHERE Order_Id = @OrderId AND Item_Id = @ItemId;";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@OrderId", servedOrder.OrderId);
            sqlParameters[1] = new SqlParameter("@ItemId", servedOrder.ItemId);
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Food> GetFood()
        {
            string query = "SELECT I.ItemId FROM Item as I JOIN Food as f ON I.ItemId = f.FoodItemId";
            return ReadFood(ExecuteSelectQuery(query));
        }
        private List<Food> ReadFood(DataTable dataTable)
        {
            List<Food> foods = new List<Food>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Food food = new Food();
                {
                    food.FoodId = (int)dr["ItemId"];
                };
                foods.Add(food);
            }
            return foods;
        }
        public List<Drink> GetDrink()
        {
            string query = " SELECT I.ItemId FROM Item as I JOIN Drink as D ON I.ItemId = d.DrinkItemId;";
            return ReadDrink(ExecuteSelectQuery(query));
        }
        private List<Drink> ReadDrink(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink();
                {
                    drink.DrinkId = (int)dr["ItemId"];
                };
                drinks.Add(drink);
            }
            return drinks;
        }


    }
}
