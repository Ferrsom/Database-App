using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Kontinent
    {
        private int kID;
        private string KBezeichnung;

        public int kID1 { get => kID; set => kID = value; }
        public string KBezeichnung1 { get => KBezeichnung; set => KBezeichnung = value; }

        public Kontinent(int nr, string nm)
        {
            kID = nr;
            KBezeichnung = nm;
        }
    }
}
