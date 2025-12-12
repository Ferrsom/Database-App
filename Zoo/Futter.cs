using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Futter
    {
        private int fID;
        private string FBezeichnung;
        private string Verpackungsgroesse;
        private string Kommentar;

        public int fID1 { get => fID; set => fID = value; }
        public string FBezeichnung1 { get => FBezeichnung; set => FBezeichnung = value; }
        public string Verpackungsgroesse1 { get => Verpackungsgroesse; set => Verpackungsgroesse = value; }
        public string Kommentar1 { get => Kommentar; set => Kommentar = value; }

        public Futter(int nr, string nm, string gr, string km)
        {
            fID = nr;
            FBezeichnung = nm;
            Verpackungsgroesse = gr;
            Kommentar = km;
        }
    }
}
