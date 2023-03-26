using Patient_handling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Handling
{
    public partial class Form_edit_patient : Form
    {
        public Form_edit_patient()
        {
            InitializeComponent();
        }

        private void button_cancel_add_patient_form_Click(object sender, EventArgs e)
        {
            Form_reception_menu formMenuReception = new Form_reception_menu();
            formMenuReception.Show();
            this.Hide();
        }
    }
}
