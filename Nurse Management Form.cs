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
    public partial class Nurse_Management_Form : Form
    {
        string connStr = "server=localhost;user id=root;password=db1234;database=hospitalmanagementsystem;";
        public Nurse_Management_Form()
        {
            InitializeComponent();
            LoadNurses();
        }

        private void LoadNurses()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Nurses", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNurses.DataSource = dt;
            }
        }
        private void Nurse_Management_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string shift = "";

            if (chkMorning.Checked)
                shift = "Morning";
            else if (chkEvening.Checked)
                shift = "Evening";
            else
            {
                MessageBox.Show("Please select a shift.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("AddNurse", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nName", txtName.Text);
                cmd.Parameters.AddWithValue("nDept", txtDepartment.Text);
                cmd.Parameters.AddWithValue("nShift", shift);
                cmd.Parameters.AddWithValue("nContact", txtContact.Text);
                cmd.ExecuteNonQuery();
            }
            LoadNurses();
            MessageBox.Show("Nurse added.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string shift = "";

            if (chkMorning.Checked)
                shift = "Morning";
            else if (chkEvening.Checked)
                shift = "Evening";
            else
            {
                MessageBox.Show("Please select a shift.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateNurse", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nID", Convert.ToInt32(txtNurseID.Text));
                cmd.Parameters.AddWithValue("nName", txtName.Text);
                cmd.Parameters.AddWithValue("nDept", txtDepartment.Text);
                cmd.Parameters.AddWithValue("nShift", shift);
                cmd.Parameters.AddWithValue("nContact", txtContact.Text);
                cmd.ExecuteNonQuery();
            }
            LoadNurses();
            MessageBox.Show("Nurse updated.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SearchNurse", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nID", Convert.ToInt32(txtNurseID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNurses.DataSource = dt;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteNurse", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nID", Convert.ToInt32(txtNurseID.Text));
                cmd.ExecuteNonQuery();
            }
            LoadNurses();
            MessageBox.Show("Nurse deleted.");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
