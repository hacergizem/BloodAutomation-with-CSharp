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
    public partial class StockIncrease : Form
    {
        Function function = new Function();
        String query;
        public StockIncrease()
        {
            InitializeComponent();
        }

        private void increaseExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockIncrease_Load(object sender, EventArgs e)
        {
            query = "select blood_group, quantity from stock";
            DataSet dataSet = function.getData(query);
            stockIncreaseDataGrid.DataSource = dataSet.Tables[0];
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            query = "update stock set quantity=quantity+" + unitComboBox.Text + " where blood_group = '" + bloodGroupComboBox.Text + "'";
            function.setData(query);
            StockIncrease_Load(this, null);
        }

        private void printStockIncrease_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.stockIncreaseDataGrid.Width, this.stockIncreaseDataGrid.Height);
            stockIncreaseDataGrid.DrawToBitmap(bitmap, new Rectangle(0, 0, this.stockIncreaseDataGrid.Width, this.stockIncreaseDataGrid.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }


        private void printButton_Click(object sender, EventArgs e)
        {
            printStockIncrease.Print();
        }
    }
}