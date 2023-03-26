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
    public partial class Form_add_patient : Form
    {
        public Form_add_patient()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_cancel_add_patient_form_Click(object sender, EventArgs e)
        {
            Form_menu form = new Form_menu();
            form.ShowDialog();
     
        }
    }
}
