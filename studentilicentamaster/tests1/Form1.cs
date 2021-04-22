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
    public partial class Form1 : Form
    {

        ColectieLicenta colectiel = new ColectieLicenta();
        ColectieMaster colectiem = new ColectieMaster();
        Candidat c;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbVarsta.Text == "")
                errorProvider1.SetError(tbVarsta, "Introduceti cifre aferente codului!");
            try
            {
                string nume = tbNume.Text;
                int varsta = Convert.ToInt32(tbVarsta.Text);
                string profil = cbProfil.Text;
                Candidat c = new Candidat(nume, varsta, profil);
                MessageBox.Show(c.ToString());
                
                    if (cbProfil.SelectedItem.ToString() == "Licenta")
                    {
                        colectiel += c;
                    }
                    else
                        colectiem += c;
                

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Introdu valorile corect!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbNume.Text = "";
                tbVarsta.Clear();

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(colectiel, colectiem);
               
            frm.Show();
        }
    }
}
