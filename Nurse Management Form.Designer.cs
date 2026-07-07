namespace Hospital_Management_System
{
    partial class Nurse_Management_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse_Management_Form));
            dgvNurses = new DataGridView();
            label7 = new Label();
            panel1 = new Panel();
            txtContact = new TextBox();
            chkEvening = new CheckBox();
            chkMorning = new CheckBox();
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
            txtDepartment = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNurseID = new TextBox();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNurses).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvNurses
            // 
            dgvNurses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNurses.Location = new Point(54, 360);
            dgvNurses.Name = "dgvNurses";
            dgvNurses.RowHeadersWidth = 51;
            dgvNurses.Size = new Size(675, 128);
            dgvNurses.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.AppWorkspace;
            label7.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold);
            label7.Location = new Point(267, 21);
            label7.Name = "label7";
            label7.Size = new Size(293, 31);
            label7.TabIndex = 36;
            label7.Text = "Nurse Management  Form";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(chkEvening);
            panel1.Controls.Add(chkMorning);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtDepartment);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNurseID);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 277);
            panel1.TabIndex = 35;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(173, 151);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(306, 27);
            txtContact.TabIndex = 47;
            // 
            // chkEvening
            // 
            chkEvening.AutoSize = true;
            chkEvening.Location = new Point(596, 90);
            chkEvening.Name = "chkEvening";
            chkEvening.Size = new Size(83, 24);
            chkEvening.TabIndex = 46;
            chkEvening.Text = "Evening";
            chkEvening.UseVisualStyleBackColor = true;
            // 
            // chkMorning
            // 
            chkMorning.AutoSize = true;
            chkMorning.Location = new Point(479, 90);
            chkMorning.Name = "chkMorning";
            chkMorning.Size = new Size(87, 24);
            chkMorning.TabIndex = 45;
            chkMorning.Text = "Morning";
            chkMorning.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 90);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 44;
            label1.Text = "Shift";
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
            groupBox1.Location = new Point(25, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 78);
            groupBox1.TabIndex = 42;
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
            // txtDepartment
            // 
            txtDepartment.Location = new Point(173, 83);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(125, 27);
            txtDepartment.TabIndex = 41;
            // 
            // txtName
            // 
            txtName.Location = new Point(479, 13);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 154);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 39;
            label5.Text = "Contact Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 90);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 38;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(385, 20);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 37;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 20);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 36;
            label2.Text = "Nurse ID";
            // 
            // txtNurseID
            // 
            txtNurseID.Location = new Point(173, 13);
            txtNurseID.Name = "txtNurseID";
            txtNurseID.RightToLeft = RightToLeft.No;
            txtNurseID.Size = new Size(125, 27);
            txtNurseID.TabIndex = 35;
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.AppWorkspace;
            backbtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(12, 22);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(54, 31);
            backbtn.TabIndex = 35;
            backbtn.Text = "<--";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // Nurse_Management_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(backbtn);
            Controls.Add(dgvNurses);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "Nurse_Management_Form";
            Text = "Nurse_Management_Form";
            Load += Nurse_Management_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNurses).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNurses;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private Label label7;
        private Panel panel1;
        private TextBox txtContact;
        private CheckBox chkEvening;
        private CheckBox checkBox2;
        private CheckBox chkMorning;
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
        private TextBox txtDepartment;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNurseID;
        private Button backbtn;
    }
}