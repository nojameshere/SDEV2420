
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.byCostRadial = new System.Windows.Forms.RadioButton();
            this.byInvIDRadial = new System.Windows.Forms.RadioButton();
            this.byCustomerIDRadial = new System.Windows.Forms.RadioButton();
            this.byLastNameRadial = new System.Windows.Forms.RadioButton();
            this.invoicesRadial = new System.Windows.Forms.RadioButton();
            this.inventorySoldRadial = new System.Windows.Forms.RadioButton();
            this.invByCustomerRadial = new System.Windows.Forms.RadioButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 151);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 336);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // byCostRadial
            // 
            this.byCostRadial.AutoSize = true;
            this.byCostRadial.Location = new System.Drawing.Point(41, 126);
            this.byCostRadial.Name = "byCostRadial";
            this.byCostRadial.Size = new System.Drawing.Size(118, 19);
            this.byCostRadial.TabIndex = 1;
            this.byCostRadial.TabStop = true;
            this.byCostRadial.Text = "Inventory by Cost";
            this.byCostRadial.UseVisualStyleBackColor = true;
            // 
            // byInvIDRadial
            // 
            this.byInvIDRadial.AutoSize = true;
            this.byInvIDRadial.Location = new System.Drawing.Point(41, 101);
            this.byInvIDRadial.Name = "byInvIDRadial";
            this.byInvIDRadial.Size = new System.Drawing.Size(105, 19);
            this.byInvIDRadial.TabIndex = 2;
            this.byInvIDRadial.TabStop = true;
            this.byInvIDRadial.Text = "Inventory by ID";
            this.byInvIDRadial.UseVisualStyleBackColor = true;
            // 
            // byCustomerIDRadial
            // 
            this.byCustomerIDRadial.AutoSize = true;
            this.byCustomerIDRadial.Location = new System.Drawing.Point(41, 76);
            this.byCustomerIDRadial.Name = "byCustomerIDRadial";
            this.byCustomerIDRadial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.byCustomerIDRadial.Size = new System.Drawing.Size(112, 19);
            this.byCustomerIDRadial.TabIndex = 3;
            this.byCustomerIDRadial.TabStop = true;
            this.byCustomerIDRadial.Text = "Customers by ID";
            this.byCustomerIDRadial.UseVisualStyleBackColor = true;
            // 
            // byLastNameRadial
            // 
            this.byLastNameRadial.AutoSize = true;
            this.byLastNameRadial.Location = new System.Drawing.Point(41, 51);
            this.byLastNameRadial.Name = "byLastNameRadial";
            this.byLastNameRadial.Size = new System.Drawing.Size(157, 19);
            this.byLastNameRadial.TabIndex = 4;
            this.byLastNameRadial.TabStop = true;
            this.byLastNameRadial.Text = "Customers by Last Name";
            this.byLastNameRadial.UseVisualStyleBackColor = true;
            // 
            // invoicesRadial
            // 
            this.invoicesRadial.AutoSize = true;
            this.invoicesRadial.Location = new System.Drawing.Point(422, 13);
            this.invoicesRadial.Name = "invoicesRadial";
            this.invoicesRadial.Size = new System.Drawing.Size(68, 19);
            this.invoicesRadial.TabIndex = 5;
            this.invoicesRadial.TabStop = true;
            this.invoicesRadial.Text = "Invoices";
            this.invoicesRadial.UseVisualStyleBackColor = true;
            // 
            // inventorySoldRadial
            // 
            this.inventorySoldRadial.AutoSize = true;
            this.inventorySoldRadial.Location = new System.Drawing.Point(513, 12);
            this.inventorySoldRadial.Name = "inventorySoldRadial";
            this.inventorySoldRadial.Size = new System.Drawing.Size(101, 19);
            this.inventorySoldRadial.TabIndex = 6;
            this.inventorySoldRadial.TabStop = true;
            this.inventorySoldRadial.Text = "Inventory Sold";
            this.inventorySoldRadial.UseVisualStyleBackColor = true;
            // 
            // invByCustomerRadial
            // 
            this.invByCustomerRadial.AutoSize = true;
            this.invByCustomerRadial.Location = new System.Drawing.Point(637, 12);
            this.invByCustomerRadial.Name = "invByCustomerRadial";
            this.invByCustomerRadial.Size = new System.Drawing.Size(146, 19);
            this.invByCustomerRadial.TabIndex = 7;
            this.invByCustomerRadial.TabStop = true;
            this.invByCustomerRadial.Text = "Inventory by Customer";
            this.invByCustomerRadial.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(412, 39);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(416, 448);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 505);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.invByCustomerRadial);
            this.Controls.Add(this.inventorySoldRadial);
            this.Controls.Add(this.invoicesRadial);
            this.Controls.Add(this.byLastNameRadial);
            this.Controls.Add(this.byCustomerIDRadial);
            this.Controls.Add(this.byInvIDRadial);
            this.Controls.Add(this.byCostRadial);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton byCostRadial;
        private System.Windows.Forms.RadioButton byInvIDRadial;
        private System.Windows.Forms.RadioButton byCustomerIDRadial;
        private System.Windows.Forms.RadioButton byLastNameRadial;
        private System.Windows.Forms.RadioButton invoicesRadial;
        private System.Windows.Forms.RadioButton inventorySoldRadial;
        private System.Windows.Forms.RadioButton invByCustomerRadial;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

