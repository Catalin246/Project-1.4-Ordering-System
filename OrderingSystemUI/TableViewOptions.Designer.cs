namespace OrderingSystemUI
{
    partial class TableViewOptions
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
            this.btnCanselSeating = new System.Windows.Forms.Button();
            this.btnSeatingACustomer = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCanselSeating
            // 
            this.btnCanselSeating.Location = new System.Drawing.Point(88, 99);
            this.btnCanselSeating.Name = "btnCanselSeating";
            this.btnCanselSeating.Size = new System.Drawing.Size(135, 35);
            this.btnCanselSeating.TabIndex = 10;
            this.btnCanselSeating.Text = "cancel sit";
            this.btnCanselSeating.UseVisualStyleBackColor = true;
            this.btnCanselSeating.Click += new System.EventHandler(this.btnCanselSeating_Click);
            // 
            // btnSeatingACustomer
            // 
            this.btnSeatingACustomer.Location = new System.Drawing.Point(88, 58);
            this.btnSeatingACustomer.Name = "btnSeatingACustomer";
            this.btnSeatingACustomer.Size = new System.Drawing.Size(135, 35);
            this.btnSeatingACustomer.TabIndex = 11;
            this.btnSeatingACustomer.Text = "sit";
            this.btnSeatingACustomer.UseVisualStyleBackColor = true;
            this.btnSeatingACustomer.Click += new System.EventHandler(this.btnSeatingACustomer_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(88, 17);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(135, 35);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // TableViewOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 182);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnSeatingACustomer);
            this.Controls.Add(this.btnCanselSeating);
            this.Name = "TableViewOptions";
            this.Text = "TableViewOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCanselSeating;
        private System.Windows.Forms.Button btnSeatingACustomer;
        private System.Windows.Forms.Button btnOrder;
    }
}