﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystemLogic;
using OrderingSystemModel;

namespace OrderingSystemUI
{
    public partial class TableView : Form
    {
        private int number;
        List<TakeOrder> takeOrders = new List<TakeOrder>();

        public TableView()
        {
            InitializeComponent();
            ShowListView();
            for (int i = 0; i < 10; i++)
                takeOrders.Add(null);
        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("TableView");
        }

        private void pnlOrderView_Paint(object sender, PaintEventArgs e)
        {

        }
        private void showPanel(string panelName)
        {
            if (panelName == "TableView")
            {
                pnlTableView.Show();
            }
        }
        public void ShowListView()
        {
            TableService tableService = new TableService();
            //DrinkService drinkService = new DrinkService();
            //List<Table> tables = tableService.GetTable();
            List<Table> tableStatus = tableService.GetTablesStatus();
            //List<Drink> drinks = drinkService.GetDrinks();
            listViewTableOrder.Items.Clear();
            foreach (Table table in tableStatus)
            {
                if (table.TableStatus == "Close")
                {
                    ChangeColor(table.TableId, "Sit");
                }
            }            
            //foreach (Table table in tables)
            //{
            //    if (table.OrderStatus == "Ready")
            //    {                    
            //        ListViewItem li = new ListViewItem(table.OrderStatus);
            //        li.SubItems.Add(table.TableId.ToString());
            //        li.SubItems.Add(table.Time.ToString("H:m"));
            //        li.SubItems.Add(table.OrderId.ToString());
            //        listViewTableOrder.Items.Add(li);
            //    }
            //}
        }
        public void ChangeColor(int number, string btnInput)
        {
            string name = $"Table {number.ToString()}";
            List<Button> buttons = this.Controls.OfType<Button>().ToList();
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].Text == name)
                {
                    switch (btnInput.ToLower())
                    {
                        case "sit":
                            buttons[i].BackColor = Color.Red;
                            break;
                        default:
                            buttons[i].BackColor = Color.Transparent;
                            break;
                    }
                }
            }
        }
        private void CallPnlOptions(int number, TakeOrder takeOrder)
        {

            TableViewOptions options = new TableViewOptions(number, this, takeOrder);
            options.Show();
        }

        private void btnTable01_Click(object sender, EventArgs e)
        {
            if (takeOrders[0] == null)
                takeOrders[0] = new TakeOrder(1);
            CallPnlOptions(1, takeOrders[0]);
        }

        private void btnTable02_Click(object sender, EventArgs e)
        {
            if (takeOrders[1] == null)
                takeOrders[1] = new TakeOrder(2);
            CallPnlOptions(2, takeOrders[1]);
        }

        private void btnTable03_Click(object sender, EventArgs e)
        {
            if (takeOrders[2] == null)
                takeOrders[2] = new TakeOrder(3);
            CallPnlOptions(3, takeOrders[2]);
        }

        private void btnTable04_Click(object sender, EventArgs e)
        {
            if (takeOrders[3] == null)
                takeOrders[3] = new TakeOrder(4);
            CallPnlOptions(4, takeOrders[3]);
        }

        private void btnTable05_Click(object sender, EventArgs e)
        {
            if (takeOrders[4] == null)
                takeOrders[4] = new TakeOrder(5);
            CallPnlOptions(5, takeOrders[4]);
        }

        private void btnTable06_Click(object sender, EventArgs e)
        {
            if (takeOrders[5] == null)
                takeOrders[5] = new TakeOrder(6);
            CallPnlOptions(6, takeOrders[5]);
        }

        private void btnTable07_Click(object sender, EventArgs e)
        {
            if (takeOrders[6] == null)
                takeOrders[6] = new TakeOrder(7);
            CallPnlOptions(7, takeOrders[6]);
        }

        private void btnTable08_Click(object sender, EventArgs e)
        {
            if (takeOrders[7] == null)
                takeOrders[7] = new TakeOrder(8);
            CallPnlOptions(8, takeOrders[7]);
        }

        private void btnTable09_Click(object sender, EventArgs e)
        {
            if (takeOrders[8] == null)
                takeOrders[8] = new TakeOrder(9);
            CallPnlOptions(9, takeOrders[8]);
        }

        private void btnTable010_Click(object sender, EventArgs e)
        {
            if (takeOrders[9] == null)
                takeOrders[9] = new TakeOrder(10);
            CallPnlOptions(10, takeOrders[9]);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            KitchenView kitchenViewForm = new KitchenView();
            kitchenViewForm.Show();
        }

        private void billViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment paymentView = new Payment();
            paymentView.Show();
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            if (listViewTableOrder.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = listViewTableOrder.SelectedItems[0];
            Table table = new Table();
            TableService tableService = new TableService();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Payment paymentView = new Payment();
            paymentView.Show();
        }
    }
}