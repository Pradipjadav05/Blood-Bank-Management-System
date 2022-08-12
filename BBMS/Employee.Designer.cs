
namespace BBMS
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmpEditBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.EmpPassTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpSaveBtn = new System.Windows.Forms.Button();
            this.EmpDeleteBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.EmployeeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 734);
            this.panel1.TabIndex = 49;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 47);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.BackColor = System.Drawing.SystemColors.Window;
            this.EmpNameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmpNameTb.ForeColor = System.Drawing.Color.Red;
            this.EmpNameTb.Location = new System.Drawing.Point(387, 573);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(224, 34);
            this.EmpNameTb.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(715, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // EmpEditBtn
            // 
            this.EmpEditBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.EmpEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.EmpEditBtn.FlatAppearance.BorderSize = 3;
            this.EmpEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpEditBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpEditBtn.ForeColor = System.Drawing.Color.White;
            this.EmpEditBtn.Location = new System.Drawing.Point(644, 647);
            this.EmpEditBtn.Name = "EmpEditBtn";
            this.EmpEditBtn.Size = new System.Drawing.Size(158, 50);
            this.EmpEditBtn.TabIndex = 56;
            this.EmpEditBtn.Text = "Edit";
            this.EmpEditBtn.UseVisualStyleBackColor = false;
            this.EmpEditBtn.Click += new System.EventHandler(this.EmpEditBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(827, 547);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 23);
            this.label14.TabIndex = 55;
            this.label14.Text = "Password:";
            // 
            // EmpPassTb
            // 
            this.EmpPassTb.BackColor = System.Drawing.SystemColors.Window;
            this.EmpPassTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmpPassTb.ForeColor = System.Drawing.Color.Red;
            this.EmpPassTb.Location = new System.Drawing.Point(827, 573);
            this.EmpPassTb.Name = "EmpPassTb";
            this.EmpPassTb.Size = new System.Drawing.Size(224, 34);
            this.EmpPassTb.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(387, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 23);
            this.label11.TabIndex = 53;
            this.label11.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(632, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 50;
            this.label1.Text = "Employees";
            // 
            // EmpSaveBtn
            // 
            this.EmpSaveBtn.BackColor = System.Drawing.Color.MediumVioletRed;
            this.EmpSaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.EmpSaveBtn.FlatAppearance.BorderSize = 3;
            this.EmpSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpSaveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpSaveBtn.ForeColor = System.Drawing.Color.White;
            this.EmpSaveBtn.Location = new System.Drawing.Point(387, 647);
            this.EmpSaveBtn.Name = "EmpSaveBtn";
            this.EmpSaveBtn.Size = new System.Drawing.Size(158, 50);
            this.EmpSaveBtn.TabIndex = 59;
            this.EmpSaveBtn.Text = "Save";
            this.EmpSaveBtn.UseVisualStyleBackColor = false;
            this.EmpSaveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpDeleteBtn
            // 
            this.EmpDeleteBtn.BackColor = System.Drawing.Color.Red;
            this.EmpDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.EmpDeleteBtn.FlatAppearance.BorderSize = 3;
            this.EmpDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpDeleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.EmpDeleteBtn.Location = new System.Drawing.Point(893, 647);
            this.EmpDeleteBtn.Name = "EmpDeleteBtn";
            this.EmpDeleteBtn.Size = new System.Drawing.Size(158, 50);
            this.EmpDeleteBtn.TabIndex = 60;
            this.EmpDeleteBtn.Text = "Delete";
            this.EmpDeleteBtn.UseVisualStyleBackColor = false;
            this.EmpDeleteBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 74);
            this.panel2.TabIndex = 61;
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
            // EmployeeDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDGV.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDGV.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeDGV.EnableHeadersVisualStyles = false;
            this.EmployeeDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.Location = new System.Drawing.Point(387, 180);
            this.EmployeeDGV.Name = "EmployeeDGV";
            this.EmployeeDGV.ReadOnly = true;
            this.EmployeeDGV.RowHeadersVisible = false;
            this.EmployeeDGV.RowHeadersWidth = 51;
            this.EmployeeDGV.RowTemplate.Height = 25;
            this.EmployeeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDGV.Size = new System.Drawing.Size(664, 329);
            this.EmployeeDGV.TabIndex = 49;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.EmployeeDGV.ThemeStyle.ReadOnly = true;
            this.EmployeeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDGV.ThemeStyle.RowsStyle.Height = 25;
            this.EmployeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.EmployeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDGV_CellContentClick_1);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 734);
            this.Controls.Add(this.EmployeeDGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EmpDeleteBtn);
            this.Controls.Add(this.EmpSaveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmpEditBtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.EmpPassTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EmpEditBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox EmpPassTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmpSaveBtn;
        private System.Windows.Forms.Button EmpDeleteBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeDGV;
    }
}