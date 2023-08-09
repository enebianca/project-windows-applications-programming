using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentie_turism
{
    public partial class drop : Form
    {
        public drop()
        {
            InitializeComponent();
        }

    

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] cale = e.Data.GetData(DataFormats.FileDrop, false) as string[];
            foreach (String ca in cale)
            {
                string[] continut = File.ReadAllLines(ca);
                TreeNode rad = new TreeNode("Articole");
                treeView1.Nodes.Add(rad);
                foreach (string linie in continut)
                {
                    
                    string[] cuvinte = linie.Split(' ');
                    TreeNode copil = new TreeNode(cuvinte[0]); // Nume
                    rad.Nodes.Add(copil);
                    TreeNode co1 = new TreeNode("Nume " + cuvinte[0]);
                    copil.Nodes.Add(co1);
                    TreeNode co2 = new TreeNode("Prenume " + cuvinte[1]); // Prenume
                    copil.Nodes.Add(co2);
                    TreeNode co3 = new TreeNode("Telefon " + cuvinte[2]); // Telefon
                    copil.Nodes.Add(co3);
                    TreeNode co4 = new TreeNode("Pret " + cuvinte[3]); // Pret
                    copil.Nodes.Add(co4);
                    TreeNode co5 = new TreeNode("Valoare totala " + cuvinte[4]); // Valoare totala
                    copil.Nodes.Add(co5);
                }

            }
        }


        private void iNAPOIToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Close();
            this.Hide();
        }

        private void drop_Load(object sender, EventArgs e)
        {
            
                panel1.AllowDrop = true;
                panel1.DragEnter += panel1_DragEnter;
                panel1.DragDrop += panel1_DragDrop;
            

        }
    }
}
