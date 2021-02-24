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
    public partial class SearchBlood : Form
    {
        Function function = new Function();
        String query;
  
        public SearchBlood()
        {
            InitializeComponent();
        }

        private void searchBloodExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SearchBlood_Load(object sender, EventArgs e)
        {
            query = "select * from newDonor";
            DataSet dataSet = function.getData(query);
            searchBloodDataGrid.DataSource = dataSet.Tables[0];
        }
        private void searchBloodTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchBloodTxt.Text != "")
            {
                query = "select * from newDonor where bloodGroup like '"+searchBloodTxt.Text+"%' ";
                DataSet dataSet = function.getData(query);
                searchBloodDataGrid.DataSource = dataSet.Tables[0];
            }
            else
            {
                query = "select * from newDonor";
                DataSet dataSet = function.getData(query);
                searchBloodDataGrid.DataSource = dataSet.Tables[0];
            }
        }
        private void searchDonorPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.searchBloodDataGrid.Width, this.searchBloodDataGrid.Height);
            searchBloodDataGrid.DrawToBitmap(bitmap, new Rectangle(0, 0, this.searchBloodDataGrid.Width, this.searchBloodDataGrid.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        private void searchBloodPrintBtn_Click(object sender, EventArgs e)
        {
            searchDonorPrintDocument.Print();
        }

        
    }
}
