using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tests1
{
   
    public partial class Form6 : Form
    {
        ColectieMaster colectiem = new ColectieMaster();
    public Form6(ColectieMaster m)
        {
            InitializeComponent();
            colectiem = m;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
           
          
          
        
        

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            foreach (Candidat c in colectiem.Candidat)
            {
                ListViewItem itm = new ListViewItem(c.Profil);
                itm.SubItems.Add(c.Nume);
                itm.SubItems.Add(c.Varsta.ToString());
                listView1.Items.Add(itm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                    itm.Remove();
        }
    }
}
