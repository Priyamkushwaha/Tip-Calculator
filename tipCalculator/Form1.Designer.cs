namespace tipCalculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.txtTipPerPerson = new System.Windows.Forms.TextBox();
            this.txtNumOfPerson = new System.Windows.Forms.TextBox();
            this.txtTipPercent = new System.Windows.Forms.TextBox();
            this.txtTotalPerPerson = new System.Windows.Forms.TextBox();
            this.addTipButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.subPersonButtton = new System.Windows.Forms.Button();
            this.subTipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip per person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total per person";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(36, 92);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(169, 27);
            this.txtBillAmount.TabIndex = 5;
            this.txtBillAmount.TextChanged += new System.EventHandler(this.txtBillAmount_TextChanged);
            // 
            // txtTipPerPerson
            // 
            this.txtTipPerPerson.Location = new System.Drawing.Point(605, 147);
            this.txtTipPerPerson.Name = "txtTipPerPerson";
            this.txtTipPerPerson.Size = new System.Drawing.Size(125, 27);
            this.txtTipPerPerson.TabIndex = 6;
            // 
            // txtNumOfPerson
            // 
            this.txtNumOfPerson.Location = new System.Drawing.Point(80, 357);
            this.txtNumOfPerson.Name = "txtNumOfPerson";
            this.txtNumOfPerson.Size = new System.Drawing.Size(125, 27);
            this.txtNumOfPerson.TabIndex = 7;
            this.txtNumOfPerson.TextChanged += new System.EventHandler(this.txtNumOfPerson_TextChanged);
            // 
            // txtTipPercent
            // 
            this.txtTipPercent.Location = new System.Drawing.Point(80, 220);
            this.txtTipPercent.Name = "txtTipPercent";
            this.txtTipPercent.Size = new System.Drawing.Size(125, 27);
            this.txtTipPercent.TabIndex = 8;
            this.txtTipPercent.TextChanged += new System.EventHandler(this.txtTipPercent_TextChanged);
            // 
            // txtTotalPerPerson
            // 
            this.txtTotalPerPerson.Location = new System.Drawing.Point(605, 255);
            this.txtTotalPerPerson.Name = "txtTotalPerPerson";
            this.txtTotalPerPerson.Size = new System.Drawing.Size(125, 27);
            this.txtTotalPerPerson.TabIndex = 9;
            // 
            // addTipButton
            // 
            this.addTipButton.Location = new System.Drawing.Point(211, 220);
            this.addTipButton.Name = "addTipButton";
            this.addTipButton.Size = new System.Drawing.Size(38, 29);
            this.addTipButton.TabIndex = 13;
            this.addTipButton.Text = "+";
            this.addTipButton.UseVisualStyleBackColor = true;
            this.addTipButton.Click += new System.EventHandler(this.addTipButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(211, 357);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(38, 29);
            this.addPersonButton.TabIndex = 14;
            this.addPersonButton.Text = "+";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // subPersonButtton
            // 
            this.subPersonButtton.Location = new System.Drawing.Point(36, 357);
            this.subPersonButtton.Name = "subPersonButtton";
            this.subPersonButtton.Size = new System.Drawing.Size(38, 29);
            this.subPersonButtton.TabIndex = 15;
            this.subPersonButtton.Text = "-";
            this.subPersonButtton.UseVisualStyleBackColor = true;
            this.subPersonButtton.Click += new System.EventHandler(this.subPersonButtton_Click);
            // 
            // subTipButton
            // 
            this.subTipButton.Location = new System.Drawing.Point(36, 218);
            this.subTipButton.Name = "subTipButton";
            this.subTipButton.Size = new System.Drawing.Size(38, 29);
            this.subTipButton.TabIndex = 16;
            this.subTipButton.Text = "-";
            this.subTipButton.UseVisualStyleBackColor = true;
            this.subTipButton.Click += new System.EventHandler(this.subTipButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subTipButton);
            this.Controls.Add(this.subPersonButtton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.addTipButton);
            this.Controls.Add(this.txtTotalPerPerson);
            this.Controls.Add(this.txtTipPercent);
            this.Controls.Add(this.txtNumOfPerson);
            this.Controls.Add(this.txtTipPerPerson);
            this.Controls.Add(this.txtBillAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBillAmount;
        private TextBox txtTipPerPerson;
        private TextBox txtNumOfPerson;
        private TextBox txtTipPercent;
        private TextBox txtTotalPerPerson;
        private Button addTipButton;
        private Button addPersonButton;
        private Button subPersonButtton;
        private Button subTipButton;
    }
}