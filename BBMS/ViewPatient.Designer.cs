
namespace BBMS
{
    partial class ViewPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PBGroupCb = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PAddressTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PGenderCb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PPhoneTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PAgeTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.PEditBtn = new System.Windows.Forms.Button();
            this.PDeleteBtn = new System.Windows.Forms.Button();
            this.PatientDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PBGroupCb
            // 
            this.PBGroupCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PBGroupCb.ForeColor = System.Drawing.Color.Red;
            this.PBGroupCb.FormattingEnabled = true;
            this.PBGroupCb.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.PBGroupCb.Location = new System.Drawing.Point(507, 255);
            this.PBGroupCb.Name = "PBGroupCb";
            this.PBGroupCb.Size = new System.Drawing.Size(191, 36);
            this.PBGroupCb.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(507, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 23);
            this.label16.TabIndex = 56;
            this.label16.Text = "Blood Group";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(714, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 23);
            this.label15.TabIndex = 55;
            this.label15.Text = "Address:";
            // 
            // PAddressTb
            // 
            this.PAddressTb.BackColor = System.Drawing.SystemColors.Window;
            this.PAddressTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PAddressTb.ForeColor = System.Drawing.Color.Red;
            this.PAddressTb.Location = new System.Drawing.Point(714, 255);
            this.PAddressTb.Multiline = true;
            this.PAddressTb.Name = "PAddressTb";
            this.PAddressTb.Size = new System.Drawing.Size(213, 36);
            this.PAddressTb.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(728, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 23);
            this.label14.TabIndex = 53;
            this.label14.Text = "Phone:";
            // 
            // PGenderCb
            // 
            this.PGenderCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PGenderCb.ForeColor = System.Drawing.Color.Red;
            this.PGenderCb.FormattingEnabled = true;
            this.PGenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PGenderCb.Location = new System.Drawing.Point(947, 170);
            this.PGenderCb.Name = "PGenderCb";
            this.PGenderCb.Size = new System.Drawing.Size(182, 36);
            this.PGenderCb.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(947, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 23);
            this.label13.TabIndex = 51;
            this.label13.Text = "Gender:";
            // 
            // PPhoneTb
            // 
            this.PPhoneTb.BackColor = System.Drawing.SystemColors.Window;
            this.PPhoneTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PPhoneTb.ForeColor = System.Drawing.Color.Red;
            this.PPhoneTb.Location = new System.Drawing.Point(728, 170);
            this.PPhoneTb.Name = "PPhoneTb";
            this.PPhoneTb.Size = new System.Drawing.Size(199, 34);
            this.PPhoneTb.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(507, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 23);
            this.label12.TabIndex = 49;
            this.label12.Text = "Age:";
            // 
            // PAgeTb
            // 
            this.PAgeTb.BackColor = System.Drawing.SystemColors.Window;
            this.PAgeTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PAgeTb.ForeColor = System.Drawing.Color.Red;
            this.PAgeTb.Location = new System.Drawing.Point(507, 170);
            this.PAgeTb.Name = "PAgeTb";
            this.PAgeTb.Size = new System.Drawing.Size(199, 34);
            this.PAgeTb.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(295, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 23);
            this.label11.TabIndex = 47;
            this.label11.Text = "Name:";
            // 
            // PNameTb
            // 
            this.PNameTb.BackColor = System.Drawing.SystemColors.Window;
            this.PNameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PNameTb.ForeColor = System.Drawing.Color.Red;
            this.PNameTb.Location = new System.Drawing.Point(295, 170);
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(196, 34);
            this.PNameTb.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(626, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 39);
            this.label1.TabIndex = 45;
            this.label1.Text = "Patients List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 74);
            this.panel2.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(189, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(447, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Blood Bank Management System";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(12, 337);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 47);
            this.panel4.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(79, 672);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 35);
            this.label9.TabIndex = 11;
            this.label9.Text = "Logout";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(50, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 35);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dashboard";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 35);
            this.label7.TabIndex = 7;
            this.label7.Text = "Blood Transfert";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Blood Stock";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Patient";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "View Donors";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "View Patients";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Donate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 734);
            this.panel1.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(50, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 35);
            this.label17.TabIndex = 12;
            this.label17.Text = "Donor";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // PEditBtn
            // 
            this.PEditBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.PEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.PEditBtn.FlatAppearance.BorderSize = 3;
            this.PEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PEditBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PEditBtn.ForeColor = System.Drawing.Color.White;
            this.PEditBtn.Location = new System.Drawing.Point(317, 303);
            this.PEditBtn.Name = "PEditBtn";
            this.PEditBtn.Size = new System.Drawing.Size(158, 50);
            this.PEditBtn.TabIndex = 60;
            this.PEditBtn.Text = "Edit";
            this.PEditBtn.UseVisualStyleBackColor = false;
            this.PEditBtn.Click += new System.EventHandler(this.PEditBtn_Click);
            // 
            // PDeleteBtn
            // 
            this.PDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.PDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.PDeleteBtn.FlatAppearance.BorderSize = 3;
            this.PDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.PDeleteBtn.Location = new System.Drawing.Point(957, 303);
            this.PDeleteBtn.Name = "PDeleteBtn";
            this.PDeleteBtn.Size = new System.Drawing.Size(158, 50);
            this.PDeleteBtn.TabIndex = 61;
            this.PDeleteBtn.Text = "Delete";
            this.PDeleteBtn.UseVisualStyleBackColor = false;
            this.PDeleteBtn.Click += new System.EventHandler(this.PDeleteBtn_Click);
            // 
            // PatientDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatientDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientDGV.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientDGV.EnableHeadersVisualStyles = false;
            this.PatientDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDGV.Location = new System.Drawing.Point(317, 378);
            this.PatientDGV.Name = "PatientDGV";
            this.PatientDGV.ReadOnly = true;
            this.PatientDGV.RowHeadersVisible = false;
            this.PatientDGV.RowHeadersWidth = 51;
            this.PatientDGV.RowTemplate.Height = 25;
            this.PatientDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientDGV.Size = new System.Drawing.Size(798, 297);
            this.PatientDGV.TabIndex = 62;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatientDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.PatientDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.PatientDGV.ThemeStyle.ReadOnly = true;
            this.PatientDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientDGV.ThemeStyle.RowsStyle.Height = 25;
            this.PatientDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.PatientDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PatientDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientDGV_CellContentClick);
            // 
            // ViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 734);
            this.Controls.Add(this.PatientDGV);
            this.Controls.Add(this.PDeleteBtn);
            this.Controls.Add(this.PEditBtn);
            this.Controls.Add(this.PBGroupCb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PAddressTb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PGenderCb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PPhoneTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PAgeTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPatient";
            this.Load += new System.EventHandler(this.ViewPatient_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PBGroupCb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PAddressTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox PGenderCb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PPhoneTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PAgeTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PEditBtn;
        private System.Windows.Forms.Button PDeleteBtn;
        private Guna.UI2.WinForms.Guna2DataGridView PatientDGV;
        private System.Windows.Forms.Label label17;
    }
}