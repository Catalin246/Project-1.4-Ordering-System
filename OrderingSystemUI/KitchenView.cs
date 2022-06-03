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

        bool readyToServe;

        public KitchenView()
        {
            InitializeComponent();
            orderedItemService = new OrderedItemService();
            orderService = new OrderService();
            tableService = new TableService();
            ItemService itemService = new ItemService();
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            readyToServe = true;

            if (listViewKitchen.SelectedItems.Count < 1)
                btnReadyToServe.Enabled = false;
            
        }

        //loading the listview
        public void ReadListOfFoodOrders(List<Order> orders)
        {
            listViewKitchen.Items.Clear();

            foreach (Order order in orders)
            {
                if (order.OrderTime.Date == DateTime.Now.Date)
                {
                    foreach (OrderedItem2 ordereditem in order.OrderedItems)
                    {
                        if (ordereditem.Status != Status.Preparing)
                        {
                            string[] listview = { order.OrderId.ToString(), order.TableId.ToString(), order.OrderTime.ToString("HH:mm:ss"), $"{order.TimePassed.Minutes:00}:{order.TimePassed.Seconds:00}", ordereditem.Item.ItemName, ordereditem.Amount.ToString(), ordereditem.Note };
                            ListViewItem li = new ListViewItem(listview);
                            li.Tag = ordereditem;
                            listViewKitchen.Items.Add(li);
                        }
                    }
                }
            }
        }

        private void btnReadyToServe_Click(object sender, EventArgs e)
        {            
            if
            {
                foreach (ListViewItem item in listViewKitchen.SelectedItems)
                {
                    orderedItemService.ChangeStatus((OrderedItem2)item.Tag);
                }
                //ListViewLoad();
            }

        }
    }
}
