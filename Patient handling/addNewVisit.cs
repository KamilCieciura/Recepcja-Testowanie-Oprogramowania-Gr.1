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

            databaseConnection.LoadPatientsAndDoctorsToComboBoxes(comboBox_patinet_add, comboBox_doctor_add);



        }

        private void button_add_visit_Click(object sender, EventArgs e)
        {
            DatabaseConnection conn = new DatabaseConnection();





        }
    }
}
