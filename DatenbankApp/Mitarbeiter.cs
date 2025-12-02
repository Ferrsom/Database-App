using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DatenbankApp
{
    public class Mitarbeiter
    {
        private int MaNr;
        private string MaName;
        private string MaVorname;
        private int MaAbtNr;

        public int MaNr1 { get => MaNr; set => MaNr = value; }
        public string MaName1 { get => MaName; set => MaName = value; }
        public string MaVorname1 { get => MaVorname; set => MaVorname = value; }
        public int MaAbtNr1 { get => MaAbtNr; set => MaAbtNr = value; }

        public Mitarbeiter(int nr, string nm, string vn, int anr)
        {
            MaNr = nr;
            MaName = nm;
            MaVorname = vn;
            MaAbtNr = anr;
        }

        public string toCSV()
        {
            return string.Format("{0};{1};{2};{3};", MaNr1, MaName1, MaVorname1, MaAbtNr1);
        }
    }
}
