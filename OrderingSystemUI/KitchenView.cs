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
        EmployeeService employeeService;

        public KitchenView()
        {
            InitializeComponent();
            orderedItemService = new OrderedItemService();
            orderService = new OrderService();
            tableService = new TableService();
            itemService = new ItemService();
            employeeService = new EmployeeService();

            Employee employee = new Employee();
            //employee = employeeService.GetEmployee();
            
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

            btnemployeeNme.Text = employee.EmployeeName;            
        }

        private void LoadListView()
        {
            try
            {
                lblTime.Text = DateTime.Now.ToString("HH:mm");

                if (comboBoxShowOrders.SelectedIndex == 0)
                {
                    LoadRunningOrders();
                }
                else
                {
                    LoadFinishedOrders();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void LoadRunningOrders()
        {
            try
            {                
                listViewKitchen.Items.Clear();
                
                List<OrderedItem> orderedItemList = orderedItemService.GetPreparingFoodItemsFromDaoClass();

                foreach (OrderedItem orderitem in orderedItemList)
                {
                    ListViewItem list = new ListViewItem((orderitem.OrderId).ToString());
                    list.SubItems.Add(orderitem.TableId.ToString());
                    list.SubItems.Add(ShowTimePassed(orderitem.OrderTime));
                    list.SubItems.Add(orderitem.Category.ToString());
                    list.SubItems.Add(orderitem.Amount.ToString());
                    list.SubItems.Add(orderitem.Name);
                    list.SubItems.Add(ShowNoteTextWithNotification(orderitem.Note));
                    list.SubItems.Add(orderitem.Status.ToString());

                    list.Tag = orderitem;
                    listViewKitchen.Items.Add(list);
                }                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void LoadFinishedOrders()
        {
            try
            {
                btnReadyToServe.Enabled = false;
                listViewKitchen.Items.Clear();

                List<OrderedItem> orderedItemList = orderedItemService.GetFinishedFoodItemsFromDaoClass();

                foreach (OrderedItem orderitem in orderedItemList)
                {
                    ListViewItem list = new ListViewItem((orderitem.OrderId).ToString());
                    list.SubItems.Add(orderitem.TableId.ToString());
                    list.SubItems.Add(((DateTime.Now.TimeOfDay - orderitem.OrderTime.TimeOfDay).Minutes).ToString() + " min ago");
                    list.SubItems.Add(orderitem.Category.ToString());
                    list.SubItems.Add(orderitem.Amount.ToString());
                    list.SubItems.Add(orderitem.Name);
                    list.SubItems.Add(ShowNoteTextWithNotification(orderitem.Note));
                    list.SubItems.Add(orderitem.Status.ToString());

                    list.Tag = orderitem;
                    listViewKitchen.Items.Add(list);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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

                ListView.SelectedListViewItemCollection selectedItems = this.listViewKitchen.SelectedItems;

                btnReadyToServe.Enabled = true;
                btnViewOrderNote.Enabled = true;

                OrderedItem selectedItem = (OrderedItem)listViewKitchen.SelectedItems[0].Tag;
                //ListViewItem noteCol = listViewKitchen.Items[6];
                //if (noteCol.Text == "No")
                //{
                //    btnViewOrderNote.Enabled = false;
                //}
                //else if (listViewKitchen.SelectedItems.Count >= 1)
                //{
                //    btnViewOrderNote.Enabled = false;
                //}
                //else
                //{
                //    btnViewOrderNote.Enabled = false;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                LoadListView(); //refreshes the form in every 30 scs
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ShowNoteTextWithNotification(string noteInput)
        {
            string output = "";
            if (noteInput == "" || noteInput == "none")
            {
                output = "No";
            }
            else
            {
                output = "!!! YES";
            }
            return output;
        }
        

        private string ShowTimePassed(DateTime time)
        {
            TimeSpan orderTimeinTimeSpan = (DateTime.Now.TimeOfDay - time.TimeOfDay);
            TimeSpan tenMinLimit = new TimeSpan(0, 10, 0);

            if (TimeSpan.Compare(orderTimeinTimeSpan, tenMinLimit) == 1) //compares both timespans. 
            {
                //if the ordertime is longer than 10 mins, this will return 1
                return $"!!! {orderTimeinTimeSpan.Minutes} min ago";
            }
            else
            {
                return $"{orderTimeinTimeSpan.Minutes} min ago";
            }            
        }

        private string ShowTimePassedForFinishedOrders(DateTime time)
        {
            TimeSpan orderTimeinTimeSpan = (DateTime.Now.TimeOfDay - time.TimeOfDay);

             return $"{orderTimeinTimeSpan.Minutes} min ago";
            
        }

        private void btnViewOrderNote_Click(object sender, EventArgs e)
        {
            try
            {
                string output = "";

                OrderedItem selectedItem = (OrderedItem)listViewKitchen.SelectedItems[0].Tag;
                output = $"{selectedItem.OrderId}\n {selectedItem.Name} \n {selectedItem.Note}";
                                
                MessageBox.Show(output);               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadyToServe_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ListView.SelectedListViewItemCollection selectedItems = this.listViewKitchen.SelectedItems;

            //    foreach (ListViewItem item in selectedItems)
            //    {
            //        OrderedItem selectedItem = (OrderedItem)listViewKitchen.SelectedItems[0].Tag;
            //        int orderId = selectedItem.OrderId;
            //        int tableId = selectedItem.TableId;

            //        orderedItemService.ChangeOrderStatusToReady(orderId, tableId);

            //        LoadListView();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void comboBoxShowOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListView();
        }
    }
}
