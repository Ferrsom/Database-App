using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tiere
    {
        private int tierID;
        private string Name;
        private decimal Gewicht;
        private string Geburtsdatum;
        private int TierartID;
        private int GehegeID;

        public int tierID1 { get => tierID; set => tierID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public decimal Gewicht1 { get => Gewicht; set => Gewicht = value; }
        public string Geburtsdatum1 { get => Geburtsdatum; set => Geburtsdatum = value; }
        public int TierartID1 { get => TierartID; set => TierartID = value; }
        public int GehegeID1 { get => GehegeID; set => GehegeID = value; }

        public Tiere(int nr, string nm, decimal gw, string dt, int tid, int gid)
        {
            tierID = nr;
            Name = nm;
            Gewicht = gw;
            Geburtsdatum = dt;
            TierartID = tid;
            GehegeID = gid;
        }
    }
}
