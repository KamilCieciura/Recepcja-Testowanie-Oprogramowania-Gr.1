namespace Patient_handling
{
    partial class addNewVisit
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
            comboBox_patinet_add = new ComboBox();
            comboBox_doctor_add = new ComboBox();
            dateTimePicker_add_visit = new DateTimePicker();
            comboBox_hour_add = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_add_visit = new Button();
            SuspendLayout();
            // 
            // comboBox_patinet_add
            // 
            comboBox_patinet_add.FormattingEnabled = true;
            comboBox_patinet_add.Location = new Point(25, 34);
            comboBox_patinet_add.Name = "comboBox_patinet_add";
            comboBox_patinet_add.Size = new Size(130, 23);
            comboBox_patinet_add.TabIndex = 0;
            // 
            // comboBox_doctor_add
            // 
            comboBox_doctor_add.FormattingEnabled = true;
            comboBox_doctor_add.Location = new Point(24, 78);
            comboBox_doctor_add.Name = "comboBox_doctor_add";
            comboBox_doctor_add.Size = new Size(130, 23);
            comboBox_doctor_add.TabIndex = 1;
            // 
            // dateTimePicker_add_visit
            // 
            dateTimePicker_add_visit.Format = DateTimePickerFormat.Short;
            dateTimePicker_add_visit.Location = new Point(25, 122);
            dateTimePicker_add_visit.Name = "dateTimePicker_add_visit";
            dateTimePicker_add_visit.Size = new Size(130, 23);
            dateTimePicker_add_visit.TabIndex = 2;
            // 
            // comboBox_hour_add
            // 
            comboBox_hour_add.FormattingEnabled = true;
            comboBox_hour_add.Location = new Point(25, 167);
            comboBox_hour_add.Name = "comboBox_hour_add";
            comboBox_hour_add.Size = new Size(130, 23);
            comboBox_hour_add.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 4;
            label1.Text = "Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Doctor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 104);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Date of visit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 149);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Hour";
            // 
            // button_add_visit
            // 
            button_add_visit.Location = new Point(24, 205);
            button_add_visit.Name = "button_add_visit";
            button_add_visit.Size = new Size(131, 23);
            button_add_visit.TabIndex = 8;
            button_add_visit.Text = "Add ";
            button_add_visit.UseVisualStyleBackColor = true;
            button_add_visit.Click += button_add_visit_Click;
            // 
            // addNewVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 248);
            Controls.Add(button_add_visit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_hour_add);
            Controls.Add(dateTimePicker_add_visit);
            Controls.Add(comboBox_doctor_add);
            Controls.Add(comboBox_patinet_add);
            Name = "addNewVisit";
            Text = "addNewVisit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_patinet_add;
        private ComboBox comboBox_doctor_add;
        private DateTimePicker dateTimePicker_add_visit;
        private ComboBox comboBox_hour_add;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_add_visit;
    }
}