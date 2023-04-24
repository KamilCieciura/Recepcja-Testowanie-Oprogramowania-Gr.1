using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_handling
{
    public partial class addNewVisit : Form
    {
        private Dictionary<int, string> _patientIdsAndNames;
        private Dictionary<int, string> _doctorIdsAndNames;

        public addNewVisit()
        {
            InitializeComponent();
            List<string> listaStringow = new List<string>();
            listaStringow.Add("08:30");
            listaStringow.Add("09:00");
            listaStringow.Add("09:30");
            listaStringow.Add("10:00");
            listaStringow.Add("10:30");
            listaStringow.Add("11:00");
            listaStringow.Add("11:30");
            listaStringow.Add("12:00");
            listaStringow.Add("12:30");
            listaStringow.Add("13:00");
            listaStringow.Add("13:30");
            listaStringow.Add("14:00");
            listaStringow.Add("14:30");
            listaStringow.Add("15:00");
            listaStringow.Add("15:30");
            listaStringow.Add("16:00");
            listaStringow.Add("16:30");
            listaStringow.Add("17:00");
            listaStringow.Add("17:30");
            listaStringow.Add("18:00");
            listaStringow.Add("18:30");
            listaStringow.Add("19:00");
            listaStringow.Add("19:30");

            comboBox_hour_add.Items.AddRange(listaStringow.ToArray());

            DatabaseConnection databaseConnection = new DatabaseConnection();

            (_patientIdsAndNames, _doctorIdsAndNames) = databaseConnection.LoadPatientsAndDoctorsToComboBoxes(comboBox_patinet_add, comboBox_doctor_add);

            databaseConnection.LoadDataIntoDataGridView(dataGridView_patients, "view_CalendarEntity");
        }

        private void button_add_visit_Click(object sender, EventArgs e)
        {
            DatabaseConnection conn = new DatabaseConnection();

            int patientId = _patientIdsAndNames.FirstOrDefault(x => x.Value == comboBox_patinet_add.SelectedItem.ToString()).Key;
            int doctorId = _doctorIdsAndNames.FirstOrDefault(x => x.Value == comboBox_doctor_add.SelectedItem.ToString()).Key;


            string[] columnNames = { "Patient", "Doctor", "Date", "Hour" };
            string visitDate = dateTimePicker_add_visit.Value.ToString("yyyy-MM-dd");
            string visitTime = comboBox_hour_add.SelectedItem.ToString();
            string[] columnValues = { patientId.ToString(), doctorId.ToString(), visitDate, visitTime };


            conn.InsertDataToDatabase("MedicalVisit", columnNames, columnValues);


            conn.LoadDataIntoDataGridView(dataGridView_patients, "MedicalVisit");
        }

        private void addNewVisit_Load(object sender, EventArgs e)
        {

        }
    }
}