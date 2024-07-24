namespace MyFinancialApp
{
    partial class AddDebtPage
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
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.txtBxAmount = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlFrequency = new System.Windows.Forms.Panel();
            this.rBtnMonthly = new System.Windows.Forms.RadioButton();
            this.rBtnWeekly = new System.Windows.Forms.RadioButton();
            this.rBtnOneTime = new System.Windows.Forms.RadioButton();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMsgTitle = new System.Windows.Forms.Label();
            this.pnlFrequency.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(34, 36);
            this.txtBxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(155, 20);
            this.txtBxDescription.TabIndex = 0;
            this.txtBxDescription.TextChanged += new System.EventHandler(this.EnableAddButton);
            // 
            // txtBxAmount
            // 
            this.txtBxAmount.Location = new System.Drawing.Point(34, 80);
            this.txtBxAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxAmount.Name = "txtBxAmount";
            this.txtBxAmount.Size = new System.Drawing.Size(155, 20);
            this.txtBxAmount.TabIndex = 1;
            this.txtBxAmount.TextChanged += new System.EventHandler(this.EnableAddButton);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(32, 20);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(32, 65);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // pnlFrequency
            // 
            this.pnlFrequency.Controls.Add(this.rBtnMonthly);
            this.pnlFrequency.Controls.Add(this.rBtnWeekly);
            this.pnlFrequency.Controls.Add(this.rBtnOneTime);
            this.pnlFrequency.Location = new System.Drawing.Point(34, 127);
            this.pnlFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFrequency.Name = "pnlFrequency";
            this.pnlFrequency.Size = new System.Drawing.Size(154, 81);
            this.pnlFrequency.TabIndex = 4;
            // 
            // rBtnMonthly
            // 
            this.rBtnMonthly.AutoSize = true;
            this.rBtnMonthly.Location = new System.Drawing.Point(26, 54);
            this.rBtnMonthly.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnMonthly.Name = "rBtnMonthly";
            this.rBtnMonthly.Size = new System.Drawing.Size(62, 17);
            this.rBtnMonthly.TabIndex = 2;
            this.rBtnMonthly.TabStop = true;
            this.rBtnMonthly.Text = "Monthly";
            this.rBtnMonthly.UseVisualStyleBackColor = true;
            // 
            // rBtnWeekly
            // 
            this.rBtnWeekly.AutoSize = true;
            this.rBtnWeekly.Location = new System.Drawing.Point(26, 32);
            this.rBtnWeekly.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnWeekly.Name = "rBtnWeekly";
            this.rBtnWeekly.Size = new System.Drawing.Size(61, 17);
            this.rBtnWeekly.TabIndex = 1;
            this.rBtnWeekly.TabStop = true;
            this.rBtnWeekly.Text = "Weekly";
            this.rBtnWeekly.UseVisualStyleBackColor = true;
            // 
            // rBtnOneTime
            // 
            this.rBtnOneTime.AutoSize = true;
            this.rBtnOneTime.Location = new System.Drawing.Point(26, 11);
            this.rBtnOneTime.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnOneTime.Name = "rBtnOneTime";
            this.rBtnOneTime.Size = new System.Drawing.Size(71, 17);
            this.rBtnOneTime.TabIndex = 0;
            this.rBtnOneTime.TabStop = true;
            this.rBtnOneTime.Text = "One Time";
            this.rBtnOneTime.UseVisualStyleBackColor = true;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(32, 111);
            this.lblFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFrequency.TabIndex = 5;
            this.lblFrequency.Text = "Frequency";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(402, 113);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Debt";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_ClickAsync);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(402, 195);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBxDescription);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.pnlFrequency);
            this.panel1.Controls.Add(this.lblFrequency);
            this.panel1.Controls.Add(this.txtBxAmount);
            this.panel1.Location = new System.Drawing.Point(68, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 250);
            this.panel1.TabIndex = 8;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(103, 326);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(409, 38);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // lblMsgTitle
            // 
            this.lblMsgTitle.AutoSize = true;
            this.lblMsgTitle.Location = new System.Drawing.Point(100, 313);
            this.lblMsgTitle.Name = "lblMsgTitle";
            this.lblMsgTitle.Size = new System.Drawing.Size(53, 13);
            this.lblMsgTitle.TabIndex = 10;
            this.lblMsgTitle.Text = "Message:";
            // 
            // AddDebtPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblMsgTitle);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDebtPage";
            this.Text = "Add Debt";
            this.Load += new System.EventHandler(this.AddDebtPage_Load);
            this.pnlFrequency.ResumeLayout(false);
            this.pnlFrequency.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxDescription;
        private System.Windows.Forms.TextBox txtBxAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel pnlFrequency;
        private System.Windows.Forms.RadioButton rBtnMonthly;
        private System.Windows.Forms.RadioButton rBtnWeekly;
        private System.Windows.Forms.RadioButton rBtnOneTime;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMsgTitle;
    }
}