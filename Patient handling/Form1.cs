using Patient_Handling;
using System.ComponentModel;

namespace Patient_handling
{
    public partial class Form_reception_menu : Form
    {
        public BindingList<Patient> Patients { get; set; } = new BindingList<Patient>();
        public Form_reception_menu()
        {
            InitializeComponent();
            List<string> listaStringow = new List<string>();
            listaStringow.Add("sort from a to z");
            listaStringow.Add("sort from z to a");


            comboBox_menu_sort_data.Items.AddRange(listaStringow.ToArray());
            dataGridView_patients.DataSource = Patients;
        }
        public void AddPatient(Patient patient)
        {
            int maxId = Patients.Any() ? Patients.Max(p => p.Id) : 0;
            patient.Id = maxId + 1;
            Patients.Add(patient);
        }

        private void button_menu_add_patient_Click(object sender, EventArgs e)
        {
            Form_add_patient formAddPatient = new Form_add_patient(this);
            formAddPatient.Show();
            this.Hide();



        }

        private void button_menu_edit_patient_Click(object sender, EventArgs e)
        {
            if (dataGridView_patients.CurrentRow != null)
            {
                Patient selectedPatient = (Patient)dataGridView_patients.CurrentRow.DataBoundItem;
                Form_edit_patient formEditPatientData = new Form_edit_patient(selectedPatient);

                if (formEditPatientData.ShowDialog() == DialogResult.OK)
                {
                    dataGridView_patients.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to edit.");
            }
        }

        private void button_menu_filter_data_Click(object sender, EventArgs e)
        {
            Form_filter_data formFilterData = new Form_filter_data();
            formFilterData.Show();
            this.Hide();
        }

        private void button_menu_remove_patient_Click(object sender, EventArgs e)
        {
            Form_accept_remove formAcceptRemove = new Form_accept_remove();
            formAcceptRemove.Show();
            this.Hide();
        }

        private void Form_reception_menu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_menu_activate_patient_Click(object sender, EventArgs e)
        {
            if (dataGridView_patients.CurrentRow != null)
            {
                Patient selectedPatient = (Patient)dataGridView_patients.CurrentRow.DataBoundItem;
                selectedPatient.Status = "Active";
                dataGridView_patients.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a patient to activate.");
            }
        }
    }
}