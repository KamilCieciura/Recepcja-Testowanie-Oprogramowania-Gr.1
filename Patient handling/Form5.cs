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
    public partial class Form_filter_data : Form
    {
        public Form_filter_data()
        {
            InitializeComponent();
        }

        private void button_cancel_add_patient_form_Click(object sender, EventArgs e)
        {
            Form_reception_menu formReceptionMenu = new Form_reception_menu();
            formReceptionMenu.Show();
            this.Hide();

        }
    }
}
