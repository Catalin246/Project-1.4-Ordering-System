using OrderingSystemLogic;
using OrderingSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystemUI
{
    public partial class Login : Form
    {
        private string username;
        private string passcode;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxUsername.Text =="")
                    lblWrongUserName.Text = "Please enter your username";                
                if (txtBoxPasscode.Text =="")
                    lblwrongPasscode.Text = "Please enter your passcode";                
                username = txtBoxUsername.Text;
                passcode = txtBoxPasscode.Text;
                List<Employee> list = new List<Employee>();
                EmployeeService accountService = new EmployeeService();
                list = accountService.GetAllEmployee();
                foreach (Employee item in list)
                {
                    if (TryPasscode(username, item.EmployeeName) && TryUserName(passcode,item.EmployeePassword))
                    {
                        EmployeeRole(item.EmployeeRole, item.EmployeeName);
                    }
                }
            }
            catch (Exception )
            {
                Console.WriteLine("Something wrong with the login");
            }
        }

        public void EmployeeRole(string employeeRole, string employeeName)
        {
            switch (employeeRole)
            {
                case "Cook":
                    KitchenView kitchenView = new KitchenView(employeeName, employeeRole);
                    kitchenView.Show();                    
                    this.Hide();
                    break;
                case "Waiter":
                    TableView tableView = new TableView(employeeName,employeeRole);
                    tableView.Show();
                    this.Hide();
                    break;
                case "Bartender":
                    BarView barView = new BarView(employeeName,employeeRole);
                    barView.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
        private bool TryPasscode(string passcode, string dataName)
        {
            return (passcode == dataName);
        }
        private bool TryUserName(string username, string dataName)
        {
            return (username == dataName);
        } 

    }
}
