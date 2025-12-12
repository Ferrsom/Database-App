namespace Zoo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabKo = new TabPage();
            label11 = new Label();
            label12 = new Label();
            tbKBez = new TextBox();
            tbKID = new TextBox();
            btnKoD = new Button();
            btnKoA = new Button();
            lbKo = new ListBox();
            tabGe = new TabPage();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            cbGkid = new ComboBox();
            tbGBez = new TextBox();
            tbGID = new TextBox();
            btnGeD = new Button();
            btnGeA = new Button();
            lbGe = new ListBox();
            tabTa = new TabPage();
            label23 = new Label();
            label24 = new Label();
            tbTaBez = new TextBox();
            tbTaID = new TextBox();
            btnTaD = new Button();
            btnTaA = new Button();
            lbTa = new ListBox();
            tabTi = new TabPage();
            rbTIfue = new RadioButton();
            rbTIti = new RadioButton();
            btnCsv = new Button();
            gbTIFU = new GroupBox();
            label18 = new Label();
            tbTIFUmen = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tbTIFUuhr = new TextBox();
            cbTIFUfut = new ComboBox();
            btnDTIFU = new Button();
            btnATIFU = new Button();
            lbTIFU = new ListBox();
            tbTiGeb = new TextBox();
            dtpTiGeb = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbTigid = new ComboBox();
            cbTitid = new ComboBox();
            tbTiGew = new TextBox();
            tbTiNam = new TextBox();
            tbTiID = new TextBox();
            btnTiD = new Button();
            btnTiA = new Button();
            lbTi = new ListBox();
            tabFu = new TabPage();
            tbFuKom = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            label17 = new Label();
            tbFuVe = new TextBox();
            tbFuBez = new TextBox();
            tbFuID = new TextBox();
            btnFuD = new Button();
            btnFuA = new Button();
            lbFu = new ListBox();
            tabUb = new TabPage();
            pbUb = new PictureBox();
            dgvUb = new DataGridView();
            Tier = new DataGridViewTextBoxColumn();
            Gewicht = new DataGridViewTextBoxColumn();
            Tierart = new DataGridViewTextBoxColumn();
            Gehege = new DataGridViewTextBoxColumn();
            Kontinent = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabKo.SuspendLayout();
            tabGe.SuspendLayout();
            tabTa.SuspendLayout();
            tabTi.SuspendLayout();
            gbTIFU.SuspendLayout();
            tabFu.SuspendLayout();
            tabUb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUb).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabKo);
            tabControl1.Controls.Add(tabGe);
            tabControl1.Controls.Add(tabTa);
            tabControl1.Controls.Add(tabTi);
            tabControl1.Controls.Add(tabFu);
            tabControl1.Controls.Add(tabUb);
            tabControl1.Location = new Point(19, 14);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(896, 477);
            tabControl1.TabIndex = 0;
            // 
            // tabKo
            // 
            tabKo.Controls.Add(label11);
            tabKo.Controls.Add(label12);
            tabKo.Controls.Add(tbKBez);
            tabKo.Controls.Add(tbKID);
            tabKo.Controls.Add(btnKoD);
            tabKo.Controls.Add(btnKoA);
            tabKo.Controls.Add(lbKo);
            tabKo.Location = new Point(4, 29);
            tabKo.Name = "tabKo";
            tabKo.Padding = new Padding(3);
            tabKo.Size = new Size(888, 444);
            tabKo.TabIndex = 0;
            tabKo.Text = "Kontinent";
            tabKo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 76);
            label11.Name = "label11";
            label11.Size = new Size(102, 20);
            label11.TabIndex = 25;
            label11.Text = "KBezeichnung";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(59, 32);
            label12.Name = "label12";
            label12.Size = new Size(31, 20);
            label12.TabIndex = 24;
            label12.Text = "kID";
            // 
            // tbKBez
            // 
            tbKBez.Location = new Point(176, 76);
            tbKBez.Name = "tbKBez";
            tbKBez.Size = new Size(191, 27);
            tbKBez.TabIndex = 19;
            // 
            // tbKID
            // 
            tbKID.Location = new Point(176, 32);
            tbKID.Name = "tbKID";
            tbKID.ReadOnly = true;
            tbKID.Size = new Size(191, 27);
            tbKID.TabIndex = 18;
            // 
            // btnKoD
            // 
            btnKoD.Location = new Point(449, 323);
            btnKoD.Name = "btnKoD";
            btnKoD.Size = new Size(213, 42);
            btnKoD.TabIndex = 17;
            btnKoD.Text = "delete";
            btnKoD.UseVisualStyleBackColor = true;
            btnKoD.Click += btnKoD_Click;
            // 
            // btnKoA
            // 
            btnKoA.Location = new Point(108, 323);
            btnKoA.Name = "btnKoA";
            btnKoA.Size = new Size(213, 42);
            btnKoA.TabIndex = 16;
            btnKoA.Text = "add / update";
            btnKoA.UseVisualStyleBackColor = true;
            btnKoA.Click += btnKoA_Click;
            // 
            // lbKo
            // 
            lbKo.FormattingEnabled = true;
            lbKo.Location = new Point(436, 24);
            lbKo.Name = "lbKo";
            lbKo.Size = new Size(239, 284);
            lbKo.TabIndex = 15;
            lbKo.SelectedIndexChanged += lbKo_SelectedIndexChanged;
            // 
            // tabGe
            // 
            tabGe.Controls.Add(label14);
            tabGe.Controls.Add(label15);
            tabGe.Controls.Add(label16);
            tabGe.Controls.Add(cbGkid);
            tabGe.Controls.Add(tbGBez);
            tabGe.Controls.Add(tbGID);
            tabGe.Controls.Add(btnGeD);
            tabGe.Controls.Add(btnGeA);
            tabGe.Controls.Add(lbGe);
            tabGe.Location = new Point(4, 29);
            tabGe.Name = "tabGe";
            tabGe.Padding = new Padding(3);
            tabGe.Size = new Size(888, 444);
            tabGe.TabIndex = 1;
            tabGe.Text = "Gehege";
            tabGe.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(59, 125);
            label14.Name = "label14";
            label14.Size = new Size(86, 20);
            label14.TabIndex = 28;
            label14.Text = "kontinentID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(59, 81);
            label15.Name = "label15";
            label15.Size = new Size(103, 20);
            label15.TabIndex = 27;
            label15.Text = "GBezeichnung";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(59, 37);
            label16.Name = "label16";
            label16.Size = new Size(33, 20);
            label16.TabIndex = 26;
            label16.Text = "gID";
            // 
            // cbGkid
            // 
            cbGkid.FormattingEnabled = true;
            cbGkid.Location = new Point(177, 125);
            cbGkid.Name = "cbGkid";
            cbGkid.Size = new Size(191, 28);
            cbGkid.TabIndex = 22;
            // 
            // tbGBez
            // 
            tbGBez.Location = new Point(177, 81);
            tbGBez.Name = "tbGBez";
            tbGBez.Size = new Size(191, 27);
            tbGBez.TabIndex = 21;
            // 
            // tbGID
            // 
            tbGID.Location = new Point(177, 37);
            tbGID.Name = "tbGID";
            tbGID.ReadOnly = true;
            tbGID.Size = new Size(191, 27);
            tbGID.TabIndex = 20;
            // 
            // btnGeD
            // 
            btnGeD.Location = new Point(449, 323);
            btnGeD.Name = "btnGeD";
            btnGeD.Size = new Size(213, 42);
            btnGeD.TabIndex = 17;
            btnGeD.Text = "delete";
            btnGeD.UseVisualStyleBackColor = true;
            btnGeD.Click += btnGeD_Click;
            // 
            // btnGeA
            // 
            btnGeA.Location = new Point(108, 323);
            btnGeA.Name = "btnGeA";
            btnGeA.Size = new Size(213, 42);
            btnGeA.TabIndex = 16;
            btnGeA.Text = "add / update";
            btnGeA.UseVisualStyleBackColor = true;
            btnGeA.Click += btnGeA_Click;
            // 
            // lbGe
            // 
            lbGe.FormattingEnabled = true;
            lbGe.Location = new Point(436, 24);
            lbGe.Name = "lbGe";
            lbGe.Size = new Size(239, 284);
            lbGe.TabIndex = 15;
            lbGe.SelectedIndexChanged += lbGe_SelectedIndexChanged;
            // 
            // tabTa
            // 
            tabTa.Controls.Add(label23);
            tabTa.Controls.Add(label24);
            tabTa.Controls.Add(tbTaBez);
            tabTa.Controls.Add(tbTaID);
            tabTa.Controls.Add(btnTaD);
            tabTa.Controls.Add(btnTaA);
            tabTa.Controls.Add(lbTa);
            tabTa.Location = new Point(4, 29);
            tabTa.Name = "tabTa";
            tabTa.Size = new Size(888, 444);
            tabTa.TabIndex = 2;
            tabTa.Text = "Tierart";
            tabTa.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(51, 76);
            label23.Name = "label23";
            label23.Size = new Size(110, 20);
            label23.TabIndex = 25;
            label23.Text = "TABezeichnung";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(51, 32);
            label24.Name = "label24";
            label24.Size = new Size(64, 20);
            label24.TabIndex = 24;
            label24.Text = "tierartID";
            // 
            // tbTaBez
            // 
            tbTaBez.Location = new Point(176, 76);
            tbTaBez.Name = "tbTaBez";
            tbTaBez.Size = new Size(191, 27);
            tbTaBez.TabIndex = 19;
            // 
            // tbTaID
            // 
            tbTaID.Location = new Point(176, 32);
            tbTaID.Name = "tbTaID";
            tbTaID.ReadOnly = true;
            tbTaID.Size = new Size(191, 27);
            tbTaID.TabIndex = 18;
            // 
            // btnTaD
            // 
            btnTaD.Location = new Point(449, 323);
            btnTaD.Name = "btnTaD";
            btnTaD.Size = new Size(213, 42);
            btnTaD.TabIndex = 17;
            btnTaD.Text = "delete";
            btnTaD.UseVisualStyleBackColor = true;
            btnTaD.Click += btnTaD_Click;
            // 
            // btnTaA
            // 
            btnTaA.Location = new Point(108, 323);
            btnTaA.Name = "btnTaA";
            btnTaA.Size = new Size(213, 42);
            btnTaA.TabIndex = 16;
            btnTaA.Text = "add / update";
            btnTaA.UseVisualStyleBackColor = true;
            btnTaA.Click += btnTaA_Click;
            // 
            // lbTa
            // 
            lbTa.FormattingEnabled = true;
            lbTa.Location = new Point(436, 24);
            lbTa.Name = "lbTa";
            lbTa.Size = new Size(239, 284);
            lbTa.TabIndex = 15;
            lbTa.SelectedIndexChanged += lbTa_SelectedIndexChanged;
            // 
            // tabTi
            // 
            tabTi.Controls.Add(rbTIfue);
            tabTi.Controls.Add(rbTIti);
            tabTi.Controls.Add(btnCsv);
            tabTi.Controls.Add(gbTIFU);
            tabTi.Controls.Add(tbTiGeb);
            tabTi.Controls.Add(dtpTiGeb);
            tabTi.Controls.Add(label6);
            tabTi.Controls.Add(label5);
            tabTi.Controls.Add(label4);
            tabTi.Controls.Add(label3);
            tabTi.Controls.Add(label2);
            tabTi.Controls.Add(label1);
            tabTi.Controls.Add(cbTigid);
            tabTi.Controls.Add(cbTitid);
            tabTi.Controls.Add(tbTiGew);
            tabTi.Controls.Add(tbTiNam);
            tabTi.Controls.Add(tbTiID);
            tabTi.Controls.Add(btnTiD);
            tabTi.Controls.Add(btnTiA);
            tabTi.Controls.Add(lbTi);
            tabTi.Location = new Point(4, 29);
            tabTi.Name = "tabTi";
            tabTi.Size = new Size(888, 444);
            tabTi.TabIndex = 3;
            tabTi.Text = "Tiere";
            tabTi.UseVisualStyleBackColor = true;
            // 
            // rbTIfue
            // 
            rbTIfue.AutoSize = true;
            rbTIfue.Location = new Point(273, 403);
            rbTIfue.Name = "rbTIfue";
            rbTIfue.Size = new Size(128, 24);
            rbTIfue.TabIndex = 20;
            rbTIfue.TabStop = true;
            rbTIfue.Text = "Fütterungsplan";
            rbTIfue.UseVisualStyleBackColor = true;
            // 
            // rbTIti
            // 
            rbTIti.AutoSize = true;
            rbTIti.Location = new Point(273, 379);
            rbTIti.Name = "rbTIti";
            rbTIti.Size = new Size(63, 24);
            rbTIti.TabIndex = 19;
            rbTIti.TabStop = true;
            rbTIti.Text = "Tiere";
            rbTIti.UseVisualStyleBackColor = true;
            // 
            // btnCsv
            // 
            btnCsv.Location = new Point(407, 386);
            btnCsv.Name = "btnCsv";
            btnCsv.Size = new Size(96, 39);
            btnCsv.TabIndex = 18;
            btnCsv.Text = "CSV export";
            btnCsv.UseVisualStyleBackColor = true;
            btnCsv.Click += btnCsv_Click;
            // 
            // gbTIFU
            // 
            gbTIFU.Controls.Add(label18);
            gbTIFU.Controls.Add(tbTIFUmen);
            gbTIFU.Controls.Add(label8);
            gbTIFU.Controls.Add(label7);
            gbTIFU.Controls.Add(tbTIFUuhr);
            gbTIFU.Controls.Add(cbTIFUfut);
            gbTIFU.Controls.Add(btnDTIFU);
            gbTIFU.Controls.Add(btnATIFU);
            gbTIFU.Controls.Add(lbTIFU);
            gbTIFU.Location = new Point(689, 16);
            gbTIFU.Name = "gbTIFU";
            gbTIFU.Size = new Size(181, 411);
            gbTIFU.TabIndex = 17;
            gbTIFU.TabStop = false;
            gbTIFU.Text = "Fütterungsplan";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 280);
            label18.Name = "label18";
            label18.Size = new Size(55, 20);
            label18.TabIndex = 8;
            label18.Text = "Menge";
            // 
            // tbTIFUmen
            // 
            tbTIFUmen.Location = new Point(15, 303);
            tbTIFUmen.Name = "tbTIFUmen";
            tbTIFUmen.Size = new Size(153, 27);
            tbTIFUmen.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 227);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 6;
            label8.Text = "Uhrzeit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 173);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 5;
            label7.Text = "Futter (neu anlegen)";
            // 
            // tbTIFUuhr
            // 
            tbTIFUuhr.Location = new Point(15, 250);
            tbTIFUuhr.Name = "tbTIFUuhr";
            tbTIFUuhr.Size = new Size(153, 27);
            tbTIFUuhr.TabIndex = 4;
            // 
            // cbTIFUfut
            // 
            cbTIFUfut.FormattingEnabled = true;
            cbTIFUfut.Location = new Point(15, 196);
            cbTIFUfut.Name = "cbTIFUfut";
            cbTIFUfut.Size = new Size(153, 28);
            cbTIFUfut.TabIndex = 3;
            cbTIFUfut.SelectedIndexChanged += cbTIFUfut_SelectedIndexChanged;
            // 
            // btnDTIFU
            // 
            btnDTIFU.Location = new Point(15, 376);
            btnDTIFU.Name = "btnDTIFU";
            btnDTIFU.Size = new Size(153, 26);
            btnDTIFU.TabIndex = 2;
            btnDTIFU.Text = "löschen";
            btnDTIFU.UseVisualStyleBackColor = true;
            btnDTIFU.Click += btnDTIFU_Click;
            // 
            // btnATIFU
            // 
            btnATIFU.Location = new Point(15, 346);
            btnATIFU.Name = "btnATIFU";
            btnATIFU.Size = new Size(153, 26);
            btnATIFU.TabIndex = 1;
            btnATIFU.Text = "zuweisen";
            btnATIFU.UseVisualStyleBackColor = true;
            btnATIFU.Click += btnATIFU_Click;
            // 
            // lbTIFU
            // 
            lbTIFU.FormattingEnabled = true;
            lbTIFU.Location = new Point(15, 26);
            lbTIFU.Name = "lbTIFU";
            lbTIFU.Size = new Size(153, 144);
            lbTIFU.TabIndex = 0;
            lbTIFU.SelectedIndexChanged += lbTIFU_SelectedIndexChanged;
            // 
            // tbTiGeb
            // 
            tbTiGeb.Location = new Point(175, 165);
            tbTiGeb.Name = "tbTiGeb";
            tbTiGeb.Size = new Size(191, 27);
            tbTiGeb.TabIndex = 16;
            // 
            // dtpTiGeb
            // 
            dtpTiGeb.Format = DateTimePickerFormat.Short;
            dtpTiGeb.Location = new Point(175, 289);
            dtpTiGeb.Name = "dtpTiGeb";
            dtpTiGeb.Size = new Size(191, 27);
            dtpTiGeb.TabIndex = 15;
            dtpTiGeb.Value = new DateTime(2025, 12, 9, 12, 56, 13, 0);
            dtpTiGeb.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 253);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 14;
            label6.Text = "GehegeID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 208);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 13;
            label5.Text = "TierartID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 164);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 12;
            label4.Text = "Geburtsdatum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 120);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 11;
            label3.Text = "Gewicht";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 76);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 32);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 9;
            label1.Text = "tierID";
            // 
            // cbTigid
            // 
            cbTigid.FormattingEnabled = true;
            cbTigid.Location = new Point(175, 253);
            cbTigid.Name = "cbTigid";
            cbTigid.Size = new Size(191, 28);
            cbTigid.TabIndex = 8;
            // 
            // cbTitid
            // 
            cbTitid.FormattingEnabled = true;
            cbTitid.Location = new Point(175, 208);
            cbTitid.Name = "cbTitid";
            cbTitid.Size = new Size(191, 28);
            cbTitid.TabIndex = 7;
            // 
            // tbTiGew
            // 
            tbTiGew.Location = new Point(175, 120);
            tbTiGew.Name = "tbTiGew";
            tbTiGew.Size = new Size(191, 27);
            tbTiGew.TabIndex = 5;
            // 
            // tbTiNam
            // 
            tbTiNam.Location = new Point(175, 76);
            tbTiNam.Name = "tbTiNam";
            tbTiNam.Size = new Size(191, 27);
            tbTiNam.TabIndex = 4;
            // 
            // tbTiID
            // 
            tbTiID.Location = new Point(175, 32);
            tbTiID.Name = "tbTiID";
            tbTiID.ReadOnly = true;
            tbTiID.Size = new Size(191, 27);
            tbTiID.TabIndex = 3;
            // 
            // btnTiD
            // 
            btnTiD.Location = new Point(448, 323);
            btnTiD.Name = "btnTiD";
            btnTiD.Size = new Size(213, 42);
            btnTiD.TabIndex = 2;
            btnTiD.Text = "delete";
            btnTiD.UseVisualStyleBackColor = true;
            btnTiD.Click += btnTiD_Click;
            // 
            // btnTiA
            // 
            btnTiA.Location = new Point(107, 323);
            btnTiA.Name = "btnTiA";
            btnTiA.Size = new Size(213, 42);
            btnTiA.TabIndex = 1;
            btnTiA.Text = "add / update";
            btnTiA.UseVisualStyleBackColor = true;
            btnTiA.Click += btnTiA_Click;
            // 
            // lbTi
            // 
            lbTi.FormattingEnabled = true;
            lbTi.Location = new Point(435, 24);
            lbTi.Name = "lbTi";
            lbTi.Size = new Size(239, 284);
            lbTi.TabIndex = 0;
            lbTi.SelectedIndexChanged += lbTi_SelectedIndexChanged;
            // 
            // tabFu
            // 
            tabFu.Controls.Add(tbFuKom);
            tabFu.Controls.Add(label9);
            tabFu.Controls.Add(label10);
            tabFu.Controls.Add(label13);
            tabFu.Controls.Add(label17);
            tabFu.Controls.Add(tbFuVe);
            tabFu.Controls.Add(tbFuBez);
            tabFu.Controls.Add(tbFuID);
            tabFu.Controls.Add(btnFuD);
            tabFu.Controls.Add(btnFuA);
            tabFu.Controls.Add(lbFu);
            tabFu.Location = new Point(4, 29);
            tabFu.Name = "tabFu";
            tabFu.Size = new Size(888, 444);
            tabFu.TabIndex = 5;
            tabFu.Text = "Futter";
            tabFu.UseVisualStyleBackColor = true;
            // 
            // tbFuKom
            // 
            tbFuKom.Location = new Point(193, 171);
            tbFuKom.Multiline = true;
            tbFuKom.Name = "tbFuKom";
            tbFuKom.Size = new Size(191, 69);
            tbFuKom.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 170);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 28;
            label9.Text = "Kommentar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 126);
            label10.Name = "label10";
            label10.Size = new Size(143, 20);
            label10.TabIndex = 27;
            label10.Text = "Verpackungsgroesse";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 82);
            label13.Name = "label13";
            label13.Size = new Size(100, 20);
            label13.TabIndex = 26;
            label13.Text = "FBezeichnung";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(29, 38);
            label17.Name = "label17";
            label17.Size = new Size(29, 20);
            label17.TabIndex = 25;
            label17.Text = "fID";
            // 
            // tbFuVe
            // 
            tbFuVe.Location = new Point(193, 126);
            tbFuVe.Name = "tbFuVe";
            tbFuVe.Size = new Size(191, 27);
            tbFuVe.TabIndex = 22;
            // 
            // tbFuBez
            // 
            tbFuBez.Location = new Point(193, 82);
            tbFuBez.Name = "tbFuBez";
            tbFuBez.Size = new Size(191, 27);
            tbFuBez.TabIndex = 21;
            // 
            // tbFuID
            // 
            tbFuID.Location = new Point(193, 38);
            tbFuID.Name = "tbFuID";
            tbFuID.ReadOnly = true;
            tbFuID.Size = new Size(191, 27);
            tbFuID.TabIndex = 20;
            // 
            // btnFuD
            // 
            btnFuD.Location = new Point(446, 329);
            btnFuD.Name = "btnFuD";
            btnFuD.Size = new Size(213, 42);
            btnFuD.TabIndex = 19;
            btnFuD.Text = "delete";
            btnFuD.UseVisualStyleBackColor = true;
            btnFuD.Click += btnFuD_Click;
            // 
            // btnFuA
            // 
            btnFuA.Location = new Point(105, 329);
            btnFuA.Name = "btnFuA";
            btnFuA.Size = new Size(213, 42);
            btnFuA.TabIndex = 18;
            btnFuA.Text = "add / update";
            btnFuA.UseVisualStyleBackColor = true;
            btnFuA.Click += btnFuA_Click;
            // 
            // lbFu
            // 
            lbFu.FormattingEnabled = true;
            lbFu.Location = new Point(433, 30);
            lbFu.Name = "lbFu";
            lbFu.Size = new Size(239, 284);
            lbFu.TabIndex = 17;
            lbFu.SelectedIndexChanged += lbFu_SelectedIndexChanged;
            // 
            // tabUb
            // 
            tabUb.Controls.Add(pbUb);
            tabUb.Controls.Add(dgvUb);
            tabUb.Location = new Point(4, 29);
            tabUb.Name = "tabUb";
            tabUb.Size = new Size(888, 444);
            tabUb.TabIndex = 4;
            tabUb.Text = "Übersicht mit Bild";
            tabUb.UseVisualStyleBackColor = true;
            // 
            // pbUb
            // 
            pbUb.Location = new Point(707, 31);
            pbUb.Name = "pbUb";
            pbUb.Size = new Size(171, 351);
            pbUb.SizeMode = PictureBoxSizeMode.Zoom;
            pbUb.TabIndex = 1;
            pbUb.TabStop = false;
            // 
            // dgvUb
            // 
            dgvUb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUb.Columns.AddRange(new DataGridViewColumn[] { Tier, Gewicht, Tierart, Gehege, Kontinent });
            dgvUb.Location = new Point(23, 15);
            dgvUb.Name = "dgvUb";
            dgvUb.RowHeadersWidth = 51;
            dgvUb.Size = new Size(678, 391);
            dgvUb.TabIndex = 0;
            dgvUb.SelectionChanged += dgvUb_SelectionChanged;
            // 
            // Tier
            // 
            Tier.HeaderText = "Tier";
            Tier.MinimumWidth = 6;
            Tier.Name = "Tier";
            Tier.ReadOnly = true;
            Tier.Width = 125;
            // 
            // Gewicht
            // 
            Gewicht.HeaderText = "Gewicht";
            Gewicht.MinimumWidth = 6;
            Gewicht.Name = "Gewicht";
            Gewicht.ReadOnly = true;
            Gewicht.Width = 125;
            // 
            // Tierart
            // 
            Tierart.HeaderText = "Tierart";
            Tierart.MinimumWidth = 6;
            Tierart.Name = "Tierart";
            Tierart.ReadOnly = true;
            Tierart.Width = 125;
            // 
            // Gehege
            // 
            Gehege.HeaderText = "Gehege";
            Gehege.MinimumWidth = 6;
            Gehege.Name = "Gehege";
            Gehege.ReadOnly = true;
            Gehege.Width = 125;
            // 
            // Kontinent
            // 
            Kontinent.HeaderText = "Kontinent";
            Kontinent.MinimumWidth = 6;
            Kontinent.Name = "Kontinent";
            Kontinent.ReadOnly = true;
            Kontinent.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 503);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabKo.ResumeLayout(false);
            tabKo.PerformLayout();
            tabGe.ResumeLayout(false);
            tabGe.PerformLayout();
            tabTa.ResumeLayout(false);
            tabTa.PerformLayout();
            tabTi.ResumeLayout(false);
            tabTi.PerformLayout();
            gbTIFU.ResumeLayout(false);
            gbTIFU.PerformLayout();
            tabFu.ResumeLayout(false);
            tabFu.PerformLayout();
            tabUb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUb).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabKo;
        private TabPage tabGe;
        private TabPage tabTa;
        private TabPage tabTi;
        private TextBox tbTiGew;
        private TextBox tbTiNam;
        private TextBox tbTiID;
        private Button btnTiD;
        private Button btnTiA;
        private ListBox lbTi;
        private TabPage tabUb;
        private Label label11;
        private Label label12;
        private TextBox tbKBez;
        private TextBox tbKID;
        private Button btnKoD;
        private Button btnKoA;
        private ListBox lbKo;
        private Label label14;
        private Label label15;
        private Label label16;
        private ComboBox cbGkid;
        private TextBox tbGBez;
        private TextBox tbGID;
        private Button btnGeD;
        private Button btnGeA;
        private ListBox lbGe;
        private Label label23;
        private Label label24;
        private TextBox tbTaBez;
        private TextBox tbTaID;
        private Button btnTaD;
        private Button btnTaA;
        private ListBox lbTa;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbTigid;
        private ComboBox cbTitid;
        private DateTimePicker dtpTiGeb;
        private TextBox tbTiGeb;
        private DataGridView dgvUb;
        private DataGridViewTextBoxColumn Tier;
        private DataGridViewTextBoxColumn Gewicht;
        private DataGridViewTextBoxColumn Tierart;
        private DataGridViewTextBoxColumn Gehege;
        private DataGridViewTextBoxColumn Kontinent;
        private TabPage tabFu;
        private TextBox tbFuKom;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label17;
        private TextBox tbFuVe;
        private TextBox tbFuBez;
        private TextBox tbFuID;
        private Button btnFuD;
        private Button btnFuA;
        private ListBox lbFu;
        private GroupBox gbTIFU;
        private Button btnDTIFU;
        private Button btnATIFU;
        private ListBox lbTIFU;
        private TextBox tbTIFUuhr;
        private ComboBox cbTIFUfut;
        private Label label8;
        private Label label7;
        private Label label18;
        private TextBox tbTIFUmen;
        private PictureBox pbUb;
        private RadioButton rbTIfue;
        private RadioButton rbTIti;
        private Button btnCsv;
    }
}
