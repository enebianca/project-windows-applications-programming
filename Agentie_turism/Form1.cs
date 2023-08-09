using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentie_turism
{
    public partial class Form1 : Form
    {
        private List<Turist> listaTuristi = null;
       
        public Form1()
        {
            InitializeComponent();
            listaTuristi = new List<Turist>();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Red;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime iTime = DateTime.Now;
            lblTime.Text = iTime.ToLongTimeString();
            DateTime iDate= DateTime.Now;
            lblDate.Text = iDate.ToLongDateString();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit=MessageBox.Show("Confirm if you want to exit", "Tourism Agency ",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(iExit== DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string nume = tbNume.Text;
            if (String.IsNullOrEmpty(nume) || nume.Length < 3)
                valid = false;
            try
            {
              
               int _pret = int.Parse(tbPlata.Text);
            }
            catch (Exception)
            {
                valid = false;
            }
            int.TryParse(tbPlata.Text, out int pret);
            {
                if (pret < 1)
                    valid = false;

            }
            string prenume = tbPrenume.Text;

            if (String.IsNullOrEmpty(prenume) || prenume.Length < 3)
                valid = false;

            string telefon = tbTelefon.Text;
            if (String.IsNullOrEmpty(telefon) || telefon.Length < 3)
                valid = false;
            string email = tbEmail.Text;
            if (String.IsNullOrEmpty(email) || email.Length < 3)
                valid = false;
            List<String> tip_turist = new List<string>();

            if (cbTransport.Checked)
            {
                tip_turist.Add("Transport adaugat.");

            }
            if (cbAllinclusive.Checked)
            {
                tip_turist.Add(" All inclusive adaugat.");

            }
            if (cbReducere.Checked)
            {
                tip_turist.Add("Reducere adaugata.");

            }
            Tranzactie tranz;
            int indexLiv = cbTranzactie.SelectedIndex;
            if (indexLiv == 0)
            {
                tranz = Tranzactie.card;
            }
            else
            { tranz = Tranzactie.cash; }
            if (valid)
            {
                Turist t = new Turist(tip_turist, nume, prenume, telefon, pret);
                t.tranzactie = tranz;
                //adaugare obiect in lista generala
                listaTuristi.Add(t);

                t.valoare = t.pret;

                // Adăugați această linie pentru a atribui valoarea introdusă lui "pret"
                t.pret = pret;
                

                populeazaListView();
                btCuratare_Click(sender, e);
                MessageBox.Show("Turist adaugat cu succes!", "Succes",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // mesaj de eroare
                MessageBox.Show("Formularul contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void btCuratare_Click(object sender, EventArgs e)
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbEmail.Clear();
            tbTelefon.Clear();
            tbPlata.Clear();
            cbTranzactie.SelectedIndex = -1;
            //checkurile iau valoarea fals ca fiind nebifate
            cbTransport.Checked = false;
            cbReducere.Checked = false;
            cbAllinclusive.Checked = false;
        }


        private void populeazaListView()
        {
            //curatam
            listView1.Items.Clear();
            // adaugare
            foreach (Turist t in listaTuristi)
            {
                t.valoare = t.pret;
                if (cbAllinclusive.Checked)
                {
                    t.valoare += 1000;
                }
                if (cbTransport.Checked)
                {
                    t.valoare += 200;
                }
                if (cbReducere.Checked)
                {
                    t.valoare -= t.pret / 10;
                }
                if (cbTranzactie.SelectedIndex.Equals(0))
                {
                    t.valoare += 50;
                }
                if (cbTranzactie.SelectedIndex.Equals(1))
                {
                    t.valoare += 10;
                }
                ListViewItem lv1 = new ListViewItem(new String[] { t.nume, t.prenume,t.telefon,t.pret.ToString(), t.valoare.ToString()});
                lv1.Tag = t;
                listView1.Items.Add(lv1);

            }
        }

        private void populeazaListView1()
        {
            //curatam
            listView1.Items.Clear();
            // adaugare
            foreach (Turist t in listaTuristi)
            {

                ListViewItem lv1 = new ListViewItem(new String[] { t.nume, t.prenume, t.telefon, t.pret.ToString(), t.valoare.ToString() });
                lv1.Tag = t;
                listView1.Items.Add(lv1);

            }
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left &&
                listView1.FocusedItem.Bounds.Contains(e.Location))

            {
                btnEditare_Click(sender, e);
            }
        }


        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                MessageBox.Show("Doresti sa stergi turistul?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
;
                Turist t = listView1.SelectedItems[0].Tag as Turist;
                listaTuristi.Remove(t);

                populeazaListView1();
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaTuristi == null)
            {
                MessageBox.Show("invalid");

            }
            else
            {
                BinaryFormatter format = new BinaryFormatter();
                FileStream stream = new FileStream("binar.dat", FileMode.Create);
                format.Serialize(stream, listaTuristi);
                stream.Close();
                MessageBox.Show("Fisierul binar a fost salvat");
            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter format = new BinaryFormatter();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisierul binar";
            ofd.Filter = "Text files (*.txt)|*.txt|Binary files (*.dat)|*.dat|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(ofd.FileName, FileMode.Open);
                listaTuristi = format.Deserialize(stream) as List<Turist>;
                stream.Close();
                populeazaListView1();

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "X")
            {
                MessageBox.Show("inchidere");
                this.Close();

            }

            if (e.Control && e.KeyCode.ToString() == "D")
            {
                if (listView1.SelectedItems.Count != 0)
                {
                    MessageBox.Show("Doresti sa stergi cartea?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    ;
                    Turist t= listView1.SelectedItems[0].Tag as Turist;
                    listaTuristi.Remove(t);

                    populeazaListView1();
                }

            }

        }

        private void salveazaCaFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName);

                writer.WriteLine("Nume:  Prenume:  Telefon: Pret: Valoare totala:  ");
                foreach (Turist t in listaTuristi)
                {
                    writer.WriteLine(t.nume + " " + t.prenume + " " + t.telefon + " "+ t.pret + " " + t.valoare);
                }

                writer.Close();
            }
        }

        private void deschideFisiertextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza fisierul";
            ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listaTuristi.Clear();

                using (StreamReader stream = new StreamReader(ofd.FileName))
                {
                    string linie;
                    while ((linie = stream.ReadLine()) != null)
                    {
                        try
                        {
                            string[] token = linie.Split(' ');
                            Turist t = new Turist();
                            t.nume = token[0];
                            t.prenume = token[1];
                            t.telefon = token[2];
                            t.pret = int.Parse(token[3]);
                            t.valoare = int.Parse(token[4]);
                            listaTuristi.Add(t);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);
                        }
                    }
                }

                populeazaListView1();
            }
        }

        private void imprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }



        private void turistiDinBazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                FormBazeDate d = new FormBazeDate();
                this.Hide();
                d.ShowDialog();
            
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            // Configurați dialogul de printare
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;

            // Verificați dacă utilizatorul a selectat opțiuni de printare și apoi imprimați
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void dragSiDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                drop d = new drop();
                this.Hide();
                d.ShowDialog();
            
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            // Testăm selecția
            if (listView1.SelectedItems.Count != 0)
            {
                // Poziționare în listă
                Turist t = listaTuristi.ElementAt(listView1.SelectedIndices[0]);

                // Adăugăm noul formular și verificăm rezultatul dialogului
                FormEditare editare = new FormEditare(t);

                DialogResult dialog = editare.ShowDialog();

                // Actualizăm listView1 doar dacă dialogul s-a încheiat cu DialogResult.OK
                if (dialog == DialogResult.OK)
                {
                    populeazaListView1();
                }
            }
        }
    }
}
