using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OrderingSystemModel;
using OrderingSystemLogic;

namespace OrderingSystemUI
{
    //NOTE: Kitchenview and barview both uses almost similar code (one uses food versions, other uses drink versions) 
    //i added comments on bar view which are explaining the code so if you want to see the comments, they are in BarView.cs
    //the same comments apply to this code (because they are 99% same).
    public partial class KitchenView : Form
    {
        OrderedItemService orderedItemService;
        private string EmployeeName { get; set; }
        private string EmployeeRole { get; set; }

        public KitchenView(string employeeName, string role)
        {
            InitializeComponent();
            orderedItemService = new OrderedItemService();

            this.EmployeeName = employeeName;
            this.EmployeeRole = role;

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
            comboBoxCourse.Items.Add("Lunch Starter");
            comboBoxCourse.Items.Add("Lunch Main");
            comboBoxCourse.Items.Add("Lunch Desert");
            comboBoxCourse.Items.Add("Diner Starter");
            comboBoxCourse.Items.Add("Diner Entrement");
            comboBoxCourse.Items.Add("Diner Main");
            comboBoxCourse.Items.Add("Diner Desert");

            LoadListView();
        }

        private void LoadListView()
        {
            try
            {
                btnemployeeName.Text = "Employee: " + EmployeeName;
                comboBoxCourse.SelectedItem = "none";
                comboBoxTable.SelectedItem = "none";
                comboBoxCourse.Enabled = false;                

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
                comboBoxTable.Enabled = true;

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
                comboBoxCourse.Enabled = false;
                comboBoxTable.Enabled = false;

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
            try
            {
                LoadListView();
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
                tableNo = tableNo.Replace("Table ", "");
                int index = int.Parse(tableNo);

                foreach (ListViewItem item in listViewKitchen.Items)
                {
                    OrderedItem orderedItem = (OrderedItem)item.Tag;

                    if (orderedItem.TableId == index)
                    {
                        item.Selected = true;
                    }
                }
                comboBoxCourse.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCourse_SelectedIndexChanged_1(object sender, EventArgs e)
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

                foreach (ListViewItem item in listViewKitchen.Items)
                {
                    OrderedItem orderedItem = (OrderedItem)item.Tag;

                    if (orderedItem.Category == courseName && orderedItem.TableId == index)
                    {
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
            this.Close();
        }
    }
}

