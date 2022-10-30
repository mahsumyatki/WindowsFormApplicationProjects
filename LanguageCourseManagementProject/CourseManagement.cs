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
    public partial class CourseManagement : Form
    {
        public CourseManagement()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MONSTER\Documents\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");
        int courseKey;
        private void label8_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
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

        private void CourseManagement_Load(object sender, EventArgs e)
        {
            ListCourse();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            CleanTextbox();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || textBox_hour.Text == "" || textBox_description.Text == "")
            {
                MessageBox.Show("Eksik Bilgi...");
            }
            else
            {
                try
                {
                    courseKey = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    connection.Open();
                    string query = "UPDATE COURSE SET COURSENAME='" + textBox_name.Text + "',COURSEHOUR='" + textBox_hour.Text +
                        "',COURSEDESCRIPTION='" + textBox_description.Text + "' WHERE COURSEID=" + courseKey;

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kurs Başarıyla Güncellendi.");
                    connection.Close();
                    ListCourse();
                    CleanTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || textBox_hour.Text == "" || textBox_description.Text == "")
            {
                MessageBox.Show("Silinecek kursu seçiniz...");
            }
            else
            {
                try
                {
                    courseKey = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    connection.Open();
                    string query = "DELETE FROM COURSE WHERE COURSEID=" + courseKey;

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kurs Başarıyla Silindi.");
                    connection.Close();
                    ListCourse();
                    CleanTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM COURSE WHERE COURSENAME like'%" + textBox_filter.Text + "%'", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            ListCourse();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            courseKey = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            textBox_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_hour.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox_description.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
