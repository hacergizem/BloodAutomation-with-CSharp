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
    public partial class UpdateDonorDetails : Form
    {
        Function function = new Function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void updateExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void updateSearch_TextChanged(object sender, EventArgs e)
        {
            if (updateSearch.Text =="")
            {
                updateTxtboxName.Clear();
                updateTxtboxFatherName.Clear();
                updateTxtboxMotherName.Clear();
                updateBirthdayDate.ResetText();
                updateTxtboxMobileNum.Clear();
                updateTxtboxGender.ResetText();
                updateTxtboxMail.ResetText();
                updateTxtboxBlood.ResetText();
                updateTxtboxCity.Clear();
                updateTxtboxAdress.Clear();
            }
        }

        private void updateDonorResetBtn_Click(object sender, EventArgs e)
        {
            updateSearch.Clear();
        }

        private void updateDonorUpdateBtn_Click(object sender, EventArgs e)
        {
            String query = "update newDonor set dname = '" + updateTxtboxName.Text + "',fname = '" + updateTxtboxFatherName.Text + "',mname = '" + updateTxtboxMotherName.Text + "',dob = '" + updateBirthdayDate.Text + "',mobile = '" + updateTxtboxMobileNum.Text + "', gender = '" + updateTxtboxGender.Text + "', email = '" + updateTxtboxMail.Text + "', bloodGroup = '" + updateTxtboxBlood.Text + "', city = '" + updateTxtboxCity + "', daddress = '" + updateTxtboxAdress + "' where did = '" + updateSearch.Text+ "' ";
            function.setData(query);
            UpdateDonorDetails_Load(this, null);
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            updateSearch.Clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Int64 id = Int64.Parse(updateSearch.Text.ToString());
            String query = "select * from newDonor where did = " + id + "";
            DataSet dataSet = function.getData(query);

            if (dataSet.Tables[0].Rows.Count != 0)
            {
                donorIDValue.Text = id.ToString();
                updateTxtboxName.Text = dataSet.Tables[0].Rows[0][1].ToString();
                updateTxtboxFatherName.Text = dataSet.Tables[0].Rows[0][2].ToString();
                updateTxtboxMotherName.Text = dataSet.Tables[0].Rows[0][3].ToString();
                updateBirthdayDate.Text = dataSet.Tables[0].Rows[0][4].ToString();
                updateTxtboxMobileNum.Text = dataSet.Tables[0].Rows[0][5].ToString();
                updateTxtboxGender.Text = dataSet.Tables[0].Rows[0][6].ToString();
                updateTxtboxMail.Text = dataSet.Tables[0].Rows[0][7].ToString();
                updateTxtboxBlood.Text = dataSet.Tables[0].Rows[0][8].ToString();
                updateTxtboxCity.Text = dataSet.Tables[0].Rows[0][9].ToString();
                updateTxtboxAdress.Text = dataSet.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                MessageBox.Show("ID bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onlyString(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
