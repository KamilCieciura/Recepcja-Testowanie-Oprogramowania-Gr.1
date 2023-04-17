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
            button_menu_edit_patient = new Button();
            button_menu_activate_patient = new Button();
            button_menu_remove_patient = new Button();
            comboBox_menu_sort_data = new ComboBox();
            button_menu_sort_data = new Button();
            button_menu_inactivate_patient = new Button();
            id = new DataGridViewTextBoxColumn();
            columnFirstName = new DataGridViewTextBoxColumn();
            columnLastName = new DataGridViewTextBoxColumn();
            columnBirthdate = new DataGridViewTextBoxColumn();
            columnPhoneNumber = new DataGridViewTextBoxColumn();
            columnEmailAddress = new DataGridViewTextBoxColumn();
            columnResidentialAddress = new DataGridViewTextBoxColumn();
            columnPESEL = new DataGridViewTextBoxColumn();
            columnStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_patients
            // 
            dataGridView_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patients.Columns.AddRange(new DataGridViewColumn[] { id, columnFirstName, columnLastName, columnBirthdate, columnPhoneNumber, columnEmailAddress, columnResidentialAddress, columnPESEL, columnStatus });
            dataGridView_patients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_patients.Location = new Point(22, 76);
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
            // button_menu_edit_patient
            // 
            button_menu_edit_patient.Location = new Point(22, 240);
            button_menu_edit_patient.Name = "button_menu_edit_patient";
            button_menu_edit_patient.Size = new Size(153, 23);
            button_menu_edit_patient.TabIndex = 2;
            button_menu_edit_patient.Text = "Edit patient's data";
            button_menu_edit_patient.UseVisualStyleBackColor = true;
            button_menu_edit_patient.Click += button_menu_edit_patient_Click;
            // 
            // button_menu_activate_patient
            // 
            button_menu_activate_patient.Location = new Point(230, 240);
            button_menu_activate_patient.Name = "button_menu_activate_patient";
            button_menu_activate_patient.Size = new Size(153, 23);
            button_menu_activate_patient.TabIndex = 3;
            button_menu_activate_patient.Text = "Activate patient";
            button_menu_activate_patient.UseVisualStyleBackColor = true;
            button_menu_activate_patient.Click += button_menu_activate_patient_Click;
            // 
            // button_menu_remove_patient
            // 
            button_menu_remove_patient.Location = new Point(671, 240);
            button_menu_remove_patient.Name = "button_menu_remove_patient";
            button_menu_remove_patient.Size = new Size(153, 23);
            button_menu_remove_patient.TabIndex = 4;
            button_menu_remove_patient.Text = "Delete";
            button_menu_remove_patient.UseVisualStyleBackColor = true;
            button_menu_remove_patient.Click += button_menu_remove_patient_Click;
            // 
            // comboBox_menu_sort_data
            // 
            comboBox_menu_sort_data.FormattingEnabled = true;
            comboBox_menu_sort_data.Location = new Point(684, 27);
            comboBox_menu_sort_data.Name = "comboBox_menu_sort_data";
            comboBox_menu_sort_data.Size = new Size(140, 23);
            comboBox_menu_sort_data.TabIndex = 5;
            // 
            // button_menu_sort_data
            // 
            button_menu_sort_data.Location = new Point(684, 48);
            button_menu_sort_data.Name = "button_menu_sort_data";
            button_menu_sort_data.Size = new Size(140, 23);
            button_menu_sort_data.TabIndex = 6;
            button_menu_sort_data.Text = "Sort data";
            button_menu_sort_data.UseVisualStyleBackColor = true;
            // 
            // button_menu_inactivate_patient
            // 
            button_menu_inactivate_patient.Location = new Point(442, 240);
            button_menu_inactivate_patient.Name = "button_menu_inactivate_patient";
            button_menu_inactivate_patient.Size = new Size(153, 23);
            button_menu_inactivate_patient.TabIndex = 8;
            button_menu_inactivate_patient.Text = "Inactivate patient";
            button_menu_inactivate_patient.UseVisualStyleBackColor = true;
            button_menu_inactivate_patient.Click += button_menu_inactivate_patient_Click;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
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
            // Form_reception_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 354);
            Controls.Add(button_menu_inactivate_patient);
            Controls.Add(button_menu_sort_data);
            Controls.Add(comboBox_menu_sort_data);
            Controls.Add(button_menu_remove_patient);
            Controls.Add(button_menu_activate_patient);
            Controls.Add(button_menu_edit_patient);
            Controls.Add(dataGridView_patients);
            Name = "Form_reception_menu";
            Text = "Reception menu";
            Load += Form_reception_menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_patients;
        private Button button_menu_edit_patient;
        private Button button_menu_activate_patient;
        private Button button_menu_remove_patient;
        private ComboBox comboBox_menu_sort_data;
        private Button button_menu_sort_data;
        private Button button_menu_inactivate_patient;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn columnFirstName;
        private DataGridViewTextBoxColumn columnLastName;
        private DataGridViewTextBoxColumn columnBirthdate;
        private DataGridViewTextBoxColumn columnPhoneNumber;
        private DataGridViewTextBoxColumn columnEmailAddress;
        private DataGridViewTextBoxColumn columnResidentialAddress;
        private DataGridViewTextBoxColumn columnPESEL;
        private DataGridViewTextBoxColumn columnStatus;
    }
}