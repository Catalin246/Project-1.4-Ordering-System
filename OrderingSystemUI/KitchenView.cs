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

        private bool runningOrFinished;
        public KitchenView()
        {
            InitializeComponent();
            orderedItemService = new OrderedItemService();
            orderService = new OrderService();
            tableService = new TableService();
            ItemService itemService = new ItemService();
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            runningOrFinished = true;
            LoadListView();

            if (listViewKitchen.SelectedItems.Count < 1)
                btnReadyToServe.Enabled = false;

        }

        private void LoadListView()
        {
            if (runningOrFinished == true)
            {
                LoadRunningOrders(orderService.GetAllFoodOrders());
            }
            else
            {
                LoadFinishedOrders(orderService.GetAllFinishedFoodOrders());
            }
        }

        private void LoadRunningOrders(List<Order> orders)
        {
            listViewKitchen.Items.Clear();

            foreach (Order order in orders)
            {
                if (order.OrderTime.Date == DateTime.Now.Date)
                {
                    foreach (OrderedItem orderedItem in order.OrderedItems)
                    {
                        if (orderedItem.Status == Status.Preparing)
                        {
                            string[] listview = { order.OrderId.ToString(),
                                order.TableId.ToString(),
                                $"{order.TimePassed.Minutes:00}:{order.TimePassed.Seconds:00}",
                                orderedItem.Amount.ToString(),
                                orderedItem.Item.ItemName,
                                orderedItem.Note,
                                orderedItem.Status.ToString()};

                            ListViewItem li = new ListViewItem(listview);
                            li.Tag = orderedItem;
                            listViewKitchen.Items.Add(li);
                        }
                    }
                }
            }

        }

        public void LoadFinishedOrders(List<Order> orders)
        {
            listViewKitchen.Items.Clear();

            foreach (Order order in orders)
            {
                if (order.OrderTime.Date == DateTime.Now.Date)
                {
                    foreach (OrderedItem orderedItem in order.OrderedItems)
                    {
                        if (orderedItem.Status != Status.Preparing)
                        {
                            string[] listview = { order.OrderId.ToString(),
                                order.TableId.ToString(),
                                $"{order.TimePassed.Minutes:00}:{order.TimePassed.Seconds:00}",
                                orderedItem.Amount.ToString(),
                                orderedItem.Item.ItemName,
                                orderedItem.Note,
                                orderedItem.Status.ToString()};

                            ListViewItem li = new ListViewItem(listview);
                            li.Tag = orderedItem;
                            listViewKitchen.Items.Add(li);
                        }
                    }
                }
            }
        }



        private void btnReadyToServe_Click(object sender, EventArgs e)
        {
            {
                foreach (ListViewItem item in listViewKitchen.SelectedItems)
                {
                    orderedItemService.UpdateStatusReady((OrderedItem)item.Tag);
                }

                LoadListView();
            }

        }
    }
}
