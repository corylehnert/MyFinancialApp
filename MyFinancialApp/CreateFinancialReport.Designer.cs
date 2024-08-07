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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(351, 393);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_ClickAsync);
            // 
            // listDebts
            // 
            this.listDebts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.descHeader,
            this.amtHeader,
            this.nextPayHeader,
            this.lastPayHeader});
            this.listDebts.GridLines = true;
            this.listDebts.HideSelection = false;
            this.listDebts.Location = new System.Drawing.Point(339, 25);
            this.listDebts.Name = "listDebts";
            this.listDebts.Size = new System.Drawing.Size(390, 247);
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
            this.comBoxFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxFrequency.FormattingEnabled = true;
            this.comBoxFrequency.Items.AddRange(new object[] {
            "FullReport",
            "MonthlyReport",
            "WeeklyReport"});
            this.comBoxFrequency.Location = new System.Drawing.Point(323, 352);
            this.comBoxFrequency.Name = "comBoxFrequency";
            this.comBoxFrequency.Size = new System.Drawing.Size(121, 21);
            this.comBoxFrequency.TabIndex = 2;
            this.comBoxFrequency.SelectedIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.listDebts);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 334);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message:";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(220, 293);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(283, 24);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateFinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comBoxFrequency);
            this.Controls.Add(this.btnGenerate);
            this.Name = "CreateFinancialReport";
            this.Text = "Create Financial Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
    }
}