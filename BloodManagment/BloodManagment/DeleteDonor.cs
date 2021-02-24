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
    public partial class DeleteDonor : Form
    {
        Function function = new Function();
        String query;
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void deleteDonorExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (deleteDonorTxt.Text != "")
            {
                query = "select * from newDonor where did = '"+deleteDonorTxt.Text+"' ";
                DataSet dataSet = function.getData(query);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    donorIDValue.Text = deleteDonorTxt.Text;
                    deleteDonorTxtboxName.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    deleteDonorTxtboxFatherName.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    deleteDonorTxtboxMotherName.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    deleteDonorBirthdayDate.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    deleteDonorMobileNum.Text = dataSet.Tables[0].Rows[0][5].ToString();
                    deleteDonorTxtboxGender.Text = dataSet.Tables[0].Rows[0][6].ToString();
                    deleteDonorTxtboxMail.Text = dataSet.Tables[0].Rows[0][7].ToString();
                    deleteDonorTxtboxBlood.Text = dataSet.Tables[0].Rows[0][8].ToString();
                    deleteDonorTxtboxCity.Text = dataSet.Tables[0].Rows[0][9].ToString();
                    deleteDonorTxtboxAdress.Text = dataSet.Tables[0].Rows[0][10].ToString();
                }
                else
                {
                    MessageBox.Show("Geçersiz ID girdiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void deleteDonorDeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kullanıcıyı sileceksiniz. Devam etmek istiyor musunuz?","Sil",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                query = "delete from newDonor where did=" + deleteDonorTxt.Text + "";
                function.setData(query);
            }
        }
    }
}
