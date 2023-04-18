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
            button_menu_edit_patient = new Button();
            button_menu_activate_patient = new Button();
            button_menu_remove_patient = new Button();
            comboBox_menu_sort_data = new ComboBox();
            button_menu_sort_data = new Button();
            button_menu_inactivate_patient = new Button();
            dataGridView_patients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).BeginInit();
            SuspendLayout();
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
            comboBox_menu_sort_data.Location = new Point(662, 21);
            comboBox_menu_sort_data.Name = "comboBox_menu_sort_data";
            comboBox_menu_sort_data.Size = new Size(140, 23);
            comboBox_menu_sort_data.TabIndex = 5;
            // 
            // button_menu_sort_data
            // 
            button_menu_sort_data.Location = new Point(662, 42);
            button_menu_sort_data.Name = "button_menu_sort_data";
            button_menu_sort_data.Size = new Size(140, 23);
            button_menu_sort_data.TabIndex = 6;
            button_menu_sort_data.Text = "Sort data";
            button_menu_sort_data.UseVisualStyleBackColor = true;
            button_menu_sort_data.Click += button_menu_sort_data_Click;
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
            // dataGridView_patients
            // 
            dataGridView_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_patients.Location = new Point(22, 69);
            dataGridView_patients.Name = "dataGridView_patients";
            dataGridView_patients.RowHeadersVisible = false;
            dataGridView_patients.RowHeadersWidth = 51;
            dataGridView_patients.RowTemplate.Height = 25;
            dataGridView_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_patients.Size = new Size(802, 165);
            dataGridView_patients.TabIndex = 20;
            dataGridView_patients.VirtualMode = true;
            // 
            // Form_reception_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 354);
            Controls.Add(dataGridView_patients);
            Controls.Add(button_menu_inactivate_patient);
            Controls.Add(button_menu_sort_data);
            Controls.Add(comboBox_menu_sort_data);
            Controls.Add(button_menu_remove_patient);
            Controls.Add(button_menu_activate_patient);
            Controls.Add(button_menu_edit_patient);
            Name = "Form_reception_menu";
            Text = "Reception menu";
            Load += Form_reception_menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_menu_edit_patient;
        private Button button_menu_activate_patient;
        private Button button_menu_remove_patient;
        private ComboBox comboBox_menu_sort_data;
        private Button button_menu_sort_data;
        private Button button_menu_inactivate_patient;
        private DataGridView dataGridView_patients;
    }
}