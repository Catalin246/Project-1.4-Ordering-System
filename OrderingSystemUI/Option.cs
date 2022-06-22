using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystemUI
{
    public partial class Option : Form
    {
        private string employeeName;
        private string employeeRole;
        public Option(string employeeName, string employeeRole)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            TableView tableView = new TableView(employeeName,employeeRole);
            BarKitchenView barkitchenView = new BarKitchenView(employeeName,employeeRole);           
            
            barkitchenView.Close();
            tableView.Close();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            labelEmployeName.Text = employeeName;
            labelEmployeRole.Text = employeeRole; 
            switch (employeeRole.ToLower())
            {
                case "waiter":
                    MenuBar.Enabled = false;
                    MenuKitchen.Enabled = false;
                    break;
                case "cook":
                    MenuBar.Enabled = false;
                    MenuKitchen.Enabled = false;
                    break;
                case "bartender":
                    MenuKitchen.Enabled = false;
                    MenuKitchen.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TableView tableView = new TableView(employeeName, employeeRole);
            tableView.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//btn back
        {
            this.Close();
        }

        private void MenuBill_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            TableView tableView = new TableView(employeeName, employeeRole);
            tableView.Show();
        }

        private void MenuKitchen_Click(object sender, EventArgs e)
        {
            BarKitchenView barKitchenView = new BarKitchenView(employeeName, employeeRole);
            barKitchenView.Show();
        }

        private void MenuBar_Click(object sender, EventArgs e)
        {
            BarKitchenView barKitchenView = new BarKitchenView(employeeName,employeeRole);
            barKitchenView.Show();
        }
    }
}
