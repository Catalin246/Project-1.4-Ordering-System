﻿namespace OrderingSystemUI
{
    partial class TakeOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTakeOrder = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnMains = new System.Windows.Forms.Button();
            this.btnStarters = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.listViewMenuItems = new System.Windows.Forms.ListView();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.ItemPrice = new System.Windows.Forms.ColumnHeader();
            this.Category = new System.Windows.Forms.ColumnHeader();
            this.ItemAmount = new System.Windows.Forms.ColumnHeader();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.listViewOrderItems = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTakeOrder.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTakeOrder
            // 
            this.pnlTakeOrder.Controls.Add(this.lblEmployeeName);
            this.pnlTakeOrder.Controls.Add(this.btnDesserts);
            this.pnlTakeOrder.Controls.Add(this.btnMains);
            this.pnlTakeOrder.Controls.Add(this.btnStarters);
            this.pnlTakeOrder.Controls.Add(this.btnPayment);
            this.pnlTakeOrder.Controls.Add(this.btnDrinks);
            this.pnlTakeOrder.Controls.Add(this.btnMinus);
            this.pnlTakeOrder.Controls.Add(this.btnAdd);
            this.pnlTakeOrder.Controls.Add(this.lblMenu);
            this.pnlTakeOrder.Controls.Add(this.lblOrderNumber);
            this.pnlTakeOrder.Controls.Add(this.listViewMenuItems);
            this.pnlTakeOrder.Controls.Add(this.btnCancel);
            this.pnlTakeOrder.Controls.Add(this.btnTake);
            this.pnlTakeOrder.Controls.Add(this.listViewOrderItems);
            this.pnlTakeOrder.Controls.Add(this.lblTableNumber);
            this.pnlTakeOrder.Location = new System.Drawing.Point(11, 30);
            this.pnlTakeOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTakeOrder.Name = "pnlTakeOrder";
            this.pnlTakeOrder.Size = new System.Drawing.Size(776, 409);
            this.pnlTakeOrder.TabIndex = 4;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(550, 10);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(194, 15);
            this.lblEmployeeName.TabIndex = 31;
            this.lblEmployeeName.Text = "Emplyee Name: Avornicesei Catalin";
            // 
            // btnDesserts
            // 
            this.btnDesserts.BackColor = System.Drawing.Color.Teal;
            this.btnDesserts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesserts.Location = new System.Drawing.Point(598, 40);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(154, 33);
            this.btnDesserts.TabIndex = 30;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = false;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click_1);
            // 
            // btnMains
            // 
            this.btnMains.BackColor = System.Drawing.Color.Teal;
            this.btnMains.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMains.Location = new System.Drawing.Point(405, 40);
            this.btnMains.Name = "btnMains";
            this.btnMains.Size = new System.Drawing.Size(154, 33);
            this.btnMains.TabIndex = 29;
            this.btnMains.Text = "Mains";
            this.btnMains.UseVisualStyleBackColor = false;
            this.btnMains.Click += new System.EventHandler(this.btnMains_Click_1);
            // 
            // btnStarters
            // 
            this.btnStarters.BackColor = System.Drawing.Color.Teal;
            this.btnStarters.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStarters.Location = new System.Drawing.Point(211, 40);
            this.btnStarters.Name = "btnStarters";
            this.btnStarters.Size = new System.Drawing.Size(154, 33);
            this.btnStarters.TabIndex = 28;
            this.btnStarters.Text = "Starters";
            this.btnStarters.UseVisualStyleBackColor = false;
            this.btnStarters.Click += new System.EventHandler(this.btnStarters_Click_1);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Teal;
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayment.Location = new System.Drawing.Point(405, 315);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(154, 33);
            this.btnPayment.TabIndex = 27;
            this.btnPayment.Text = "Pay";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.Teal;
            this.btnDrinks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDrinks.Location = new System.Drawing.Point(18, 40);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(154, 33);
            this.btnDrinks.TabIndex = 26;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click_1);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(334, 127);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.btnMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMinus.Size = new System.Drawing.Size(31, 26);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "- ";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(722, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(31, 26);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+ ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(405, 83);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(38, 15);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "Menu";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(18, 101);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(98, 15);
            this.lblOrderNumber.TabIndex = 11;
            this.lblOrderNumber.Text = "Order No. 001347";
            // 
            // listViewMenuItems
            // 
            this.listViewMenuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemPrice,
            this.Category,
            this.ItemAmount});
            this.listViewMenuItems.FullRowSelect = true;
            this.listViewMenuItems.HideSelection = false;
            this.listViewMenuItems.Location = new System.Drawing.Point(405, 127);
            this.listViewMenuItems.Name = "listViewMenuItems";
            this.listViewMenuItems.Size = new System.Drawing.Size(348, 179);
            this.listViewMenuItems.TabIndex = 9;
            this.listViewMenuItems.UseCompatibleStateImageBehavior = false;
            this.listViewMenuItems.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 120;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DisplayIndex = 2;
            this.ItemPrice.Text = "Price";
            // 
            // Category
            // 
            this.Category.DisplayIndex = 3;
            this.Category.Text = "Category";
            this.Category.Width = 100;
            // 
            // ItemAmount
            // 
            this.ItemAmount.DisplayIndex = 1;
            this.ItemAmount.Text = "Amount";
            this.ItemAmount.Width = 100;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(597, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTake.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTake.Location = new System.Drawing.Point(18, 315);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(154, 33);
            this.btnTake.TabIndex = 7;
            this.btnTake.Text = "Take order";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // listViewOrderItems
            // 
            this.listViewOrderItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Price,
            this.Amount});
            this.listViewOrderItems.FullRowSelect = true;
            this.listViewOrderItems.HideSelection = false;
            this.listViewOrderItems.Location = new System.Drawing.Point(18, 127);
            this.listViewOrderItems.Name = "listViewOrderItems";
            this.listViewOrderItems.Size = new System.Drawing.Size(348, 179);
            this.listViewOrderItems.TabIndex = 6;
            this.listViewOrderItems.UseCompatibleStateImageBehavior = false;
            this.listViewOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Item Name";
            this.Name.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 100;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(18, 83);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(47, 15);
            this.lblTableNumber.TabIndex = 10;
            this.lblTableNumber.Text = "Table#1";
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
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // barViewToolStripMenuItem
            // 
            this.barViewToolStripMenuItem.Name = "barViewToolStripMenuItem";
            this.barViewToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.barViewToolStripMenuItem.Text = "Bar view";
            // 
            // kitchenViewToolStripMenuItem
            // 
            this.kitchenViewToolStripMenuItem.Name = "kitchenViewToolStripMenuItem";
            this.kitchenViewToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.kitchenViewToolStripMenuItem.Text = "Kitchen view";
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.tableViewToolStripMenuItem.Text = "Table view";
            this.tableViewToolStripMenuItem.Click += new System.EventHandler(this.tableViewToolStripMenuItem_Click);
            // 
            // TakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlTakeOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.Name = "TakeOrder";
            this.Text = "TakeOrder";
            this.Load += new System.EventHandler(this.TakeOrder_Load);
            this.pnlTakeOrder.ResumeLayout(false);
            this.pnlTakeOrder.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTakeOrder;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnMains;
        private System.Windows.Forms.Button btnStarters;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.ListView listViewMenuItems;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemPrice;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader ItemAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.ListView listViewOrderItems;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}