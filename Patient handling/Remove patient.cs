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
    public partial class Form_accept_remove : Form
    {
        public Form_accept_remove()
        {
            InitializeComponent();
        }

        private void button_no_remove_patient_accept_form_Click(object sender, EventArgs e)
        {
            //Form_reception_menu formReceptionMenu = new Form_reception_menu();
            //formReceptionMenu.Show();
            this.Hide();
            
        }
    }
}
