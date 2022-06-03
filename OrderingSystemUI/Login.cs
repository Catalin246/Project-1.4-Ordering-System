using OrderingSystemLogic;
using OrderingSystemModel;
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
                if ((TryUserName(Username) && (TryPasscode(Passcode))))
                {
                    TableView tableView = new TableView();
                    tableView.Show();
                    this.Hide();
                    //Login login = new Login();
                    //login.Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private bool TryUserName(string username)
        {
            List<Employee> list = new List<Employee>();
            Employee employee = new Employee();
            EmployeeService accountService = new EmployeeService();
            list = accountService.GetEmployee();
            foreach (Employee em in list)
            {
                if(username == em.EmployeeName)
                    return true;
            }
            return false;
        }
        private bool TryPasscode(string passcode)
        {
            List<Employee> list = new List<Employee>();
            Employee employee = new Employee();
            EmployeeService accountService = new EmployeeService();
            list = accountService.GetEmployee();
            foreach (Employee em in list)
            {
                if(passcode == em.EmployeePassword)
                    return true;
            }
            return false;
        }

    }
}
