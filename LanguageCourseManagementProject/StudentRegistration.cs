using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LanguageCourseManagementProject
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration() 
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MONSTER\Documents\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void ListStudent()
        {
            connection.Open();
            string query = "SELECT * FROM STUDENT";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            dataGridView_student.DataSource = dataset.Tables[0];
            connection.Close();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox_studentImage.ImageLocation = openFileDialog1.FileName;
            textBox_studentImage.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_studentName.Text == "" || textBox_studentPhone.Text == "" || textBox_studentImage.Text == ""
                || comboBox_studentGender.Text == "" || textBox_studentAddress.Text == "")
            {
                MessageBox.Show("Eksik Bilgi...");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO STUDENT VALUES ('"
                         + textBox_studentName.Text + "','" +
                         textBox_studentPhone.Text + "','" +
                         dateTimePicker_studentBirthday.Text + "','" +
                         comboBox_studentGender.Text + "','" +
                         textBox_studentImage.Text + "','" +
                         textBox_studentAddress.Text + "')";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Eklendi.");
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

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            ListStudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CleanTextbox();
        }

        private void CleanTextbox()
        {
            textBox_studentName.Text = "";
            textBox_studentPhone.Text = "";
            textBox_studentImage.Text = "";
            comboBox_studentGender.Text = "";
            textBox_studentAddress.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
            
    }
}
