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
        private SqlConnection conn;
        public OrderDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["2122chapeau.database.windows.net"].ConnectionString);
        }

        public List<Order> GetAllOrders()
        {
            string query = "SELECT Order_Id FROM dbo.[Order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order(1)
                {
                    OrderId = (int)dr["Order_Id"],
                };
                orders.Add(order);
            }
            return orders;
        }

        public void Add(Order order)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO dbo.[Order] " +
                        "VALUES(@Order_Id, @Order_Time, @Table_Id, @Order_Status);", conn);

                command.Parameters.AddWithValue("@Order_Id", order.OrderId);
                command.Parameters.AddWithValue("@Order_Time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                command.Parameters.AddWithValue("@Table_Id", order.TableId);
                command.Parameters.AddWithValue("@Order_Status", false);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Take order failed! " + e.Message);
            }
            conn.Close();
        }

        // Gets list of Order IDs with associated Table ID
        public List<Order> GetOrderIDsByTable(int tableID)
        {
            string query = "SELECT Order_Id FROM dbo.[Order] WHERE Table_Id = @tableID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

    }
}



