using System;
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
        private List<TakeOrder> takeOrders = new List<TakeOrder>();
        private string employeeName;
        private string employeeRole;
        Employee employee = new Employee();
        List<Button> buttonList { get; set; }
        private TableService tableService = new TableService();
        public TableView(string employeeName,string employeeRole)
        {
            employee.EmployeeName = employeeName;
            employee.EmployeeRole = employeeRole;
            this.employeeName = employeeName;
            this.employeeRole = employeeRole;            
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
                ShowListView();
            }
        }
        public void CheckTable()
        {
            List<Table> tableStatus = tableService.GetTablesStatus();
            foreach (Table table in tableStatus)
            {
                switch (table.TableStatus)
                {
                    case "Close":
                        ChangeColor(table.TableId, "ordered");
                        break;
                    case "Sit":
                        ChangeColor(table.TableId, "Sit");
                        break;
                    default:
                        break;
                }
            }
        }
        public void ShowListView()
        {
            try
            {
                List<Table> tables = tableService.GetTable();
                List<Drink> drinks = tableService.GetDrink();
                listViewTableOrder.Items.Clear();
                foreach (Table table in tables)
                {
                    if (table.OrderStatus == "Ready")
                    {
                        ListViewItem li = new ListViewItem(table.OrderStatus);
                        li.SubItems.Add(table.TableId.ToString());
                        foreach (Drink drink in drinks)
                        {
                            if (drink.DrinkId == table.ItemId)
                            {
                                li.SubItems.Add("Bar");
                                break;
                            }
                            else
                            {
                                li.SubItems.Add("Kitchen");
                                break;
                            }
                        }
                        TimeSpan time = DateTime.Now - table.Time;
                        li.SubItems.Add(time.ToString());
                        li.SubItems.Add(table.OrderId.ToString());
                        li.Tag = table;
                        listViewTableOrder.Items.Add(li);
                    }
                }
                List<Table> tablesId = tableService.GetTablesId();
                this.buttonList = GetButtons(tablesId);
                CheckTable();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void ChangeColor(int number, string btnInput)
        {
            string name = $"Table {number.ToString()}";
            List<Button> buttons = buttonList;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].Name == name.ToLower())
                {
                    switch (btnInput.ToLower())
                    {
                        case "sit":
                            buttons[i].BackColor = Color.Orange;
                            break;
                        case "ordered":
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BarKitchenView barViewForm = new BarKitchenView(this.employeeName, this.employeeRole);
            barViewForm.Show();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTableOrder.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = listViewTableOrder.SelectedItems[0];
            Table selectedOrder = (Table)selectedItem.Tag;
            lblOrderId.Text = selectedOrder.OrderId.ToString();
            lblItemId.Text = selectedOrder.ItemId.ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            KitchenView kitchenViewForm = new KitchenView(this.employeeName, this.employeeRole);
            kitchenViewForm.Show();
        }

        private void billViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment paymentView = new Payment();
            paymentView.Show();
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTableOrder.SelectedItems.Count == 0)
                    return;
                Table selectedItem = new Table();
                TableService tableService = new TableService();
                selectedItem.OrderId = int.Parse(lblOrderId.Text);
                selectedItem.ItemId = int.Parse(lblItemId.Text);
                tableService.Served(selectedItem);
                listViewTableOrder.Refresh();
                lblItemId.Text = "";
                lblOrderId.Text = "";
                showPanel("TableView");
            }
            catch (Exception ex)
            {
                throw new Exception("please select your ordered menu" +ex);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Payment paymentView = new Payment();
            paymentView.tableView = this;
            this.Hide();
            paymentView.Show();

        }
        private void TableView_Load(object sender, EventArgs e)
        {
            int x = 20;
            int y = -40;
            int z = 1;
            btnProfile.Text = employeeName;          
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            if (employeeRole == "Waiter")
            {
                MenuBar.Enabled = false;
                MenuKitchen.Enabled = false;
            }
            
        }
        private List<Button> GetButtons(List<Table> tablesId)
        {
            int x = 20;
            int y = -40;
            int z = 1;
            buttonList = new List<Button>();
            foreach (Table table in tablesId)
            {
                if (z % 2 == 0)
                    x = 200;
                else
                {
                    x = 20;
                    y += 80;
                }
                buttonList.Add(GenerateButtons(x, y, table.TableId, this));
                z++;
            }
            return buttonList;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ShowListView();
            DateTime dateTime = DateTime.Now;
            txtTime.Text = dateTime.ToString("H:mm:s");
        }    
        private void txtItemId_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Option optionForm = new Option(employeeName, employeeRole);
            optionForm.Show();
            this.Close();
        }
        public Button GenerateButtons(int x, int y, int tableNumber, Form form)
        {
            try
            {
                Button button = new Button();
                button.Text = "table " + tableNumber;
                button.Name = "table " + tableNumber;
                button.Width = 84;
                button.Height = 66;
                button.Location = new Point(x, y);
                form.Controls.Add(button);
                button.BringToFront();
                button.Click += button_Click;
                this.Controls.Add(button);
                return button;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button selected = sender as Button;
            var splitedName = selected.Name.Split(' ').Skip(1).FirstOrDefault();
            int tableNumber = int.Parse(splitedName);
            if (takeOrders[tableNumber-1] == null)
                takeOrders[tableNumber-1] = new TakeOrder(tableNumber, employee);
            CallPnlOptions(tableNumber, takeOrders[tableNumber - 1]);
        }
    }
}