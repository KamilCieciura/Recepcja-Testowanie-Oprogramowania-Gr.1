using Patient_Handling;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices;

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

            DatabaseConnection databaseConnection = new DatabaseConnection();

            databaseConnection.LoadDataIntoDataGridView(dataGridView_patients, "Patients");



        }
        public void AddPatient(Patient patient)
        {
            /*int maxId = Patients.Any() ? Patients.Max(p => p.Id) : 0;
            patient.Id = maxId + 1;
            Patients.Add(patient);*/
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

        }

        private void button_menu_remove_patient_Click(object sender, EventArgs e)
        {
            Form_accept_remove formAcceptRemove = new Form_accept_remove();
            formAcceptRemove.Show();

        }

        private void Form_reception_menu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_menu_activate_patient_Click(object sender, EventArgs e)
        {
            Patient selectedPatient = (Patient)dataGridView_patients.CurrentRow.DataBoundItem;
            if (dataGridView_patients.CurrentRow != null)
            {

                selectedPatient.Status = "Active";
                dataGridView_patients.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a patient to activate.");
            }



            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "1" };
            string condition = $"ID = {selectedPatient}";
            databaseConnection.UpdateDataInDatabase("Patients", columnNames, columnValues, condition);







        }

        private void button_menu_inactivate_patient_Click(object sender, EventArgs e)
        {
            Patient selectedPatient = (Patient)dataGridView_patients.CurrentRow.DataBoundItem;
            if (dataGridView_patients.CurrentRow != null)
            {

                selectedPatient.Status = "Inactive";
                dataGridView_patients.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a patient to activate.");
            }

            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "0" };
            string condition = $"ID = {selectedPatient}";
            databaseConnection.UpdateDataInDatabase("Patients", columnNames, columnValues, condition);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_ReceptionMenu2 receptionMenu2 = new form_ReceptionMenu2();
            receptionMenu2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ZarzadzanieWizytami f = new ZarzadzanieWizytami();
            f.Show();
        }

        private void button_menu_sort_data_Click(object sender, EventArgs e)
        {
            if (comboBox_menu_sort_data.SelectedIndex==0)
            {
                // Sortuj dane rosn�co wed�ug wybranej kolumny
                dataGridView_patients.Sort(dataGridView_patients.Columns["columnfirstName"], ListSortDirection.Ascending);
            }
            else if (comboBox_menu_sort_data.SelectedIndex==1)
            {
                // Sortuj dane malej�co wed�ug wybranej kolumny
                dataGridView_patients.Sort(dataGridView_patients.Columns["columnLastName"], ListSortDirection.Descending);
            }

        }
    }
}