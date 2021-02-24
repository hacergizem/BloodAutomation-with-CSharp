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
    public partial class SearchLocation : Form
    {
        Function function = new Function();
        public SearchLocation()
        {
            InitializeComponent();
        }

        private void searchLocationExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchLocation_Load(object sender, EventArgs e)
        {
            String query = "select * from newDonor";
            DataSet dataSet = function.getData(query);
            searchLocationDataGrid.DataSource = dataSet.Tables[0];
        }

        private void searchLocationTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchLocationTxt.Text != "")
            {
                String query = "select * from newDonor where city like '"+searchLocationTxt.Text+"%' or daddress like '" +searchLocationTxt.Text+"%' ";
                DataSet dataSet = function.getData(query);
                searchLocationDataGrid.DataSource = dataSet.Tables[0];
            }
            else
            {
                String query = "select * from newDonor";
                DataSet dataSet = function.getData(query);
                searchLocationDataGrid.DataSource = dataSet.Tables[0];
            }
        }
        private void searchDonorPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.searchLocationDataGrid.Width, this.searchLocationDataGrid.Height);
            searchLocationDataGrid.DrawToBitmap(bitmap, new Rectangle(0, 0, this.searchLocationDataGrid.Width, this.searchLocationDataGrid.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void searchLocationPrintBtn_Click(object sender, EventArgs e)
        {
            searchDonorPrintDocument.Print();
        }
    }
}
