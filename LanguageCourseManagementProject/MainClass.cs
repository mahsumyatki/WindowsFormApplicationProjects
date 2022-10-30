using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCourseManagementProject
{
    public class MainClass
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MONSTER\Documents\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");
        public void ListStudent(DataGridView dataGridView)
        {
            connection.Open();
            string query = "SELECT * FROM STUDENT";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            dataGridView.DataSource = dataset.Tables[0];
            connection.Close();
        }
    }
}
