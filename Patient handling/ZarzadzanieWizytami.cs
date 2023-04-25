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
    public partial class ZarzadzanieWizytami : Form
    {
        public ZarzadzanieWizytami()
        {
            InitializeComponent();

            DatabaseConnection database = new DatabaseConnection();
            database.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "view_listMedicalVisit");
        }

        private void button_edit_appointment_Click(object sender, EventArgs e)
        {
            EditAppointment editAppointment = new EditAppointment();
            editAppointment.Show();
        }

        private void ZarządzanieWizytami_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_lista_wizyt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Clear_the_calendar_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_cancel_visit_Click(object sender, EventArgs e)
        {
            int selcetedPatientId = Convert.ToInt32(dataGridView_lista_wizyt.SelectedRows[0].Cells["ID"].Value);
            int selcetedPatientStatus = Convert.ToInt32(dataGridView_lista_wizyt.SelectedRows[0].Cells["Status"].Value);

            if (selcetedPatientStatus == 0)
            {
                MessageBox.Show("this visit is already cancel");
                return;

            }

            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "0" };
            string condition = $"ID = {selcetedPatientId}";
            databaseConnection.UpdateDataInDatabase("MedicalVisit", columnNames, columnValues, condition);


            DatabaseConnection databaseConnection1 = new DatabaseConnection();

            databaseConnection1.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "view_listMedicalVisit");
        }

        private void button_Send_confirmation_Click(object sender, EventArgs e)
        {
            MedicalVisit medicalVisit = new MedicalVisit();
            medicalVisit.ExportToPDF(dataGridView_lista_wizyt.SelectedRows[0]);
        }
    }
}
