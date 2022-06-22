﻿using OrderingSystemLogic;
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
                if (txtBoxUsername.Text == "")
                    lblWrongUserName.Text = "Please enter your username";
                if (txtBoxPasscode.Text == "")
                    lblwrongPasscode.Text = "Please enter your passcode";
                username = txtBoxUsername.Text;
                passcode = txtBoxPasscode.Text;
                List<Employee> list = new List<Employee>();
                EmployeeService accountService = new EmployeeService();
                list = accountService.GetAllEmployee();
                foreach (Employee item in list)
                {
                    if ((passcode == item.EmployeePassword) && (username == item.EmployeeName)) 
                    {
                        EmployeeRole(item.EmployeeRole, item.EmployeeName);
                    }
                    else
                    {
                        if (username != item.EmployeeName)
                        {
                            lblWrongUserName.Text = "Username is wrong please enter the right one";
                        }
                        if (passcode != item.EmployeePassword)
                        {
                            lblwrongPasscode.Text = "Passcode is wrong please enter again";
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong with the login");
            }
        }

        public void EmployeeRole(string employeeRole, string employeeName)
        {
            switch (employeeRole)
            {
                case "Cook":
                    BarKitchenView barView1 = new BarKitchenView(employeeName, employeeRole);
                    barView1.Show();                    
                    this.Hide();
                    break;
                case "Waiter":
                    TableView tableView = new TableView(employeeName,employeeRole);
                    tableView.Show();
                    this.Hide();
                    break;
                case "Bartender":
                    BarKitchenView barView = new BarKitchenView(employeeName,employeeRole);
                    barView.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private HashWithSaltResult TryPasscode(string passcode, string salt)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = pwHasher.Hash(passcode, SHA256.Create(), salt);
            return hashResultSha256;
        }

    }
}
