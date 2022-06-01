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
    public partial class Payment : Form
    {
        public Bill bill;
        public Payment()
        {

            InitializeComponent();
        }

        private void OrderingSystem_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }
        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                pnlTakeOrder.Hide();
                pnlTableView.Hide();
                pnlDashboard.Show();
            }
            else if (panelName == "Table view")
            {
                pnlTakeOrder.Hide();
                pnlDashboard.Hide();
                pnlTableView.Show();
            }
            else if (panelName == "Take Order")
            {
                pnlDashboard.Hide();
                pnlTableView.Hide();
                pnlTakeOrder.Show();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void barViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kitchenViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Table view");
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            showPanel("Take Order");
        }



        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlTableView.Hide();
            pnlTakeOrder.Hide();
            pnlPayment.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxTotal.Text != null)
            {
                btnSaveTotal.Enabled = true;
            }
            else
            {
                btnSaveTotal.Enabled = false;
            }
        }

        private void btnSaveTotal_Click(object sender, EventArgs e)
        {
            // determine if valid update
            float desiredTotal = float.Parse(txtBoxTotal.Text);
            if (desiredTotal > bill.BillTotalWithoutTip)
            {
                float updatedTip = desiredTotal - bill.BillTotalWithoutTip;
                bill.Tip = updatedTip;
                // display  tip amount
                labelDisplayTip.Text = updatedTip.ToString();
                // display total with tip 
                labelDisplayTotalWithTip.Text = desiredTotal.ToString();
            }
        }

        private void listViewDisplaybillItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*// fill the bill listview within list of orderedItemns
                OrderedItemns teachService = new TeacherService(); ;
                List<Teacher> teacherList = teachService.GetTeachers(); ;

                // clear the listview before filling it again
                listViewTeacher.Clear();

                listViewTeacher.View = View.Details;
                listViewTeacher.FullRowSelect = true;
                listViewTeacher.Columns.Add("Id", 200);
                listViewTeacher.Columns.Add("First Name", 200);
                listViewTeacher.Columns.Add("Last Name", 200);

                foreach (Teacher t in teacherList)
                {
                    string[] listViewStrings = { t.Number.ToString(), t.FirstName, t.LastName };
                    ListViewItem li = new ListViewItem(listViewStrings);
                    listViewTeacher.Items.Add(li);

                }*/
            }
            catch (Exception)
            {
                //MessageBox.Show("Something went wrong while loading the Teachers: " + e.Message);
            }


        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            if (txtBoxTableNumber.Text != null)
            {
                int tableID = int.Parse(txtBoxTableNumber.Text);
                OrderService orderService = new OrderService();
                OrderedItemService orderedItemService = new OrderedItemService();
                ItemService itemService = new ItemService();

                List<Order> orders = orderService.GetOrdersByTable(tableID);
                List<OrderedItem> orderedItems = new List<OrderedItem>(); // use this list
                foreach (Order order in orders)
                {
                    orderedItems.Concat(orderedItemService.GetOrderedItemsByOrder(order.OrderId));
                }
                foreach(OrderedItem orderedItem in orderedItems)
                {
                    orderedItem.item = itemService.GetItem(orderedItem.itemID);
                }


            }
        }
    }
}
