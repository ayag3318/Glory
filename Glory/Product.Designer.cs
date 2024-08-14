namespace Glory
{
    partial class Product
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
            this.addproduct = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BackBTN = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.LoadImageBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PDPriceBox = new System.Windows.Forms.TextBox();
            this.PDSPriceBox = new System.Windows.Forms.TextBox();
            this.PDImageBox = new System.Windows.Forms.TextBox();
            this.PDnameBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateQuantityBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdatepriceBox = new System.Windows.Forms.TextBox();
            this.UpdateSalesPriceBox = new System.Windows.Forms.TextBox();
            this.updateImagePathbox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.addproduct.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addproduct
            // 
            this.addproduct.Controls.Add(this.tabPage1);
            this.addproduct.Controls.Add(this.tabPage2);
            this.addproduct.Location = new System.Drawing.Point(21, 26);
            this.addproduct.Name = "addproduct";
            this.addproduct.SelectedIndex = 0;
            this.addproduct.Size = new System.Drawing.Size(524, 309);
            this.addproduct.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BackBTN);
            this.tabPage1.Controls.Add(this.Save);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.QuantityBox);
            this.tabPage1.Controls.Add(this.LoadImageBTN);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PDPriceBox);
            this.tabPage1.Controls.Add(this.PDSPriceBox);
            this.tabPage1.Controls.Add(this.PDImageBox);
            this.tabPage1.Controls.Add(this.PDnameBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 283);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BackBTN
            // 
            this.BackBTN.Location = new System.Drawing.Point(278, 244);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(75, 23);
            this.BackBTN.TabIndex = 7;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(404, 244);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product quantity";
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(211, 193);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(269, 20);
            this.QuantityBox.TabIndex = 5;
            // 
            // LoadImageBTN
            // 
            this.LoadImageBTN.Location = new System.Drawing.Point(27, 81);
            this.LoadImageBTN.Name = "LoadImageBTN";
            this.LoadImageBTN.Size = new System.Drawing.Size(75, 23);
            this.LoadImageBTN.TabIndex = 2;
            this.LoadImageBTN.Text = "load Image";
            this.LoadImageBTN.UseVisualStyleBackColor = true;
            this.LoadImageBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sales Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name";
            // 
            // PDPriceBox
            // 
            this.PDPriceBox.Location = new System.Drawing.Point(211, 124);
            this.PDPriceBox.Name = "PDPriceBox";
            this.PDPriceBox.Size = new System.Drawing.Size(269, 20);
            this.PDPriceBox.TabIndex = 3;
            // 
            // PDSPriceBox
            // 
            this.PDSPriceBox.Location = new System.Drawing.Point(211, 161);
            this.PDSPriceBox.Name = "PDSPriceBox";
            this.PDSPriceBox.Size = new System.Drawing.Size(269, 20);
            this.PDSPriceBox.TabIndex = 4;
            // 
            // PDImageBox
            // 
            this.PDImageBox.Location = new System.Drawing.Point(211, 84);
            this.PDImageBox.Name = "PDImageBox";
            this.PDImageBox.Size = new System.Drawing.Size(269, 20);
            this.PDImageBox.TabIndex = 2;
            // 
            // PDnameBox
            // 
            this.PDnameBox.Location = new System.Drawing.Point(211, 43);
            this.PDnameBox.Name = "PDnameBox";
            this.PDnameBox.Size = new System.Drawing.Size(269, 20);
            this.PDnameBox.TabIndex = 1;
            this.PDnameBox.TextChanged += new System.EventHandler(this.PDnameBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.UpdateQuantityBox);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.UpdatepriceBox);
            this.tabPage2.Controls.Add(this.UpdateSalesPriceBox);
            this.tabPage2.Controls.Add(this.updateImagePathbox);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(516, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Product";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Product quantity";
            // 
            // UpdateQuantityBox
            // 
            this.UpdateQuantityBox.Location = new System.Drawing.Point(216, 182);
            this.UpdateQuantityBox.Name = "UpdateQuantityBox";
            this.UpdateQuantityBox.Size = new System.Drawing.Size(269, 20);
            this.UpdateQuantityBox.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "load Image";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sales Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Product Name";
            // 
            // UpdatepriceBox
            // 
            this.UpdatepriceBox.Location = new System.Drawing.Point(216, 113);
            this.UpdatepriceBox.Name = "UpdatepriceBox";
            this.UpdatepriceBox.Size = new System.Drawing.Size(269, 20);
            this.UpdatepriceBox.TabIndex = 3;
            // 
            // UpdateSalesPriceBox
            // 
            this.UpdateSalesPriceBox.Location = new System.Drawing.Point(216, 150);
            this.UpdateSalesPriceBox.Name = "UpdateSalesPriceBox";
            this.UpdateSalesPriceBox.Size = new System.Drawing.Size(269, 20);
            this.UpdateSalesPriceBox.TabIndex = 4;
            // 
            // updateImagePathbox
            // 
            this.updateImagePathbox.Location = new System.Drawing.Point(216, 73);
            this.updateImagePathbox.Name = "updateImagePathbox";
            this.updateImagePathbox.Size = new System.Drawing.Size(269, 20);
            this.updateImagePathbox.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(389, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 406);
            this.Controls.Add(this.addproduct);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.addproduct.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl addproduct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox PDPriceBox;
        private System.Windows.Forms.TextBox PDSPriceBox;
        private System.Windows.Forms.TextBox PDImageBox;
        private System.Windows.Forms.TextBox PDnameBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadImageBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UpdateQuantityBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UpdatepriceBox;
        private System.Windows.Forms.TextBox UpdateSalesPriceBox;
        private System.Windows.Forms.TextBox updateImagePathbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Button button1;

    }
}