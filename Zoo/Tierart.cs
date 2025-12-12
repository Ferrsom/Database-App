using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tierart
    {
        private int tierartID;
        private string TABezeichnung;

        public int tierartID1 { get => tierartID; set => tierartID = value; }
        public string TABezeichnung1 { get => TABezeichnung; set => TABezeichnung = value; }

        public Tierart(int nr, string nm)
        {
            tierartID = nr;
            TABezeichnung = nm;
        }
    }
}
