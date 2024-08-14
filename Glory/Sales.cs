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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void ServiceRB_CheckedChanged(object sender, EventArgs e)
        {
            QuantityNUD.Visible = false;
            Quantity.Visible = false;
            CostLBL.Visible = true;
            CostTXT.Visible = true;
            ProductName.Text = "Service";

        }

        private void SalesRB_CheckedChanged(object sender, EventArgs e)
        {
            Quantity.Visible = true;
            QuantityNUD.Visible = true;
            CostLBL.Visible = false;
            CostTXT.Visible = false;
            //ProductName.Hide();
        }
    }
}
