using Patient_Handling;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices;

namespace Patient_handling
{
    public partial class Form_reception_menu : Form
    {

       // public BindingList<Patient> Patients { get; set; } = new BindingList<Patient>();
        public Form_reception_menu()
        {
            InitializeComponent();
            List<string> listaStringow = new List<string>();
            listaStringow.Add("sort from a to z");
            listaStringow.Add("sort from z to a");


            /*comboBox_menu_sort_data.Items.AddRange(listaStringow.ToArray());*/
            /*dataGridView1.DataSource = Patients;*/



            DatabaseConnection databaseConnection = new DatabaseConnection();

            databaseConnection.LoadDataIntoDataGridView(dataGridView1, "Patients");




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


            /* if (dataGridView_patients.CurrentRow != null)
             {

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
             */









        }

        private void button_menu_filter_data_Click(object sender, EventArgs e)
        {
            Form_filter_data formFilterData = new Form_filter_data();
            formFilterData.Show();

        }

        private void button_menu_remove_patient_Click(object sender, EventArgs e)
        {
            int selcetedPatientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            int selcetedPatientStatus = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Status"].Value);

            if (selcetedPatientStatus == 0)
            {
                MessageBox.Show("this patient is already inactive");
                return;

            }

            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "0" };
            string condition = $"ID = {selcetedPatientId}";
            databaseConnection.UpdateDataInDatabase("Patients", columnNames, columnValues, condition);


            DatabaseConnection databaseConnection1 = new DatabaseConnection();

            databaseConnection1.LoadDataIntoDataGridView(dataGridView1, "Patients");

        }

        private void Form_reception_menu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_patients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button_menu_activate_patient_Click(object sender, EventArgs e)
        {
            /*
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
            */

            int selcetedPatientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            int selcetedPatientStatus = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Status"].Value);

            if (selcetedPatientStatus == 1)
            {
                MessageBox.Show("this patient is already active");
                return;

            }



            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "1" };
            string condition = $"ID = {selcetedPatientId}";
            databaseConnection.UpdateDataInDatabase("Patients", columnNames, columnValues, condition);

            DatabaseConnection databaseConnection1 = new DatabaseConnection();

            databaseConnection1.LoadDataIntoDataGridView(dataGridView1, "Patients");








        }

   
    }
}