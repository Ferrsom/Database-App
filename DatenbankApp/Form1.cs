namespace DatenbankApp
{
    public partial class Form1 : Form
    {
        private Datenbank db;

        private List<Mitarbeiter> liMa = new List<Mitarbeiter>();
        private List<Abteilung> liAb = new List<Abteilung>();
        private List<Projekt> liPr = new List<Projekt>();
        private List<MaProj> liMaProj = new List<MaProj>();

        private const string bildPfad = "C:\\Users\\Da.Melchor\\C# 2\\DatenbankApp\\Assets\\";


        public Form1()
        {
            InitializeComponent();

            db = new Datenbank();
            dispAbteilung();
            dispMitarbeiter();
            dispProjekt();

            fillGrid();
        }

        private void clearBoxes()
        {
            txtBox_mitNr.Text = "";
            txtBox_mitNam.Text = "";
            txtBox_mitVor.Text = "";
            li_mitab.SelectedIndex = -1;

            txtBox_abtNr.Text = "";
            txtBox_abtNam.Text = "";
            li_abt.SelectedIndex = -1;

            cb_Abteilung.Text = "";
            cb_Abteilung.SelectedIndex = -1;
        }
        
        //Bild

        private void bildAnzeigen(int nr)
        {

            string bild = bildPfad + nr.ToString() + ".png";
            pbMitarb.Image = null;

            if (File.Exists(bild))
            {
                pbMitarb.Image = Image.FromFile(bild);
            }
            else
            {
                pbMitarb.Image = null;
            }
        }

        // Mitarbeiter

        private void dispMitarbeiter()
        {
            liMa = db.getMitarbeiter();
            li_mitab.Items.Clear();

            foreach (Mitarbeiter mi in liMa)
            {
                li_mitab.Items.Add(mi.MaName1);
            }
            clearBoxes();
        }

        

        private void btn_spch_Click(object sender, EventArgs e)
        {
            //mitarbeiter instanz will be created temporarily to copy and save all the values

            int nr = 0;
            int.TryParse(txtBox_mitNr.Text, out nr);
            int abtNr = cb_Abteilung.SelectedIndex == -1 ? 0 : liAb[cb_Abteilung.SelectedIndex].AbtNr1;

            Mitarbeiter ma = new Mitarbeiter(nr,
                                             txtBox_mitNam.Text,
                                             txtBox_mitVor.Text,
                                             abtNr);
            db.saveMitarbeiter(ma);
            dispMitarbeiter();
        }

        private void li_mitab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (li_mitab.SelectedIndex != -1)
            {
                txtBox_mitNr.Text = liMa[li_mitab.SelectedIndex].MaNr1.ToString();
                txtBox_mitNam.Text = liMa[li_mitab.SelectedIndex].MaName1;
                txtBox_mitVor.Text = liMa[li_mitab.SelectedIndex].MaVorname1;

                bildAnzeigen(liMa[li_mitab.SelectedIndex].MaNr1);

                dispMaProj(liMa[li_mitab.SelectedIndex].MaNr1);

                if (liMa[li_mitab.SelectedIndex].MaAbtNr1 != -1)
                {
                    int index = liAb.FindIndex(x => x.AbtNr1 == liMa[li_mitab.SelectedIndex].MaAbtNr1); //lamda
                    cb_Abteilung.SelectedIndex = index;
                }
                else
                {
                    cb_Abteilung.Text = "";
                    cb_Abteilung.SelectedIndex = -1;
                }

            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (li_mitab.SelectedIndex != -1)
            {
                int nr = liMa[li_mitab.SelectedIndex].MaNr1;
                db.delMitarbeiter(nr);
                dispMitarbeiter();
            }
        }


        //Abteilung

        private void dispAbteilung()
        {
            liAb = db.getAbteilung();
            li_abt.Items.Clear();
            cb_Abteilung.Items.Clear();

            foreach (Abteilung ab in liAb)
            {
                li_abt.Items.Add(ab.AbtName1);
                cb_Abteilung.Items.Add(ab.AbtName1);
            }
            clearBoxes();
        }

        private void btn_spch_abt_Click(object sender, EventArgs e)
        {
            int nr = 0;
            int.TryParse(txtBox_abtNr.Text, out nr);


            Abteilung ab = new Abteilung(nr, txtBox_abtNam.Text);
            db.saveAbteilung(ab);
            dispAbteilung();
        }

        private void li_abt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (li_abt.SelectedIndex != -1)
            {
                txtBox_abtNr.Text = liAb[li_abt.SelectedIndex].AbtNr1.ToString();
                txtBox_abtNam.Text = liAb[li_abt.SelectedIndex].AbtName1;
            }
        }

        private void btn_del_abt_Click(object sender, EventArgs e)
        {
            if (li_abt.SelectedIndex != -1)
            {
                int nr = liAb[li_abt.SelectedIndex].AbtNr1;
                db.delAbteilung(nr);
                dispAbteilung();
            }
        }

        //Projekt

        private void dispProjekt()
        {
            liPr = db.getProjekt();
            li_pro.Items.Clear();
            cb_prmipr.Items.Clear();

            foreach (Projekt pr in liPr)
            {
                li_pro.Items.Add(pr.ProjName1);
                cb_prmipr.Items.Add(pr.ProjName1);
            }
            clearBoxes();
        }

        private void btn_spch_pro_Click(object sender, EventArgs e)
        {
            int nr = 0;
            int.TryParse(txtBox_prnr.Text, out nr);


            Projekt pr = new Projekt(nr, txtBox_prnm.Text);
            db.saveProjekt(pr);
            dispProjekt();
        }

        private void li_pro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (li_pro.SelectedIndex != -1)
            {
                txtBox_prnr.Text = liPr[li_pro.SelectedIndex].ProjNr1.ToString();
                txtBox_prnm.Text = liPr[li_pro.SelectedIndex].ProjName1;

                dispBtg(liPr[li_pro.SelectedIndex].ProjNr1);

                /*
                liMaProj = db.getBtg(int.Parse(li_pro.SelectedIndex));
                li_btg.Items.Clear();
                foreach (MaProj mp in liMaProj)
                {
                    li_btg.Items.Add(liMa.Find(x => x.MaNr1 == mp.MaNr1).MaName1);
                }
                */
            }
        }

        private void btn_del_pro_Click(object sender, EventArgs e)
        {
            if (li_pro.SelectedIndex != -1)
            {
                int nr = liPr[li_pro.SelectedIndex].ProjNr1;
                db.delProjekt(nr);
                dispProjekt();
            }
        }

        //MaProj

        private void dispMaProj(int manr)
        {
            liMaProj = db.getMaproj(manr);
            li_mapro.Items.Clear();

            foreach (MaProj mp in liMaProj)
            {
                string pn = liPr.Find(x => x.ProjNr1 == mp.ProjNr1).ProjName1;
                li_mapro.Items.Add(pn);
            }
            //clearBoxes(); not here, otherwise it´ll make the index -1 again and the list won´t be able to show anything (out of range)
        }

        private void btn_prmipr_Click(object sender, EventArgs e)
        {
            if (txtBox_mitNr.Text != "" && cb_prmipr.SelectedIndex != -1)
            {
                MaProj mp = new MaProj(int.Parse(txtBox_mitNr.Text), liPr[cb_prmipr.SelectedIndex].ProjNr1);

                db.saveMaProj(mp);
                dispMaProj(mp.MaNr1);
            }
        }

        //Beteiligung

        private void dispBtg(int mpr)
        {
            liMaProj = db.getBtg(mpr);
            li_btg.Items.Clear();

            foreach (MaProj mp in liMaProj)
            {
                string pma = liMa.Find(x => x.MaNr1 == mp.MaNr1).MaName1;
                li_btg.Items.Add(pma);
            }
        }

        private void btn_csv_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(bildPfad + "ma.csv", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            //eigentlich try-catch hier

            foreach (Mitarbeiter ma in liMa)
            {
                sw.WriteLine(ma.toCSV());
            }

            sw.Close();
            fs.Close();

            MessageBox.Show("Datei " + bildPfad + "ma.csv erzeugt.", "Moin",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Grid

        private void fillGrid()
        {
            dgv_usicht.Rows.Clear();

            foreach (Mitarbeiter mi in liMa)
            {
                string s = liAb.Find(x => x.AbtNr1 == mi.MaAbtNr1) == null ? "" :
                           liAb.Find(x => x.AbtNr1 == mi.MaAbtNr1).AbtName1;
                
                dgv_usicht.Rows.Add(mi.MaName1, mi.MaVorname1, s);

                liMaProj = db.getMaproj(mi.MaNr1);

                foreach (MaProj mp in liMaProj)
                {
                    string str = liPr.Find(x => x.ProjNr1 == mp.ProjNr1) == null ? "" :
                                 liPr.Find(x => x.ProjNr1 == mp.ProjNr1).ProjName1;

                    dgv_usicht.Rows.Add("", "", "", str);
                }
            }
        }

        private void dgv_usicht_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_usicht.CurrentRow.Cells[0].Value.ToString() != "")
            {
                int index = liMa.FindIndex(x => x.MaName1 == dgv_usicht.CurrentRow.Cells[0].Value.ToString());

                li_mitab.SelectedIndex = index;
                //tabControl1.TabPages[0].Show(); wollen wir nicht
            }
        }
    }
}
