namespace Hospital_Management_System
{
    partial class Billing_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing_Form));
            label7 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            dtpDate = new DateTimePicker();
            txtPatientID = new TextBox();
            txtAmount = new NumericUpDown();
            rbNotPaid = new RadioButton();
            rbPaid = new RadioButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            bPaymentStatus = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBillID = new TextBox();
            dgvBills = new DataGridView();
            backbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAmount).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = SystemColors.AppWorkspace;
            label7.CausesValidation = false;
            label7.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            label7.Location = new Point(308, 9);
            label7.Name = "label7";
            label7.Size = new Size(147, 31);
            label7.TabIndex = 34;
            label7.Text = "Billing Form";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(txtPatientID);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(rbNotPaid);
            panel1.Controls.Add(rbPaid);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(bPaymentStatus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBillID);
            panel1.Location = new Point(12, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 278);
            panel1.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 89);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 54;
            label5.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(169, 89);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(272, 27);
            dtpDate.TabIndex = 53;
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(510, 18);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(125, 27);
            txtPatientID.TabIndex = 52;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(173, 146);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 27);
            txtAmount.TabIndex = 51;
            // 
            // rbNotPaid
            // 
            rbNotPaid.AutoSize = true;
            rbNotPaid.Location = new Point(647, 151);
            rbNotPaid.Name = "rbNotPaid";
            rbNotPaid.Size = new Size(84, 24);
            rbNotPaid.TabIndex = 50;
            rbNotPaid.Text = "not Paid";
            rbNotPaid.UseVisualStyleBackColor = true;
            // 
            // rbPaid
            // 
            rbPaid.AutoSize = true;
            rbPaid.Checked = true;
            rbPaid.Location = new Point(557, 153);
            rbPaid.Name = "rbPaid";
            rbPaid.Size = new Size(62, 24);
            rbPaid.TabIndex = 49;
            rbPaid.TabStop = true;
            rbPaid.Text = "Paid ";
            rbPaid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 148);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 45;
            label1.Text = "Total Amount";
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
            groupBox1.Location = new Point(25, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 78);
            groupBox1.TabIndex = 43;
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
            // bPaymentStatus
            // 
            bPaymentStatus.AutoSize = true;
            bPaymentStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bPaymentStatus.Location = new Point(409, 153);
            bPaymentStatus.Name = "bPaymentStatus";
            bPaymentStatus.Size = new Size(118, 20);
            bPaymentStatus.TabIndex = 38;
            bPaymentStatus.Text = "Payment status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(385, 21);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 37;
            label3.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 17);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 36;
            label2.Text = "Bill ID";
            // 
            // txtBillID
            // 
            txtBillID.Location = new Point(173, 14);
            txtBillID.Name = "txtBillID";
            txtBillID.Size = new Size(125, 27);
            txtBillID.TabIndex = 35;
            // 
            // dgvBills
            // 
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Location = new Point(58, 359);
            dgvBills.Name = "dgvBills";
            dgvBills.RowHeadersWidth = 51;
            dgvBills.Size = new Size(670, 128);
            dgvBills.TabIndex = 52;
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.AppWorkspace;
            backbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(12, 9);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(54, 31);
            backbtn.TabIndex = 53;
            backbtn.Text = "<--";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // Billing_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(backbtn);
            Controls.Add(dgvBills);
            Controls.Add(panel1);
            Controls.Add(label7);
            Name = "Billing_Form";
            Text = "Billing_Form";
            Load += Billing_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAmount).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private NumericUpDown txtAmount;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnAdd;
        private Label bPaymentStatus;
        private Label label3;
        private Label label2;
        private TextBox txtBillID;
        private DataGridView dgvBills;
        private TextBox txtPatientID;
        private DateTimePicker dtpDate;
        private RadioButton rbNotPaid;
        private RadioButton rbPaid;
        private Label label5;
        private Button backbtn;
    }
}