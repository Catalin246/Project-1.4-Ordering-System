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
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT OrderId, TableId, OrderTime FROM dbo.Order ORDER BY [OrderId]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

            //should we assign orders' ids in sql server?
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["OrderId"],
                    TableId = (int)dr["TableId"],
                    OrderTime = (DateTime)dr["OrderTime"],
                    BillId = (int)dr["BillId"]
                };
                orders.Add(order);
            }
            return orders;
        }

        //public List<Drink> GetDrinkOrders()
        //{
        //    string query = "SELECT OrderId, TableId, OrderTime FROM dbo.Order WHERE  = 'Hardik'";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //}
    }
}



