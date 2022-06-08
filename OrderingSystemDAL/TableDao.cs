using OrderingSystemModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemDAL
{
    public class TableDao : BaseDao
    {
        public List<Table> GetAllTable()
        {
            string query = "SELECT t.[Table_Id], O.Order_Time, O.Order_Status, O.Order_Id,t.Table_Status FROM dbo.[Table] as T join dbo.[Order] as O on T.Table_Id = O.Table_Id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                    table.OrderStatus = (string)dr["Order_Status"];
                    table.TableStatus = (string)dr["Table_Status"];
                };
                tables.Add(table);
            }
            return tables;
        }
        public List<Table> GetTableStatus()
        {
            string query = "SELECT Table_Id,Table_Status FROM dbo.[Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesStatus(ExecuteSelectQuery(query, sqlParameters));
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
        public void Sit(int number)
        {
            string query = $"UPDATE dbo.[Table] SET Table_Status = 'Close' WHERE Table_Id = {number}; ";
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
            string query = "UPDATE dbo.[Order] SET Order_Status = served  WHERE Order_Id = @OrderId; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
