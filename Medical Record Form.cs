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
    public partial class Medical_Record_Form : Form
    {
        string connStr = "server=localhost;user id=root;password=db1234;database=hospitalmanagementsystem;";

        public Medical_Record_Form()
        {
            InitializeComponent();
            LoadRecords();

        }

        private void LoadRecords()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM MedicalRecords", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMedicalRecords.DataSource = dt;
            }
        }

        private void Medical_Record_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("AddMedicalRecord", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtPatientID.Text));
                cmd.Parameters.AddWithValue("mDiagnosis", txtDiagnosis.Text);
                cmd.Parameters.AddWithValue("mTreatment", txtTreatment.Text);
                cmd.Parameters.AddWithValue("mDate", dtpDate.Value);
                cmd.ExecuteNonQuery();
            }
            LoadRecords();
            MessageBox.Show("Medical record added.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SearchMedicalRecord", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("mID", Convert.ToInt32(txtRecordID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMedicalRecords.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateMedicalRecord", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("mID", Convert.ToInt32(txtRecordID.Text));
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtPatientID.Text));
                cmd.Parameters.AddWithValue("mDiagnosis", txtDiagnosis.Text);
                cmd.Parameters.AddWithValue("mTreatment", txtTreatment.Text);
                cmd.Parameters.AddWithValue("mDate", dtpDate.Value);
                cmd.ExecuteNonQuery();
            }
            LoadRecords();
            MessageBox.Show("Medical record updated.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteMedicalRecord", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("mID", Convert.ToInt32(txtRecordID.Text));
                cmd.ExecuteNonQuery();
            }
            LoadRecords();
            MessageBox.Show("Medical record deleted.");

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
