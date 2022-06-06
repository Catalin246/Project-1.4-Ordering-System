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
        public List<Item> GetStarters(bool var)
        {
            List<Item> items;
            if (var)
                items = itemdb.GetDinnerStarters();
            else
                items = itemdb.GetLunchStarters();
            return items;
        }
        public List<Item> GetMains(bool var)
        {
            List<Item> items;
            if (var)
                items = itemdb.GetDinerMains();
            else
                items = itemdb.GetLunchMains();
            return items;
        }
        public List<Item> GetDeserts(bool var)
        {
            List<Item> items;
            if (var)
                items = itemdb.GetDinerDeserts();
            else
                items = itemdb.GetLunchDeserts();
            return items;
        }


        public void Update(OrderedItem orderedItem)
        {
            itemdb.Update(orderedItem);
        }

        public Item GetItem(int itemID)
        {
            return itemdb.GetItem(itemID);
        }
    }
}
