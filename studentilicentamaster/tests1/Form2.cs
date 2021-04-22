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
using System.Runtime.Serialization.Formatters.Binary;

namespace tests1
{
    public partial class Form2 : Form
    {
        ColectieLicenta colectiel = new ColectieLicenta();
        ColectieMaster colectiemm = new ColectieMaster();
        Candidat c;
        public Form2(ColectieLicenta l, ColectieMaster m)
        {
            InitializeComponent();
            colectiel = l;
            tbCandidati.Text = l.ToString();
            colectiemm = m;
            tbprofilmaster.Text = m.ToString();
           

        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "(*.txt)|*.txt";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(svd.FileName);
                sw.WriteLine(colectiel.ToString());
                sw.WriteLine(colectiemm.ToString());
                sw.Close();
                MessageBox.Show("Salvat cu succes!");
            }
        }

        private void butoncitire_Click(object sender, EventArgs e)
        {
            OpenFileDialog svd = new OpenFileDialog();
            svd.Filter = "(*.txt)|*.txt";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(svd.FileName);
                tbCandidati.Clear();
                tbCandidati.Text += "Citit din fisierul" + svd.FileName + Environment.NewLine;
                tbCandidati.Text += sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("Citire cu succes!");
            }
        }

        private void serializare_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fileStream, tbCandidati.Text);
            bf.Serialize(fileStream, tbCandidati.Text);
            fileStream.Close();
            MessageBox.Show("Serializare cu succes!");
        }

        private void button1deserializare_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            tbCandidati.Text = (string)bf.Deserialize(fileStream);
            tbCandidati.Text = (string)bf.Deserialize(fileStream);

            tbCandidati.Clear();
            tbCandidati.Text += "Obiecte deserializate din fisier.dat" + Environment.NewLine;
            string result = "";
            foreach (Candidat c in colectiel.Candidat)
            {
                result += c.ToString() + Environment.NewLine;
            }
            foreach (Candidat c in colectiemm.Candidat)
            {
                result += c.ToString() + Environment.NewLine;
            }
            tbCandidati.Text += result;
            fileStream.Close();
            MessageBox.Show("Deserializare cu succes!");
        }

        private void tbCandidati_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vizualizareArboreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void licentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(colectiel);
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(colectiemm);
            frm.Show();
        }

        private void licentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5(colectiel);
            frm.Show();
        }
    }

}

