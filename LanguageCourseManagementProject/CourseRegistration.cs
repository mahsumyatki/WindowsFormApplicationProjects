using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCourseManagementProject
{
    public partial class CourseRegistration : Form
    {
        public CourseRegistration()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MONSTER\Documents\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button_reset_Click(object sender, EventArgs e)
        {
            CleanTextbox();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text==""| textBox_hour.Text==""|textBox_description.Text=="")
            {
                MessageBox.Show("Eksik Bilgi..");    
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO COURSE VALUES('" + textBox_name.Text + "','" + textBox_hour.Text + "','" + textBox_description.Text + "')";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kurs başarıyla eklendi..");
                    connection.Close();
                    ListCourse();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CleanTextbox()
        {
            textBox_name.Text = "";
            textBox_hour.Text = "";
            textBox_description.Text = "";
        }

        private void ListCourse()
        {
            connection.Open();
            string query = "SELECT * FROM COURSE";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            connection.Close();
        }

        private void CourseRegistration_Load(object sender, EventArgs e)
        {
            ListCourse();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
