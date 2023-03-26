namespace Patient_handling
{
    partial class Form_reception_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button_menu_add_patient = new Button();
            button_menu_edit_patient = new Button();
            button_menu_activate_patient = new Button();
            button_menu_remove_patient = new Button();
            comboBox_menu_sort_data = new ComboBox();
            button_menu_sort_data = new Button();
            button_menu_filter_data = new Button();
            First_Name = new DataGridViewTextBoxColumn();
            Last_name = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Phone_number = new DataGridViewTextBoxColumn();
            email_adress = new DataGridViewTextBoxColumn();
            Residential_address = new DataGridViewTextBoxColumn();
            social_security_number = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { First_Name, Last_name, Age, Phone_number, email_adress, Residential_address, social_security_number });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(68, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(698, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.VirtualMode = true;
            // 
            // button_menu_add_patient
            // 
            button_menu_add_patient.Location = new Point(68, 249);
            button_menu_add_patient.Name = "button_menu_add_patient";
            button_menu_add_patient.Size = new Size(153, 23);
            button_menu_add_patient.TabIndex = 1;
            button_menu_add_patient.Text = "Add patient";
            button_menu_add_patient.UseVisualStyleBackColor = true;
            button_menu_add_patient.Click += button_menu_add_patient_Click;
            // 
            // button_menu_edit_patient
            // 
            button_menu_edit_patient.Location = new Point(251, 249);
            button_menu_edit_patient.Name = "button_menu_edit_patient";
            button_menu_edit_patient.Size = new Size(153, 23);
            button_menu_edit_patient.TabIndex = 2;
            button_menu_edit_patient.Text = "Edit patient data";
            button_menu_edit_patient.UseVisualStyleBackColor = true;
            button_menu_edit_patient.Click += button_menu_edit_patient_Click;
            // 
            // button_menu_activate_patient
            // 
            button_menu_activate_patient.Location = new Point(431, 249);
            button_menu_activate_patient.Name = "button_menu_activate_patient";
            button_menu_activate_patient.Size = new Size(153, 23);
            button_menu_activate_patient.TabIndex = 3;
            button_menu_activate_patient.Text = "Activate patient account";
            button_menu_activate_patient.UseVisualStyleBackColor = true;
            // 
            // button_menu_remove_patient
            // 
            button_menu_remove_patient.Location = new Point(613, 249);
            button_menu_remove_patient.Name = "button_menu_remove_patient";
            button_menu_remove_patient.Size = new Size(153, 23);
            button_menu_remove_patient.TabIndex = 4;
            button_menu_remove_patient.Text = "Remove patient account";
            button_menu_remove_patient.UseVisualStyleBackColor = true;
            button_menu_remove_patient.Click += button_menu_remove_patient_Click;
            // 
            // comboBox_menu_sort_data
            // 
            comboBox_menu_sort_data.FormattingEnabled = true;
            comboBox_menu_sort_data.Location = new Point(626, 35);
            comboBox_menu_sort_data.Name = "comboBox_menu_sort_data";
            comboBox_menu_sort_data.Size = new Size(140, 23);
            comboBox_menu_sort_data.TabIndex = 5;
            // 
            // button_menu_sort_data
            // 
            button_menu_sort_data.Location = new Point(626, 56);
            button_menu_sort_data.Name = "button_menu_sort_data";
            button_menu_sort_data.Size = new Size(140, 23);
            button_menu_sort_data.TabIndex = 6;
            button_menu_sort_data.Text = "Sort data";
            button_menu_sort_data.UseVisualStyleBackColor = true;
            // 
            // button_menu_filter_data
            // 
            button_menu_filter_data.Location = new Point(271, 291);
            button_menu_filter_data.Name = "button_menu_filter_data";
            button_menu_filter_data.Size = new Size(292, 23);
            button_menu_filter_data.TabIndex = 7;
            button_menu_filter_data.Text = "Filter data";
            button_menu_filter_data.UseVisualStyleBackColor = true;
            button_menu_filter_data.Click += button_menu_filter_data_Click;
            // 
            // First_Name
            // 
            First_Name.HeaderText = "First name";
            First_Name.Name = "First_Name";
            First_Name.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Last_name
            // 
            Last_name.HeaderText = "Last name";
            Last_name.Name = "Last_name";
            Last_name.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone_number
            // 
            Phone_number.HeaderText = "Phone number";
            Phone_number.Name = "Phone_number";
            Phone_number.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // email_adress
            // 
            email_adress.HeaderText = "Email adress";
            email_adress.Name = "email_adress";
            email_adress.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Residential_address
            // 
            Residential_address.HeaderText = "Residential address";
            Residential_address.Name = "Residential_address";
            // 
            // social_security_number
            // 
            social_security_number.HeaderText = "Social security number";
            social_security_number.Name = "social_security_number";
            social_security_number.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Form_reception_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 354);
            Controls.Add(button_menu_filter_data);
            Controls.Add(button_menu_sort_data);
            Controls.Add(comboBox_menu_sort_data);
            Controls.Add(button_menu_remove_patient);
            Controls.Add(button_menu_activate_patient);
            Controls.Add(button_menu_edit_patient);
            Controls.Add(button_menu_add_patient);
            Controls.Add(dataGridView1);
            Name = "Form_reception_menu";
            Text = "Reception menu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_menu_add_patient;
        private Button button_menu_edit_patient;
        private Button button_menu_activate_patient;
        private Button button_menu_remove_patient;
        private ComboBox comboBox_menu_sort_data;
        private Button button_menu_sort_data;
        private Button button_menu_filter_data;
        private DataGridViewTextBoxColumn First_Name;
        private DataGridViewTextBoxColumn Last_name;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Phone_number;
        private DataGridViewTextBoxColumn email_adress;
        private DataGridViewTextBoxColumn Residential_address;
        private DataGridViewTextBoxColumn social_security_number;
    }
}