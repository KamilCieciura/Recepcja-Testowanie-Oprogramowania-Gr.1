using Patient_handling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Handling
{
    public partial class Form_add_patient : Form
    {
        private readonly Form_reception_menu _formReceptionMenu;
        public Form_add_patient(Form_reception_menu formReceptionMenu)
        {
            InitializeComponent();
            _formReceptionMenu = formReceptionMenu;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_cancel_add_patient_form_Click(object sender, EventArgs e)
        {
            Form_reception_menu formReceptionMenu = new Form_reception_menu();
            formReceptionMenu.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_add_patient_Load(object sender, EventArgs e)
        {

        }

        private void button_add_patient_form_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient
            {
                FirstName = textBox_form_add_patient_First_name.Text,
                LastName = textBox_form_add_patient_last_name.Text,
                Age = int.Parse(numericUpDown_form_add_patient_age.Text),
                PhoneNumber = textBox_form_add_patient_phone_number.Text,
                EmailAddress = textBox_form_add_patient_adress_email.Text,
                ResidentialAddress = textBox_form_add_patient_residential_adress.Text,
                SocialSecurityNumber = textBox_form_add_patient_social_security_number.Text
            };
            _formReceptionMenu.AddPatient(newPatient);

            this.Hide();
            _formReceptionMenu.Show();
        }
    }
}
