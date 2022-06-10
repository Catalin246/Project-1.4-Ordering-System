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
        private string Username;
        private string Passcode;
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
                Username = txtBoxUsername.Text;
                Passcode = txtBoxPasscode.Text;
                List<Employee> list = new List<Employee>();
                EmployeeService accountService = new EmployeeService();
                list = accountService.GetAllEmployee();
                foreach (Employee item in list)
                {
                    //if(item.EmployeePassword == TryPasscode(Passcode, item.salt).Digest && TryUserName(Username, list))
                    //{
                    //    EmployeeRole(item.EmployeeRole, item.EmployeeName);
                    //}
                    if (TryPasscode(txtBoxPasscode.Text) && TryUserName(txtBoxUsername.Text))
                    {
                        EmployeeRole(item.EmployeeRole, item.EmployeeName);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public void EmployeeRole(string employeeRole, string employeeName)
        {
            switch (employeeRole)
            {
                case "Cook":
                    KitchenView kitchenView = new KitchenView(employeeName);
                    kitchenView.Show();
                    this.Hide();
                    break;
                case "Waiter":
                    TableView tableView = new TableView(employeeName,employeeRole);
                    tableView.Show();
                    this.Hide();
                    break;
                case "Bartender":
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
        private bool TryPasscode(string passcode)
        {
            if (this.Passcode == passcode)
                return true;

            return false;
        }
        private bool TryUserName(string username)
        {
            if(this.Username == username)
                    return true;
            
            return false;
        }
        //private HashWithSaltResult TryPasscode(string passcode, string salt)
        //{
        //    PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
        //    HashWithSaltResult hashResultSha256 = pwHasher.Hash(passcode, SHA256.Create(), salt);
        //    return hashResultSha256;
        //}

    }
}
