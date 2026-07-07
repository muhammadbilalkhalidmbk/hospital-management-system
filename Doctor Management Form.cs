using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace Hospital_Management_System
{
    public partial class Doctor_Management_Form : Form
    {
        string connStr = "server=localhost;user id=root;password=db1234;database=hospitalmanagementsystem;";
        public Doctor_Management_Form()
        {
            InitializeComponent();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Doctors", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoctors.DataSource = dt;
                dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDoctors.AutoGenerateColumns = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("AddDoctor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("dName", txtName.Text);
                cmd.Parameters.AddWithValue("dSpecialty", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("dContact", txtContact.Text);
                cmd.Parameters.AddWithValue("dGender", cmbGender.Text);
                cmd.ExecuteNonQuery();
            }
            LoadDoctors();
            MessageBox.Show("Doctor added.");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SearchDoctor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("dID", Convert.ToInt32(txtDoctorID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoctors.DataSource = dt;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateDoctor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("dID", Convert.ToInt32(txtDoctorID.Text));
                cmd.Parameters.AddWithValue("dName", txtName.Text);
                cmd.Parameters.AddWithValue("dSpecialty", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("dContact", txtContact.Text);
                cmd.Parameters.AddWithValue("dGender", cmbGender.Text);
                cmd.ExecuteNonQuery();
            }
            LoadDoctors();
            MessageBox.Show("Doctor updated.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteDoctor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("dID", Convert.ToInt32(txtDoctorID.Text));
                cmd.ExecuteNonQuery();
            }
            LoadDoctors();
            MessageBox.Show("Doctor deleted.");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
