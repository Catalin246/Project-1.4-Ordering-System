﻿using System;
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
    public class OrderedItemDao
    {

        private SqlConnection conn;
        public OrderedItemDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["2122chapeau.database.windows.net"].ConnectionString);
        }

        //public List<Order> GetAllOrdereditems()
        //{
        //    string query = "SELECT Order_Id FROM dbo.[OrderedItem]";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //}


        //private List<Order> ReadTables(DataTable dataTable)
        //{
        //    List<Order> orders = new List<Order>();

        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        Order order = new Order(1)
        //        {
        //            OrderId = (int)dr["Order_Id"],
        //        };
        //        orders.Add(order);
        //    }
        //    return orders;
        //}

        public void Add(OrderedItem orderedItem, Order order)
        {
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO dbo.[OrderedItem] " +
                        "VALUES(@Item_Id, @Order_Id);", conn);

                command.Parameters.AddWithValue("@Item_Id", orderedItem.item.ItemId);
                command.Parameters.AddWithValue("@Order_Id", order.OrderId);

                int nrOfRowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Take order failed! " + e.Message);
            }
            conn.Close();
        }
    }
}
