namespace DatenbankApp
{
    public partial class Form1 : Form
    {
        private Datenbank db;

        private List<Mitarbeiter> liMa = new List<Mitarbeiter>();
        private List<Abteilung> liAb = new List<Abteilung>();


        public Form1()
        {
            InitializeComponent();

            db = new Datenbank();
            dispMitarbeiter();
            dispAbteilung();
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


            Mitarbeiter ma = new Mitarbeiter(nr,
                                             txtBox_mitNam.Text,
                                             txtBox_mitVor.Text,
                                             0);
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


        //Abteilungs

        private void dispAbteilung()
        {
            liAb = db.getAbteilung();
            li_abt.Items.Clear();

            foreach (Abteilung ab in liAb)
            {
                li_abt.Items.Add(ab.AbtName1);
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
    }
}
