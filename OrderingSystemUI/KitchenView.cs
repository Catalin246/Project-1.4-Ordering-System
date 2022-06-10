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
        private string EmployeeName { get; set; }
        public KitchenView()
        {
            InitializeComponent();
            orderedItemService = new OrderedItemService();
            orderService = new OrderService();
            tableService = new TableService();
            itemService = new ItemService();
            employeeService = new EmployeeService();
                        

            LoadListView();

            btnReadyToServe.Enabled = false;
            btnViewOrderNote.Enabled = false;            
            comboBoxCourse.Enabled = false;


            comboBoxShowOrders.Items.Clear();
            comboBoxShowOrders.Items.Add("Running Orders");
            comboBoxShowOrders.Items.Add("Finished Orders");
            comboBoxShowOrders.SelectedIndex = 0;

            comboBoxTable.Items.Clear();
            comboBoxTable.Items.Add("none");
            comboBoxTable.SelectedIndex = 0;
            comboBoxTable.Items.Add("Table 1");
            comboBoxTable.Items.Add("Table 2");
            comboBoxTable.Items.Add("Table 3");
            comboBoxTable.Items.Add("Table 4");
            comboBoxTable.Items.Add("Table 5");
            comboBoxTable.Items.Add("Table 6");
            comboBoxTable.Items.Add("Table 7");
            comboBoxTable.Items.Add("Table 8");
            comboBoxTable.Items.Add("Table 9");
            comboBoxTable.Items.Add("Table 10");

            comboBoxCourse.Items.Clear();
            comboBoxCourse.Items.Add("none");
            comboBoxCourse.SelectedIndex = 0;
            comboBoxCourse.Items.Add("Starters");
            comboBoxCourse.Items.Add("Mains");
            comboBoxCourse.Items.Add("Entremets");
            comboBoxCourse.Items.Add("Deserts");
        }
        public KitchenView(string employeeName) : base()
        {
            this.EmployeeName = employeeName;
        }

        private void LoadListView()
        {
            btnemployeeNme.Text = EmployeeName;
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
        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxTable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedIndex == 0)
            {
                return;
            }

            string tableNo = comboBoxTable.SelectedIndex.ToString();
            tableNo = tableNo.Replace("Table ", "");
            int index = int.Parse(tableNo);

            foreach (ListViewItem item in listViewKitchen.Items)
            {
                OrderedItem orderedItem = (OrderedItem)listViewKitchen.SelectedItems[0].Tag;

                if (orderedItem.TableId == index)
                {
                    item.Selected = true;
                }
            }
            comboBoxCourse.Enabled = true;
        }

        private void comboBoxCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxCourse.SelectedIndex == 0)
            {
                return;
            }
            string courseName = comboBoxTable.SelectedIndex.ToString();

            foreach (ListViewItem item in listViewKitchen.Items)
            {
                OrderedItem orderedItem = (OrderedItem)listViewKitchen.SelectedItems[0].Tag;

                if (orderedItem.Category == courseName)
                {
                    item.Selected = true;
                }
            }
        }
    }
}
