namespace Patient_handling
{
    partial class form_ReceptionMenu2
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
            pnlSideMenu = new Panel();
            pnlDoctorSubmenu = new Panel();
            btnDoctorAdd = new Button();
            btnDoctorList = new Button();
            btnDoctor = new Button();
            pnlEmployeeSubmenu = new Panel();
            btnEmployeeAdd = new Button();
            btnEmployeeList = new Button();
            btnEmployee = new Button();
            pnlLogo = new Panel();
            btnMenu = new Button();
            pnlTitle = new Panel();
            labelTitle = new Label();
            panel1 = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlDoctorSubmenu.SuspendLayout();
            pnlEmployeeSubmenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.AutoScroll = true;
            pnlSideMenu.BackColor = Color.FromArgb(23, 35, 49);
            pnlSideMenu.Controls.Add(pnlDoctorSubmenu);
            pnlSideMenu.Controls.Add(btnDoctor);
            pnlSideMenu.Controls.Add(pnlEmployeeSubmenu);
            pnlSideMenu.Controls.Add(btnEmployee);
            pnlSideMenu.Controls.Add(pnlLogo);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(250, 617);
            pnlSideMenu.TabIndex = 1;
            // 
            // pnlDoctorSubmenu
            // 
            pnlDoctorSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlDoctorSubmenu.Controls.Add(btnDoctorAdd);
            pnlDoctorSubmenu.Controls.Add(btnDoctorList);
            pnlDoctorSubmenu.Dock = DockStyle.Top;
            pnlDoctorSubmenu.Location = new Point(0, 298);
            pnlDoctorSubmenu.Name = "pnlDoctorSubmenu";
            pnlDoctorSubmenu.Size = new Size(250, 81);
            pnlDoctorSubmenu.TabIndex = 4;
            // 
            // btnDoctorAdd
            // 
            btnDoctorAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnDoctorAdd.Dock = DockStyle.Top;
            btnDoctorAdd.FlatAppearance.BorderSize = 0;
            btnDoctorAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorAdd.FlatStyle = FlatStyle.Flat;
            btnDoctorAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoctorAdd.ForeColor = Color.WhiteSmoke;
            btnDoctorAdd.Location = new Point(0, 40);
            btnDoctorAdd.Name = "btnDoctorAdd";
            btnDoctorAdd.Padding = new Padding(35, 0, 0, 0);
            btnDoctorAdd.Size = new Size(250, 40);
            btnDoctorAdd.TabIndex = 1;
            btnDoctorAdd.Tag = "Add";
            btnDoctorAdd.Text = "Add";
            btnDoctorAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctorAdd.UseVisualStyleBackColor = false;
            // 
            // btnDoctorList
            // 
            btnDoctorList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnDoctorList.Dock = DockStyle.Top;
            btnDoctorList.FlatAppearance.BorderSize = 0;
            btnDoctorList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnDoctorList.FlatStyle = FlatStyle.Flat;
            btnDoctorList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoctorList.ForeColor = Color.WhiteSmoke;
            btnDoctorList.Location = new Point(0, 0);
            btnDoctorList.Name = "btnDoctorList";
            btnDoctorList.Padding = new Padding(35, 0, 0, 0);
            btnDoctorList.Size = new Size(250, 40);
            btnDoctorList.TabIndex = 0;
            btnDoctorList.Tag = "List";
            btnDoctorList.Text = "List";
            btnDoctorList.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctorList.UseVisualStyleBackColor = false;
            // 
            // btnDoctor
            // 
            btnDoctor.BackColor = Color.FromArgb(23, 35, 49);
            btnDoctor.Dock = DockStyle.Top;
            btnDoctor.FlatAppearance.BorderSize = 0;
            btnDoctor.FlatStyle = FlatStyle.Flat;
            btnDoctor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoctor.ForeColor = Color.WhiteSmoke;
            btnDoctor.Location = new Point(0, 253);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Padding = new Padding(10, 0, 0, 0);
            btnDoctor.Size = new Size(250, 45);
            btnDoctor.TabIndex = 3;
            btnDoctor.Tag = "Doctor’s specializations";
            btnDoctor.Text = "Medical Visit";
            btnDoctor.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctor.UseVisualStyleBackColor = false;
            // 
            // pnlEmployeeSubmenu
            // 
            pnlEmployeeSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlEmployeeSubmenu.Controls.Add(btnEmployeeAdd);
            pnlEmployeeSubmenu.Controls.Add(btnEmployeeList);
            pnlEmployeeSubmenu.Dock = DockStyle.Top;
            pnlEmployeeSubmenu.Location = new Point(0, 170);
            pnlEmployeeSubmenu.Name = "pnlEmployeeSubmenu";
            pnlEmployeeSubmenu.Size = new Size(250, 83);
            pnlEmployeeSubmenu.TabIndex = 2;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnEmployeeAdd.Dock = DockStyle.Top;
            btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            btnEmployeeAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeAdd.FlatStyle = FlatStyle.Flat;
            btnEmployeeAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeAdd.ForeColor = Color.WhiteSmoke;
            btnEmployeeAdd.Location = new Point(0, 40);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Padding = new Padding(35, 0, 0, 0);
            btnEmployeeAdd.Size = new Size(250, 43);
            btnEmployeeAdd.TabIndex = 1;
            btnEmployeeAdd.Tag = "Add";
            btnEmployeeAdd.Text = "Add";
            btnEmployeeAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeAdd.UseVisualStyleBackColor = false;
            btnEmployeeAdd.Click += btnEmployeeAdd_Click;
            // 
            // btnEmployeeList
            // 
            btnEmployeeList.BackColor = Color.FromArgb(0, 0, 0, 0);
            btnEmployeeList.Dock = DockStyle.Top;
            btnEmployeeList.FlatAppearance.BorderSize = 0;
            btnEmployeeList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeList.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            btnEmployeeList.FlatStyle = FlatStyle.Flat;
            btnEmployeeList.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeList.ForeColor = Color.WhiteSmoke;
            btnEmployeeList.Location = new Point(0, 0);
            btnEmployeeList.Name = "btnEmployeeList";
            btnEmployeeList.Padding = new Padding(35, 0, 0, 0);
            btnEmployeeList.Size = new Size(250, 40);
            btnEmployeeList.TabIndex = 0;
            btnEmployeeList.Tag = "List";
            btnEmployeeList.Text = "List";
            btnEmployeeList.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeList.UseVisualStyleBackColor = false;
            btnEmployeeList.Click += btnEmployeeList_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(23, 35, 49);
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.ForeColor = Color.WhiteSmoke;
            btnEmployee.Location = new Point(0, 125);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(10, 0, 0, 0);
            btnEmployee.Size = new Size(250, 45);
            btnEmployee.TabIndex = 1;
            btnEmployee.Tag = "Employee";
            btnEmployee.Text = "Patient";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(23, 35, 49);
            pnlLogo.Controls.Add(btnMenu);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 125);
            pnlLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(181, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(66, 53);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(23, 35, 49);
            pnlTitle.Controls.Add(labelTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(250, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(867, 125);
            pnlTitle.TabIndex = 2;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(103, 36);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(325, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Reception Menu";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(250, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 492);
            panel1.TabIndex = 3;
            // 
            // form_ReceptionMenu2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 617);
            Controls.Add(panel1);
            Controls.Add(pnlTitle);
            Controls.Add(pnlSideMenu);
            Name = "form_ReceptionMenu2";
            Text = "ReceptionMenu2";
            Load += ReceptionMenu2_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlDoctorSubmenu.ResumeLayout(false);
            pnlEmployeeSubmenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Button btnDoctor;
        private Panel pnlEmployeeSubmenu;
        private Button btnEmployeeAdd;
        private Button btnEmployeeList;
        private Button btnEmployee;
        private Panel pnlLogo;
        private Button btnMenu;
        private Panel pnlTitle;
        private Label labelTitle;
        private Panel pnlDoctorSubmenu;
        private Button btnDoctorAdd;
        private Button btnDoctorList;
        public Panel panel1;
    }
}