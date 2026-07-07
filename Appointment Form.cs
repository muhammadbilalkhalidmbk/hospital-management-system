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
    public partial class Appointment_Form : Form
    {
        string connStr = "server=localhost;user id=root;password=db1234;database=hospitalmanagementsystem;";
        public Appointment_Form()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter dp = new MySqlDataAdapter("SELECT * FROM Appointments", conn);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dgvAppointments.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("AddAppointment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtPatientID.Text));
                cmd.Parameters.AddWithValue("dID", Convert.ToInt32(txtDoctorID.Text));
                cmd.Parameters.AddWithValue("aDate", dtpDate.Value);
                cmd.Parameters.AddWithValue("aTime", DateTime.Parse(txtTime.Text).ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("aPurpose", txtPurpose.Text);

                cmd.ExecuteNonQuery();
            }
            LoadAppointments();
            MessageBox.Show("Appointment added.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SearchAppointment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtAppointmentID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAppointments.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateAppointment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtPatientID.Text));
                cmd.Parameters.AddWithValue("dID", Convert.ToInt32(txtDoctorID.Text));
                cmd.Parameters.AddWithValue("aDate", dtpDate.Value);
                cmd.Parameters.AddWithValue("aTime", DateTime.Parse(txtTime.Text).ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("aPurpose", txtPurpose.Text);

                cmd.ExecuteNonQuery();
            }
            LoadAppointments();
            MessageBox.Show("Appointment updated.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteAppointment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtAppointmentID.Text));
                cmd.ExecuteNonQuery();
            }
            LoadAppointments();
            MessageBox.Show("Appointment deleted.");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();


        }
    }
}
