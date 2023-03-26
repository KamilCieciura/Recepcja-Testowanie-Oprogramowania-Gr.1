namespace Patient_Handling
{
    partial class Form_accept_remove
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
            button_yes_remove_patient_accept_form = new Button();
            button_no_remove_patient_accept_form = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_yes_remove_patient_accept_form
            // 
            button_yes_remove_patient_accept_form.Location = new Point(38, 89);
            button_yes_remove_patient_accept_form.Name = "button_yes_remove_patient_accept_form";
            button_yes_remove_patient_accept_form.Size = new Size(136, 23);
            button_yes_remove_patient_accept_form.TabIndex = 0;
            button_yes_remove_patient_accept_form.Text = "yes";
            button_yes_remove_patient_accept_form.UseVisualStyleBackColor = true;
            // 
            // button_no_remove_patient_accept_form
            // 
            button_no_remove_patient_accept_form.Location = new Point(197, 89);
            button_no_remove_patient_accept_form.Name = "button_no_remove_patient_accept_form";
            button_no_remove_patient_accept_form.Size = new Size(136, 23);
            button_no_remove_patient_accept_form.TabIndex = 1;
            button_no_remove_patient_accept_form.Text = "no";
            button_no_remove_patient_accept_form.UseVisualStyleBackColor = true;
            button_no_remove_patient_accept_form.Click += button_no_remove_patient_accept_form_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(295, 15);
            label1.TabIndex = 2;
            label1.Text = "Are you sure you want to delete this patient's account?";
            // 
            // Form_accept_remove
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 148);
            Controls.Add(label1);
            Controls.Add(button_no_remove_patient_accept_form);
            Controls.Add(button_yes_remove_patient_accept_form);
            Name = "Form_accept_remove";
            Text = "Remove patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_yes_remove_patient_accept_form;
        private Button button_no_remove_patient_accept_form;
        private Label label1;
    }
}