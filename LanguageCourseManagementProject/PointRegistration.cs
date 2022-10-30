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
    public partial class PointRegistration : Form
    {
        public PointRegistration()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MONSTER\Documents\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void PointRegistration_Load(object sender, EventArgs e)
        {
            MainClass mainClass = new MainClass();
            mainClass.ListStudent(dataGridViev_studentList);
            PointList();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_studentId.Text==""| textBox_point.Text=="" | textBox_description.Text=="" | comboBox_course.Text=="")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO POINT VALUES("+textBox_studentId.Text+",'"+textBox_point.Text+"','"+comboBox_course.Text+"','"
                        +textBox_description.Text+"')";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Puan Başarıyla Eklendi.");
                    connection.Close();
                    PointList();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PointList()
        {
            connection.Open();
            string query = "SELECT * FROM POINT";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            dataGridView_point.DataSource = dataset.Tables[0];
            connection.Close();
        }

        

        private void button_reset_Click(object sender, EventArgs e)
        {
            CleanTextbox();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            PointList();
        }

        private void CleanTextbox()
        {
            textBox_studentId.Text = "";
            textBox_point.Text = "";
            comboBox_course.Text = "";
            textBox_description.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
