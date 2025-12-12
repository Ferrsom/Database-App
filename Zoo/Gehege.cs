using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Gehege
    {
        private int gID;
        private string GBezeichnung;
        private int kontinentID;

        public int gID1 { get => gID; set => gID = value; }
        public string GBezeichnung1 { get => GBezeichnung; set => GBezeichnung = value; }
        public int kontinentID1 { get => kontinentID; set => kontinentID = value; }

        public Gehege(int nr, string nm, int idn)
        {
            gID = nr;
            GBezeichnung = nm;
            kontinentID = idn;
        }
    }
}
