namespace Hospital_Management_System
{
    partial class Appointment_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment_Form));
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            txtDoctorID = new TextBox();
            txtPatientID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtAppointmentID = new TextBox();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            txtPurpose = new TextBox();
            label7 = new Label();
            dgvAppointments = new DataGridView();
            txtTime = new DateTimePicker();
            backbtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(55, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 78);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(562, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(384, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(199, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(591, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 38);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(417, 28);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 37);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(228, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 38);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(70, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 39);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new Point(203, 170);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new Size(125, 27);
            txtDoctorID.TabIndex = 24;
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(509, 100);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(125, 27);
            txtPatientID.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 246);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 22;
            label6.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(415, 246);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 21;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 177);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 20;
            label4.Text = "Doctor ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(415, 107);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 19;
            label3.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 107);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 18;
            label2.Text = "Appointment ID";
            // 
            // txtAppointmentID
            // 
            txtAppointmentID.Location = new Point(203, 100);
            txtAppointmentID.Name = "txtAppointmentID";
            txtAppointmentID.Size = new Size(125, 27);
            txtAppointmentID.TabIndex = 17;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(509, 241);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(272, 27);
            dtpDate.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(415, 177);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 30;
            label1.Text = "Purpose";
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(509, 174);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(125, 27);
            txtPurpose.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.AppWorkspace;
            label7.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            label7.Location = new Point(231, 9);
            label7.Name = "label7";
            label7.Size = new Size(368, 31);
            label7.TabIndex = 32;
            label7.Text = "Appointment Management Form";
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(55, 356);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new Size(772, 128);
            dgvAppointments.TabIndex = 33;
            // 
            // txtTime
            // 
            txtTime.Format = DateTimePickerFormat.Time;
            txtTime.Location = new Point(203, 239);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(125, 27);
            txtTime.TabIndex = 34;
            txtTime.Value = new DateTime(2025, 4, 5, 13, 11, 32, 0);
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.AppWorkspace;
            backbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(12, 12);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(54, 31);
            backbtn.TabIndex = 35;
            backbtn.Text = "<--";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // Appointment_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(839, 450);
            Controls.Add(backbtn);
            Controls.Add(txtTime);
            Controls.Add(dgvAppointments);
            Controls.Add(label7);
            Controls.Add(txtPurpose);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Controls.Add(groupBox1);
            Controls.Add(txtDoctorID);
            Controls.Add(txtPatientID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAppointmentID);
            Name = "Appointment_Form";
            Text = "Appointment_Form";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnAdd;
        private TextBox txtDoctorID;
        private TextBox txtPatientID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtAppointmentID;
        private DateTimePicker dtpDate;
        private Label label1;
        private TextBox txtPurpose;
        private Label label7;
        private DataGridView dgvAppointments;
        private DateTimePicker txtTime;
        private Button backbtn;
    }
}