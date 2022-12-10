
namespace FinalInvoicesGUI
{
    partial class Form1
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
            this.leftBox = new System.Windows.Forms.RichTextBox();
            this.byCostRadial = new System.Windows.Forms.RadioButton();
            this.byInvIDRadial = new System.Windows.Forms.RadioButton();
            this.byCustomerIDRadial = new System.Windows.Forms.RadioButton();
            this.byLastNameRadial = new System.Windows.Forms.RadioButton();
            this.invoicesRadial = new System.Windows.Forms.RadioButton();
            this.inventorySoldRadial = new System.Windows.Forms.RadioButton();
            this.invByCustomerRadial = new System.Windows.Forms.RadioButton();
            this.rightBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftBox
            // 
            this.leftBox.Location = new System.Drawing.Point(14, 201);
            this.leftBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(356, 447);
            this.leftBox.TabIndex = 0;
            this.leftBox.Text = "";
            // 
            // byCostRadial
            // 
            this.byCostRadial.AutoSize = true;
            this.byCostRadial.Location = new System.Drawing.Point(12, 112);
            this.byCostRadial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.byCostRadial.Name = "byCostRadial";
            this.byCostRadial.Size = new System.Drawing.Size(144, 24);
            this.byCostRadial.TabIndex = 1;
            this.byCostRadial.TabStop = true;
            this.byCostRadial.Text = "Inventory by Cost";
            this.byCostRadial.UseVisualStyleBackColor = true;
            this.byCostRadial.CheckedChanged += new System.EventHandler(this.byCostRadial_CheckedChanged);
            // 
            // byInvIDRadial
            // 
            this.byInvIDRadial.AutoSize = true;
            this.byInvIDRadial.Location = new System.Drawing.Point(12, 79);
            this.byInvIDRadial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.byInvIDRadial.Name = "byInvIDRadial";
            this.byInvIDRadial.Size = new System.Drawing.Size(130, 24);
            this.byInvIDRadial.TabIndex = 2;
            this.byInvIDRadial.TabStop = true;
            this.byInvIDRadial.Text = "Inventory by ID";
            this.byInvIDRadial.UseVisualStyleBackColor = true;
            this.byInvIDRadial.CheckedChanged += new System.EventHandler(this.byInvIDRadial_CheckedChanged);
            // 
            // byCustomerIDRadial
            // 
            this.byCustomerIDRadial.AutoSize = true;
            this.byCustomerIDRadial.Location = new System.Drawing.Point(12, 45);
            this.byCustomerIDRadial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.byCustomerIDRadial.Name = "byCustomerIDRadial";
            this.byCustomerIDRadial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.byCustomerIDRadial.Size = new System.Drawing.Size(138, 24);
            this.byCustomerIDRadial.TabIndex = 3;
            this.byCustomerIDRadial.TabStop = true;
            this.byCustomerIDRadial.Text = "Customers by ID";
            this.byCustomerIDRadial.UseVisualStyleBackColor = true;
            this.byCustomerIDRadial.CheckedChanged += new System.EventHandler(this.byCustomerIDRadial_CheckedChanged);
            // 
            // byLastNameRadial
            // 
            this.byLastNameRadial.AutoSize = true;
            this.byLastNameRadial.Location = new System.Drawing.Point(12, 12);
            this.byLastNameRadial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.byLastNameRadial.Name = "byLastNameRadial";
            this.byLastNameRadial.Size = new System.Drawing.Size(193, 24);
            this.byLastNameRadial.TabIndex = 4;
            this.byLastNameRadial.TabStop = true;
            this.byLastNameRadial.Text = "Customers by Last Name";
            this.byLastNameRadial.UseVisualStyleBackColor = true;
            this.byLastNameRadial.CheckedChanged += new System.EventHandler(this.byLastNameRadial_CheckedChanged);
            // 
            // invoicesRadial
            // 
            this.invoicesRadial.AutoSize = true;
            this.invoicesRadial.Location = new System.Drawing.Point(3, 4);
            this.invoicesRadial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invoicesRadial.Name = "invoicesRadial";
            this.invoicesRadial.Size = new System.Drawing.Size(83, 24);
            this.invoicesRadial.TabIndex = 5;
            this.invoicesRadial.TabStop = true;
            this.invoicesRadial.Text = "Invoices";
            this.invoicesRadial.UseVisualStyleBackColor = true;
            this.invoicesRadial.CheckedChanged += new System.EventHandler(this.invoicesRadial_CheckedChanged);
            // 
            // inventorySoldRadial
            // 
            this.inventorySoldRadial.AutoSize = true;
            this.inventorySoldRadial.Location = new System.Drawing.Point(92, 4);
            this.inventorySoldRadial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inventorySoldRadial.Name = "inventorySoldRadial";
            this.inventorySoldRadial.Size = new System.Drawing.Size(125, 24);
            this.inventorySoldRadial.TabIndex = 6;
            this.inventorySoldRadial.TabStop = true;
            this.inventorySoldRadial.Text = "Inventory Sold";
            this.inventorySoldRadial.UseVisualStyleBackColor = true;
            this.inventorySoldRadial.CheckedChanged += new System.EventHandler(this.inventorySoldRadial_CheckedChanged);
            // 
            // invByCustomerRadial
            // 
            this.invByCustomerRadial.AutoSize = true;
            this.invByCustomerRadial.Location = new System.Drawing.Point(223, 4);
            this.invByCustomerRadial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invByCustomerRadial.Name = "invByCustomerRadial";
            this.invByCustomerRadial.Size = new System.Drawing.Size(178, 24);
            this.invByCustomerRadial.TabIndex = 7;
            this.invByCustomerRadial.TabStop = true;
            this.invByCustomerRadial.Text = "Inventory by Customer";
            this.invByCustomerRadial.UseVisualStyleBackColor = true;
            this.invByCustomerRadial.CheckedChanged += new System.EventHandler(this.invByCustomerRadial_CheckedChanged);
            // 
            // rightBox
            // 
            this.rightBox.Location = new System.Drawing.Point(471, 52);
            this.rightBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(475, 596);
            this.rightBox.TabIndex = 8;
            this.rightBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.invByCustomerRadial);
            this.panel1.Controls.Add(this.inventorySoldRadial);
            this.panel1.Controls.Add(this.invoicesRadial);
            this.panel1.Location = new System.Drawing.Point(502, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 36);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.byInvIDRadial);
            this.panel2.Controls.Add(this.byLastNameRadial);
            this.panel2.Controls.Add(this.byCostRadial);
            this.panel2.Controls.Add(this.byCustomerIDRadial);
            this.panel2.Location = new System.Drawing.Point(60, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 156);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.leftBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "SDEV 2420 Final | James Sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox leftBox;
        private System.Windows.Forms.RadioButton byCostRadial;
        private System.Windows.Forms.RadioButton byInvIDRadial;
        private System.Windows.Forms.RadioButton byCustomerIDRadial;
        private System.Windows.Forms.RadioButton byLastNameRadial;
        private System.Windows.Forms.RadioButton invoicesRadial;
        private System.Windows.Forms.RadioButton inventorySoldRadial;
        private System.Windows.Forms.RadioButton invByCustomerRadial;
        private System.Windows.Forms.RichTextBox rightBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

