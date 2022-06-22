
namespace OrderingSystemUI
{
    partial class Feedback
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFeedBack = new System.Windows.Forms.RichTextBox();
            this.btnFeedbackDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrderingSystemUI.Properties.Resources.chapeauLog;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(97, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "YOUR OPNION MATTER!";
            // 
            // txtBoxFeedBack
            // 
            this.txtBoxFeedBack.Location = new System.Drawing.Point(27, 105);
            this.txtBoxFeedBack.Name = "txtBoxFeedBack";
            this.txtBoxFeedBack.Size = new System.Drawing.Size(373, 137);
            this.txtBoxFeedBack.TabIndex = 2;
            this.txtBoxFeedBack.Text = "";
            // 
            // btnFeedbackDone
            // 
            this.btnFeedbackDone.BackColor = System.Drawing.Color.Teal;
            this.btnFeedbackDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFeedbackDone.ForeColor = System.Drawing.Color.White;
            this.btnFeedbackDone.Location = new System.Drawing.Point(108, 258);
            this.btnFeedbackDone.Name = "btnFeedbackDone";
            this.btnFeedbackDone.Size = new System.Drawing.Size(220, 44);
            this.btnFeedbackDone.TabIndex = 3;
            this.btnFeedbackDone.Text = "DONE";
            this.btnFeedbackDone.UseVisualStyleBackColor = false;
            this.btnFeedbackDone.Click += new System.EventHandler(this.btnFeedbackDone_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 324);
            this.Controls.Add(this.btnFeedbackDone);
            this.Controls.Add(this.txtBoxFeedBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Feedback";
            this.Text = "Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtBoxFeedBack;
        private System.Windows.Forms.Button btnFeedbackDone;
    }
}