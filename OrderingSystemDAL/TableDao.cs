using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OrderingSystemModel;
using System.Data;

namespace OrderingSystemDAL
{
    public class TableDao : BaseDao
    {
        private SqlConnection conn;
        public TableDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["2122chapeau.database.windows.net"].ConnectionString);
        }

        public List<Table> GetAllTables()
        {
            string query = "SELECT Table_Id, Employee_Id FROM dbo.Table";
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
                    table.TableId = (int)dr["Table_Id"];
                    table.EmployeeId = (int)dr["Employee_Id"];
                };
                tables.Add(table);
            }
            return tables;
        }

        public List<Table> GetTableByID(int id)
        {
            string query = "SELECT Table_Id, Employee_Id FROM [dbo.Table] where Table_Id=@TableNumber";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableNumber", id);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
