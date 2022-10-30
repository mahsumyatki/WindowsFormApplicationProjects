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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_user.Text==""|textBox_password.Text=="")
            {
                MessageBox.Show("Boş alan bırakmayınız..");
            }
            else if(textBox_user.Text=="Admin"&&textBox_password.Text=="1234")
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ve şifre ...");
            }
        }
    }
}
