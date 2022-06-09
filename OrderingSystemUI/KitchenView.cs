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

            
            btnReadyToServe.Enabled = false;
            btnViewOrderNote.Enabled = false;
            

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
                listViewKitchen.MultiSelect = true;
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
                listViewKitchen.MultiSelect = false;
                btnReadyToServe.Enabled = false;
                listViewKitchen.Items.Clear();

                List<OrderedItem> orderedItemList = orderedItemService.GetFinishedFoodItemsFromDaoClass();

                foreach (OrderedItem orderitem in orderedItemList)
                {
                    ListViewItem list = new ListViewItem((orderitem.OrderId).ToString());
                    list.SubItems.Add(orderitem.TableId.ToString());
                    list.SubItems.Add(ShowTimePassedForFinishedOrders(orderitem.OrderTime));
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
                else
                {
                    OrderedItem selected = (OrderedItem)listViewKitchen.SelectedItems[0].Tag;

                    if (selected.Status != Status.Preparing)
                    {
                        btnReadyToServe.Enabled = false;
                    }
                    else
                    {
                        btnReadyToServe.Enabled = true;
                    }

                    if (listViewKitchen.SelectedItems.Count > 1)
                    {
                        btnViewOrderNote.Enabled = false;
                    }
                    else
                    {
                        //OrderedItem selectedItem = (OrderedItem)listViewKitchen.SelectedItems[0].Tag;

                        if ((selected.Note == "") || (selected.Note == "none"))
                        {
                            btnViewOrderNote.Enabled = false;
                        }
                        else
                        {
                            btnViewOrderNote.Enabled = true;
                        }
                    }
                }
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
            string output;
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
        

        private string ShowTimePassed(DateTime orderTime)
        {            
            DateTime now = DateTime.Now;
            TimeSpan diff = now.Subtract(orderTime);
            double minuteDiff = Convert.ToInt32(diff.TotalMinutes);                        

            if (10 < minuteDiff) 
            {                
                return $"!!! {minuteDiff} min ago";
            }
            else
            {
                return $"{minuteDiff} min ago";
            }            
        }

        private string ShowTimePassedForFinishedOrders(DateTime orderTime)
        {
            DateTime now = DateTime.Now;
            TimeSpan diff = now.Subtract(orderTime);
            double minuteDiff = Convert.ToInt32(diff.TotalMinutes);
                        
            return $"{minuteDiff} min ago";
            
        }

        private void btnViewOrderNote_Click(object sender, EventArgs e)
        {
            try
            {
                string output = "";

                OrderedItem selectedItem = (OrderedItem)listViewKitchen.SelectedItems[0].Tag;
                output = $"{selectedItem.OrderId}\n\n {selectedItem.Name} \n\n {selectedItem.Note}";
                                
                MessageBox.Show(output);               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadyToServe_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewKitchen.SelectedItems[0] == null)
                {
                    return;
                }

                if (listViewKitchen.SelectedItems.Count > 0)
                {

                    for (int i = 0; i < listViewKitchen.SelectedItems.Count; i++)
                    {
                        OrderedItem selectedItem = (OrderedItem)listViewKitchen.SelectedItems[i].Tag;
                        int orderId = selectedItem.OrderId;
                        string itemName = selectedItem.Name;

                        orderedItemService.ChangeOrderStatusToReady(orderId, itemName);
                    }
                }

                btnReadyToServe.Enabled = false;

                LoadListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxShowOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListView();
        }
    }
}
