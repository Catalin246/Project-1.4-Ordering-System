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
            
            LoadListView();

            if (listViewKitchen.SelectedItems.Count < 1)
            {
                btnReadyToServe.Enabled = false;
                btnViewOrderNote.Enabled = false;
            }

            comboBoxShowOrders.Items.Clear();
            comboBoxShowOrders.Items.Add("Running Orders");
            comboBoxShowOrders.Items.Add("Finished Orders");
            comboBoxShowOrders.SelectedIndex = 0;
        }

        private void LoadListView()
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");

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
                                ShowTimePassed(order).ToString(),
                                orderedItem.FoodCategory.ToString(),
                                orderedItem.Amount.ToString(),
                                orderedItem.Item.ItemName,
                                ShowNoteText(orderedItem.Note).ToString(),
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
                                $"{order.TimePassed.Minutes:00} min ago",
                                orderedItem.FoodCategory.ToString(),
                                orderedItem.Amount.ToString(),
                                orderedItem.Item.ItemName,
                                ShowNoteText(orderedItem.Note).ToString(),
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
                    //orderedItemService.UpdateStatusReady((OrderedItem)item.Tag);
                }

                LoadListView();
            }

        }

        private void listViewKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                if (listViewKitchen.SelectedItems.Count == 0)
                {
                    return;
                }
                btnReadyToServe.Enabled = true;
                btnViewOrderNote.Enabled = true;

                OrderedItem selectedItem = (OrderedItem)listViewKitchen.SelectedItems[0].Tag;
                if (selectedItem.Note == "")
                {
                    btnViewOrderNote.Enabled = false;
                }
                else if (listViewKitchen.SelectedItems.Count >= 1)
                {
                    btnViewOrderNote.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadListView();
        }

        private string ShowNoteText(string noteInput)
        {
            string output = "";
            if (noteInput == null)
            {
                output = "No";
            }
            else
            {
                output = "YES";
            }
            return output;
        }

        private string ShowTimePassed(Order order)
        {
            string output = "";
            if (order.TimePassed > new TimeSpan(10, 0, 0))
            {
                output = $"!!! {order.TimePassed.Minutes:00} min ago";
            }
            else
            {
                output = $"{order.TimePassed.Minutes:00} min ago";
            }
            return output;
        }

        private void comboBoxShowOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxShowOrders.SelectedIndex == 0)
            {
                runningOrFinished = false;
            }
            else
            {
                runningOrFinished = true;
            }
        }
    }
}
