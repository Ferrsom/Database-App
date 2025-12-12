using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Füttern
    {
        private int fuetID;
        private string Menge;
        private string Uhrzeit;
        private int TierID;
        private int FutterID;

        public int fuetID1 { get => fuetID; set => fuetID = value; }
        public string Menge1 { get => Menge; set => Menge = value; }
        public string Uhrzeit1 { get => Uhrzeit; set => Uhrzeit = value; }
        public int TierID1 { get => TierID; set => TierID = value; }
        public int FutterID1 { get => FutterID; set => FutterID = value; }

        public Füttern(int nr, string mg, string z, int tid, int fid)
        {
            fuetID = nr;
            Menge = mg;
            Uhrzeit = z;
            TierID = tid;
            FutterID = fid;
        }
    }
}
