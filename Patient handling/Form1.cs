using Patient_Handling;

namespace Patient_handling
{
    public partial class Form_reception_menu : Form
    {
        public Form_reception_menu()
        {
            InitializeComponent();
            List<string> listaStringow = new List<string>();
            listaStringow.Add("sort from a to z");
            listaStringow.Add("sort from z to a");


            comboBox_menu_sort_data.Items.AddRange(listaStringow.ToArray());
        }

        private void button_menu_add_patient_Click(object sender, EventArgs e)
        {
            Form_add_patient formAddPatient = new Form_add_patient();
            formAddPatient.Show();
            this.Hide();


            
        }

        private void button_menu_edit_patient_Click(object sender, EventArgs e)
        {
            Form_edit_patient formEditPatientData = new Form_edit_patient();
            formEditPatientData.Show();
            this.Hide();
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
    }
}