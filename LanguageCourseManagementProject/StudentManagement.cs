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
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MONSTER\Documents\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            ListStudent();
        }

        int studentKey;

        private void ListStudent()
        {
            connection.Open();
            string query = "SELECT * FROM STUDENT";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            dataGridView_studentList.DataSource = dataset.Tables[0];
            connection.Close();
        }

        private void CleanTextbox()
        {
            textBox_nameSurname.Text = "";
            textBox_phone.Text = "";
            textBox_address.Text = "";
            comboBox_gender.Text = "";
            textBox_image.Text = "";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_nameSurname.Text == "" || textBox_phone.Text == "" || textBox_image.Text == ""
                || comboBox_gender.Text == "" || textBox_address.Text == "")
            {
                MessageBox.Show("Silinecek öğrenciyi seçiniz...");
            }
            else
            {
                try
                {
                    studentKey = Convert.ToInt32(dataGridView_studentList.SelectedRows[0].Cells[0].Value.ToString());
                    connection.Open();
                    string query = "DELETE FROM STUDENT WHERE StudentId=" +studentKey;

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Silindi.");
                    connection.Close();
                    ListStudent();
                    CleanTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void dataGridView_studentList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentKey = Convert.ToInt32(dataGridView_studentList.SelectedRows[0].Cells[0].Value.ToString());

            textBox_nameSurname.Text = dataGridView_studentList.SelectedRows[0].Cells[1].Value.ToString();
            textBox_phone.Text = dataGridView_studentList.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker_birthday.Text = dataGridView_studentList.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_gender.Text = dataGridView_studentList.SelectedRows[0].Cells[4].Value.ToString();
            textBox_image.Text = dataGridView_studentList.SelectedRows[0].Cells[5].Value.ToString();
            textBox_address.Text = dataGridView_studentList.SelectedRows[0].Cells[6].Value.ToString();

            pictureBox_image.ImageLocation = dataGridView_studentList.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_nameSurname.Text == "" || textBox_phone.Text == "" || textBox_image.Text == ""
                || comboBox_gender.Text == "" || textBox_address.Text == "")
            {
                MessageBox.Show("Eksik Bilgi..");
            }
            else
            {
                try
                {
                    studentKey = Convert.ToInt32(dataGridView_studentList.SelectedRows[0].Cells[0].Value.ToString());
                    connection.Open();
                    string query = "UPDATE STUDENT SET NameSurname='"+textBox_nameSurname.Text+"',Phone='"+textBox_phone.Text+
                        "',DateOfBirth='"+dateTimePicker_birthday.Text+"',Gender='"+comboBox_gender.Text+"',Image='"+textBox_image.Text+
                        "',Address='"+textBox_address.Text+"' WHERE StudentId="+studentKey;

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Güncellendi.");
                    connection.Close();
                    ListStudent();
                    CleanTextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            CleanTextbox();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM STUDENT WHERE NameSurname like'%"+textBox_filter.Text+"%'",connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView_studentList.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            ListStudent();
        }
    }
}
