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
    public partial class PointPrint : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MONSTER\Documents\CourseDb.mdf;Integrated Security=True;Connect Timeout=30");
        public PointPrint()
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

        private void button_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PointPrint_Load(object sender, EventArgs e)
        {
            PointList();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView_pointList.Width, this.dataGridView_pointList.Height);
            dataGridView_pointList.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView_pointList.Width, this.dataGridView_pointList.Height));
            e.Graphics.DrawImage(objBmp, 20, 150);
            e.Graphics.DrawString(label1.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            this.dataGridView_pointList.Columns["POINTID"].Visible = false;
        }
    }
}
