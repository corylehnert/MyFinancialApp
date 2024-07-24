namespace MyFinancialApp
{
    partial class MainScreen
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
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.btnAddDebt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(31, 67);
            this.btnCreateReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(88, 59);
            this.btnCreateReport.TabIndex = 1;
            this.btnCreateReport.Text = "Create Financial Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // btnAddDebt
            // 
            this.btnAddDebt.Location = new System.Drawing.Point(31, 20);
            this.btnAddDebt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDebt.Name = "btnAddDebt";
            this.btnAddDebt.Size = new System.Drawing.Size(88, 43);
            this.btnAddDebt.TabIndex = 2;
            this.btnAddDebt.Text = "Add Debt";
            this.btnAddDebt.UseVisualStyleBackColor = true;
            this.btnAddDebt.Click += new System.EventHandler(this.btnAddDebt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateReport);
            this.panel1.Controls.Add(this.btnAddDebt);
            this.panel1.Location = new System.Drawing.Point(216, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 145);
            this.panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(170, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 55);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "My Financial App";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreen";
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Button btnAddDebt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
    }
}

