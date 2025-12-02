using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DatenbankApp
{
    public class Projekt
    {
        private int ProjNr;
        private string ProjName;

        public int ProjNr1 { get => ProjNr; set => ProjNr = value; }
        public string ProjName1 { get => ProjName; set => ProjName = value; }

        public Projekt(int nr, string nm)
        {
            ProjNr = nr;
            ProjName = nm;
        }


    }
}
