using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
            int selcetedcalendarId = Convert.ToInt32(dataGridView_lista_wizyt.SelectedRows[0].Cells["ID"].Value);
            int selcetedVisitStatus = Convert.ToInt32(dataGridView_lista_wizyt.SelectedRows[0].Cells["Status"].Value);

            if (selcetedVisitStatus == 0)
            {
                MessageBox.Show("this visit is already cancel");
                return;

            }

            DatabaseConnection databaseConnection = new DatabaseConnection();

            string[] columnNames = { "Status" };
            string[] columnValues = { "0" };
            string condition = $"ID = {selcetedcalendarId}";
            databaseConnection.UpdateDataInDatabase("MedicalVisit", columnNames, columnValues, condition);


            DatabaseConnection databaseConnection1 = new DatabaseConnection();

            databaseConnection1.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "view_listMedicalVisit");


            DateTime selectedDate = (DateTime)dataGridView_lista_wizyt.SelectedRows[0].Cells["Date"].Value;
            TimeSpan selectedTime = (TimeSpan)dataGridView_lista_wizyt.SelectedRows[0].Cells["Hour"].Value;


            DatabaseConnection databaseConnection2 = new DatabaseConnection();

            string[] columnNames1 = { "Status" };
            string[] columnValues1 = { "free" };
            string condition1 = $"Date = '{selectedDate.ToString("yyyy-MM-dd")}' AND Time = '{selectedTime.ToString(@"hh\:mm\:ss")}'";

            databaseConnection2.UpdateDataInDatabase("CalendarEntity", columnNames1, columnValues1, condition1);



        }

        private void button_Send_confirmation_Click(object sender, EventArgs e)
        {
            MedicalVisit medicalVisit = new MedicalVisit();
            medicalVisit.ExportToPDF(dataGridView_lista_wizyt.SelectedRows[0]);
        }
    }
}
