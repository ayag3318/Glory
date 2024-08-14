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
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var sales = new Sales();
            sales.Show();
            this.Close();

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            var emp = new SignUp(); ;
            emp.StartPosition = FormStartPosition.CenterScreen;
            emp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.StartPosition = FormStartPosition.CenterScreen;
            product.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
