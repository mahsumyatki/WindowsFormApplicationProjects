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
    public partial class PointManagement : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MONSTER\Documents\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");
        int pointKey;

        public PointManagement()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void PointList()
        {
            connection.Open();
            string query = "SELECT * FROM POINT";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            dataGridView_pointList.DataSource = dataset.Tables[0];
            connection.Close();
        }

        private void PointManagement_Load(object sender, EventArgs e)
        {
            PointList();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_studentId.Text == "" || textBox_point.Text == "" || textBox_description.Text == "" || comboBox_course.Text == "")
            {
                MessageBox.Show("Silinecek puanı seçiniz...");
            }
            else
            {
                try
                {
                    pointKey = Convert.ToInt32(dataGridView_pointList.SelectedRows[0].Cells[0].Value.ToString());
                    connection.Open();
                    string query = "DELETE FROM POINT WHERE POINTID=" + pointKey;

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Puan Başarıyla Silindi.");
                    connection.Close();
                    PointList();
                    CleanTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void CleanTextbox()
        {
            textBox_studentId.Text = "";
            textBox_point.Text = "";
            comboBox_course.Text = "";
            textBox_description.Text = "";
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_studentId.Text == "" || textBox_point.Text == "" || textBox_description.Text == "" || comboBox_course.Text == "")
            {
                MessageBox.Show("Eksik Bilgi...");
            }
            else
            {
                try
                {
                    pointKey = Convert.ToInt32(dataGridView_pointList.SelectedRows[0].Cells[0].Value.ToString());
                    connection.Open();
                    string query = "UPDATE POINT SET STUDENTID=" + textBox_studentId.Text + ",POINT='" + textBox_point.Text +
                        "', COURSE='" + comboBox_course.Text + "', POINTDESCRIPTION='" + textBox_description.Text + "' WHERE POINTID=" + pointKey;

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Puan Başarıyla Güncellendi.");
                    connection.Close();
                    PointList();
                    CleanTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            CleanTextbox();
        }

        private void dataGridView_pointList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pointKey = Convert.ToInt32(dataGridView_pointList.SelectedRows[0].Cells[0].Value.ToString());

            textBox_studentId.Text = dataGridView_pointList.SelectedRows[0].Cells[1].Value.ToString();
            textBox_point.Text = dataGridView_pointList.SelectedRows[0].Cells[2].Value.ToString();
            comboBox_course.Text = dataGridView_pointList.SelectedRows[0].Cells[3].Value.ToString();
            textBox_description.Text = dataGridView_pointList.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            PointList();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM POINT WHERE POINT like'%" + textBox_filter.Text + "%'", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView_pointList.DataSource = dataSet.Tables[0];
            connection.Close();
        }
    }
}
