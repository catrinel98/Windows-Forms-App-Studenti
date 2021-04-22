using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests1
{

   public class ColectieLicenta : ICloneable
    {
        private List<Candidat> candidatl;
        public ColectieLicenta()
        {
            candidatl = new List<Candidat>();
        }

        public ColectieLicenta(List<Candidat> Candidat)
        {
            candidatl = Candidat;
        }
        public List<Candidat> Candidat
        {
            get { return candidatl; }
            set { if (value != null) candidatl = value; }

        }

        public object Clone()
        {
            ColectieLicenta colectie = (ColectieLicenta)this.MemberwiseClone();
            List<Candidat> lista = new List<Candidat>();
            foreach (Candidat c in candidatl)
                lista.Add(c);
            colectie.candidatl = lista;
            return colectie;
        }


         public override string ToString()
        {
            string result="";
            foreach(Candidat c in candidatl)
            {
                result += c.ToString() + Environment.NewLine;
            }
            return result;
        }

        public static ColectieLicenta operator +(ColectieLicenta c, Candidat ca)
        {
            c.candidatl.Add(ca);
            return c;
        }
    }
    }
