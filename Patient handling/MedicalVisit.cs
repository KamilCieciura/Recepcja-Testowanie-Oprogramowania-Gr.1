using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Windows.Forms;


namespace Patient_handling
{
    internal class MedicalVisit
    {
        private int Doctorid ;
        private int patientid ;
        private string date ;
        private string time ;

        public int Doctorid1 { get => Doctorid; set => Doctorid = value; }
        public int Patientid { get => patientid; set => patientid = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }



        public void ExportToPDF(DataGridViewRow row)
        {
            // create a new PDF document
            PdfDocument document = new PdfDocument();

            // add a page to the document
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 12);

            // get the data from the selected row
            string doctorId = row.Cells["DoctorName"].Value.ToString();
            string patientId = row.Cells["PatientName"].Value.ToString();
            string date = row.Cells["Date"].Value.ToString();
            string time = row.Cells["HOUR"].Value.ToString();

            // create the text to be added to the PDF
            string text = "Doctor Name: " + doctorId + "\nPatient Name: " + patientId + "\nDate: " + date + "\nTime: " + time;

            // set the path for the PDF file
            string path = @"C:\Users\kubax\Documents\potwierdzenia\";
            string fileName = "potwierdzenie_" + doctorId + "_" + patientId + ".pdf";
            string filePath = Path.Combine(path, fileName);

            // create the directory if it doesn't exist
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            // draw the text on the page
            XRect rect = new XRect(40, 40, page.Width - 80, page.Height - 80);
            gfx.DrawString(text, font, XBrushes.Black, rect, XStringFormats.TopLeft);

            // save the PDF to the specified path
            document.Save(filePath);

            // show a message box to confirm the PDF was created and saved successfully
            MessageBox.Show("PDF created successfully!");
        }



    }
}
