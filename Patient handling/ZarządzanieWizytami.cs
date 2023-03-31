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
    public partial class ZarządzanieWizytami : Form
    {
        public ZarządzanieWizytami()
        {
            InitializeComponent();
        }

        private void button_edit_appointment_Click(object sender, EventArgs e)
        {
            EditAppointment editAppointment = new EditAppointment();
            editAppointment.Show();
        }
    }
}
