namespace Currency_Calculator
{
    partial class Form1
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
            this.amountDiscountLabel = new System.Windows.Forms.Label();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.regularPriceTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentLabel = new System.Windows.Forms.Label();
            this.regularPriceLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.finalPriceLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountDiscountLabel
            // 
            this.amountDiscountLabel.BackColor = System.Drawing.SystemColors.Info;
            this.amountDiscountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountDiscountLabel.Location = new System.Drawing.Point(613, 375);
            this.amountDiscountLabel.Name = "amountDiscountLabel";
            this.amountDiscountLabel.Size = new System.Drawing.Size(400, 55);
            this.amountDiscountLabel.TabIndex = 15;
            this.amountDiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.AutoSize = true;
            this.salePriceLabel.Location = new System.Drawing.Point(93, 375);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(298, 37);
            this.salePriceLabel.TabIndex = 14;
            this.salePriceLabel.Text = "Amount Discounted";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(613, 254);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(400, 44);
            this.discountTextBox.TabIndex = 13;
            this.discountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regularPriceTextBox
            // 
            this.regularPriceTextBox.Location = new System.Drawing.Point(613, 157);
            this.regularPriceTextBox.Name = "regularPriceTextBox";
            this.regularPriceTextBox.Size = new System.Drawing.Size(400, 44);
            this.regularPriceTextBox.TabIndex = 12;
            this.regularPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discountPercentLabel
            // 
            this.discountPercentLabel.AutoSize = true;
            this.discountPercentLabel.Location = new System.Drawing.Point(93, 261);
            this.discountPercentLabel.Name = "discountPercentLabel";
            this.discountPercentLabel.Size = new System.Drawing.Size(322, 37);
            this.discountPercentLabel.TabIndex = 11;
            this.discountPercentLabel.Text = "Item Discounted Rate";
            // 
            // regularPriceLabel
            // 
            this.regularPriceLabel.AutoSize = true;
            this.regularPriceLabel.Location = new System.Drawing.Point(93, 157);
            this.regularPriceLabel.Name = "regularPriceLabel";
            this.regularPriceLabel.Size = new System.Drawing.Size(279, 37);
            this.regularPriceLabel.TabIndex = 10;
            this.regularPriceLabel.Text = "Item Regular Price";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(0, 71);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(253, 110);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "&CALCULATE";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(660, 71);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(253, 110);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "EXI&T";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(324, 71);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(253, 110);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "C&LEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calcButton);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Location = new System.Drawing.Point(94, 654);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 238);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // finalPriceLabel
            // 
            this.finalPriceLabel.AutoSize = true;
            this.finalPriceLabel.Location = new System.Drawing.Point(93, 495);
            this.finalPriceLabel.Name = "finalPriceLabel";
            this.finalPriceLabel.Size = new System.Drawing.Size(240, 37);
            this.finalPriceLabel.TabIndex = 17;
            this.finalPriceLabel.Text = "Final Sale Price";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BackColor = System.Drawing.SystemColors.Info;
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsLabel.Location = new System.Drawing.Point(613, 477);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(400, 55);
            this.resultsLabel.TabIndex = 18;
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 1011);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.finalPriceLabel);
            this.Controls.Add(this.amountDiscountLabel);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.regularPriceTextBox);
            this.Controls.Add(this.discountPercentLabel);
            this.Controls.Add(this.regularPriceLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountDiscountLabel;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox regularPriceTextBox;
        private System.Windows.Forms.Label discountPercentLabel;
        private System.Windows.Forms.Label regularPriceLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label finalPriceLabel;
        private System.Windows.Forms.Label resultsLabel;
    }
}

