using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentie_turism
{
    public partial class FormEditare : Form
    {
        Turist turist;
        public FormEditare(Turist t)
        {//preluarea turist actual
            InitializeComponent();
            turist = t;

        }

        private void FormEditare_Load(object sender, EventArgs e)
        {
            //preluare info in formular editare
            tbPlata.Text = turist.pret.ToString();
            tbNume.Text = turist.nume;
            tbPrenume.Text = turist.prenume;
            tbTelefon.Text = turist.telefon;
            
            Tranzactie tr = turist.tranzactie;
            if (tr == Tranzactie.card)
            {
                cbTranzactie.SelectedIndex = 0;
            }
            if (tr == Tranzactie.cash)
            {
                cbTranzactie.SelectedIndex = 1;
            }
            List<String> tip_turist = turist.tip_Tranzactie;
            //verificam selectiile

            if (tip_turist.Contains("All inclusive"))
            {
                cbAllinclusive.Checked = true;

            }
            if (tip_turist.Contains(" Transport adaugat"))
            {
                cbTransport.Checked = true;


            }
            if (tip_turist.Contains("Reducere"))
            {
                cbReducere.Checked = true;

            }

        }

    

        private void btnSalvare_Click(object sender, EventArgs e)
        {
           
            int.TryParse(tbPlata.Text, out int p);
            turist.pret = p;
            turist.valoare = turist.pret;
            turist.nume = tbNume.Text;
            turist.prenume = tbPrenume.Text;
            turist.telefon = tbTelefon.Text;
            List<String> tip_turist= new List<string>();

            if (cbAllinclusive.Checked)
            {
                tip_turist.Add("All inclusive adaugat");
                turist.valoare += 1000;


            }
            if (cbTransport.Checked)
            {
                tip_turist.Add(" Transport adaugat");
                turist.valoare += 500;

            }
            if (cbReducere.Checked)
            {
                tip_turist.Add("Reducere adaugata.");
                turist.valoare -= turist.pret / 10;

            }
            Tranzactie tranz;
            int indexTranz = cbTranzactie.SelectedIndex;
            if (indexTranz == 0)
            {
                tranz = Tranzactie.card;
                turist.valoare += 50;
            }
            else
            {
                tranz = Tranzactie.cash;
                turist.valoare += 25;
            }
            turist.tranzactie = tranz;
            
            this.Close();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "x")
                this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
