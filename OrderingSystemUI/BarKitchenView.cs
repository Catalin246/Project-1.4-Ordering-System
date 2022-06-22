using System;
using System.Collections.Generic;
using OrderingSystemModel;
using OrderingSystemLogic;
using System.Windows.Forms;

namespace OrderingSystemUI
{
    public partial class BarKitchenView : Form
    {
        OrderedItemService orderedItemService;
        private string EmployeeName { get; set; }
        private string EmployeeRole { get; set; }
        public BarKitchenView(string employeeName, string role)
        {
            InitializeComponent();
            orderedItemService = new OrderedItemService();

            this.EmployeeName = employeeName;
            this.EmployeeRole = role;           

            //adding 2 options (running & finished) order to the view order combo.
            comboBoxShowOrders.Items.Clear();
            comboBoxShowOrders.Items.Add("Running Orders");
            comboBoxShowOrders.Items.Add("Finished Orders");
            comboBoxShowOrders.SelectedIndex = 0;

            //adding options to table filter combo.
            comboBoxTable.Items.Clear();
            comboBoxTable.Items.Add("none");
            comboBoxTable.SelectedIndex = 0;

            for (int i = 1; i < 11; i++)
            {
                comboBoxTable.Items.Add("Table " + i);
            }           
            
            CheckEmployeeRole();
        }

