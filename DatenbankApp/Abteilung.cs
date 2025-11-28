using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DatenbankApp
{
    public class Abteilung
    {
        private int AbtNr;
        private string AbtName;

        public int AbtNr1 { get => AbtNr; set => AbtNr = value; }
        public string AbtName1 { get => AbtName; set => AbtName = value; }
    
        public Abteilung(int nr, string nm)
        {
            AbtNr = nr;
            AbtName = nm;
        }

    }  
}
