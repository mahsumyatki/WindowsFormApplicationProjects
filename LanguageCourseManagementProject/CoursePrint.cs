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
    public partial class CoursePrint : Form
    {
        public CoursePrint()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MONSTER\Documents\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void CoursePrint_Load(object sender, EventArgs e)
        {
            ListCourse();
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

        private void button5_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(objBmp, 20, 150);
            e.Graphics.DrawString(label1.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            this.dataGridView1.Columns["COURSEID"].Visible = false;
        }
    }
}
