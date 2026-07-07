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
    public partial class PatientForm : Form
    {
        string connStr = "server=localhost;user id=root;password=db1234;database=hospitalmanagementsystem;";
        public PatientForm()
        {
            InitializeComponent();
            LoadPatients();

        }

        private void LoadPatients()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Patients", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                dgvPatients.DataSource = dt;

                dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPatients.AutoGenerateColumns = true;

            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("AddPatient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pName", txtName.Text);
                cmd.Parameters.AddWithValue("pAge", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("pGender", cmbGender.Text);
                cmd.Parameters.AddWithValue("pContact", txtContact.Text);
                cmd.ExecuteNonQuery();
            }
            LoadPatients();
            MessageBox.Show("Patient added successfully.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SearchPatient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtPatientID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPatients.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdatePatient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtPatientID.Text));
                cmd.Parameters.AddWithValue("pName", txtName.Text);
                cmd.Parameters.AddWithValue("pAge", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("pGender", cmbGender.Text);
                cmd.Parameters.AddWithValue("pContact", txtContact.Text);
                cmd.ExecuteNonQuery();
            }
            LoadPatients();
            MessageBox.Show("Patient updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeletePatient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtPatientID.Text));
                cmd.ExecuteNonQuery();
            }
            LoadPatients();
            MessageBox.Show("Patient deleted successfully.");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
