using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests1
{
    [Serializable]
    public class Candidat
    {

        private string nume;
        private int varsta;
        private string profil;


        public Candidat(string n, int v, string p)
        {
            nume = n;
            varsta = v;
            profil = p;
        }

        public string Nume
            {
            get {return nume; }
            set { nume=value;}
}
         public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }
        public string Profil
        {
            get { return profil; }
            set { profil = value; }
        }

        public override string ToString()
        {
            return "candidatul " + nume + "are varsta de " + varsta + " ani " + " candideaza la profilul" + profil;
        }

    }

}
