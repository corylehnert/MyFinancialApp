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
            this.comBoxFrequency = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // listDebts
            // 
            this.listDebts.HideSelection = false;
            this.listDebts.Location = new System.Drawing.Point(459, 53);
            this.listDebts.Name = "listDebts";
            this.listDebts.Size = new System.Drawing.Size(264, 247);
            this.listDebts.TabIndex = 1;
            this.listDebts.UseCompatibleStateImageBehavior = false;
            this.listDebts.Visible = false;
            // 
            // comBoxFrequency
            // 
            this.comBoxFrequency.FormattingEnabled = true;
            this.comBoxFrequency.Items.AddRange(new object[] {
            "Full Report",
            "Monthly Report",
            "Weekly Report"});
            this.comBoxFrequency.Location = new System.Drawing.Point(323, 352);
            this.comBoxFrequency.Name = "comBoxFrequency";
            this.comBoxFrequency.Size = new System.Drawing.Size(121, 21);
            this.comBoxFrequency.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listDebts);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 334);
            this.panel1.TabIndex = 3;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListView listDebts;
        private System.Windows.Forms.ComboBox comBoxFrequency;
        private System.Windows.Forms.Panel panel1;
    }
}