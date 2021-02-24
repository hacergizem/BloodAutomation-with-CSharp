using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagment
{
    class Function
    {
        public SqlConnection getConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "data source = DESKTOP-*******\\SQLEXPRESS;database = BloodBank;integrated security= True";
            //You have to change this side.
            return sqlConnection;
        }

        public DataSet getData(string query) // Get data from database.
        {
            SqlConnection sqlConnection = getConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = query;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
        public void setData(String query) // Insertion, updation ve deletion.
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Veri başarıyla kaydedildi.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
