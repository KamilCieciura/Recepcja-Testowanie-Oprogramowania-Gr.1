namespace Patient_handling
{
    partial class EditAppointment
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
            dateTimePicker_edit_appointment = new DateTimePicker();
            comboBox_edit_apointment = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button_edit_appointment = new Button();
            button_Cancel_edit = new Button();
            SuspendLayout();
            // 
            // dateTimePicker_edit_appointment
            // 
            dateTimePicker_edit_appointment.Format = DateTimePickerFormat.Short;
            dateTimePicker_edit_appointment.Location = new Point(12, 47);
            dateTimePicker_edit_appointment.Name = "dateTimePicker_edit_appointment";
            dateTimePicker_edit_appointment.Size = new Size(146, 23);
            dateTimePicker_edit_appointment.TabIndex = 0;
            // 
            // comboBox_edit_apointment
            // 
            comboBox_edit_apointment.FormattingEnabled = true;
            comboBox_edit_apointment.Location = new Point(12, 93);
            comboBox_edit_apointment.Name = "comboBox_edit_apointment";
            comboBox_edit_apointment.Size = new Size(146, 23);
            comboBox_edit_apointment.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "date of visit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 75);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Appointment time";
            // 
            // button_edit_appointment
            // 
            button_edit_appointment.Location = new Point(12, 122);
            button_edit_appointment.Name = "button_edit_appointment";
            button_edit_appointment.Size = new Size(66, 23);
            button_edit_appointment.TabIndex = 4;
            button_edit_appointment.Text = "Edit";
            button_edit_appointment.UseVisualStyleBackColor = true;
            // 
            // button_Cancel_edit
            // 
            button_Cancel_edit.Location = new Point(83, 122);
            button_Cancel_edit.Name = "button_Cancel_edit";
            button_Cancel_edit.Size = new Size(75, 23);
            button_Cancel_edit.TabIndex = 5;
            button_Cancel_edit.Text = "Cancel";
            button_Cancel_edit.UseVisualStyleBackColor = true;
            // 
            // EditAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(181, 174);
            Controls.Add(button_Cancel_edit);
            Controls.Add(button_edit_appointment);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_edit_apointment);
            Controls.Add(dateTimePicker_edit_appointment);
            Name = "EditAppointment";
            Text = "EditAppointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker_edit_appointment;
        private ComboBox comboBox_edit_apointment;
        private Label label1;
        private Label label2;
        private Button button_edit_appointment;
        private Button button_Cancel_edit;
    }
}