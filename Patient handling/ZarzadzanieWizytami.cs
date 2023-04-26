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
        public string visitId { get; set; }
        public ZarzadzanieWizytami()
        {
            InitializeComponent();

            DatabaseConnection database = new DatabaseConnection();
            database.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "view_listMedicalVisit");

            if (dataGridView_lista_wizyt.Rows.Count > 0)
            {
                //Wywołujemy metodę CellClick dla pierwszego wiersza
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, 0);
                dataGridView_lista_wizyt_CellClick(this, args);
            }
            this.dataGridView_lista_wizyt.SelectionChanged += new System.EventHandler(this.dataGridView_lista_wizyt_SelectionChanged);
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
        /*
        private void button_Clear_the_calendar_Click(object sender, EventArgs e)
        {
            // Tworzymy listę indeksów wierszy, które mają zostać usunięte
            List<int> rowsToDelete = new List<int>();

            // Przechodzimy przez każdy wiersz w dataGridView_lista_wizyt
            foreach (DataGridViewRow row in dataGridView_lista_wizyt.Rows)
            {
                // Sprawdzamy, czy wartość w kolumnie "Status" jest równa 0
                if (Convert.ToInt32(row.Cells["Status"].Value) == 0)
                {
                    // Jeśli tak i wiersz nie jest nowy, dodajemy indeks wiersza do listy rowsToDelete
                    if (!row.IsNewRow)
                    {
                        // Ustawiamy status lekarza na "free"
                        int calendarId = Convert.ToInt32(row.Cells["ID"].Value);
                        DatabaseConnection databaseConnection = new DatabaseConnection();
                        string[] columnNames = { "Status" };
                        string[] columnValues = { "free" };
                        string condition = $"ID = {calendarId}";
                        databaseConnection.UpdateDataInDatabase("CalendarEntity", columnNames, columnValues, condition);

                        // Usuwamy wiersz z bazy danych
                        int visitId = Convert.ToInt32(row.Cells["ID"].Value);
                        DatabaseConnection databaseConnection3 = new DatabaseConnection();
                        string condition3 = $"ID = {visitId}";
                        databaseConnection3.DeleteDataFromDatabase("MedicalVisit", condition3);

                        // Dodajemy indeks wiersza do listy rowsToDelete
                        rowsToDelete.Add(row.Index);
                    }
                }
            }

            // Usuwamy wiersze z listy, zaczynając od ostatniego, aby uniknąć przesuwania indeksów
            for (int i = rowsToDelete.Count - 1; i >= 0; i--)
            {
                dataGridView_lista_wizyt.Rows.RemoveAt(rowsToDelete[i]);
            }

            // Usuwamy wiersze, których data jest mniejsza niż dzisiejsza
            DatabaseConnection databaseConnection5 = new DatabaseConnection();
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string condition5 = $"Date < '{currentDate}'";
            databaseConnection5.DeleteDataFromDatabase("MedicalVisit", condition5);

            // Aktualizujemy status lekarzy na "free"
            DatabaseConnection databaseConnection2 = new DatabaseConnection();
            string[] columnNames1 = { "status" };
            string[] columnValues1 = { "free" };
            string condition6 = $"Date < '{currentDate}'";
            databaseConnection2.UpdateDataInDatabase("CalendarEntity", columnNames1, columnValues1, condition6);

            // Odświeżamy dane w dataGridView_lista_wizyt
            DatabaseConnection databaseConnection7 = new DatabaseConnection();
            databaseConnection7.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "view_listMedicalVisit");
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {

            form_visitDetails form_VisitDetails = new form_visitDetails();
            form_VisitDetails.TopLevel = false;
            form_VisitDetails.FormBorderStyle = FormBorderStyle.None;
            form_VisitDetails.Dock = DockStyle.Fill;
            form_ReceptionMenu2 receptionMenu2 = Application.OpenForms["form_ReceptionMenu2"] as form_ReceptionMenu2;
            receptionMenu2.panel1.Controls.Add(form_VisitDetails);
            receptionMenu2.panel1.Tag = form_VisitDetails;
            form_VisitDetails.BringToFront();
            form_VisitDetails.Show();

            

 
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
            string[] columnValues1 = { "" };
            string condition1 = $"Date = '{selectedDate.ToString("yyyy-MM-dd")}' AND Time = '{selectedTime.ToString(@"hh\:mm\:ss")}'";

            databaseConnection2.UpdateDataInDatabase("CalendarEntity", columnNames1, columnValues1, condition1);



        }
        private void UpdateTextBoxValues(DataGridViewRow selectedRow)
        {



 
        }
        private void button_Send_confirmation_Click(object sender, EventArgs e)
        {
            if (dataGridView_lista_wizyt.SelectedRows.Count > 0)
            {
                MedicalVisit medicalVisit = new MedicalVisit();
                medicalVisit.ExportToPDF(dataGridView_lista_wizyt.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Proszę wybrać wizytę do eksportu.");
            }
        }

        private void button_Clear_the_calendar_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.LoadDataIntoDataGridView(dataGridView_lista_wizyt, "view_TodaysMedicalVisits");
        }

        public void dataGridView_lista_wizyt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string visitId = dataGridView_lista_wizyt.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        
                
           

            }

        }
        private void dataGridView_lista_wizyt_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_lista_wizyt.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_lista_wizyt.SelectedRows[0];
                UpdateTextBoxValues(selectedRow);
            }
        }
    }
}
