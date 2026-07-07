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
using Org.BouncyCastle.Asn1.Cmp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{

    public partial class Billing_Form : Form
    {
        string connStr = "server=localhost;user id=root;password=db1234;database=hospitalmanagementsystem;";


        public Billing_Form()
        {
            InitializeComponent();
            LoadBills();
        }

        private void LoadBills()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Billing", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBills.DataSource = dt;
            }
        }
        private void Billing_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string status;
            if (rbPaid.Checked)
                status = "Bill Paid.";
            else if (rbNotPaid.Checked)
                status = "Bill Not Paid";
            else
            {
                MessageBox.Show("Please select Payment status.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("AddBilling", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtPatientID.Text));
                cmd.Parameters.AddWithValue("bDate", dtpDate.Value);
                cmd.Parameters.AddWithValue("bAmount", Convert.ToDecimal(txtAmount.Text));
                cmd.Parameters.AddWithValue("bStatus", status);
                cmd.ExecuteNonQuery();
            }

            LoadBills();
            MessageBox.Show("Bill added.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SearchBilling", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("bID", Convert.ToInt32(txtBillID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBills.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status;
            if (rbPaid.Checked)
                status = "Bill Paid.";
            else if (rbNotPaid.Checked)
                status = "Bill Not Paid";
            else
            {
                MessageBox.Show("Please select Payment status.");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateBilling", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("bID", Convert.ToInt32(txtBillID.Text));
                cmd.Parameters.AddWithValue("pID", Convert.ToInt32(txtPatientID.Text));
                cmd.Parameters.AddWithValue("bDate", dtpDate.Value);
                cmd.Parameters.AddWithValue("bAmount", Convert.ToDecimal(txtAmount.Text));
                cmd.Parameters.AddWithValue("bStatus", status);
                cmd.ExecuteNonQuery();
            }
            LoadBills();
            MessageBox.Show("Bill updated.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteBilling", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("bID", Convert.ToInt32(txtBillID.Text));
                cmd.ExecuteNonQuery();
            }
            LoadBills();
            MessageBox.Show("Bill deleted.");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
