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
            HideMenu();
        }

        private void button_studentManagement_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_studentContent_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_studentPrint_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_courseMenu);
        }

        private void button_courseRegistration_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_courseManagement_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_pointMenu);
        }

        private void button_pointRegistration_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_pointManagement_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_pointPrint_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
