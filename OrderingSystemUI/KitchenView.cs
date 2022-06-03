using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OrderingSystemModel;
using OrderingSystemLogic;

namespace OrderingSystemUI
{
    public partial class KitchenView : Form
    {
        OrderedItemService orderedItemService;
        OrderService orderService;
        TableService tableService;
        ItemService itemService;

        public KitchenView()
        {
            InitializeComponent();
            orderedItemService = new OrderedItemService();
            orderService = new OrderService();
            tableService = new TableService();
            ItemService itemService = new ItemService();
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }

        public void ReadListOfFoodOrders()
        {
            List<OrderedItem> foodOrderList = orderedItemService.GetFoodOrders();

            int tableNo = 0; //change this later

            listViewKitchen.Items.Clear();
            listViewKitchen.FullRowSelect = true;

            foreach (OrderedItem foodOrder in foodOrderList)
            {
                Item item = itemService.GetItem(foodOrder.itemID);

                ListViewItem li = new ListViewItem(foodOrder.orderId.ToString());
                li.SubItems.Add(tableNo.ToString());
                li.SubItems.Add(GetCalculatedTime(foodOrder.orderId));
                li.SubItems.Add(item.ItemCategory.ToString());
                li.SubItems.Add(foodOrder.amount.ToString());
                li.SubItems.Add(item.ItemName.ToString());
                li.SubItems.Add(foodOrder.note.ToString());
                li.SubItems.Add("Running");
            }
        }

        public string GetCalculatedTime(int OrderId)
        {
            Order order = new Order(1); //change this
            DateTime a = new DateTime();
            DateTime b = new DateTime();
            a = order.OrderTime;
            b = DateTime.Now;
            return $"(b.Subtract(a).TotalMinutes) minutes ago";
        }

        //public int GetTableNoFromOrderedItem()
        //{

        //}
    }
}
