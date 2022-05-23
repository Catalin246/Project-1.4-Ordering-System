using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
    public class ItemService
    {
        ItemDao itemdb;

        public ItemService()
        {
            itemdb = new ItemDao();
        }

        public List<Item> GetDrinks()
        {
            List<Item> items = itemdb.GetAllDrinks();
            return items;
        }
        public List<Item> GetStarters()
        {
            List<Item> items = itemdb.GetAllStarters();
            return items;
        }
        public List<Item> GetMains()
        {
            List<Item> items = itemdb.GetAllMains();
            return items;
        }
        public List<Item> GetDesserts()
        {
            List<Item> items = itemdb.GetAllDesserts();
            return items;
        }
    }
}
