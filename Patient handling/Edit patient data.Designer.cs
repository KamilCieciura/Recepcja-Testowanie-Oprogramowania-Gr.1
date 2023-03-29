namespace Patient_Handling
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
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 52);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 10;
            label2.Text = "Last Name";
            // 
            // textBox_form_edit_patient_last_name
            // 
            textBox_form_edit_patient_last_name.Location = new Point(33, 76);
            textBox_form_edit_patient_last_name.Margin = new Padding(3, 4, 3, 4);
            textBox_form_edit_patient_last_name.Name = "textBox_form_edit_patient_last_name";
            textBox_form_edit_patient_last_name.Size = new Size(194, 27);
            textBox_form_edit_patient_last_name.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 132);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 12;
            label4.Text = "Phone number";
            // 
            // textBox_form_edit_patient_phone_number
            // 
            textBox_form_edit_patient_phone_number.Location = new Point(33, 156);
            textBox_form_edit_patient_phone_number.Margin = new Padding(3, 4, 3, 4);
            textBox_form_edit_patient_phone_number.Name = "textBox_form_edit_patient_phone_number";
            textBox_form_edit_patient_phone_number.Size = new Size(194, 27);
            textBox_form_edit_patient_phone_number.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 208);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 14;
            label5.Text = "Email adress";
            // 
            // textBox_form_edit_patient_adress
            // 
            textBox_form_edit_patient_adress.Location = new Point(33, 232);
            textBox_form_edit_patient_adress.Margin = new Padding(3, 4, 3, 4);
            textBox_form_edit_patient_adress.Name = "textBox_form_edit_patient_adress";
            textBox_form_edit_patient_adress.Size = new Size(193, 27);
            textBox_form_edit_patient_adress.TabIndex = 13;
            // 
            // button_edit_patient_form
            // 
            button_edit_patient_form.Location = new Point(33, 363);
            button_edit_patient_form.Margin = new Padding(3, 4, 3, 4);
            button_edit_patient_form.Name = "button_edit_patient_form";
            button_edit_patient_form.Size = new Size(102, 28);
            button_edit_patient_form.TabIndex = 15;
            button_edit_patient_form.Text = "Edit patient data";
            button_edit_patient_form.UseVisualStyleBackColor = true;
            button_edit_patient_form.Click += button_edit_patient_form_Click;
            // 
            // button_cancel_add_patient_form
            // 
            button_cancel_add_patient_form.Location = new Point(152, 363);
            button_cancel_add_patient_form.Margin = new Padding(3, 4, 3, 4);
            button_cancel_add_patient_form.Name = "button_cancel_add_patient_form";
            button_cancel_add_patient_form.Size = new Size(74, 28);
            button_cancel_add_patient_form.TabIndex = 16;
            button_cancel_add_patient_form.Text = "Cancel";
            button_cancel_add_patient_form.UseVisualStyleBackColor = true;
            button_cancel_add_patient_form.Click += button_cancel_add_patient_form_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 281);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 18;
            label7.Text = "Residential adress";
            // 
            // textBox_form_edit_patient_residential_adress
            // 
            textBox_form_edit_patient_residential_adress.Location = new Point(33, 304);
            textBox_form_edit_patient_residential_adress.Margin = new Padding(3, 4, 3, 4);
            textBox_form_edit_patient_residential_adress.Name = "textBox_form_edit_patient_residential_adress";
            textBox_form_edit_patient_residential_adress.Size = new Size(193, 27);
            textBox_form_edit_patient_residential_adress.TabIndex = 17;
            // 
            // Form_edit_patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 443);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_edit_patient";
            Text = "Edit patient data";
            Load += Form_edit_patient_Load;
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
    }
}