
namespace M4Competency
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
            this.label1 = new System.Windows.Forms.Label();
            this.byLastName = new System.Windows.Forms.RadioButton();
            this.byDepartment = new System.Windows.Forms.RadioButton();
            this.byEmployeeID = new System.Windows.Forms.RadioButton();
            this.byHireDate = new System.Windows.Forms.RadioButton();
            this.empInfoBox = new System.Windows.Forms.ListBox();
            this.payrollBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // byLastName
            // 
            this.byLastName.AutoSize = true;
            this.byLastName.Location = new System.Drawing.Point(44, 42);
            this.byLastName.Name = "byLastName";
            this.byLastName.Size = new System.Drawing.Size(97, 19);
            this.byLastName.TabIndex = 1;
            this.byLastName.TabStop = true;
            this.byLastName.Text = "By Last Name";
            this.byLastName.UseVisualStyleBackColor = true;
            this.byLastName.CheckedChanged += new System.EventHandler(this.byLastName_CheckedChanged);
            // 
            // byDepartment
            // 
            this.byDepartment.AutoSize = true;
            this.byDepartment.Location = new System.Drawing.Point(44, 68);
            this.byDepartment.Name = "byDepartment";
            this.byDepartment.Size = new System.Drawing.Size(104, 19);
            this.byDepartment.TabIndex = 2;
            this.byDepartment.TabStop = true;
            this.byDepartment.Text = "By Department";
            this.byDepartment.UseVisualStyleBackColor = true;
            this.byDepartment.CheckedChanged += new System.EventHandler(this.byDepartment_CheckedChanged);
            // 
            // byEmployeeID
            // 
            this.byEmployeeID.AutoSize = true;
            this.byEmployeeID.Location = new System.Drawing.Point(44, 94);
            this.byEmployeeID.Name = "byEmployeeID";
            this.byEmployeeID.Size = new System.Drawing.Size(107, 19);
            this.byEmployeeID.TabIndex = 3;
            this.byEmployeeID.TabStop = true;
            this.byEmployeeID.Text = "By Employee ID";
            this.byEmployeeID.UseVisualStyleBackColor = true;
            this.byEmployeeID.CheckedChanged += new System.EventHandler(this.byEmployeeID_CheckedChanged);
            // 
            // byHireDate
            // 
            this.byHireDate.AutoSize = true;
            this.byHireDate.Location = new System.Drawing.Point(44, 120);
            this.byHireDate.Name = "byHireDate";
            this.byHireDate.Size = new System.Drawing.Size(90, 19);
            this.byHireDate.TabIndex = 4;
            this.byHireDate.TabStop = true;
            this.byHireDate.Text = "By Hire Date";
            this.byHireDate.UseVisualStyleBackColor = true;
            this.byHireDate.CheckedChanged += new System.EventHandler(this.byHireDate_CheckedChanged);
            // 
            // empInfoBox
            // 
            this.empInfoBox.FormattingEnabled = true;
            this.empInfoBox.ItemHeight = 15;
            this.empInfoBox.Location = new System.Drawing.Point(44, 145);
            this.empInfoBox.Name = "empInfoBox";
            this.empInfoBox.Size = new System.Drawing.Size(334, 349);
            this.empInfoBox.TabIndex = 5;
            // 
            // payrollBox
            // 
            this.payrollBox.FormattingEnabled = true;
            this.payrollBox.ItemHeight = 15;
            this.payrollBox.Location = new System.Drawing.Point(423, 145);
            this.payrollBox.Name = "payrollBox";
            this.payrollBox.Size = new System.Drawing.Size(588, 349);
            this.payrollBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(492, 87);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(101, 39);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(507, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payroll";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.payrollBox);
            this.Controls.Add(this.empInfoBox);
            this.Controls.Add(this.byHireDate);
            this.Controls.Add(this.byEmployeeID);
            this.Controls.Add(this.byDepartment);
            this.Controls.Add(this.byLastName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Module 4 Competency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton byLastName;
        private System.Windows.Forms.RadioButton byDepartment;
        private System.Windows.Forms.RadioButton byEmployeeID;
        private System.Windows.Forms.RadioButton byHireDate;
        private System.Windows.Forms.ListBox empInfoBox;
        private System.Windows.Forms.ListBox payrollBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label2;
    }
}
