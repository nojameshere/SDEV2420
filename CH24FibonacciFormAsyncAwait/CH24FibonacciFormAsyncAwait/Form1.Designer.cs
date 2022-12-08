namespace CH24FibonacciFormAsyncAwait
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
            this.label2 = new System.Windows.Forms.Label();
            this.RecursiveButton = new System.Windows.Forms.Button();
            this.fibonacciNumbers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calcResultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeTaken = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IterativeButton = new System.Windows.Forms.Button();
            this.IterativeResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate Synchronously";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter number of\r\nFibonacci numbers";
            // 
            // RecursiveButton
            // 
            this.RecursiveButton.Location = new System.Drawing.Point(211, 105);
            this.RecursiveButton.Name = "RecursiveButton";
            this.RecursiveButton.Size = new System.Drawing.Size(152, 65);
            this.RecursiveButton.TabIndex = 2;
            this.RecursiveButton.Text = "Calculate \r\nRecursively";
            this.RecursiveButton.UseVisualStyleBackColor = true;
            this.RecursiveButton.Click += new System.EventHandler(this.RecursiveButton_Click);
            // 
            // fibonacciNumbers
            // 
            this.fibonacciNumbers.Location = new System.Drawing.Point(211, 72);
            this.fibonacciNumbers.Name = "fibonacciNumbers";
            this.fibonacciNumbers.Size = new System.Drawing.Size(152, 27);
            this.fibonacciNumbers.TabIndex = 3;
            this.fibonacciNumbers.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result of calculation";
            // 
            // calcResultLabel
            // 
            this.calcResultLabel.AutoSize = true;
            this.calcResultLabel.Location = new System.Drawing.Point(211, 199);
            this.calcResultLabel.Name = "calcResultLabel";
            this.calcResultLabel.Size = new System.Drawing.Size(0, 20);
            this.calcResultLabel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time";
            // 
            // timeTaken
            // 
            this.timeTaken.AutoSize = true;
            this.timeTaken.Location = new System.Drawing.Point(211, 241);
            this.timeTaken.Name = "timeTaken";
            this.timeTaken.Size = new System.Drawing.Size(0, 20);
            this.timeTaken.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Display next number";
            // 
            // IterativeButton
            // 
            this.IterativeButton.Location = new System.Drawing.Point(211, 324);
            this.IterativeButton.Name = "IterativeButton";
            this.IterativeButton.Size = new System.Drawing.Size(152, 59);
            this.IterativeButton.TabIndex = 9;
            this.IterativeButton.Text = "Calculate\r\nIteratively";
            this.IterativeButton.UseVisualStyleBackColor = true;
            this.IterativeButton.Click += new System.EventHandler(this.IterativeButton_Click);
            // 
            // IterativeResult
            // 
            this.IterativeResult.AutoSize = true;
            this.IterativeResult.Location = new System.Drawing.Point(45, 363);
            this.IterativeResult.Name = "IterativeResult";
            this.IterativeResult.Size = new System.Drawing.Size(17, 20);
            this.IterativeResult.TabIndex = 10;
            this.IterativeResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 442);
            this.Controls.Add(this.IterativeResult);
            this.Controls.Add(this.IterativeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeTaken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calcResultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fibonacciNumbers);
            this.Controls.Add(this.RecursiveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chapter 24: Fibonacci Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button RecursiveButton;
        private TextBox fibonacciNumbers;
        private Label label3;
        private Label calcResultLabel;
        private Label label4;
        private Label timeTaken;
        private Label label5;
        private Button IterativeButton;
        private Label IterativeResult;
    }
}