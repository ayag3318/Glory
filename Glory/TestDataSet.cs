using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glory;

namespace Glory
{
    public partial class TestDataSet : Form
    {
        public TestDataSet()
        {
            InitializeComponent();
            GloryDBTableAdapters.SalesTableAdapter SalesTableAdapter = new GloryDBTableAdapters.SalesTableAdapter();
            GloryDB.SalesDataTable SalesDataTable = new GloryDB.SalesDataTable();

            GloryDB.SalesRow NewSalesRow = SalesDataTable.NewSalesRow();
            NewSalesRow.PID = 3;
            SalesTableAdapter.DeleteQuery(5);
            SalesDataTable.AddSalesRow(NewSalesRow);

            var AllSales = SalesDataTable.ToList();
            //foreach (var salesRow in AllSales)
            //    salesRow.

            SalesTableAdapter.Update(SalesDataTable);

        }
    }
}
