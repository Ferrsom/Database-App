using System;
using System.Collections.Generic;
using System.Text;

namespace DatenbankApp
{
    public class MaProj
    {
        private int maNr;
        private int projNr;

        public int MaNr1 { get => maNr; set => maNr = value; }
        public int ProjNr1 { get => projNr; set => projNr = value; }

        public MaProj(int mnr, int pnr)
        { 
            maNr = mnr;
            projNr = pnr;
        }
    }
}
