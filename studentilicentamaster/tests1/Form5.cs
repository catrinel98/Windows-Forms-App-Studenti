using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tests1
{
    public partial class Form5 : Form
    {
        ColectieLicenta colectiel = new ColectieLicenta();
        public Form5(ColectieLicenta l)
        {
            InitializeComponent();
            colectiel = l;
        }

        private void button1populare_Click(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            foreach (Candidat c in colectiel.Candidat)
            {
                ListViewItem itm = new ListViewItem(c.Profil);
                itm.SubItems.Add(c.Nume);
                itm.SubItems.Add(c.Varsta.ToString());
                listView1.Items.Add(itm);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                    itm.Remove();
        }
       

            private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stergeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                    itm.Remove();
        }
    }
}
