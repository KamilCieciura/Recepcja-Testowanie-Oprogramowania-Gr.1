using Patient_Handling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;

namespace Patient_handling
{
    public partial class form_ReceptionMenu2 : Form
    {
        public form_ReceptionMenu2()
        {
            InitializeComponent();




      


        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void ReceptionMenu2_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {


            Form_reception_menu formReceptionMenu = new Form_reception_menu();
            formReceptionMenu.TopLevel = false;
            formReceptionMenu.FormBorderStyle = FormBorderStyle.None;
            formReceptionMenu.Dock = DockStyle.Fill;
            panel1.Controls.Add(formReceptionMenu);
            panel1.Tag = formReceptionMenu;
            formReceptionMenu.BringToFront();
            formReceptionMenu.Show();




        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {

            Form_reception_menu formreceptionmenu = new Form_reception_menu();
            Form_add_patient formAddPatient = new Form_add_patient(formreceptionmenu);
            formAddPatient.TopLevel = false;
            formAddPatient.FormBorderStyle = FormBorderStyle.None;
            formAddPatient.Dock = DockStyle.Fill;
            panel1.Controls.Add(formAddPatient);
            panel1.Tag = formAddPatient;
            formAddPatient.BringToFront();
            formAddPatient.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_filter_data formfilterdata = new Form_filter_data();
            formfilterdata.TopLevel = false;
            formfilterdata.FormBorderStyle = FormBorderStyle.None;
            formfilterdata.Dock = DockStyle.Fill;
            panel1.Controls.Add(formfilterdata);
            panel1.Tag = formfilterdata;
            formfilterdata.BringToFront();
            formfilterdata.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZarządzanieWizytami zarzadzaniewizytami = new ZarządzanieWizytami();
            zarzadzaniewizytami.TopLevel = false;
            zarzadzaniewizytami.FormBorderStyle = FormBorderStyle.None;
            zarzadzaniewizytami.Dock = DockStyle.Fill;
            panel1.Controls.Add(zarzadzaniewizytami);
            panel1.Tag = zarzadzaniewizytami;
            zarzadzaniewizytami.BringToFront();
            zarzadzaniewizytami.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNewVisit add = new addNewVisit();
            add.TopLevel = false;
            add.FormBorderStyle = FormBorderStyle.None;
            add.Dock = DockStyle.Fill;
            panel1.Controls.Add(add);
            panel1.Tag = add;
            add.BringToFront();
            add.Show();

        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
