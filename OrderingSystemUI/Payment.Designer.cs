
namespace OrderingSystemUI
{
    partial class Payment
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
            this.billViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.lblTotalWithVatValue = new System.Windows.Forms.Label();
            this.lblTotalWithVat = new System.Windows.Forms.Label();
            this.checkBoxSplitBill = new System.Windows.Forms.CheckBox();
            this.comboBoxSplitBill = new System.Windows.Forms.ComboBox();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.txtBoxFeedBack = new System.Windows.Forms.RichTextBox();
            this.btnSearchTable = new System.Windows.Forms.Button();
            this.bttAddFeedBack = new System.Windows.Forms.Button();
            this.txtBoxTableNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDisplayTip = new System.Windows.Forms.Label();
            this.labelDisplayTotalWithTip = new System.Windows.Forms.Label();
            this.btnSaveTotal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttFinalizePayment = new System.Windows.Forms.Button();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewDisplaybillItems = new System.Windows.Forms.ListView();
            this.ItemsName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.ItemsPrice = new System.Windows.Forms.ColumnHeader();
            this.Vat = new System.Windows.Forms.ColumnHeader();
            this.TotalWithVAT = new System.Windows.Forms.ColumnHeader();
            this.pnlTakeOrder = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.pnlTakeOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.barViewToolStripMenuItem,
            this.kitchenViewToolStripMenuItem,
            this.tableViewToolStripMenuItem,
            this.billViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // barViewToolStripMenuItem
            // 
            this.barViewToolStripMenuItem.Name = "barViewToolStripMenuItem";
            this.barViewToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.barViewToolStripMenuItem.Text = "Bar view";
            this.barViewToolStripMenuItem.Click += new System.EventHandler(this.barViewToolStripMenuItem_Click);
            // 
            // kitchenViewToolStripMenuItem
            // 
            this.kitchenViewToolStripMenuItem.Name = "kitchenViewToolStripMenuItem";
            this.kitchenViewToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.kitchenViewToolStripMenuItem.Text = "Kitchen view";
            this.kitchenViewToolStripMenuItem.Click += new System.EventHandler(this.kitchenViewToolStripMenuItem_Click);
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.tableViewToolStripMenuItem.Text = "Table view";
            this.tableViewToolStripMenuItem.Click += new System.EventHandler(this.tableViewToolStripMenuItem_Click);
            // 
            // billViewToolStripMenuItem
            // 
            this.billViewToolStripMenuItem.Name = "billViewToolStripMenuItem";
            this.billViewToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.billViewToolStripMenuItem.Text = "Bill view";
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.lblTotalWithVatValue);
            this.pnlPayment.Controls.Add(this.lblTotalWithVat);
            this.pnlPayment.Controls.Add(this.checkBoxSplitBill);
            this.pnlPayment.Controls.Add(this.comboBoxSplitBill);
            this.pnlPayment.Controls.Add(this.comboBoxPaymentType);
            this.pnlPayment.Controls.Add(this.txtBoxFeedBack);
            this.pnlPayment.Controls.Add(this.btnSearchTable);
            this.pnlPayment.Controls.Add(this.bttAddFeedBack);
            this.pnlPayment.Controls.Add(this.txtBoxTableNumber);
            this.pnlPayment.Controls.Add(this.label7);
            this.pnlPayment.Controls.Add(this.labelDisplayTip);
            this.pnlPayment.Controls.Add(this.labelDisplayTotalWithTip);
            this.pnlPayment.Controls.Add(this.btnSaveTotal);
            this.pnlPayment.Controls.Add(this.label6);
            this.pnlPayment.Controls.Add(this.buttFinalizePayment);
            this.pnlPayment.Controls.Add(this.txtBoxTotal);
            this.pnlPayment.Controls.Add(this.label5);
            this.pnlPayment.Controls.Add(this.label4);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Controls.Add(this.listViewDisplaybillItems);
            this.pnlPayment.Location = new System.Drawing.Point(6, 2);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(884, 545);
            this.pnlPayment.TabIndex = 29;
            // 
            // lblTotalWithVatValue
            // 
            this.lblTotalWithVatValue.AutoSize = true;
            this.lblTotalWithVatValue.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalWithVatValue.Location = new System.Drawing.Point(735, 15);
            this.lblTotalWithVatValue.Name = "lblTotalWithVatValue";
            this.lblTotalWithVatValue.Size = new System.Drawing.Size(0, 31);
            this.lblTotalWithVatValue.TabIndex = 39;
            // 
            // lblTotalWithVat
            // 
            this.lblTotalWithVat.AutoSize = true;
            this.lblTotalWithVat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalWithVat.Location = new System.Drawing.Point(541, 15);
            this.lblTotalWithVat.Name = "lblTotalWithVat";
            this.lblTotalWithVat.Size = new System.Drawing.Size(140, 28);
            this.lblTotalWithVat.TabIndex = 38;
            this.lblTotalWithVat.Text = "Total with Vat:";
            // 
            // checkBoxSplitBill
            // 
            this.checkBoxSplitBill.AutoSize = true;
            this.checkBoxSplitBill.Enabled = false;
            this.checkBoxSplitBill.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSplitBill.Location = new System.Drawing.Point(541, 288);
            this.checkBoxSplitBill.Name = "checkBoxSplitBill";
            this.checkBoxSplitBill.Size = new System.Drawing.Size(103, 29);
            this.checkBoxSplitBill.TabIndex = 37;
            this.checkBoxSplitBill.Text = "Split bill";
            this.checkBoxSplitBill.UseVisualStyleBackColor = true;
            this.checkBoxSplitBill.CheckedChanged += new System.EventHandler(this.checkBoxSplitBill_CheckedChanged);
            // 
            // comboBoxSplitBill
            // 
            this.comboBoxSplitBill.Enabled = false;
            this.comboBoxSplitBill.FormattingEnabled = true;
            this.comboBoxSplitBill.Items.AddRange(new object[] {
            "Number of people",
            "2",
            "3",
            "4"});
            this.comboBoxSplitBill.Location = new System.Drawing.Point(716, 290);
            this.comboBoxSplitBill.Name = "comboBoxSplitBill";
            this.comboBoxSplitBill.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSplitBill.TabIndex = 36;
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.Enabled = false;
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card",
            "Cash",
            "Mixed Payment"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(716, 237);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPaymentType.TabIndex = 4;
            // 
            // txtBoxFeedBack
            // 
            this.txtBoxFeedBack.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxFeedBack.Location = new System.Drawing.Point(14, 409);
            this.txtBoxFeedBack.Name = "txtBoxFeedBack";
            this.txtBoxFeedBack.Size = new System.Drawing.Size(273, 74);
            this.txtBoxFeedBack.TabIndex = 34;
            this.txtBoxFeedBack.Text = "";
            this.txtBoxFeedBack.TextChanged += new System.EventHandler(this.txtBoxFeedBack_TextChanged);
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.Location = new System.Drawing.Point(389, 14);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(127, 29);
            this.btnSearchTable.TabIndex = 32;
            this.btnSearchTable.Text = "search";
            this.btnSearchTable.UseVisualStyleBackColor = true;
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // bttAddFeedBack
            // 
            this.bttAddFeedBack.BackColor = System.Drawing.Color.Teal;
            this.bttAddFeedBack.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bttAddFeedBack.Enabled = false;
            this.bttAddFeedBack.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttAddFeedBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttAddFeedBack.Location = new System.Drawing.Point(310, 428);
            this.bttAddFeedBack.Name = "bttAddFeedBack";
            this.bttAddFeedBack.Size = new System.Drawing.Size(191, 55);
            this.bttAddFeedBack.TabIndex = 31;
            this.bttAddFeedBack.Text = "Add FeedBack";
            this.bttAddFeedBack.UseVisualStyleBackColor = false;
            this.bttAddFeedBack.Click += new System.EventHandler(this.bttAddFeedBack_Click);
            // 
            // txtBoxTableNumber
            // 
            this.txtBoxTableNumber.Location = new System.Drawing.Point(209, 14);
            this.txtBoxTableNumber.Name = "txtBoxTableNumber";
            this.txtBoxTableNumber.Size = new System.Drawing.Size(145, 27);
            this.txtBoxTableNumber.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "Search Bill by table";
            // 
            // labelDisplayTip
            // 
            this.labelDisplayTip.AutoSize = true;
            this.labelDisplayTip.Location = new System.Drawing.Point(730, 138);
            this.labelDisplayTip.Name = "labelDisplayTip";
            this.labelDisplayTip.Size = new System.Drawing.Size(36, 20);
            this.labelDisplayTip.TabIndex = 28;
            this.labelDisplayTip.Text = "0,00";
            // 
            // labelDisplayTotalWithTip
            // 
            this.labelDisplayTotalWithTip.AutoSize = true;
            this.labelDisplayTotalWithTip.Location = new System.Drawing.Point(730, 181);
            this.labelDisplayTotalWithTip.Name = "labelDisplayTotalWithTip";
            this.labelDisplayTotalWithTip.Size = new System.Drawing.Size(36, 20);
            this.labelDisplayTotalWithTip.TabIndex = 28;
            this.labelDisplayTotalWithTip.Text = "0,00";
            // 
            // btnSaveTotal
            // 
            this.btnSaveTotal.Enabled = false;
            this.btnSaveTotal.Location = new System.Drawing.Point(778, 79);
            this.btnSaveTotal.Name = "btnSaveTotal";
            this.btnSaveTotal.Size = new System.Drawing.Size(94, 29);
            this.btnSaveTotal.TabIndex = 4;
            this.btnSaveTotal.Text = "Update";
            this.btnSaveTotal.UseVisualStyleBackColor = true;
            this.btnSaveTotal.Click += new System.EventHandler(this.btnSaveTotal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(537, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Select Payment Type:";
            // 
            // buttFinalizePayment
            // 
            this.buttFinalizePayment.BackColor = System.Drawing.Color.Teal;
            this.buttFinalizePayment.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttFinalizePayment.Enabled = false;
            this.buttFinalizePayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttFinalizePayment.ForeColor = System.Drawing.Color.White;
            this.buttFinalizePayment.Location = new System.Drawing.Point(537, 339);
            this.buttFinalizePayment.Name = "buttFinalizePayment";
            this.buttFinalizePayment.Size = new System.Drawing.Size(330, 44);
            this.buttFinalizePayment.TabIndex = 26;
            this.buttFinalizePayment.Text = "Finalize Payment";
            this.buttFinalizePayment.UseVisualStyleBackColor = false;
            this.buttFinalizePayment.Click += new System.EventHandler(this.buttFinalizePayment_Click);
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBoxTotal.Location = new System.Drawing.Point(673, 79);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(93, 27);
            this.txtBoxTotal.TabIndex = 23;
            this.txtBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(537, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "SET TOTAL TO: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(541, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "TIP: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(537, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total with TIP:";
            // 
            // listViewDisplaybillItems
            // 
            this.listViewDisplaybillItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemsName,
            this.Quantity,
            this.ItemsPrice,
            this.Vat,
            this.TotalWithVAT});
            this.listViewDisplaybillItems.HideSelection = false;
            this.listViewDisplaybillItems.Location = new System.Drawing.Point(14, 79);
            this.listViewDisplaybillItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewDisplaybillItems.Name = "listViewDisplaybillItems";
            this.listViewDisplaybillItems.Size = new System.Drawing.Size(502, 304);
            this.listViewDisplaybillItems.TabIndex = 7;
            this.listViewDisplaybillItems.UseCompatibleStateImageBehavior = false;
            this.listViewDisplaybillItems.View = System.Windows.Forms.View.Details;
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
            // pnlTakeOrder
            // 
            this.pnlTakeOrder.Controls.Add(this.pnlPayment);
            this.pnlTakeOrder.Location = new System.Drawing.Point(12, 34);
            this.pnlTakeOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTakeOrder.Name = "pnlTakeOrder";
            this.pnlTakeOrder.Size = new System.Drawing.Size(890, 550);
            this.pnlTakeOrder.TabIndex = 3;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pnlTakeOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Payment";
            this.Text = "Bill ";
            this.Load += new System.EventHandler(this.OrderingSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.pnlTakeOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billViewToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Button btnSearchTable;
        private System.Windows.Forms.Button bttAddFeedBack;
        private System.Windows.Forms.TextBox txtBoxTableNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDisplayTip;
        private System.Windows.Forms.Label labelDisplayTotalWithTip;
        private System.Windows.Forms.Button btnSaveTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttFinalizePayment;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewDisplaybillItems;
        private System.Windows.Forms.ColumnHeader ItemsName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader ItemsPrice;
        private System.Windows.Forms.ColumnHeader Vat;
        private System.Windows.Forms.ColumnHeader TotalWithVAT;
        private System.Windows.Forms.Panel pnlTakeOrder;
        private System.Windows.Forms.RichTextBox txtBoxFeedBacka;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.CheckBox checkBoxSplitBill;
        private System.Windows.Forms.ComboBox comboBoxSplitBill;
        private System.Windows.Forms.RichTextBox txtBoxFeedBack;
        private System.Windows.Forms.Label lblTotalWithVat;
        private System.Windows.Forms.Label lblTotalWithVatValue;
    }
}




