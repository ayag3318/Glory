namespace Glory
{
    partial class Sales
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
            this.DGVSales = new System.Windows.Forms.DataGridView();
            this.BTNSell = new System.Windows.Forms.Button();
            this.ProductNumberTB = new System.Windows.Forms.TextBox();
            this.ProductNumberLBL = new System.Windows.Forms.Label();
            this.QuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.Quantity = new System.Windows.Forms.Label();
            this.ServiceRB = new System.Windows.Forms.RadioButton();
            this.SalesRB = new System.Windows.Forms.RadioButton();
            this.CostTXT = new System.Windows.Forms.TextBox();
            this.CostLBL = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ProductLBL = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSales
            // 
            this.DGVSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSales.Location = new System.Drawing.Point(47, 133);
            this.DGVSales.Name = "DGVSales";
            this.DGVSales.Size = new System.Drawing.Size(557, 131);
            this.DGVSales.TabIndex = 0;
            // 
            // BTNSell
            // 
            this.BTNSell.Location = new System.Drawing.Point(529, 279);
            this.BTNSell.Name = "BTNSell";
            this.BTNSell.Size = new System.Drawing.Size(75, 23);
            this.BTNSell.TabIndex = 1;
            this.BTNSell.Text = "Sell";
            this.BTNSell.UseVisualStyleBackColor = true;
            // 
            // ProductNumberTB
            // 
            this.ProductNumberTB.Location = new System.Drawing.Point(371, 32);
            this.ProductNumberTB.Name = "ProductNumberTB";
            this.ProductNumberTB.Size = new System.Drawing.Size(121, 20);
            this.ProductNumberTB.TabIndex = 2;
            // 
            // ProductNumberLBL
            // 
            this.ProductNumberLBL.AutoSize = true;
            this.ProductNumberLBL.Location = new System.Drawing.Point(523, 35);
            this.ProductNumberLBL.Name = "ProductNumberLBL";
            this.ProductNumberLBL.Size = new System.Drawing.Size(81, 13);
            this.ProductNumberLBL.TabIndex = 3;
            this.ProductNumberLBL.Text = "ProductNumber";
            // 
            // QuantityNUD
            // 
            this.QuantityNUD.Location = new System.Drawing.Point(372, 96);
            this.QuantityNUD.Name = "QuantityNUD";
            this.QuantityNUD.Size = new System.Drawing.Size(120, 20);
            this.QuantityNUD.TabIndex = 4;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(558, 98);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 5;
            this.Quantity.Text = "Quantity";
            // 
            // ServiceRB
            // 
            this.ServiceRB.AutoSize = true;
            this.ServiceRB.Location = new System.Drawing.Point(243, 35);
            this.ServiceRB.Name = "ServiceRB";
            this.ServiceRB.Size = new System.Drawing.Size(61, 17);
            this.ServiceRB.TabIndex = 6;
            this.ServiceRB.Text = "Service";
            this.ServiceRB.UseVisualStyleBackColor = true;
            this.ServiceRB.CheckedChanged += new System.EventHandler(this.ServiceRB_CheckedChanged);
            // 
            // SalesRB
            // 
            this.SalesRB.AutoSize = true;
            this.SalesRB.Checked = true;
            this.SalesRB.Location = new System.Drawing.Point(243, 73);
            this.SalesRB.Name = "SalesRB";
            this.SalesRB.Size = new System.Drawing.Size(51, 17);
            this.SalesRB.TabIndex = 7;
            this.SalesRB.TabStop = true;
            this.SalesRB.Text = "Sales";
            this.SalesRB.UseVisualStyleBackColor = true;
            this.SalesRB.CheckedChanged += new System.EventHandler(this.SalesRB_CheckedChanged);
            // 
            // CostTXT
            // 
            this.CostTXT.Location = new System.Drawing.Point(57, 34);
            this.CostTXT.Name = "CostTXT";
            this.CostTXT.Size = new System.Drawing.Size(100, 20);
            this.CostTXT.TabIndex = 8;
            this.CostTXT.Visible = false;
            // 
            // CostLBL
            // 
            this.CostLBL.AutoSize = true;
            this.CostLBL.Location = new System.Drawing.Point(177, 38);
            this.CostLBL.Name = "CostLBL";
            this.CostLBL.Size = new System.Drawing.Size(28, 13);
            this.CostLBL.TabIndex = 9;
            this.CostLBL.Text = "Cost";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(312, 278);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(81, 278);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // ProductLBL
            // 
            this.ProductLBL.AutoSize = true;
            this.ProductLBL.Location = new System.Drawing.Point(529, 64);
            this.ProductLBL.Name = "ProductLBL";
            this.ProductLBL.Size = new System.Drawing.Size(75, 13);
            this.ProductLBL.TabIndex = 12;
            this.ProductLBL.Text = "Product Name";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(457, 64);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(0, 13);
            this.ProductName.TabIndex = 13;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 324);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductLBL);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CostLBL);
            this.Controls.Add(this.CostTXT);
            this.Controls.Add(this.SalesRB);
            this.Controls.Add(this.ServiceRB);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.QuantityNUD);
            this.Controls.Add(this.ProductNumberLBL);
            this.Controls.Add(this.ProductNumberTB);
            this.Controls.Add(this.BTNSell);
            this.Controls.Add(this.DGVSales);
            this.Name = "Sales";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.DGVSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSales;
        private System.Windows.Forms.Button BTNSell;
        private System.Windows.Forms.TextBox ProductNumberTB;
        private System.Windows.Forms.Label ProductNumberLBL;
        private System.Windows.Forms.NumericUpDown QuantityNUD;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.RadioButton ServiceRB;
        private System.Windows.Forms.RadioButton SalesRB;
        private System.Windows.Forms.TextBox CostTXT;
        private System.Windows.Forms.Label CostLBL;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ProductLBL;
        private System.Windows.Forms.Label ProductName;
    }
}