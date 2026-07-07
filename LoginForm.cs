using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "123")
            {
                this.Hide(); // hide login form

                DashboardForm dashboard = new DashboardForm(); // or Dashboard
                dashboard.Show();
            }

            else
            {
                MessageBox.Show("Invalid login credentials.", "Login Failed");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
