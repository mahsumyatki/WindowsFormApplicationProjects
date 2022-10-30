using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCourseManagementProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            PanelDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelDesign()
        {
            panel_studentMenu.Visible = false;
            panel_courseMenu.Visible = false;
            panel_pointMenu.Visible = false;
        }

        private void HideMenu()
        {
            if (panel_studentMenu.Visible==true)
            {
                panel_studentMenu.Visible = false;
            }
            if (panel_courseMenu.Visible == true)
            {
                panel_courseMenu.Visible = false;
            }
            if (panel_pointMenu.Visible == true)
            {
                panel_pointMenu.Visible = false;
            }
        }

        private void ShowMenu(Panel panel)
        {
            if (panel.Visible==false)
            {
                HideMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false; 
            }
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_studentMenu);
        }

        private void button_studentRegistration_Click(object sender, EventArgs e)
        {
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.Show();
            this.Hide();
        }

        private void button_studentManagement_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.Show();
            this.Hide();
        }

        private void button_studentContent_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_studentPrint_Click(object sender, EventArgs e)
        {
            StudentPrint studentPrint = new StudentPrint();
            studentPrint.Show();
            this.Hide();
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_courseMenu);
        }

        private void button_courseRegistration_Click(object sender, EventArgs e)
        {
            CourseRegistration courseRegistration = new CourseRegistration();
            courseRegistration.Show();
            this.Hide();
        }

        private void button_courseManagement_Click(object sender, EventArgs e)
        {
            CourseManagement courseManagement = new CourseManagement();
            courseManagement.Show();
            this.Hide();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            CoursePrint coursePrint = new CoursePrint();
            coursePrint.Show();
            this.Hide();
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_pointMenu);
        }

        private void button_pointRegistration_Click(object sender, EventArgs e)
        {
            PointRegistration pointRegistration = new PointRegistration();
            pointRegistration.Show();
            this.Hide();
        }

        private void button_pointManagement_Click(object sender, EventArgs e)
        {
            PointManagement pointManagement = new PointManagement();
            pointManagement.Show();
            this.Hide();
        }

        private void button_pointPrint_Click(object sender, EventArgs e)
        {
            PointPrint pointPrint = new PointPrint();
            pointPrint.Show();
            this.Hide();
        }

        private void button_signout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
