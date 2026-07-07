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
    public partial class General__Search_Form : Form
    {
        string connStr = "server=localhost;user id=root;password=db1234;database=hospitalmanagementsystem;";
        public General__Search_Form()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[]
 {
    "patients",
    "doctors",
    "appointments",
    "rooms",
    "billing",
    "medicalrecords",
    "nurses"
 });


            comboBox1.SelectedIndex = 0;
        }

        private void General__Search_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tableName = comboBox1.SelectedItem.ToString();
            string keyword = txtSearch.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string columns = GetSearchableColumns(tableName);
                if (string.IsNullOrEmpty(columns))
                {
                    MessageBox.Show("Invalid table or no columns to search!");
                    return;  // stop the search here
                }

                string query = $"SELECT * FROM {tableName} WHERE CONCAT_WS('', {columns}) LIKE @keyword";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResults.DataSource = dt;
            }



        }
        private string GetSearchableColumns(string table)
        {
            switch (table)
            {
                case "patients": return "PatientID, Name, Gender, ContactNumber";
                case "doctors": return "DoctorID, Name, Specialty, ContactNumber";
                case "appointments": return "AppointmentID, PatientID, DoctorID, Purpose";
                case "rooms": return "RoomID, RoomType, Availability";
                case "billing": return "BillID, PatientID, PaymentStatus";
                case "medicalrecords": return "RecordID, Diagnosis, Treatment";
                case "nurses": return "NurseID, Name, Department, Shift";
                default: return "";
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
