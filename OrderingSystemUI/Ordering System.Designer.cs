﻿
namespace OrderingSystemUI
{
    partial class OrderingSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlTableView = new System.Windows.Forms.Panel();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.pnlTakeOrder = new System.Windows.Forms.Panel();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnMains = new System.Windows.Forms.Button();
            this.btnStarters = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnReserveTable = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.listViewMenuItems = new System.Windows.Forms.ListView();
            this.ItemID = new System.Windows.Forms.ColumnHeader();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.listViewOrderItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttCash = new System.Windows.Forms.Button();
            this.buttDebit = new System.Windows.Forms.Button();
            this.buttCredit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDisplayItems = new System.Windows.Forms.ListView();
            this.ItemsName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.ItemsPrice = new System.Windows.Forms.ColumnHeader();
            this.Vat = new System.Windows.Forms.ColumnHeader();
            this.TotalWithVAT = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.pnlTableView.SuspendLayout();
            this.pnlTakeOrder.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.barViewToolStripMenuItem,
            this.kitchenViewToolStripMenuItem,
            this.tableViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1142, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // barViewToolStripMenuItem
            // 
            this.barViewToolStripMenuItem.Name = "barViewToolStripMenuItem";
            this.barViewToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.barViewToolStripMenuItem.Text = "Bar view";
            this.barViewToolStripMenuItem.Click += new System.EventHandler(this.barViewToolStripMenuItem_Click);
            // 
            // kitchenViewToolStripMenuItem
            // 
            this.kitchenViewToolStripMenuItem.Name = "kitchenViewToolStripMenuItem";
            this.kitchenViewToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.kitchenViewToolStripMenuItem.Text = "Kitchen view";
            this.kitchenViewToolStripMenuItem.Click += new System.EventHandler(this.kitchenViewToolStripMenuItem_Click);
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.tableViewToolStripMenuItem.Text = "Table view";
            this.tableViewToolStripMenuItem.Click += new System.EventHandler(this.tableViewToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Location = new System.Drawing.Point(18, 45);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1109, 685);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlTableView
            // 
            this.pnlTableView.Controls.Add(this.btnTable1);
            this.pnlTableView.Location = new System.Drawing.Point(18, 45);
            this.pnlTableView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTableView.Name = "pnlTableView";
            this.pnlTableView.Size = new System.Drawing.Size(1109, 685);
            this.pnlTableView.TabIndex = 2;
            // 
            // btnTable1
            // 
            this.btnTable1.Location = new System.Drawing.Point(38, 35);
            this.btnTable1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(108, 106);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = true;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // pnlTakeOrder
            // 
            this.pnlTakeOrder.Controls.Add(this.btnDesserts);
            this.pnlTakeOrder.Controls.Add(this.btnMains);
            this.pnlTakeOrder.Controls.Add(this.btnStarters);
            this.pnlTakeOrder.Controls.Add(this.btnPayment);
            this.pnlTakeOrder.Controls.Add(this.btnDrinks);
            this.pnlTakeOrder.Controls.Add(this.btnReserveTable);
            this.pnlTakeOrder.Controls.Add(this.btnMinus);
            this.pnlTakeOrder.Controls.Add(this.btnAdd);
            this.pnlTakeOrder.Controls.Add(this.lblMenu);
            this.pnlTakeOrder.Controls.Add(this.lblOrderNumber);
            this.pnlTakeOrder.Controls.Add(this.listViewMenuItems);
            this.pnlTakeOrder.Controls.Add(this.btnCancel);
            this.pnlTakeOrder.Controls.Add(this.btnTake);
            this.pnlTakeOrder.Controls.Add(this.listViewOrderItems);
            this.pnlTakeOrder.Controls.Add(this.lblTableNumber);
            this.pnlTakeOrder.Location = new System.Drawing.Point(19, 45);
            this.pnlTakeOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTakeOrder.Name = "pnlTakeOrder";
            this.pnlTakeOrder.Size = new System.Drawing.Size(1109, 685);
            this.pnlTakeOrder.TabIndex = 3;
            // 
            // btnDesserts
            // 
            this.btnDesserts.BackColor = System.Drawing.Color.Teal;
            this.btnDesserts.Enabled = false;
            this.btnDesserts.Location = new System.Drawing.Point(912, 155);
            this.btnDesserts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(96, 55);
            this.btnDesserts.TabIndex = 30;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = false;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click);
            // 
            // btnMains
            // 
            this.btnMains.BackColor = System.Drawing.Color.Teal;
            this.btnMains.Enabled = false;
            this.btnMains.Location = new System.Drawing.Point(799, 155);
            this.btnMains.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMains.Name = "btnMains";
            this.btnMains.Size = new System.Drawing.Size(96, 55);
            this.btnMains.TabIndex = 29;
            this.btnMains.Text = "Mains";
            this.btnMains.UseVisualStyleBackColor = false;
            this.btnMains.Click += new System.EventHandler(this.btnMains_Click);
            // 
            // btnStarters
            // 
            this.btnStarters.BackColor = System.Drawing.Color.Teal;
            this.btnStarters.Enabled = false;
            this.btnStarters.Location = new System.Drawing.Point(682, 155);
            this.btnStarters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStarters.Name = "btnStarters";
            this.btnStarters.Size = new System.Drawing.Size(96, 55);
            this.btnStarters.TabIndex = 28;
            this.btnStarters.Text = "Starters";
            this.btnStarters.UseVisualStyleBackColor = false;
            this.btnStarters.Click += new System.EventHandler(this.btnStarters_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Teal;
            this.btnPayment.Enabled = false;
            this.btnPayment.Location = new System.Drawing.Point(569, 545);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(199, 55);
            this.btnPayment.TabIndex = 27;
            this.btnPayment.Text = "Pay";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.Teal;
            this.btnDrinks.Enabled = false;
            this.btnDrinks.Location = new System.Drawing.Point(569, 154);
            this.btnDrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(96, 55);
            this.btnDrinks.TabIndex = 26;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnReserveTable
            // 
            this.btnReserveTable.BackColor = System.Drawing.Color.Teal;
            this.btnReserveTable.Location = new System.Drawing.Point(335, 545);
            this.btnReserveTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReserveTable.Name = "btnReserveTable";
            this.btnReserveTable.Size = new System.Drawing.Size(199, 55);
            this.btnReserveTable.TabIndex = 24;
            this.btnReserveTable.Text = "Reserve Table";
            this.btnReserveTable.UseVisualStyleBackColor = false;
            this.btnReserveTable.Click += new System.EventHandler(this.btnReserveTable_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(503, 155);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.btnMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMinus.Size = new System.Drawing.Size(31, 36);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "- ";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(977, 219);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(31, 36);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+ ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(569, 116);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(57, 25);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "Menu";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(94, 116);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(156, 25);
            this.lblOrderNumber.TabIndex = 11;
            this.lblOrderNumber.Text = "Order No. 001347";
            // 
            // listViewMenuItems
            // 
            this.listViewMenuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemID,
            this.ItemName});
            this.listViewMenuItems.FullRowSelect = true;
            this.listViewMenuItems.HideSelection = false;
            this.listViewMenuItems.Location = new System.Drawing.Point(569, 219);
            this.listViewMenuItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewMenuItems.Name = "listViewMenuItems";
            this.listViewMenuItems.Size = new System.Drawing.Size(439, 298);
            this.listViewMenuItems.TabIndex = 9;
            this.listViewMenuItems.UseCompatibleStateImageBehavior = false;
            this.listViewMenuItems.View = System.Windows.Forms.View.Details;
            // 
            // ItemID
            // 
            this.ItemID.Text = "Item ID";
            this.ItemID.Width = 100;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 100;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(809, 545);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(199, 55);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel order";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTake.Enabled = false;
            this.btnTake.Location = new System.Drawing.Point(94, 545);
            this.btnTake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(199, 55);
            this.btnTake.TabIndex = 7;
            this.btnTake.Text = "Take order";
            this.btnTake.UseVisualStyleBackColor = false;
            // 
            // listViewOrderItems
            // 
            this.listViewOrderItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewOrderItems.HideSelection = false;
            this.listViewOrderItems.Location = new System.Drawing.Point(95, 154);
            this.listViewOrderItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewOrderItems.Name = "listViewOrderItems";
            this.listViewOrderItems.Size = new System.Drawing.Size(439, 363);
            this.listViewOrderItems.TabIndex = 6;
            this.listViewOrderItems.UseCompatibleStateImageBehavior = false;
            this.listViewOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 100;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(95, 86);
            this.lblTableNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(73, 25);
            this.lblTableNumber.TabIndex = 10;
            this.lblTableNumber.Text = "Table#1";
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.label6);
            this.pnlPayment.Controls.Add(this.buttCash);
            this.pnlPayment.Controls.Add(this.buttDebit);
            this.pnlPayment.Controls.Add(this.buttCredit);
            this.pnlPayment.Controls.Add(this.textBox1);
            this.pnlPayment.Controls.Add(this.label5);
            this.pnlPayment.Controls.Add(this.label4);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Controls.Add(this.button3);
            this.pnlPayment.Controls.Add(this.button4);
            this.pnlPayment.Controls.Add(this.label1);
            this.pnlPayment.Controls.Add(this.label2);
            this.pnlPayment.Controls.Add(this.listViewDisplayItems);
            this.pnlPayment.Location = new System.Drawing.Point(15, 45);
            this.pnlPayment.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(1109, 681);
            this.pnlPayment.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(768, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Select Payment Type:";
            // 
            // buttCash
            // 
            this.buttCash.BackColor = System.Drawing.Color.Teal;
            this.buttCash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttCash.ForeColor = System.Drawing.Color.White;
            this.buttCash.Location = new System.Drawing.Point(959, 238);
            this.buttCash.Margin = new System.Windows.Forms.Padding(4);
            this.buttCash.Name = "buttCash";
            this.buttCash.Size = new System.Drawing.Size(118, 36);
            this.buttCash.TabIndex = 26;
            this.buttCash.Text = "CASH";
            this.buttCash.UseVisualStyleBackColor = false;
            // 
            // buttDebit
            // 
            this.buttDebit.BackColor = System.Drawing.Color.Teal;
            this.buttDebit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttDebit.ForeColor = System.Drawing.Color.White;
            this.buttDebit.Location = new System.Drawing.Point(814, 238);
            this.buttDebit.Margin = new System.Windows.Forms.Padding(4);
            this.buttDebit.Name = "buttDebit";
            this.buttDebit.Size = new System.Drawing.Size(118, 36);
            this.buttDebit.TabIndex = 25;
            this.buttDebit.Text = "DEBIT";
            this.buttDebit.UseVisualStyleBackColor = false;
            // 
            // buttCredit
            // 
            this.buttCredit.BackColor = System.Drawing.Color.Teal;
            this.buttCredit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttCredit.ForeColor = System.Drawing.Color.White;
            this.buttCredit.Location = new System.Drawing.Point(676, 238);
            this.buttCredit.Margin = new System.Windows.Forms.Padding(4);
            this.buttCredit.Name = "buttCredit";
            this.buttCredit.Size = new System.Drawing.Size(118, 36);
            this.buttCredit.TabIndex = 24;
            this.buttCredit.Text = "CREDIT";
            this.buttCredit.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(901, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 31);
            this.textBox1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(768, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "ADD TIP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "TIP: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(332, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total with TIP:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(4, 134);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(31, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "- ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(652, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(31, 36);
            this.button4.TabIndex = 19;
            this.button4.Text = "+ ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Order No. 001347";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Table#1";
            // 
            // listViewDisplayItems
            // 
            this.listViewDisplayItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemsName,
            this.Quantity,
            this.ItemsPrice,
            this.Vat,
            this.TotalWithVAT});
            this.listViewDisplayItems.HideSelection = false;
            this.listViewDisplayItems.Location = new System.Drawing.Point(40, 98);
            this.listViewDisplayItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewDisplayItems.Name = "listViewDisplayItems";
            this.listViewDisplayItems.Size = new System.Drawing.Size(602, 363);
            this.listViewDisplayItems.TabIndex = 7;
            this.listViewDisplayItems.UseCompatibleStateImageBehavior = false;
            this.listViewDisplayItems.View = System.Windows.Forms.View.Details;
            // 
            // ItemsName
            // 
            this.ItemsName.Text = "ItemsName";
            this.ItemsName.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 80;
            // 
            // ItemsPrice
            // 
            this.ItemsPrice.Text = "Unit Price";
            this.ItemsPrice.Width = 80;
            // 
            // Vat
            // 
            this.Vat.Text = "VAT";
            this.Vat.Width = 80;
            // 
            // TotalWithVAT
            // 
            this.TotalWithVAT.Text = "Total With VAT";
            this.TotalWithVAT.Width = 150;
            // 
            // OrderingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 750);
            this.Controls.Add(this.pnlTakeOrder);
            this.Controls.Add(this.pnlTableView);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlPayment);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderingSystem";
            this.Text = "Ordering System";
            this.Load += new System.EventHandler(this.OrderingSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTableView.ResumeLayout(false);
            this.pnlTakeOrder.ResumeLayout(false);
            this.pnlTakeOrder.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlTableView;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Panel pnlTakeOrder;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.ListView listViewMenuItems;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.ListView listViewOrderItems;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnReserveTable;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.ListView listViewDisplayItems;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader ItemsPrice;
        private System.Windows.Forms.ColumnHeader ItemsName;
        private System.Windows.Forms.ColumnHeader Vat;
        private System.Windows.Forms.ColumnHeader TotalWithVAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttCash;
        private System.Windows.Forms.Button buttDebit;
        private System.Windows.Forms.Button buttCredit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnMains;
        private System.Windows.Forms.Button btnStarters;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

