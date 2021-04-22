using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests1
{
   public class ColectieMaster
    {

        private List<Candidat> candidatm;
        public ColectieMaster()
        {
            candidatm = new List<Candidat>();
        }

        public ColectieMaster (List<Candidat> Candidat)
        {
            candidatm = Candidat;
        }
        public List<Candidat> Candidat
        {
            get { return candidatm; }
            set { if (value != null) candidatm = value; }

        }

        public object Clone()
        {
            ColectieMaster colectie = (ColectieMaster)this.MemberwiseClone();
            List<Candidat> lista = new List<Candidat>();
            foreach (Candidat c in candidatm)
                lista.Add(c);
            colectie.candidatm = lista;
            return colectie;
        }


        public override string ToString()
        {
            string result = "";
            foreach (Candidat c in candidatm)
            {
                result += c.ToString() + Environment.NewLine;
            }
            return result;
        }

        public static ColectieMaster operator +(ColectieMaster c, Candidat ca)
        {
            c.candidatm.Add(ca);
            return c;
        }
    }
}
