namespace OrderingSystemUI
{
    partial class KitchenView
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
            this.listViewKitchen = new System.Windows.Forms.ListView();
            this.colTableNo = new System.Windows.Forms.ColumnHeader();
            this.colTime = new System.Windows.Forms.ColumnHeader();
            this.colCategory = new System.Windows.Forms.ColumnHeader();
            this.colAmount = new System.Windows.Forms.ColumnHeader();
            this.colFoodName = new System.Windows.Forms.ColumnHeader();
            this.colOrderNote = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnViewCompletedOrders = new System.Windows.Forms.Button();
            this.btnViewRunningOrders = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReadyToServe = new System.Windows.Forms.Button();
            this.btnViewOrderNote = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewKitchen
            // 
            this.listViewKitchen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTableNo,
            this.colTime,
            this.colCategory,
            this.colAmount,
            this.colFoodName,
            this.colOrderNote,
            this.colStatus});
            this.listViewKitchen.HideSelection = false;
            this.listViewKitchen.Location = new System.Drawing.Point(3, 89);
            this.listViewKitchen.Name = "listViewKitchen";
            this.listViewKitchen.Size = new System.Drawing.Size(842, 346);
            this.listViewKitchen.TabIndex = 12;
            this.listViewKitchen.UseCompatibleStateImageBehavior = false;
            this.listViewKitchen.View = System.Windows.Forms.View.Details;
            // 
            // colTableNo
            // 
            this.colTableNo.Text = "Table No";
            this.colTableNo.Width = 70;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCategory.Width = 90;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Amount";
            this.colAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAmount.Width = 80;
            // 
            // colFoodName
            // 
            this.colFoodName.Text = "Food Name";
            this.colFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFoodName.Width = 330;
            // 
            // colOrderNote
            // 
            this.colOrderNote.Text = "Order Note";
            this.colOrderNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colOrderNote.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatus.Width = 90;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(629, 9);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(130, 15);
            this.lblEmployeeName.TabIndex = 11;
            this.lblEmployeeName.Text = "Employee: Beril Dündar";
            // 
            // btnViewCompletedOrders
            // 
            this.btnViewCompletedOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnViewCompletedOrders.Location = new System.Drawing.Point(244, 52);
            this.btnViewCompletedOrders.Name = "btnViewCompletedOrders";
            this.btnViewCompletedOrders.Size = new System.Drawing.Size(148, 31);
            this.btnViewCompletedOrders.TabIndex = 10;
            this.btnViewCompletedOrders.Text = "View Completed Orders";
            this.btnViewCompletedOrders.UseVisualStyleBackColor = false;
            // 
            // btnViewRunningOrders
            // 
            this.btnViewRunningOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewRunningOrders.Location = new System.Drawing.Point(88, 52);
            this.btnViewRunningOrders.Name = "btnViewRunningOrders";
            this.btnViewRunningOrders.Size = new System.Drawing.Size(150, 31);
            this.btnViewRunningOrders.TabIndex = 9;
            this.btnViewRunningOrders.Text = "View Running Orders";
            this.btnViewRunningOrders.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(398, 1);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 20);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(765, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnReadyToServe
            // 
            this.btnReadyToServe.BackColor = System.Drawing.Color.Lime;
            this.btnReadyToServe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReadyToServe.Location = new System.Drawing.Point(640, 441);
            this.btnReadyToServe.Name = "btnReadyToServe";
            this.btnReadyToServe.Size = new System.Drawing.Size(205, 46);
            this.btnReadyToServe.TabIndex = 15;
            this.btnReadyToServe.Text = "Ready To Serve";
            this.btnReadyToServe.UseVisualStyleBackColor = false;
            this.btnReadyToServe.Click += new System.EventHandler(this.btnReadyToServe_Click);
            // 
            // btnViewOrderNote
            // 
            this.btnViewOrderNote.BackColor = System.Drawing.Color.Teal;
            this.btnViewOrderNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewOrderNote.Location = new System.Drawing.Point(4, 441);
            this.btnViewOrderNote.Name = "btnViewOrderNote";
            this.btnViewOrderNote.Size = new System.Drawing.Size(205, 46);
            this.btnViewOrderNote.TabIndex = 13;
            this.btnViewOrderNote.Text = "View Order Note";
            this.btnViewOrderNote.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(724, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(597, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Select:";
            // 
            // KitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 495);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewKitchen);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.btnViewCompletedOrders);
            this.Controls.Add(this.btnViewRunningOrders);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReadyToServe);
            this.Controls.Add(this.btnViewOrderNote);
            this.Name = "KitchenView";
            this.Text = "KitchenView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewKitchen;
        private System.Windows.Forms.ColumnHeader colTableNo;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colFoodName;
        private System.Windows.Forms.ColumnHeader colOrderNote;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnViewCompletedOrders;
        private System.Windows.Forms.Button btnViewRunningOrders;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReadyToServe;
        private System.Windows.Forms.Button btnViewOrderNote;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}