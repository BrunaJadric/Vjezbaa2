using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Vjezbaa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            string imePrezime, mjestoRodenja, vozackadozvola, mobilni, spol, fakultet;
            DateTime datumRodjenja, danasnjiDatum;
            int ukupanbrojispita=0;
            imePrezime = txtime.Text;
            mjestoRodenja = cbMjestoRođenja.SelectedItem.ToString();
            vozackadozvola =cbB.Text;
            mobilni= maskedTextBox1.Text;
            if(rbMusko.Checked)
            {
                spol = "Muško";
            }
            else
            {
                spol = "Žensko";
            }
            fakultet = lbFakultet.SelectedItem.ToString();
            datumRodjenja = dtpDatumRodenja.Value;
            danasnjiDatum = DateTime.Now;
            ukupanbrojispita.ToString();



            MessageBox.Show("Ime i prezime: " + imePrezime + "\nMjesto rođenja: " + mjestoRodenja + "\nDatum rođenja: " + datumRodjenja.ToShortDateString() + "\nSpol: " + spol + "\nFakultet: " + fakultet + "\nVozacka dozvola: " + vozackadozvola + "\nMobilni: " + mobilni + ukupanbrojispita + "\nUkupan broj ispita: ");


        }
    }
}
