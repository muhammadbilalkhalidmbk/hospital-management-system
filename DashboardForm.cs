namespace Hospital_Management_System
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientForm pf = new PatientForm();
            pf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor_Management_Form df = new Doctor_Management_Form();
            df.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment_Form af = new Appointment_Form();
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room_Management_Form room_Management_Form = new Room_Management_Form();
            room_Management_Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing_Form billing_Form = new Billing_Form();
            billing_Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medical_Record_Form medical_Record_Form = new Medical_Record_Form();
            medical_Record_Form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nurse_Management_Form nurse_Management_Forms = new Nurse_Management_Form();
            nurse_Management_Forms.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            General__Search_Form general__Search_Form = new General__Search_Form();
            general__Search_Form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
