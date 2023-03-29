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
            dataGridView_patients = new DataGridView();
            columnFirstName = new DataGridViewTextBoxColumn();
            columnLastName = new DataGridViewTextBoxColumn();
            columnBirthdate = new DataGridViewTextBoxColumn();
            columnPhoneNumber = new DataGridViewTextBoxColumn();
            columnEmailAddress = new DataGridViewTextBoxColumn();
            columnResidentialAddress = new DataGridViewTextBoxColumn();
            columnPESEL = new DataGridViewTextBoxColumn();
            columnStatus = new DataGridViewTextBoxColumn();
            button_menu_add_patient = new Button();
            button_menu_edit_patient = new Button();
            button_menu_activate_patient = new Button();
            button_menu_remove_patient = new Button();
            comboBox_menu_sort_data = new ComboBox();
            button_menu_sort_data = new Button();
            button_menu_filter_data = new Button();
            button_menu_inactivate_patient = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_patients
            // 
            dataGridView_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patients.Columns.AddRange(new DataGridViewColumn[] { columnFirstName, columnLastName, columnBirthdate, columnPhoneNumber, columnEmailAddress, columnResidentialAddress, columnPESEL, columnStatus });
            dataGridView_patients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_patients.Location = new Point(68, 85);
            dataGridView_patients.Name = "dataGridView_patients";
            dataGridView_patients.RowHeadersVisible = false;
            dataGridView_patients.RowHeadersWidth = 51;
            dataGridView_patients.RowTemplate.Height = 25;
            dataGridView_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_patients.Size = new Size(802, 150);
            dataGridView_patients.TabIndex = 0;
            dataGridView_patients.VirtualMode = true;
            dataGridView_patients.CellContentClick += dataGridView_patients_CellContentClick;
            // 
            // columnFirstName
            // 
            columnFirstName.DataPropertyName = "FirstName";
            columnFirstName.HeaderText = "First Name";
            columnFirstName.MinimumWidth = 6;
            columnFirstName.Name = "columnFirstName";
            // 
            // columnLastName
            // 
            columnLastName.DataPropertyName = "LastName";
            columnLastName.HeaderText = "Last Name";
            columnLastName.MinimumWidth = 6;
            columnLastName.Name = "columnLastName";
            // 
            // columnBirthdate
            // 
            columnBirthdate.DataPropertyName = "Birthdate";
            columnBirthdate.HeaderText = "Birth date";
            columnBirthdate.MaxInputLength = 10;
            columnBirthdate.MinimumWidth = 6;
            columnBirthdate.Name = "columnBirthdate";
            // 
            // columnPhoneNumber
            // 
            columnPhoneNumber.DataPropertyName = "PhoneNumber";
            columnPhoneNumber.HeaderText = "Phone Number";
            columnPhoneNumber.MinimumWidth = 6;
            columnPhoneNumber.Name = "columnPhoneNumber";
            // 
            // columnEmailAddress
            // 
            columnEmailAddress.DataPropertyName = "EmailAddress";
            columnEmailAddress.HeaderText = "Email Address";
            columnEmailAddress.MinimumWidth = 6;
            columnEmailAddress.Name = "columnEmailAddress";
            // 
            // columnResidentialAddress
            // 
            columnResidentialAddress.DataPropertyName = "ResidentialAddress";
            columnResidentialAddress.HeaderText = "Residential Address";
            columnResidentialAddress.MinimumWidth = 6;
            columnResidentialAddress.Name = "columnResidentialAddress";
            // 
            // columnPESEL
            // 
            columnPESEL.DataPropertyName = "PESEL";
            columnPESEL.HeaderText = "PESEL";
            columnPESEL.MinimumWidth = 6;
            columnPESEL.Name = "columnPESEL";
            // 
            // columnStatus
            // 
            columnStatus.DataPropertyName = "Status";
            columnStatus.HeaderText = "Status";
            columnStatus.MinimumWidth = 6;
            columnStatus.Name = "columnStatus";
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
            button_menu_edit_patient.Location = new Point(227, 249);
            button_menu_edit_patient.Name = "button_menu_edit_patient";
            button_menu_edit_patient.Size = new Size(153, 23);
            button_menu_edit_patient.TabIndex = 2;
            button_menu_edit_patient.Text = "Edit patient data";
            button_menu_edit_patient.UseVisualStyleBackColor = true;
            button_menu_edit_patient.Click += button_menu_edit_patient_Click;
            // 
            // button_menu_activate_patient
            // 
            button_menu_activate_patient.Location = new Point(389, 249);
            button_menu_activate_patient.Name = "button_menu_activate_patient";
            button_menu_activate_patient.Size = new Size(153, 23);
            button_menu_activate_patient.TabIndex = 3;
            button_menu_activate_patient.Text = "Activate patient account";
            button_menu_activate_patient.UseVisualStyleBackColor = true;
            button_menu_activate_patient.Click += button_menu_activate_patient_Click;
            // 
            // button_menu_remove_patient
            // 
            button_menu_remove_patient.Location = new Point(717, 249);
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
            comboBox_menu_sort_data.Location = new Point(730, 36);
            comboBox_menu_sort_data.Name = "comboBox_menu_sort_data";
            comboBox_menu_sort_data.Size = new Size(140, 23);
            comboBox_menu_sort_data.TabIndex = 5;
            // 
            // button_menu_sort_data
            // 
            button_menu_sort_data.Location = new Point(730, 57);
            button_menu_sort_data.Name = "button_menu_sort_data";
            button_menu_sort_data.Size = new Size(140, 23);
            button_menu_sort_data.TabIndex = 6;
            button_menu_sort_data.Text = "Sort data";
            button_menu_sort_data.UseVisualStyleBackColor = true;
            // 
            // button_menu_filter_data
            // 
            button_menu_filter_data.Location = new Point(316, 290);
            button_menu_filter_data.Name = "button_menu_filter_data";
            button_menu_filter_data.Size = new Size(292, 23);
            button_menu_filter_data.TabIndex = 7;
            button_menu_filter_data.Text = "Filter data";
            button_menu_filter_data.UseVisualStyleBackColor = true;
            button_menu_filter_data.Click += button_menu_filter_data_Click;
            // 
            // button_menu_inactivate_patient
            // 
            button_menu_inactivate_patient.Location = new Point(554, 249);
            button_menu_inactivate_patient.Name = "button_menu_inactivate_patient";
            button_menu_inactivate_patient.Size = new Size(153, 23);
            button_menu_inactivate_patient.TabIndex = 8;
            button_menu_inactivate_patient.Text = "Inactivate patient account";
            button_menu_inactivate_patient.UseVisualStyleBackColor = true;
            button_menu_inactivate_patient.Click += button1_Click;
            // 
            // Form_reception_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 354);
            Controls.Add(button_menu_inactivate_patient);
            Controls.Add(button_menu_filter_data);
            Controls.Add(button_menu_sort_data);
            Controls.Add(comboBox_menu_sort_data);
            Controls.Add(button_menu_remove_patient);
            Controls.Add(button_menu_activate_patient);
            Controls.Add(button_menu_edit_patient);
            Controls.Add(button_menu_add_patient);
            Controls.Add(dataGridView_patients);
            Name = "Form_reception_menu";
            Text = "Reception menu";
            Load += Form_reception_menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_patients;
        private Button button_menu_add_patient;
        private Button button_menu_edit_patient;
        private Button button_menu_activate_patient;
        private Button button_menu_remove_patient;
        private ComboBox comboBox_menu_sort_data;
        private Button button_menu_sort_data;
        private Button button_menu_filter_data;
        private DataGridViewTextBoxColumn columnFirstName;
        private DataGridViewTextBoxColumn columnLastName;
        private DataGridViewTextBoxColumn columnBirthdate;
        private DataGridViewTextBoxColumn columnPhoneNumber;
        private DataGridViewTextBoxColumn columnEmailAddress;
        private DataGridViewTextBoxColumn columnResidentialAddress;
        private DataGridViewTextBoxColumn columnPESEL;
        private DataGridViewTextBoxColumn columnStatus;
        private Button button_menu_inactivate_patient;
    }
}