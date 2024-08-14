namespace Glory
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.SalesBTN = new System.Windows.Forms.Button();
            this.ProductBTN = new System.Windows.Forms.Button();
            this.EmployeeBTN = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SalesBTN
            // 
            this.SalesBTN.Location = new System.Drawing.Point(398, 50);
            this.SalesBTN.Name = "SalesBTN";
            this.SalesBTN.Size = new System.Drawing.Size(167, 81);
            this.SalesBTN.TabIndex = 1;
            this.SalesBTN.Text = "Start Sales";
            this.SalesBTN.UseVisualStyleBackColor = true;
            this.SalesBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductBTN
            // 
            this.ProductBTN.Location = new System.Drawing.Point(398, 157);
            this.ProductBTN.Name = "ProductBTN";
            this.ProductBTN.Size = new System.Drawing.Size(167, 81);
            this.ProductBTN.TabIndex = 2;
            this.ProductBTN.Text = "Product";
            this.ProductBTN.UseVisualStyleBackColor = true;
            this.ProductBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmployeeBTN
            // 
            this.EmployeeBTN.Location = new System.Drawing.Point(184, 50);
            this.EmployeeBTN.Name = "EmployeeBTN";
            this.EmployeeBTN.Size = new System.Drawing.Size(167, 81);
            this.EmployeeBTN.TabIndex = 3;
            this.EmployeeBTN.Text = "Add New Employee";
            this.EmployeeBTN.UseVisualStyleBackColor = true;
            this.EmployeeBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 81);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add Product";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 330);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.EmployeeBTN);
            this.Controls.Add(this.ProductBTN);
            this.Controls.Add(this.SalesBTN);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Glory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalesBTN;
        private System.Windows.Forms.Button ProductBTN;
        private System.Windows.Forms.Button EmployeeBTN;
        private System.Windows.Forms.Button button4;
    }
}