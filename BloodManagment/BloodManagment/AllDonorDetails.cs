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
    public partial class AllDonorDetails : Form
    {
        Function function = new Function();
        public AllDonorDetails()
        {
            InitializeComponent();
        }

        private void allDonorsExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllDonorDetails_Load(object sender, EventArgs e)
        {
            String query = "select * from newDonor";
            DataSet dataSet = function.getData(query);
            allDonorDetailsDataGrid.DataSource = dataSet.Tables[0];
        }

        private void allDonorPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.allDonorDetailsDataGrid.Width, this.allDonorDetailsDataGrid.Height);
            allDonorDetailsDataGrid.DrawToBitmap(bitmap, new Rectangle(0, 0, this.allDonorDetailsDataGrid.Width,this.allDonorDetailsDataGrid.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void allDonorPrintBtn_Click(object sender, EventArgs e)
        {
            allDonorPrint.Print();
        }
    }
}
