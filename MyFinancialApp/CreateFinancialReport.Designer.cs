namespace MyFinancialApp
{
    partial class CreateFinancialReport
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.listDebts = new System.Windows.Forms.ListView();
            this.descHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amtHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nextPayHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastPayHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comBoxFrequency = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(468, 484);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 28);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // listDebts
            // 
            this.listDebts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.descHeader,
            this.amtHeader,
            this.nextPayHeader,
            this.lastPayHeader});
            listDebts.GridLines = true;
            this.listDebts.HideSelection = false;
            this.listDebts.Location = new System.Drawing.Point(612, 65);
            this.listDebts.Margin = new System.Windows.Forms.Padding(4);
            this.listDebts.Name = "listDebts";
            this.listDebts.Size = new System.Drawing.Size(351, 303);
            this.listDebts.TabIndex = 1;
            this.listDebts.UseCompatibleStateImageBehavior = false;
            this.listDebts.View = System.Windows.Forms.View.Details;
            this.listDebts.Visible = false;
            // 
            // descHeader
            // 
            this.descHeader.Text = "Description";
            // 
            // amtHeader
            // 
            this.amtHeader.Text = "Amount";
            // 
            // nextPayHeader
            // 
            this.nextPayHeader.Text = "Next Payment Due";
            this.nextPayHeader.Width = 127;
            // 
            // lastPayHeader
            // 
            this.lastPayHeader.Text = "Last Payment Made";
            this.lastPayHeader.Width = 134;
            // 
            // comBoxFrequency
            // 
            this.comBoxFrequency.FormattingEnabled = true;
            this.comBoxFrequency.Items.AddRange(new object[] {
            "Full Report",
            "Monthly Report",
            "Weekly Report"});
            this.comBoxFrequency.Location = new System.Drawing.Point(431, 433);
            this.comBoxFrequency.Margin = new System.Windows.Forms.Padding(4);
            this.comBoxFrequency.Name = "comBoxFrequency";
            this.comBoxFrequency.Size = new System.Drawing.Size(160, 24);
            this.comBoxFrequency.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listDebts);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 411);
            this.panel1.TabIndex = 3;
            // 
            // CreateFinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comBoxFrequency);
            this.Controls.Add(this.btnGenerate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateFinancialReport";
            this.Text = "Create Financial Report";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListView listDebts;
        private System.Windows.Forms.ComboBox comBoxFrequency;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader descHeader;
        private System.Windows.Forms.ColumnHeader amtHeader;
        private System.Windows.Forms.ColumnHeader nextPayHeader;
        private System.Windows.Forms.ColumnHeader lastPayHeader;
    }
}