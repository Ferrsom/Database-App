namespace Zoo
{
    public partial class Form1 : Form
    {
        private Datenbank db;

        private List<Kontinent> liKo = new List<Kontinent>();
        private List<Tierart> liTa = new List<Tierart>();
        private List<Gehege> liGe = new List<Gehege>();
        private List<Tiere> liTi = new List<Tiere>();
        private List<Futter> liFu = new List<Futter>();
        private List<Füttern> liFue = new List<Füttern>();

        private const string bildPfad = "C:\\Users\\tn\\Desktop\\Projekte\\Zoo\\Assets\\";

        public Form1()
        {
            InitializeComponent();

            db = new Datenbank();
            dispKontinent();
            dispTierart();
            dispGehege();
            dispTiere();
            dispFutter();

            fillGrid();
        }

        private void clearBoxes()
        {
            //Ko
            tbKID.Text = "";
            tbKBez.Text = "";
            lbKo.SelectedIndex = -1;
            //Ta
            tbTaID.Text = "";
            tbTaBez.Text = "";
            lbTa.SelectedIndex = -1;
            //Ge
            tbGID.Text = "";
            tbGBez.Text = "";
            cbGkid.Text = "";
            cbGkid.SelectedIndex = -1;
            //Ti
            tbTiID.Text = "";
            tbTiNam.Text = "";
            tbTiGew.Text = "";
            tbTiGeb.Text = "";
            cbTitid.Text = "";
            cbTitid.SelectedIndex = -1;
            cbTigid.Text = "";
            cbTigid.SelectedIndex = -1;
            //Fu
            tbFuID.Text = "";
            tbFuBez.Text = "";
            tbFuVe.Text = "";
            tbFuKom.Text = "";
            lbFu.SelectedIndex = -1;
            //Fue
            lbTIFU.SelectedIndex = -1;
            cbTIFUfut.Text = "";
            cbTIFUfut.SelectedIndex = -1;
            tbTIFUuhr.Text = "";
            tbTIFUmen.Text = "";
        }

        //Bilder

        private void bildAnzeigen(int nr)
        {
            string bild = bildPfad + nr.ToString() + ".png";
            pbUb.Image = null;

            if (File.Exists(bild))
            {
                pbUb.Image = Image.FromFile(bild);
            }
            else
            {
                pbUb.Image = null;
            }
        }

        private void dgvUb_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUb.CurrentRow.Cells[0].Value.ToString() != "")
            {
                int index = liTi.FindIndex(x => x.Name1 == dgvUb.CurrentRow.Cells[0].Value.ToString());

                lbTi.SelectedIndex = index;

                int index2 = liTi[lbTi.SelectedIndex].tierID1;

                bildAnzeigen(index2);
            }
        }

        //Kontinent

        private void dispKontinent()
        {
            liKo = db.getKontinent();
            lbKo.Items.Clear();
            cbGkid.Items.Clear();

            foreach (Kontinent ko in liKo)
            {
                lbKo.Items.Add(ko.KBezeichnung1);
                cbGkid.Items.Add(ko.KBezeichnung1); //Dies wird in Tab:Gehege gezeigt
            }
            clearBoxes();
        }

        private void lbKo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKo.SelectedIndex != -1)
            {
                tbKID.Text = liKo[lbKo.SelectedIndex].kID1.ToString();
                tbKBez.Text = liKo[lbKo.SelectedIndex].KBezeichnung1;
            }
        }

        private void btnKoA_Click(object sender, EventArgs e)
        {
            int nr = 0;
            int.TryParse(tbKID.Text, out nr);

            Kontinent ko = new Kontinent(nr, tbKBez.Text);
            db.saveKontinent(ko);
            dispKontinent();
        }

        private void btnKoD_Click(object sender, EventArgs e)
        {
            if (lbKo.SelectedIndex != -1)
            {
                int nr = liKo[lbKo.SelectedIndex].kID1;
                db.delKontinent(nr);
                dispKontinent();
            }
        }

        //Tierart

        private void dispTierart()
        {
            liTa = db.getTierart();
            lbTa.Items.Clear();
            cbTitid.Items.Clear();

            foreach (Tierart ta in liTa)
            {
                lbTa.Items.Add(ta.TABezeichnung1);
                cbTitid.Items.Add(ta.TABezeichnung1); //Dies wird in Tab:Tiere gezeigt
            }
            clearBoxes();
        }

        private void lbTa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTa.SelectedIndex != -1)
            {
                tbTaID.Text = liTa[lbTa.SelectedIndex].tierartID1.ToString();
                tbTaBez.Text = liTa[lbTa.SelectedIndex].TABezeichnung1;
            }
        }

        private void btnTaA_Click(object sender, EventArgs e)
        {
            int nr = 0;
            int.TryParse(tbTaID.Text, out nr);

            Tierart ta = new Tierart(nr, tbTaBez.Text);
            db.saveTierart(ta);
            dispTierart();
        }

        private void btnTaD_Click(object sender, EventArgs e)
        {
            if (lbTa.SelectedIndex != -1)
            {
                int nr = liTa[lbTa.SelectedIndex].tierartID1;
                db.delTierart(nr);
                dispTierart();
            }
        }

        //Gehege

        private void dispGehege()
        {
            liGe = db.getGehege();
            lbGe.Items.Clear();
            cbTigid.Items.Clear();

            foreach (Gehege ge in liGe)
            {
                lbGe.Items.Add(ge.GBezeichnung1);
                cbTigid.Items.Add(ge.GBezeichnung1); //Dies wird in Tab:Tiere gezeigt
            }
            clearBoxes();
        }

        private void lbGe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGe.SelectedIndex != -1)
            {
                tbGID.Text = liGe[lbGe.SelectedIndex].gID1.ToString();
                tbGBez.Text = liGe[lbGe.SelectedIndex].GBezeichnung1;

                if (liGe[lbGe.SelectedIndex].kontinentID1 != -1)
                {
                    int index = liKo.FindIndex(x => x.kID1 == liGe[lbGe.SelectedIndex].kontinentID1);
                    cbGkid.SelectedIndex = index;
                }
                else
                {
                    cbGkid.Text = "";
                    cbGkid.SelectedIndex = -1;
                }

            }
        }

        private void btnGeA_Click(object sender, EventArgs e)
        {
            int nr = 0;
            int.TryParse(tbGID.Text, out nr);
            int koId = cbGkid.SelectedIndex == -1 ? 0 : liKo[cbGkid.SelectedIndex].kID1;

            Gehege ge = new Gehege(nr,
                                   tbGBez.Text,
                                   koId);
            db.saveGehege(ge);
            dispGehege();
        }

        private void btnGeD_Click(object sender, EventArgs e)
        {
            if (lbGe.SelectedIndex != -1)
            {
                int nr = liGe[lbGe.SelectedIndex].gID1;
                db.delGehege(nr);
                dispGehege();
            }
        }

        //Tiere

        private void dispTiere()
        {
            liTi = db.getTiere();
            lbTi.Items.Clear();

            foreach (Tiere ti in liTi)
            {
                lbTi.Items.Add(ti.Name1);
            }
            clearBoxes();
        }

        private void lbTi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTi.SelectedIndex != -1)
            {
                tbTiID.Text = liTi[lbTi.SelectedIndex].tierID1.ToString();
                tbTiNam.Text = liTi[lbTi.SelectedIndex].Name1;
                tbTiGew.Text = liTi[lbTi.SelectedIndex].Gewicht1.ToString();
                tbTiGeb.Text = liTi[lbTi.SelectedIndex].Geburtsdatum1;

                dispFüttern(liTi[lbTi.SelectedIndex].tierID1);

                if (liTi[lbTi.SelectedIndex].TierartID1 != -1)
                {
                    int index1 = liTa.FindIndex(x => x.tierartID1 == liTi[lbTi.SelectedIndex].TierartID1);
                    cbTitid.SelectedIndex = index1;
                }
                else
                {
                    cbTitid.Text = "";
                    cbTitid.SelectedIndex = -1;
                }

                if (liTi[lbTi.SelectedIndex].GehegeID1 != -1)
                {
                    int index2 = liGe.FindIndex(x => x.gID1 == liTi[lbTi.SelectedIndex].GehegeID1);
                    cbTigid.SelectedIndex = index2;
                }
                else
                {
                    cbTigid.Text = "";
                    cbTigid.SelectedIndex = -1;
                }

            }
        }

        private void btnTiA_Click(object sender, EventArgs e)
        {
            int nr = 0;
            int.TryParse(tbTiID.Text, out nr);

            decimal gw = 0;
            decimal.TryParse(tbTiGew.Text, out gw);


            int taId = cbTitid.SelectedIndex == -1 ? 0 : liTa[cbTitid.SelectedIndex].tierartID1;
            int geId = cbTigid.SelectedIndex == -1 ? 0 : liGe[cbTigid.SelectedIndex].gID1;

            Tiere ti = new Tiere(nr,
                                 tbTiNam.Text,
                                 gw,
                                 tbTiGeb.Text,
                                 taId,
                                 geId);
            db.saveTiere(ti);
            dispTiere();
        }

        private void btnTiD_Click(object sender, EventArgs e)
        {
            if (lbTi.SelectedIndex != -1)
            {
                int nr = liTi[lbTi.SelectedIndex].tierID1;
                db.delTiere(nr);
                dispTiere();
            }
        }

        //Grid

        private void fillGrid()
        {
            dgvUb.Rows.Clear();

            foreach (Tiere ti in liTi)
            {
                liGe = db.getGehege();

                string st = liTa.Find(x => x.tierartID1 == ti.TierartID1) == null ? "" :
                            liTa.Find(x => x.tierartID1 == ti.TierartID1).TABezeichnung1;

                string sg = liGe.Find(x => x.gID1 == ti.GehegeID1) == null ? "" :
                            liGe.Find(x => x.gID1 == ti.GehegeID1).GBezeichnung1;

                dgvUb.Rows.Add(ti.Name1, ti.Gewicht1, st, sg);

                liGe = db.gridGehege(ti.GehegeID1);

                foreach (Gehege ge in liGe)
                {
                    string sk = liKo.Find(x => x.kID1 == ge.kontinentID1) == null ? "" :
                                liKo.Find(x => x.kID1 == ge.kontinentID1).KBezeichnung1;

                    dgvUb.Rows.Add("", "", "", "", sk);
                }

                liGe = db.getGehege();
            }
        }

        //Futter

        private void dispFutter()
        {
            liFu = db.getFutter();
            lbFu.Items.Clear();
            cbTIFUfut.Items.Clear(); //

            foreach (Futter fu in liFu)
            {
                lbFu.Items.Add(fu.FBezeichnung1);
                cbTIFUfut.Items.Add(fu.FBezeichnung1); //Dies wird in GroupBox:Fütterungsplan gezeigt
            }
            clearBoxes();
        }

        private void lbFu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFu.SelectedIndex != -1)
            {
                tbFuID.Text = liFu[lbFu.SelectedIndex].fID1.ToString();
                tbFuBez.Text = liFu[lbFu.SelectedIndex].FBezeichnung1;
                tbFuVe.Text = liFu[lbFu.SelectedIndex].Verpackungsgroesse1;
                tbFuKom.Text = liFu[lbFu.SelectedIndex].Kommentar1;
            }
        }

        private void btnFuA_Click(object sender, EventArgs e)
        {
            int nr = 0;
            int.TryParse(tbFuID.Text, out nr);

            Futter fu = new Futter(nr, tbFuBez.Text, tbFuVe.Text, tbFuKom.Text);
            db.saveFutter(fu);
            dispFutter();
        }

        private void btnFuD_Click(object sender, EventArgs e)
        {
            if (lbFu.SelectedIndex != -1)
            {
                int nr = liFu[lbFu.SelectedIndex].fID1;
                db.delFutter(nr);
                dispFutter();
            }
        }

        //Füttern

        private void dispFüttern(int nr)
        {
            liFue = db.getFüttern(nr);
            lbTIFU.Items.Clear();

            foreach (Füttern fue in liFue)
            {
                string tfb = liFu.Find(x => x.fID1 == fue.FutterID1).FBezeichnung1;
                lbTIFU.Items.Add(tfb);
            }
            cbTIFUfut.Text = "";
            cbTIFUfut.SelectedIndex = -1;
            tbTIFUuhr.Text = "";
            tbTIFUmen.Text = "";
        }

        private void lbTIFU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTIFU.SelectedIndex != -1)
            {
                tbTIFUuhr.Text = liFue[lbTIFU.SelectedIndex].Uhrzeit1;
                tbTIFUmen.Text = liFue[lbTIFU.SelectedIndex].Menge1;
            }
        }

        private void btnATIFU_Click(object sender, EventArgs e)
        {
            if (tbTiID.Text != "" && cbTIFUfut.SelectedIndex != -1)
            {
                Füttern fue = new Füttern(0, tbTIFUmen.Text, tbTIFUuhr.Text, liTi[lbTi.SelectedIndex].tierID1, liFu[cbTIFUfut.SelectedIndex].fID1);

                db.saveFüttern(fue);
                dispFüttern(fue.TierID1);
            }
        }

        private void btnDTIFU_Click(object sender, EventArgs e)
        {
            if (lbTIFU.SelectedIndex != -1)
            {
                int tn = liFue[lbTIFU.SelectedIndex].TierID1;
                int nr = liFue[lbTIFU.SelectedIndex].fuetID1;
                db.delFüttern(nr);
                dispFüttern(tn);
            }
        }

        private void cbTIFUfut_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTIFU.SelectedIndex = -1;
            tbTIFUuhr.Text = "";
            tbTIFUmen.Text = "";
        }

    }
}
