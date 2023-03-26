namespace Patient_Handling
{
    partial class Form_add_patient
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
            button_add_patient_form_data = new Button();
            textBox_First_name = new TextBox();
            textBox_last_name = new TextBox();
            numericUpDown_age = new NumericUpDown();
            textBox_phone_number = new TextBox();
            textBox_adress_email = new TextBox();
            textBox_social_security_number = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button_cancel_add_patient_form = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_age).BeginInit();
            SuspendLayout();
            // 
            // button_add_patient_form_data
            // 
            button_add_patient_form_data.Location = new Point(46, 313);
            button_add_patient_form_data.Name = "button_add_patient_form_data";
            button_add_patient_form_data.Size = new Size(74, 23);
            button_add_patient_form_data.TabIndex = 0;
            button_add_patient_form_data.Text = "Add";
            button_add_patient_form_data.UseVisualStyleBackColor = true;
            // 
            // textBox_First_name
            // 
            textBox_First_name.Location = new Point(46, 50);
            textBox_First_name.Name = "textBox_First_name";
            textBox_First_name.Size = new Size(159, 23);
            textBox_First_name.TabIndex = 1;
            // 
            // textBox_last_name
            // 
            textBox_last_name.Location = new Point(46, 97);
            textBox_last_name.Name = "textBox_last_name";
            textBox_last_name.Size = new Size(159, 23);
            textBox_last_name.TabIndex = 2;
            // 
            // numericUpDown_age
            // 
            numericUpDown_age.Location = new Point(46, 139);
            numericUpDown_age.Name = "numericUpDown_age";
            numericUpDown_age.Size = new Size(159, 23);
            numericUpDown_age.TabIndex = 3;
            // 
            // textBox_phone_number
            // 
            textBox_phone_number.Location = new Point(45, 182);
            textBox_phone_number.Name = "textBox_phone_number";
            textBox_phone_number.Size = new Size(160, 23);
            textBox_phone_number.TabIndex = 4;
            // 
            // textBox_adress_email
            // 
            textBox_adress_email.Location = new Point(46, 228);
            textBox_adress_email.Name = "textBox_adress_email";
            textBox_adress_email.Size = new Size(159, 23);
            textBox_adress_email.TabIndex = 5;
            // 
            // textBox_social_security_number
            // 
            textBox_social_security_number.Location = new Point(45, 275);
            textBox_social_security_number.Name = "textBox_social_security_number";
            textBox_social_security_number.Size = new Size(160, 23);
            textBox_social_security_number.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 34);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 80);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 122);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 164);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 10;
            label4.Text = "Phone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 210);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 11;
            label5.Text = "Email adress";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 257);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 12;
            label6.Text = "Social security number";
            // 
            // button_cancel_add_patient_form
            // 
            button_cancel_add_patient_form.Location = new Point(131, 313);
            button_cancel_add_patient_form.Name = "button_cancel_add_patient_form";
            button_cancel_add_patient_form.Size = new Size(74, 23);
            button_cancel_add_patient_form.TabIndex = 13;
            button_cancel_add_patient_form.Text = "Cancel";
            button_cancel_add_patient_form.UseVisualStyleBackColor = true;
            button_cancel_add_patient_form.Click += button_cancel_add_patient_form_Click;
            // 
            // Form_add_patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 360);
            Controls.Add(button_cancel_add_patient_form);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_social_security_number);
            Controls.Add(textBox_adress_email);
            Controls.Add(textBox_phone_number);
            Controls.Add(numericUpDown_age);
            Controls.Add(textBox_last_name);
            Controls.Add(textBox_First_name);
            Controls.Add(button_add_patient_form_data);
            Name = "Form_add_patient";
            Text = "Add new patient";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_add_patient_form_data;
        private TextBox textBox_First_name;
        private TextBox textBox_last_name;
        private NumericUpDown numericUpDown_age;
        private TextBox textBox_phone_number;
        private TextBox textBox_adress_email;
        private TextBox textBox_social_security_number;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_cancel_add_patient_form;
    }
}