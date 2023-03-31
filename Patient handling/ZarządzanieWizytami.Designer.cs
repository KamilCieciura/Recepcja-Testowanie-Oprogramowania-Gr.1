namespace Patient_handling
{
    partial class ZarządzanieWizytami
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
            dataGridView_lista_wizyt = new DataGridView();
            Patient = new DataGridViewTextBoxColumn();
            Doctor = new DataGridViewTextBoxColumn();
            date_of_visit = new DataGridViewTextBoxColumn();
            appointment_time = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewButtonColumn();
            comboBox_sort_visit = new ComboBox();
            button_sort_visit = new Button();
            button_edit_appointment = new Button();
            button_cancel_visit = new Button();
            button_Send_confirmation = new Button();
            button_Clear_the_calendar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista_wizyt).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_lista_wizyt
            // 
            dataGridView_lista_wizyt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lista_wizyt.Columns.AddRange(new DataGridViewColumn[] { Patient, Doctor, date_of_visit, appointment_time, Column1 });
            dataGridView_lista_wizyt.Location = new Point(29, 65);
            dataGridView_lista_wizyt.Name = "dataGridView_lista_wizyt";
            dataGridView_lista_wizyt.RowHeadersVisible = false;
            dataGridView_lista_wizyt.RowTemplate.Height = 25;
            dataGridView_lista_wizyt.Size = new Size(500, 150);
            dataGridView_lista_wizyt.TabIndex = 0;
            // 
            // Patient
            // 
            Patient.HeaderText = "Patient";
            Patient.Name = "Patient";
            // 
            // Doctor
            // 
            Doctor.HeaderText = "Doctor";
            Doctor.Name = "Doctor";
            // 
            // date_of_visit
            // 
            date_of_visit.HeaderText = "Date of visit";
            date_of_visit.Name = "date_of_visit";
            // 
            // appointment_time
            // 
            appointment_time.HeaderText = "Appointment time";
            appointment_time.Name = "appointment_time";
            // 
            // Column1
            // 
            Column1.HeaderText = "details";
            Column1.Name = "Column1";
            Column1.Text = "details";
            // 
            // comboBox_sort_visit
            // 
            comboBox_sort_visit.FormattingEnabled = true;
            comboBox_sort_visit.Location = new Point(408, 17);
            comboBox_sort_visit.Name = "comboBox_sort_visit";
            comboBox_sort_visit.Size = new Size(121, 23);
            comboBox_sort_visit.TabIndex = 1;
            // 
            // button_sort_visit
            // 
            button_sort_visit.Location = new Point(408, 36);
            button_sort_visit.Name = "button_sort_visit";
            button_sort_visit.Size = new Size(121, 23);
            button_sort_visit.TabIndex = 2;
            button_sort_visit.Text = "Sort";
            button_sort_visit.UseVisualStyleBackColor = true;
            // 
            // button_edit_appointment
            // 
            button_edit_appointment.Location = new Point(29, 230);
            button_edit_appointment.Name = "button_edit_appointment";
            button_edit_appointment.Size = new Size(129, 26);
            button_edit_appointment.TabIndex = 3;
            button_edit_appointment.Text = "Edit appointment";
            button_edit_appointment.UseVisualStyleBackColor = true;
            button_edit_appointment.Click += button_edit_appointment_Click;
            // 
            // button_cancel_visit
            // 
            button_cancel_visit.Location = new Point(171, 230);
            button_cancel_visit.Name = "button_cancel_visit";
            button_cancel_visit.Size = new Size(85, 26);
            button_cancel_visit.TabIndex = 4;
            button_cancel_visit.Text = "Cancel visit";
            button_cancel_visit.UseVisualStyleBackColor = true;
            // 
            // button_Send_confirmation
            // 
            button_Send_confirmation.Location = new Point(270, 230);
            button_Send_confirmation.Name = "button_Send_confirmation";
            button_Send_confirmation.Size = new Size(125, 26);
            button_Send_confirmation.TabIndex = 5;
            button_Send_confirmation.Text = "Send confirmation";
            button_Send_confirmation.UseVisualStyleBackColor = true;
            // 
            // button_Clear_the_calendar
            // 
            button_Clear_the_calendar.Location = new Point(413, 230);
            button_Clear_the_calendar.Name = "button_Clear_the_calendar";
            button_Clear_the_calendar.Size = new Size(116, 26);
            button_Clear_the_calendar.TabIndex = 6;
            button_Clear_the_calendar.Text = "Clear the calendar";
            button_Clear_the_calendar.UseVisualStyleBackColor = true;
            // 
            // ZarządzanieWizytami
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 313);
            Controls.Add(button_Clear_the_calendar);
            Controls.Add(button_Send_confirmation);
            Controls.Add(button_cancel_visit);
            Controls.Add(button_edit_appointment);
            Controls.Add(button_sort_visit);
            Controls.Add(comboBox_sort_visit);
            Controls.Add(dataGridView_lista_wizyt);
            Name = "ZarządzanieWizytami";
            Text = "ZarządzanieWizytami";
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista_wizyt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_lista_wizyt;
        private ComboBox comboBox_sort_visit;
        private Button button_sort_visit;
        private DataGridViewTextBoxColumn Patient;
        private DataGridViewTextBoxColumn Doctor;
        private DataGridViewTextBoxColumn date_of_visit;
        private DataGridViewTextBoxColumn appointment_time;
        private DataGridViewButtonColumn Column1;
        private Button button_edit_appointment;
        private Button button_cancel_visit;
        private Button button_Send_confirmation;
        private Button button_Clear_the_calendar;
    }
}