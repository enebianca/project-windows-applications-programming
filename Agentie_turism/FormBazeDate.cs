using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentie_turism
{
    public partial class FormBazeDate : Form
    {
        public FormBazeDate()
        {
            InitializeComponent();
        }

        private void FormBazeDate_Load(object sender, EventArgs e)
        {
           
            this.turistTableAdapter.Fill(this.turistDataSet.turist);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iNAPOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Close();
            this.Hide();
        }
    }
}
