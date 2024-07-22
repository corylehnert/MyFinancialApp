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
            this.pnlFrequency.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(46, 44);
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(205, 22);
            this.txtBxDescription.TabIndex = 0;
            // 
            // txtBxAmount
            // 
            this.txtBxAmount.Location = new System.Drawing.Point(46, 99);
            this.txtBxAmount.Name = "txtBxAmount";
            this.txtBxAmount.Size = new System.Drawing.Size(205, 22);
            this.txtBxAmount.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(43, 25);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(43, 80);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // pnlFrequency
            // 
            this.pnlFrequency.Controls.Add(this.rBtnMonthly);
            this.pnlFrequency.Controls.Add(this.rBtnWeekly);
            this.pnlFrequency.Controls.Add(this.rBtnOneTime);
            this.pnlFrequency.Location = new System.Drawing.Point(46, 156);
            this.pnlFrequency.Name = "pnlFrequency";
            this.pnlFrequency.Size = new System.Drawing.Size(205, 100);
            this.pnlFrequency.TabIndex = 4;
            // 
            // rBtnMonthly
            // 
            this.rBtnMonthly.AutoSize = true;
            this.rBtnMonthly.Location = new System.Drawing.Point(35, 67);
            this.rBtnMonthly.Name = "rBtnMonthly";
            this.rBtnMonthly.Size = new System.Drawing.Size(74, 20);
            this.rBtnMonthly.TabIndex = 2;
            this.rBtnMonthly.TabStop = true;
            this.rBtnMonthly.Text = "Monthly";
            this.rBtnMonthly.UseVisualStyleBackColor = true;
            // 
            // rBtnWeekly
            // 
            this.rBtnWeekly.AutoSize = true;
            this.rBtnWeekly.Location = new System.Drawing.Point(35, 40);
            this.rBtnWeekly.Name = "rBtnWeekly";
            this.rBtnWeekly.Size = new System.Drawing.Size(74, 20);
            this.rBtnWeekly.TabIndex = 1;
            this.rBtnWeekly.TabStop = true;
            this.rBtnWeekly.Text = "Weekly";
            this.rBtnWeekly.UseVisualStyleBackColor = true;
            // 
            // rBtnOneTime
            // 
            this.rBtnOneTime.AutoSize = true;
            this.rBtnOneTime.Location = new System.Drawing.Point(35, 14);
            this.rBtnOneTime.Name = "rBtnOneTime";
            this.rBtnOneTime.Size = new System.Drawing.Size(87, 20);
            this.rBtnOneTime.TabIndex = 0;
            this.rBtnOneTime.TabStop = true;
            this.rBtnOneTime.Text = "One Time";
            this.rBtnOneTime.UseVisualStyleBackColor = true;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(43, 137);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(71, 16);
            this.lblFrequency.TabIndex = 5;
            this.lblFrequency.Text = "Frequency";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(536, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 52);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Debt";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(536, 240);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 52);
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
            this.panel1.Location = new System.Drawing.Point(90, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 308);
            this.panel1.TabIndex = 8;
            // 
            // AddDebtPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddDebtPage";
            this.Text = "Add Debt";
            this.Load += new System.EventHandler(this.AddDebtPage_Load);
            this.pnlFrequency.ResumeLayout(false);
            this.pnlFrequency.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}