﻿namespace Patient_Handling
{
    partial class Form_edit_patient
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
            label2 = new Label();
            textBox_form_edit_patient_last_name = new TextBox();
            label4 = new Label();
            textBox_form_edit_patient_phone_number = new TextBox();
            label5 = new Label();
            textBox_form_edit_patient_adress = new TextBox();
            button_edit_patient_form = new Button();
            button_cancel_add_patient_form = new Button();
            label7 = new Label();
            textBox_form_edit_patient_residential_adress = new TextBox();
            dataGridView_patients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 39);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 10;
            label2.Text = "Last Name";
            // 
            // textBox_form_edit_patient_last_name
            // 
            textBox_form_edit_patient_last_name.Location = new Point(29, 57);
            textBox_form_edit_patient_last_name.Name = "textBox_form_edit_patient_last_name";
            textBox_form_edit_patient_last_name.Size = new Size(170, 23);
            textBox_form_edit_patient_last_name.TabIndex = 9;
            textBox_form_edit_patient_last_name.TextChanged += textBox_form_edit_patient_last_name_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 99);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 12;
            label4.Text = "Phone number";
            // 
            // textBox_form_edit_patient_phone_number
            // 
            textBox_form_edit_patient_phone_number.Location = new Point(29, 117);
            textBox_form_edit_patient_phone_number.Name = "textBox_form_edit_patient_phone_number";
            textBox_form_edit_patient_phone_number.Size = new Size(170, 23);
            textBox_form_edit_patient_phone_number.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 156);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 14;
            label5.Text = "Email adress";
            // 
            // textBox_form_edit_patient_adress
            // 
            textBox_form_edit_patient_adress.Location = new Point(29, 174);
            textBox_form_edit_patient_adress.Name = "textBox_form_edit_patient_adress";
            textBox_form_edit_patient_adress.Size = new Size(169, 23);
            textBox_form_edit_patient_adress.TabIndex = 13;
            // 
            // button_edit_patient_form
            // 
            button_edit_patient_form.Location = new Point(29, 272);
            button_edit_patient_form.Name = "button_edit_patient_form";
            button_edit_patient_form.Size = new Size(89, 21);
            button_edit_patient_form.TabIndex = 15;
            button_edit_patient_form.Text = "Save";
            button_edit_patient_form.UseVisualStyleBackColor = true;
            button_edit_patient_form.Click += button_edit_patient_form_Click;
            // 
            // button_cancel_add_patient_form
            // 
            button_cancel_add_patient_form.Location = new Point(133, 272);
            button_cancel_add_patient_form.Name = "button_cancel_add_patient_form";
            button_cancel_add_patient_form.Size = new Size(65, 21);
            button_cancel_add_patient_form.TabIndex = 16;
            button_cancel_add_patient_form.Text = "Cancel";
            button_cancel_add_patient_form.UseVisualStyleBackColor = true;
            button_cancel_add_patient_form.Click += button_cancel_add_patient_form_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 211);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 18;
            label7.Text = "Residential adress";
            // 
            // textBox_form_edit_patient_residential_adress
            // 
            textBox_form_edit_patient_residential_adress.Location = new Point(29, 228);
            textBox_form_edit_patient_residential_adress.Name = "textBox_form_edit_patient_residential_adress";
            textBox_form_edit_patient_residential_adress.Size = new Size(169, 23);
            textBox_form_edit_patient_residential_adress.TabIndex = 17;
            // 
            // dataGridView_patients
            // 
            dataGridView_patients.AllowUserToResizeColumns = false;
            dataGridView_patients.AllowUserToResizeRows = false;
            dataGridView_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_patients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_patients.Location = new Point(242, 57);
            dataGridView_patients.MultiSelect = false;
            dataGridView_patients.Name = "dataGridView_patients";
            dataGridView_patients.RowHeadersVisible = false;
            dataGridView_patients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView_patients.RowTemplate.Height = 25;
            dataGridView_patients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_patients.Size = new Size(999, 236);
            dataGridView_patients.TabIndex = 19;
            dataGridView_patients.VirtualMode = true;
            dataGridView_patients.CellContentClick += dataGridView_patients_CellContentClick;
            // 
            // Form_edit_patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 501);
            Controls.Add(dataGridView_patients);
            Controls.Add(label7);
            Controls.Add(textBox_form_edit_patient_residential_adress);
            Controls.Add(button_cancel_add_patient_form);
            Controls.Add(button_edit_patient_form);
            Controls.Add(label5);
            Controls.Add(textBox_form_edit_patient_adress);
            Controls.Add(label4);
            Controls.Add(textBox_form_edit_patient_phone_number);
            Controls.Add(label2);
            Controls.Add(textBox_form_edit_patient_last_name);
            Name = "Form_edit_patient";
            Text = "Edit patient data";
            Load += Form_edit_patient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_patients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox_form_edit_patient_last_name;
        private Label label4;
        private TextBox textBox_form_edit_patient_phone_number;
        private Label label5;
        private TextBox textBox_form_edit_patient_adress;
        private Button button_edit_patient_form;
        private Button button_cancel_add_patient_form;
        private Label label7;
        private TextBox textBox_form_edit_patient_residential_adress;
        private DataGridView dataGridView_patients;
    }
}