
﻿using OrderingSystemDAL;
using OrderingSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemLogic
{
    public class TableService
    {
        TableDao tabledb;
        public TableService()
        {
            tabledb = new TableDao();
        }
        public List<Table> GetTable()
        {
            List<Table> tables = tabledb.GetAllTable();
            return tables;
        }
        public List<Table> GetTablesId()
        {
            List<Table> tablesId = tabledb.GetTablesId();
            return tablesId;
        }
        public List<Table> GetTablesStatus()
        {
            List<Table> tables = tabledb.GetTableStatus();
            return tables;
        }
        public void Served(Table selectedOrder)
        {
            tabledb.Served(selectedOrder);
        }
        public void Sit(int number)
        {
            tabledb.Sit(number);
        }
        public void Order(int number)
        {
            tabledb.Order(number);
        }
        public void CancelSit(int number)
        {
            tabledb.CancelSit(number);
        }
        public List<Food> GetFood()
        {
            List<Food> foods= tabledb.GetFood();
            return foods;
        }
        public List<Drink> GetDrink()
        {
            List<Drink> drinks= tabledb.GetDrink();
            return drinks;
        }

        public void OpenTable(int number)
        {
            tabledb.MarkTableOpen(number);
        }

    }
}
