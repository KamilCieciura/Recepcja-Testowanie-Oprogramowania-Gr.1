using Patient_handling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (string.IsNullOrEmpty(textBox_form_add_patient_First_name.Text) ||
                string.IsNullOrEmpty(textBox_form_add_patient_last_name.Text) ||
                string.IsNullOrEmpty(dateTimePicker_form_add_patient_birthdate.Text) ||
                string.IsNullOrEmpty(textBox_form_add_patient_phone_number.Text) ||
                string.IsNullOrEmpty(textBox_form_add_patient_adress_email.Text) ||
                string.IsNullOrEmpty(textBox_form_add_patient_residential_adress.Text) ||
                string.IsNullOrEmpty(textBox_form_add_patient_social_security_number.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }

            if (!Regex.IsMatch(textBox_form_add_patient_phone_number.Text, @"^\+?[0-9]{3}-?[0-9]{3}-?[0-9]{3}$"))
            {
                MessageBox.Show("Numer telefonu musi składać się z dziewięciu cyfr.");
                return;
            }

            if (!Regex.IsMatch(textBox_form_add_patient_adress_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Adres email jest nieprawidłowy.");
                return;
            }

            Patient newPatient = new Patient
            {
                FirstName = textBox_form_add_patient_First_name.Text,
                LastName = textBox_form_add_patient_last_name.Text,
                Birthdate = dateTimePicker_form_add_patient_birthdate.Value.Date,
                PhoneNumber = textBox_form_add_patient_phone_number.Text,
                EmailAddress = textBox_form_add_patient_adress_email.Text,
                ResidentialAddress = textBox_form_add_patient_residential_adress.Text,
                PESEL = textBox_form_add_patient_social_security_number.Text
            };
            _formReceptionMenu.AddPatient(newPatient);

            this.Hide();
            _formReceptionMenu.Show();
        }
    }
}
