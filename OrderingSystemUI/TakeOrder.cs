using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystemDAL;
using OrderingSystemLogic;
using OrderingSystemModel;


namespace OrderingSystemUI
{
    public partial class TakeOrder : Form
    {
        public string note;
        public int tableNumber;
        public TableView tableView;
        public AddNote addNote;
        public Order order;
        Employee employee;
        public TakeOrder(int tableNumber, Employee employee)
        {
            this.employee = employee;
            this.tableNumber = tableNumber;
            InitializeComponent();
            lblTableNumber.Text = "Table#" + this.tableNumber.ToString();
            lblEmployeeName.Text = "Employee Name: " + employee.EmployeeName.ToString();
        }
      
        //Display menu items
        public void DisplayItems(List<Item> items)
        {
            try
            {                
                listViewMenuItems.Items.Clear();

                foreach (Item item in items)
                {
                    ListViewItem li = new ListViewItem(item.ItemName);
                    li.SubItems.Add(item.ItemPrice.ToString());
                    li.SubItems.Add(item.ItemType);

                    li.Tag = item;

                    listViewMenuItems.Items.Add(li);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        //Display order items
        public void DisplayOrderItems(List<OrderedItem> items)
        {
            try
            {
                listViewOrderItems.Items.Clear();

                foreach (OrderedItem item in order.OrderedItems)
                {
                    ListViewItem li = new ListViewItem(item.Item.ItemName);
                    li.SubItems.Add(item.Item.ItemPrice.ToString());
                    li.SubItems.Add(item.Amount.ToString());
                    li.SubItems.Add(item.Note.ToString());

                    li.Tag = item;

                    listViewOrderItems.Items.Add(li);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        //Display order items and add note
        public void DisplayOrderItemsNote(List<OrderedItem> items, string note,ListViewItem selectedItem)
        {
            try
            {
                ItemService itemService = new ItemService();

                if (listViewMenuItems.SelectedItems.Count == 0)
                    return;

                OrderedItem itemSelected = (OrderedItem)selectedItem.Tag;

                foreach (OrderedItem item in order.OrderedItems)
                {
                    if (itemSelected == item)
                        item.Note = note;
                }

                listViewOrderItems.Items.Clear();

                foreach (OrderedItem item in order.OrderedItems)
                {
                    ListViewItem li = new ListViewItem(item.Item.ItemName);
                    li.SubItems.Add(item.Item.ItemPrice.ToString());
                    li.SubItems.Add(item.Amount.ToString());
                    li.SubItems.Add(item.Note.ToString());

                    li.Tag = item;

                    listViewOrderItems.Items.Add(li);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }
       
        private void btnDrinks_Click_1(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();
                List<Item> items = itemService.GetDrinks();
                DisplayItems(items);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }
      
        private void btnStarters_Click_1(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();
                List<Item> items = itemService.GetStarters(CheckDinerTime());
                DisplayItems(items);                               
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnMains_Click_1(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();
                List<Item> items = itemService.GetMains(CheckDinerTime());
                DisplayItems(items);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnDesserts_Click_1(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();
                List<Item> items = itemService.GetDeserts(CheckDinerTime());
                DisplayItems(items);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }
        private bool CheckDinerTime()
        {
            bool dinerTime = false;
            TimeSpan timeNow = DateTime.Now.TimeOfDay;
            TimeSpan startTimeForDinner = new TimeSpan(18, 00, 00);
            if (timeNow > startTimeForDinner)
                dinerTime = true;
            return dinerTime;
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            try
            {
                btnTake.Enabled = false;
                btnPayment.Enabled = true;
                btnCancel.Enabled = false;
                btnAdd.Enabled = false;
                btnMinus.Enabled = false;   
                btnModify.Enabled = true;

                List<Order> orders = new List<Order>();
                OrderService orderService = new OrderService();
                OrderedItemService orderedItemService = new OrderedItemService();
                if (btnModify.Enabled == true)
                {
                    orderService.AddOrder(order);
                    order.OrderId = orderService.GetOrderId();
                }

                foreach (OrderedItem item in order.OrderedItems)
                {
                    if (item.ItemAddedInDatabase == false)
                    {
                        orderedItemService.AddOrderesItem(item, order);
                        item.ItemAddedInDatabase = true;
                    }
                    else
                    {
                        orderedItemService.UpdateAmount(item, order.OrderId);
                    }
                }
                btnModify.Enabled = true;
                MessageBox.Show("Order was taken successfully");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnPayment.Enabled = false;
                btnTake.Enabled = false;
                btnCancel.Enabled = false;

                order.OrderedItems = new List<OrderedItem>();

                listViewOrderItems.Items.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();
                bool contains = false;

                if (listViewMenuItems.SelectedItems.Count == 0)
                    return;

                ListViewItem selectedItem = listViewOrderItems.SelectedItems[0];
                OrderedItem itemSelected = (OrderedItem)selectedItem.Tag;

                foreach (OrderedItem item in order.OrderedItems)
                {
                    if (itemSelected == item)
                        if (item.Amount == 1)
                            contains = true;
                        else
                        {
                            item.Item.ItemStock++;
                            item.Amount--;
                            itemService.Update(itemSelected);
                        }
                }

                if (contains)
                {
                    itemSelected.Item.ItemStock++;
                    order.OrderedItems.Remove(itemSelected);
                    itemService.Update(itemSelected);
                }

                DisplayOrderItems(order.OrderedItems);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();

                btnCancel.Enabled = true;
                btnTake.Enabled = true;

                bool contains = false;
                if (order == null)
                    order = new Order(tableNumber);

                if (listViewMenuItems.SelectedItems.Count == 0)
                    return;

                ListViewItem selectedItem = listViewMenuItems.SelectedItems[0];
                Item itemSelected = (Item)selectedItem.Tag;

                OrderedItem orderedItem = new OrderedItem(itemSelected, 1, "", 0);

                if (order.OrderedItems != null)
                    foreach (OrderedItem item in order.OrderedItems)
                    {
                        if (item.Item == itemSelected)
                        {
                            item.Amount++;
                            item.Item.ItemStock--;
                            itemService.Update(orderedItem);
                            contains = true;
                        }
                    }

                if (!contains)
                {
                    order.OrderedItems.Add(orderedItem);
                    orderedItem.Item.ItemStock--;
                    itemService.Update(orderedItem);
                }

                DisplayOrderItems(order.OrderedItems);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                btnModify.Enabled = false;
                btnAdd.Enabled = true;
                btnMinus.Enabled = true;
                btnTake.Enabled = true;
                btnCancel.Enabled = true;
                btnPayment.Enabled = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        //Open payment form
        private void btnPayment_Click(object sender, EventArgs e)
        {
           
            try
            {
                btnPayment.Enabled = false;
                this.Close();
                Payment payment = new Payment(tableNumber);
                payment.tableView = this.tableView;
                payment.Show();
                //if ordered item list != null then... DisplayOrderedItems(List<OrderedItem> orderedItems)
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        //Add note for an item
        private void listViewOrderItems_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(btnModify.Enabled == false)
                {
                    ListViewItem selectedItem = listViewOrderItems.SelectedItems[0];

                    addNote = new AddNote(this, selectedItem);
                    addNote.Show();
                }
                else
                {
                    MessageBox.Show("Please press button 'Modify Order' if you want to add a comment!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void lblEmployeeName_MouseClick(object sender, MouseEventArgs e)
        {
            Option option = new Option(employee.EmployeeName, employee.EmployeeRole);
            option.Show();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            tableView.Show();
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCourse.SelectedIndex == 0)
                {
                    return;
                }
                else if (comboBoxCourse.SelectedIndex == 0)
                {
                    return;
                }

                string courseName = comboBoxCourse.SelectedItem.ToString();

                foreach (ListViewItem item in listViewMenuItems.Items)
                {
                    Item orderedItem = (Item)item.Tag;

                    if (orderedItem.ItemType == courseName)
                    {
                        item.Selected = true;
                        listViewMenuItems.EnsureVisible(listViewMenuItems.Items.IndexOf(listViewMenuItems.SelectedItems[0]));
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

     
    }
}
    

