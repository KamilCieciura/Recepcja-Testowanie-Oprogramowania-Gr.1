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
            textBox_last_name_edit = new TextBox();
            label4 = new Label();
            textBox_phone_number_edit = new TextBox();
            label5 = new Label();
            textBox_adress_email_edit = new TextBox();
            button_edit_patient_form = new Button();
            button_cancel_add_patient_form = new Button();
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
            // textBox_last_name_edit
            // 
            textBox_last_name_edit.Location = new Point(29, 57);
            textBox_last_name_edit.Name = "textBox_last_name_edit";
            textBox_last_name_edit.Size = new Size(170, 23);
            textBox_last_name_edit.TabIndex = 9;
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
            // textBox_phone_number_edit
            // 
            textBox_phone_number_edit.Location = new Point(29, 117);
            textBox_phone_number_edit.Name = "textBox_phone_number_edit";
            textBox_phone_number_edit.Size = new Size(170, 23);
            textBox_phone_number_edit.TabIndex = 11;
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
            // textBox_adress_email_edit
            // 
            textBox_adress_email_edit.Location = new Point(29, 174);
            textBox_adress_email_edit.Name = "textBox_adress_email_edit";
            textBox_adress_email_edit.Size = new Size(169, 23);
            textBox_adress_email_edit.TabIndex = 13;
            // 
            // button_edit_patient_form
            // 
            button_edit_patient_form.Location = new Point(29, 215);
            button_edit_patient_form.Name = "button_edit_patient_form";
            button_edit_patient_form.Size = new Size(89, 21);
            button_edit_patient_form.TabIndex = 15;
            button_edit_patient_form.Text = "Edit patient data";
            button_edit_patient_form.UseVisualStyleBackColor = true;
            // 
            // button_cancel_add_patient_form
            // 
            button_cancel_add_patient_form.Location = new Point(134, 215);
            button_cancel_add_patient_form.Name = "button_cancel_add_patient_form";
            button_cancel_add_patient_form.Size = new Size(65, 21);
            button_cancel_add_patient_form.TabIndex = 16;
            button_cancel_add_patient_form.Text = "Cancel";
            button_cancel_add_patient_form.UseVisualStyleBackColor = true;
            // 
            // Form_edit_patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 276);
            Controls.Add(button_cancel_add_patient_form);
            Controls.Add(button_edit_patient_form);
            Controls.Add(label5);
            Controls.Add(textBox_adress_email_edit);
            Controls.Add(label4);
            Controls.Add(textBox_phone_number_edit);
            Controls.Add(label2);
            Controls.Add(textBox_last_name_edit);
            Name = "Form_edit_patient";
            Text = "Edit patient data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox_last_name_edit;
        private Label label4;
        private TextBox textBox_phone_number_edit;
        private Label label5;
        private TextBox textBox_adress_email_edit;
        private Button button_edit_patient_form;
        private Button button_cancel_add_patient_form;
    }
}