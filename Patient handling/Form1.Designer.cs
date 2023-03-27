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
            button_menu_add_patient = new Button();
            button_menu_edit_patient = new Button();
            button_menu_activate_patient = new Button();
            button_menu_remove_patient = new Button();
            comboBox_menu_sort_data = new ComboBox();
            button_menu_sort_data = new Button();
            button_menu_filter_data = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_patients
            // 
            dataGridView_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_patients.Location = new Point(78, 113);
            dataGridView_patients.Margin = new Padding(3, 4, 3, 4);
            dataGridView_patients.Name = "dataGridView_patients";
            dataGridView_patients.RowHeadersVisible = false;
            dataGridView_patients.RowHeadersWidth = 51;
            dataGridView_patients.RowTemplate.Height = 25;
            dataGridView_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_patients.Size = new Size(798, 200);
            dataGridView_patients.TabIndex = 0;
            dataGridView_patients.VirtualMode = true;
            dataGridView_patients.CellContentClick += dataGridView_patients_CellContentClick;
            // 
            // button_menu_add_patient
            // 
            button_menu_add_patient.Location = new Point(78, 332);
            button_menu_add_patient.Margin = new Padding(3, 4, 3, 4);
            button_menu_add_patient.Name = "button_menu_add_patient";
            button_menu_add_patient.Size = new Size(175, 31);
            button_menu_add_patient.TabIndex = 1;
            button_menu_add_patient.Text = "Add patient";
            button_menu_add_patient.UseVisualStyleBackColor = true;
            button_menu_add_patient.Click += button_menu_add_patient_Click;
            // 
            // button_menu_edit_patient
            // 
            button_menu_edit_patient.Location = new Point(287, 332);
            button_menu_edit_patient.Margin = new Padding(3, 4, 3, 4);
            button_menu_edit_patient.Name = "button_menu_edit_patient";
            button_menu_edit_patient.Size = new Size(175, 31);
            button_menu_edit_patient.TabIndex = 2;
            button_menu_edit_patient.Text = "Edit patient data";
            button_menu_edit_patient.UseVisualStyleBackColor = true;
            button_menu_edit_patient.Click += button_menu_edit_patient_Click;
            // 
            // button_menu_activate_patient
            // 
            button_menu_activate_patient.Location = new Point(493, 332);
            button_menu_activate_patient.Margin = new Padding(3, 4, 3, 4);
            button_menu_activate_patient.Name = "button_menu_activate_patient";
            button_menu_activate_patient.Size = new Size(175, 31);
            button_menu_activate_patient.TabIndex = 3;
            button_menu_activate_patient.Text = "Activate patient account";
            button_menu_activate_patient.UseVisualStyleBackColor = true;
            // 
            // button_menu_remove_patient
            // 
            button_menu_remove_patient.Location = new Point(701, 332);
            button_menu_remove_patient.Margin = new Padding(3, 4, 3, 4);
            button_menu_remove_patient.Name = "button_menu_remove_patient";
            button_menu_remove_patient.Size = new Size(175, 31);
            button_menu_remove_patient.TabIndex = 4;
            button_menu_remove_patient.Text = "Remove patient account";
            button_menu_remove_patient.UseVisualStyleBackColor = true;
            button_menu_remove_patient.Click += button_menu_remove_patient_Click;
            // 
            // comboBox_menu_sort_data
            // 
            comboBox_menu_sort_data.FormattingEnabled = true;
            comboBox_menu_sort_data.Location = new Point(715, 47);
            comboBox_menu_sort_data.Margin = new Padding(3, 4, 3, 4);
            comboBox_menu_sort_data.Name = "comboBox_menu_sort_data";
            comboBox_menu_sort_data.Size = new Size(159, 28);
            comboBox_menu_sort_data.TabIndex = 5;
            // 
            // button_menu_sort_data
            // 
            button_menu_sort_data.Location = new Point(715, 75);
            button_menu_sort_data.Margin = new Padding(3, 4, 3, 4);
            button_menu_sort_data.Name = "button_menu_sort_data";
            button_menu_sort_data.Size = new Size(160, 31);
            button_menu_sort_data.TabIndex = 6;
            button_menu_sort_data.Text = "Sort data";
            button_menu_sort_data.UseVisualStyleBackColor = true;
            // 
            // button_menu_filter_data
            // 
            button_menu_filter_data.Location = new Point(310, 388);
            button_menu_filter_data.Margin = new Padding(3, 4, 3, 4);
            button_menu_filter_data.Name = "button_menu_filter_data";
            button_menu_filter_data.Size = new Size(334, 31);
            button_menu_filter_data.TabIndex = 7;
            button_menu_filter_data.Text = "Filter data";
            button_menu_filter_data.UseVisualStyleBackColor = true;
            button_menu_filter_data.Click += button_menu_filter_data_Click;
            // 
            // Form_reception_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 472);
            Controls.Add(button_menu_filter_data);
            Controls.Add(button_menu_sort_data);
            Controls.Add(comboBox_menu_sort_data);
            Controls.Add(button_menu_remove_patient);
            Controls.Add(button_menu_activate_patient);
            Controls.Add(button_menu_edit_patient);
            Controls.Add(button_menu_add_patient);
            Controls.Add(dataGridView_patients);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}