        public void CheckEmployeeRole()
        {
            try
            {
                if (this.EmployeeRole == "Bartender")
                {      
                    //adding options to course combo.
                    comboBoxCourse.Items.Clear();
                    comboBoxCourse.Items.Add("none");
                    comboBoxCourse.SelectedIndex = 0;
                    comboBoxCourse.Items.Add("Beer");
                    comboBoxCourse.Items.Add("Soft");
                    comboBoxCourse.Items.Add("Coffee");
                    comboBoxCourse.Items.Add("Tea");
                    comboBoxCourse.Items.Add("Spirit Drink");
                    comboBoxCourse.Items.Add("Wine");

                    LoadForm();
                }
                else if (this.EmployeeRole == "Cook")
                {         
                    comboBoxCourse.Items.Clear();
                    comboBoxCourse.Items.Add("none");
                    comboBoxCourse.SelectedIndex = 0;
                    comboBoxCourse.Items.Add("Lunch Starter");
                    comboBoxCourse.Items.Add("Lunch Main");
                    comboBoxCourse.Items.Add("Lunch Desert");
                    comboBoxCourse.Items.Add("Diner Starter");
                    comboBoxCourse.Items.Add("Diner Entrement");
                    comboBoxCourse.Items.Add("Diner Main");
                    comboBoxCourse.Items.Add("Diner Desert");

                    LoadForm();
                }
                else
                {
                    MessageBox.Show("You do not have permission to load this form.");
                }

                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void LoadForm()
        {
            try
            {
                //making all buttons disabled first.
                //these will be enabled when some actions are done.
                btnReadyToServe.Enabled = false;
                btnViewOrderNote.Enabled = false;
                comboBoxCourse.Enabled = false;

                //setting things that should load everytime the listview refreshes itself.
                btnemployeeName.Text = "Employee: " + EmployeeName;
                comboBoxCourse.SelectedItem = "none";
                comboBoxTable.SelectedItem = "none"; //default combobox options.                

                lblTime.Text = DateTime.Now.ToString("HH:mm"); //in every refresh, time is updating. 

                LoadListView();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadListView()
        {
            try
            {
                if (comboBoxShowOrders.SelectedIndex == 0) //if running orders is selected
                {
                    LoadRunningOrders();
                }
                else
                {
                    LoadFinishedOrders(); //if "finished orders" is selected.
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
                listViewBar.MultiSelect = true;
                listViewBar.Items.Clear();
                comboBoxTable.Enabled = true;

                List<OrderedItem> orderedItemList = GetOrderedRunningItems();

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
                    listViewBar.Items.Add(list);
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
                //when listview shows the finished orders, REadyToServe button should be disabled. 
                // because these orders already "finished" so they are already "Ready Be Serve"
                listViewBar.MultiSelect = false;
                btnReadyToServe.Enabled = false;
                listViewBar.Items.Clear();
                comboBoxCourse.Enabled = false;
                comboBoxTable.Enabled = false;

                List<OrderedItem> orderedItemList = GetFinishedItems();

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
                    listViewBar.Items.Add(list);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void listViewBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewBar.SelectedItems.Count == 0)
                {
                    return;
                }
                else
                {
                    OrderedItem selected = (OrderedItem)listViewBar.SelectedItems[0].Tag;

                    if (selected.Status != Status.Ordered)
                    {
                        btnReadyToServe.Enabled = false;
                    }
                    else
                    {
                        btnReadyToServe.Enabled = true;
                    }

                    if (listViewBar.SelectedItems.Count > 1)
                    {
                        //disabling the ViewOrderNote button if more than 1 items are selected.
                        btnViewOrderNote.Enabled = false;
                    }
                    else
                    {
                        //disabling the ViewOrderNote button if order note is "none" or null. So these won't
                        //be seen as note in the system.
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
                LoadForm(); //refreshes the form in every 30 scs
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
                //putting !!! to make note more visible.
                output = "!!! YES";
            }
            return output;
        }

        private string ShowTimePassed(DateTime orderTime)
        {
            DateTime now = DateTime.Now;
            TimeSpan diff = now.Subtract(orderTime);
            int minuteDiff = Convert.ToInt32(diff.TotalMinutes);

            if (10 < minuteDiff)
            {
                //if the order time is more than 10 mins ago, the bartender/chef must be hurry. so this is a notification..
                return $"!!! {minuteDiff} min ago";
            }
            else
            {
                return $"{minuteDiff} min ago";
            }
        }

        private string ShowTimePassedForFinishedOrders(DateTime orderTime)
        {
            //finished orders dont need any notification. so they recieve normal time.
            DateTime now = DateTime.Now;
            TimeSpan diff = now.Subtract(orderTime);
            double minuteDiff = Convert.ToInt32(diff.TotalMinutes);

            return $"{minuteDiff} min ago";

        }

        private void btnViewOrderNote_Click(object sender, EventArgs e)
        {
            try
            {
                //this is showing note:
                string output = "";

                OrderedItem selectedItem = (OrderedItem)listViewBar.SelectedItems[0].Tag;
                output = $"{selectedItem.OrderId}\n\n {selectedItem.Name} \n\n NOTE: \n\n {selectedItem.Note}";

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
                if (listViewBar.SelectedItems[0] == null)
                {
                    return;
                }

                if (listViewBar.SelectedItems.Count > 0)
                {
                    //for every item selected in listview, this updates the data.
                    for (int i = 0; i < listViewBar.SelectedItems.Count; i++)
                    {
                        OrderedItem selectedItem = (OrderedItem)listViewBar.SelectedItems[i].Tag;
                        int orderId = selectedItem.OrderId;
                        int itemId = selectedItem.ItemID;

                        orderedItemService.ChangeOrderStatusToReady(orderId, itemId);
                    }
                }

                btnReadyToServe.Enabled = false;

                LoadForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxShowOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //everytime showing mode changes, listview must renew itself.
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTable.SelectedIndex == 0)
                {
                    return;
                }

                string tableNo = comboBoxTable.SelectedItem.ToString();
                tableNo = tableNo.Replace("Table ", ""); //getting only the number from the combobox.
                int index = int.Parse(tableNo);

                foreach (ListViewItem item in listViewBar.Items)
                {
                    OrderedItem orderedItem = (OrderedItem)item.Tag;

                    if (orderedItem.TableId == index) //if order's table id is same with the item in listview
                    {
                        item.Selected = true;
                    }
                }
                comboBoxCourse.Enabled = true; //after combobox table is selected, course combobox is also enabled.
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTable.SelectedIndex == 0)
                {
                    return;
                }
                else if (comboBoxCourse.SelectedIndex == 0)
                {
                    return;
                }

                string tableNo = comboBoxTable.SelectedIndex.ToString();
                tableNo = tableNo.Replace("Table ", "");
                int index = int.Parse(tableNo);

                string courseName = comboBoxCourse.SelectedItem.ToString();

                foreach (ListViewItem item in listViewBar.Items)
                {
                    OrderedItem orderedItem = (OrderedItem)item.Tag;

                    if (orderedItem.Category == courseName && orderedItem.TableId == index)
                    {
                        //if both category names (from combobox) and table ids(from combobox) same, this item should be selected automatically.
                        item.Selected = true;
                    }
                    else
                    {
                        item.Selected = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnemployeeName_Click(object sender, EventArgs e)
        {
            Option optionForm = new Option(EmployeeName, EmployeeRole);
            optionForm.Show();
            
        }

        private List<OrderedItem> GetOrderedRunningItems()
        {
            List<OrderedItem> orderedItemList = new List<OrderedItem>();

            if (this.EmployeeRole == "Bartender")
            {
                orderedItemList = orderedItemService.GetPreparingDrinkItemsFromDaoClass();
            }
            else if (this.EmployeeRole == "Cook")
            {
                orderedItemList = orderedItemService.GetPreparingFoodItemsFromDaoClass();
            }

            return orderedItemList;
        }

        private List<OrderedItem> GetFinishedItems()
        {
            List<OrderedItem> orderedItemList = new List<OrderedItem>();

            if (this.EmployeeRole == "Bartender")
            {
                orderedItemList = orderedItemService.GetFinishedDrinkItemsFromDaoClass();
            }
            else if (this.EmployeeRole == "Cook")
            {
                orderedItemList = orderedItemService.GetFinishedFoodItemsFromDaoClass();
            }
            return orderedItemList;
        }
    }
}
