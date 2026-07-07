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
    public partial class Room_Management_Form : Form
    {
        string connStr = "server=localhost;user id=root;password=db1234;database=hospitalmanagementsystem;";
        public Room_Management_Form()
        {
            InitializeComponent();
            LoadRooms();
        }

        private void LoadRooms()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Rooms", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRooms.DataSource = dt;
            }
        }


        private void Room_Management_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string availability;
            if (rbAvailable.Checked)
                availability = "Available";
            else if (rbNotAvailable.Checked)
                availability = "Not Available";
            else
            {
                MessageBox.Show("Please select availability status.");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("AddRoom", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("rType", cmbType.Text);
                cmd.Parameters.AddWithValue("rAvailability", availability);

                cmd.Parameters.AddWithValue("rCharges", Convert.ToDecimal(txtCharges.Text));
                cmd.ExecuteNonQuery();
            }
            LoadRooms();
            MessageBox.Show("Room added.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SearchRoom", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("rID", Convert.ToInt32(txtRoomID.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRooms.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string availability;
            if (rbAvailable.Checked)
                availability = "Available";
            else if (rbNotAvailable.Checked)
                availability = "Not Available";
            else
            {
                MessageBox.Show("Please select availability status.");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UpdateRoom", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("rID", Convert.ToInt32(txtRoomID.Text));
                cmd.Parameters.AddWithValue("rType", cmbType.Text);

                cmd.Parameters.AddWithValue("rAvailability", availability);

                cmd.Parameters.AddWithValue("rCharges", Convert.ToDecimal(txtCharges.Text));
                cmd.ExecuteNonQuery();
            }
            LoadRooms();
            MessageBox.Show("Room updated.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteRoom", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("rID", Convert.ToInt32(txtRoomID.Text));
                cmd.ExecuteNonQuery();
            }
            LoadRooms();
            MessageBox.Show("Room deleted.");
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
