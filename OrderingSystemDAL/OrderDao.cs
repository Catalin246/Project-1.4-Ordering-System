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
            string query = " SELECT Order_Id FROM dbo.[Order] ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTableOnlyOrderID(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTableOnlyOrderID(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderId = (int)dr["Order_Id"]
                };
                orders.Add(order);
            }
            return orders;
        }


        public int GetOrderId()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["2122chapeau.database.windows.net"].ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Max([Order_Id]) FROM dbo.[Order]", conn);
            Int32 count = (Int32)command.ExecuteScalar();
            conn.Close();
            return (int)count;
        }
        public void Add(Order order)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["2122chapeau.database.windows.net"].ConnectionString);
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand(" INSERT INTO dbo.[Order] " +
                        " VALUES(@Order_Time, @Table_Id, @Order_Status);", conn);              

                command.Parameters.AddWithValue("@Order_Id", order.OrderId);
                command.Parameters.AddWithValue("@Order_Time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                command.Parameters.AddWithValue("@Table_Id", order.TableId);
                command.Parameters.AddWithValue("@Order_Status", "ordered");

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Take order failed! " + e.Message);
            }
            conn.Close();
        }


        public void MarkOrderPaid(int tableID)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["2122chapeau.database.windows.net"].ConnectionString);
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("Update dbo.[Order] SET [Order_Status] = 'Paid' WHERE [Table_Id] = @tableId;", conn);

                command.Parameters.AddWithValue("@tableID", tableID);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Marking Order Paid failed! " + e.Message);
            }
            conn.Close();
        }

        // Gets list of Order IDs with associated Table ID
        public List<Order> GetOrderIDsByTable(int tableID)
        {
            // string query = "SELECT Order_Id FROM dbo.[Order] WHERE Table_Id=@tableID; ";
            string query = "SELECT * FROM dbo.[Order] WHERE [Table_id]=@tableID AND [Order_Status] != @statusPaid";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tableID", tableID);
            sqlParameters[1] = new SqlParameter("@statusPaid", "Paid");
            return ReadTableOnlyOrderID(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
