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
    public partial class Form4 : Form
    {

        ColectieMaster colectiem = new ColectieMaster();
        public Form4(ColectieMaster m)
        {
            InitializeComponent();
            colectiem = m;
            TreeNode parinte = new TreeNode("Candidati");
            treeView1.Nodes.Add(parinte);
            foreach (Candidat c in colectiem.Candidat)
            {
                TreeNode copil = new TreeNode(c.Nume);
                parinte.Nodes.Add(copil);
                TreeNode nepot1 = new TreeNode(c.Varsta.ToString());
                copil.Nodes.Add(nepot1);
                TreeNode nepot2 = new TreeNode(c.Profil);
                copil.Nodes.Add(nepot2);
            }
            treeView1.ExpandAll();
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.SelectedNode.BackColor = Color.BlueViolet;
        }
    }
}

