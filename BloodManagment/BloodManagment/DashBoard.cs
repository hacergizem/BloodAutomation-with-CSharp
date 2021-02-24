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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();            
            loginPage.Show();
            this.Hide();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor addNewDonor = new AddNewDonor();
            addNewDonor.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails updateDonor = new UpdateDonorDetails();
            updateDonor.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails allDonorDetails = new AllDonorDetails();
            allDonorDetails.Show();
        }

        private void searchLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchLocation searchLocation = new SearchLocation();
            searchLocation.Show();
        }

        private void searchBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBlood searchBlood = new SearchBlood();
            searchBlood.Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIncrease stockIncrease = new StockIncrease();
            stockIncrease.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDecrease stockDecrease = new StockDecrease();
            stockDecrease.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails stockDetails = new StockDetails();
            stockDetails.Show();
        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonor deleteDonor = new DeleteDonor();
            deleteDonor.Show();
        }
    }
}
