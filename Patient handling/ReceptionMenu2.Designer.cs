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
            panel2 = new Panel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            pnlEmployeeSubmenu = new Panel();
            panel3 = new Panel();
            button4 = new Button();
            button5 = new Button();
            btnEmployeeAdd = new Button();
            btnEmployeeList = new Button();
            btnEmployee = new Button();
            pnlLogo = new Panel();
            btnMenu = new Button();
            pnlTitle = new Panel();
            labelTitle = new Label();
            panel1 = new Panel();
            pnlSideMenu.SuspendLayout();
            panel2.SuspendLayout();
            pnlEmployeeSubmenu.SuspendLayout();
            panel3.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.AutoScroll = true;
            pnlSideMenu.BackColor = Color.FromArgb(23, 35, 49);
            pnlSideMenu.Controls.Add(panel2);
            pnlSideMenu.Controls.Add(button2);
            pnlSideMenu.Controls.Add(pnlEmployeeSubmenu);
            pnlSideMenu.Controls.Add(btnEmployee);
            pnlSideMenu.Controls.Add(pnlLogo);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 0);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(250, 617);
            pnlSideMenu.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 47, 66);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 79);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 0, 0);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(0, 40);
            button1.Name = "button1";
            button1.Padding = new Padding(35, 0, 0, 0);
            button1.Size = new Size(250, 40);
            button1.TabIndex = 1;
            button1.Tag = "Add";
            button1.Text = "Add";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 0, 0);
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(250, 40);
            button3.TabIndex = 0;
            button3.Tag = "List";
            button3.Text = "List";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 35, 49);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(0, 291);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(250, 45);
            button2.TabIndex = 3;
            button2.Tag = "Employee";
            button2.Text = "Medical Visit";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // pnlEmployeeSubmenu
            // 
            pnlEmployeeSubmenu.BackColor = Color.FromArgb(31, 47, 66);
            pnlEmployeeSubmenu.Controls.Add(panel3);
            pnlEmployeeSubmenu.Controls.Add(btnEmployeeAdd);
            pnlEmployeeSubmenu.Controls.Add(btnEmployeeList);
            pnlEmployeeSubmenu.Dock = DockStyle.Top;
            pnlEmployeeSubmenu.Location = new Point(0, 170);
            pnlEmployeeSubmenu.Name = "pnlEmployeeSubmenu";
            pnlEmployeeSubmenu.Size = new Size(250, 121);
            pnlEmployeeSubmenu.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 47, 66);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 121);
            panel3.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 0, 0);
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(0, 40);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(250, 40);
            button4.TabIndex = 1;
            button4.Tag = "Add";
            button4.Text = "Add";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 0, 0, 0);
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 189, 241);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 189, 241);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(250, 40);
            button5.TabIndex = 0;
            button5.Tag = "List";
            button5.Text = "Filter data";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            btnEmployeeAdd.Size = new Size(250, 40);
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
            panel2.ResumeLayout(false);
            pnlEmployeeSubmenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel pnlEmployeeSubmenu;
        private Button btnEmployeeAdd;
        private Button btnEmployeeList;
        private Button btnEmployee;
        private Panel pnlLogo;
        private Button btnMenu;
        private Panel pnlTitle;
        private Label labelTitle;
        public Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel3;
        private Button button4;
        private Button button5;
    }
}