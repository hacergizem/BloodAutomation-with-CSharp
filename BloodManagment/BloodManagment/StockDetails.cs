using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagment
{
    public partial class StockDetails : Form
    {

        Function function = new Function();
        String query;
        public StockDetails()
        {
            InitializeComponent();
        }

        private void detailsExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {
            query = "select * from stock";
            DataSet dataSet = function.getData(query);
            stockDetailsDataGrid.DataSource = dataSet.Tables[0];

        }


        private void printStockDetails_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.stockDetailsDataGrid.Width, this.stockDetailsDataGrid.Height);
            stockDetailsDataGrid.DrawToBitmap(bitmap, new Rectangle(0, 0, this.stockDetailsDataGrid.Width, this.stockDetailsDataGrid.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printStockDetails.Print();
        }
    }
}
