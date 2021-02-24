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
    public partial class StockDecrease : Form
    {
        Function function = new Function();
        String query;
        public StockDecrease()
        {
            InitializeComponent();
        }

        private void decreaseExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockDecrease_Load(object sender, EventArgs e)
        {
            query = "select blood_group, quantity from stock";
            DataSet dataSet = function.getData(query);
            stockDecreaseDataGrid.DataSource = dataSet.Tables[0];
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            query = "update stock set quantity=quantity+" + unitComboBox.Text + " where blood_group = '" + bloodGroupComboBox.Text + "' ";
            function.setData(query);
            StockDecrease_Load(this, null);
        }

        private void printStockDec_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.stockDecreaseDataGrid.Width, this.stockDecreaseDataGrid.Height);
            stockDecreaseDataGrid.DrawToBitmap(bitmap, new Rectangle(0, 0, this.stockDecreaseDataGrid.Width, this.stockDecreaseDataGrid.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
