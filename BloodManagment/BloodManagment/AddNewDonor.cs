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
    public partial class AddNewDonor : Form
    {
        public AddNewDonor()
        {
            InitializeComponent();
        }

        Function function = new Function();

        private void addDonorExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(did) from newDonor";
            
            DataSet dataset = function.getData(query);
            int count = int.Parse(dataset.Tables[0].Rows[0][0].ToString());
            donorIDValue.Text = (count+1).ToString();
        }

        private void addDonorSaveBtn_Click(object sender, EventArgs e)
        {
            if (addDonorTxtboxName.Text != "" && addDonorTxtboxFatherName.Text != "" && addDonorTxtboxMotherName.Text != "" && addDonorTxtboxMobileNum.Text != "" && addDonorTxtboxMail.Text != "" && addDonorBirthdayDate.Text != "" && addDonorTxtboxGender.Text != "" && addDonorTxtboxBlood.Text != "" && addDonorTxtboxCity.Text != "" && addDonorTxtboxAdress.Text != "")
            {
                String donorName = addDonorTxtboxName.Text;
                String fatherName = addDonorTxtboxFatherName.Text;
                String motherName = addDonorTxtboxMotherName.Text;
                String birthdayDate = addDonorBirthdayDate.Text;
                Int64 mobile = Int64.Parse(addDonorTxtboxMobileNum.Text);
                String gender = addDonorTxtboxGender.Text;
                String eMail = addDonorTxtboxMail.Text;
                String bloodGroup = addDonorTxtboxBlood.Text;
                String city = addDonorTxtboxCity.Text;
                String address = addDonorTxtboxAdress.Text;

                String query = "insert into newDonor (dname,fname, mname,dob,mobile,gender,email,bloodGroup,city,daddress) values ('"+donorName+ "','" + fatherName + "','" + motherName + "','" + birthdayDate + "','" + mobile + "','" + gender + "','" + eMail + "','" + bloodGroup + "','" + city + "','" + address + "') ";
                function.setData(query);
            }
            else
            {
                MessageBox.Show("Lütfen eksik bilgi girmeyiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void addDonorResetBtn_Click(object sender, EventArgs e)
        {
            addDonorTxtboxName.Clear();
            addDonorTxtboxFatherName.Clear();
            addDonorTxtboxMotherName.Clear();
            addDonorTxtboxMobileNum.Clear();
            addDonorTxtboxMail.Clear();
            addDonorTxtboxCity.Clear();
            addDonorTxtboxAdress.Clear();
            addDonorTxtboxGender.ResetText();
            addDonorBirthdayDate.ResetText();
            addDonorTxtboxBlood.ResetText();
        }

        private void onlyString(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void onyNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
