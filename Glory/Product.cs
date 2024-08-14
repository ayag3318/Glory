using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glory
{



    public partial class Product : Form
    {

        GloryDBTableAdapters.productTableAdapter PDAdapter =
            new GloryDBTableAdapters.productTableAdapter();
        GloryDB.productDataTable ProductDT = new GloryDB.productDataTable();
        

        public Product()
        {
            InitializeComponent();
            PDAdapter.Fill(ProductDT);
            

        }

        private void Product_Load(object sender, EventArgs e)
        {

            

            for (int i = 0; i < ProductDT.Count; i++)
            {

                comboBox1.Items.Add(ProductDT[i]["PName"]);
            }
            
            

            
            

        }

        private void Save_Click(object sender, EventArgs e)
        {

            GloryDB.productRow PDrow = ProductDT.NewproductRow();
            GloryDB.productRow checkDublicate = ProductDT.NewproductRow();
            checkDublicate = ProductDT.FirstOrDefault(x => x.PName == PDnameBox.Text);

            if (checkDublicate != null)
            {
                MessageBox.Show("Product already exist");
                return;
            }

            if (PDnameBox.Text != "" && PDPriceBox.Text != "" && QuantityBox.Text != "" &&
                PDSPriceBox.Text != "" )
            {
               
                
                PDrow.PName = PDnameBox.Text;
                PDrow.PImage = ( PDImageBox.Text);
                PDrow.PPrice = int.Parse(PDPriceBox.Text);
                PDrow.PQuantity = int.Parse(QuantityBox.Text);
                PDrow.PSalesprice = int.Parse(PDSPriceBox.Text);

                ProductDT.Rows.Add(PDrow);
                PDAdapter.Update(ProductDT);
            }

            else MessageBox.Show("please fill in valid values");
            return;
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            var M = new Main();
            M.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var M = new Main();
            M.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string productname = comboBox1.SelectedItem.ToString();
            GloryDB.productRow updateproductrow = ProductDT.NewproductRow();
            

            

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            string ImagePath;

            ImagePath = op.FileName;

            PDImageBox.Text = ImagePath;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PDAdapter.Fill(ProductDT);
            GloryDB.productRow productrowfromDB = ProductDT.NewproductRow();

            productrowfromDB = ProductDT.FirstOrDefault(x => x.PName ==comboBox1.SelectedItem.ToString());

            if(productrowfromDB == null){
                MessageBox.Show("cannot find this product");
            return;
            }

            updateImagePathbox.Text = productrowfromDB.PImage;
            UpdatepriceBox.Text = productrowfromDB.PPrice.ToString();
            UpdateSalesPriceBox.Text = productrowfromDB.PSalesprice.ToString();
            
            UpdateQuantityBox.Text = productrowfromDB.PQuantity.ToString();

           
        }

        private void PDnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
