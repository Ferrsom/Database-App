namespace DatenbankApp
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
            tabPage1 = new TabPage();
            btn_imp = new Button();
            btn_csv = new Button();
            pbMitarb = new PictureBox();
            groupBox1 = new GroupBox();
            btn_prmipr = new Button();
            cb_prmipr = new ComboBox();
            label9 = new Label();
            li_mapro = new ListBox();
            cb_Abteilung = new ComboBox();
            label6 = new Label();
            btn_del = new Button();
            btn_spch = new Button();
            li_mitab = new ListBox();
            txtBox_mitVor = new TextBox();
            txtBox_mitNam = new TextBox();
            txtBox_mitNr = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btn_del_abt = new Button();
            btn_spch_abt = new Button();
            li_abt = new ListBox();
            txtBox_abtNam = new TextBox();
            txtBox_abtNr = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            label10 = new Label();
            li_btg = new ListBox();
            btn_del_pro = new Button();
            btn_spch_pro = new Button();
            li_pro = new ListBox();
            txtBox_prnm = new TextBox();
            txtBox_prnr = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tabPage4 = new TabPage();
            dgv_usicht = new DataGridView();
            MA_Nachname = new DataGridViewTextBoxColumn();
            MA_Vorname = new DataGridViewTextBoxColumn();
            MA_Abteilung = new DataGridViewTextBoxColumn();
            MAinProjekt = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMitarb).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_usicht).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(36, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(720, 394);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_imp);
            tabPage1.Controls.Add(btn_csv);
            tabPage1.Controls.Add(pbMitarb);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(cb_Abteilung);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btn_del);
            tabPage1.Controls.Add(btn_spch);
            tabPage1.Controls.Add(li_mitab);
            tabPage1.Controls.Add(txtBox_mitVor);
            tabPage1.Controls.Add(txtBox_mitNam);
            tabPage1.Controls.Add(txtBox_mitNr);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(712, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Mitarbeiter";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_imp
            // 
            btn_imp.Location = new Point(598, 182);
            btn_imp.Name = "btn_imp";
            btn_imp.Size = new Size(78, 43);
            btn_imp.TabIndex = 14;
            btn_imp.Text = "CSV Import";
            btn_imp.UseVisualStyleBackColor = true;
            btn_imp.Click += btn_imp_Click;
            // 
            // btn_csv
            // 
            btn_csv.Location = new Point(471, 182);
            btn_csv.Name = "btn_csv";
            btn_csv.Size = new Size(92, 41);
            btn_csv.TabIndex = 13;
            btn_csv.Text = "CSV Export";
            btn_csv.UseVisualStyleBackColor = true;
            btn_csv.Click += btn_csv_Click;
            // 
            // pbMitarb
            // 
            pbMitarb.Location = new Point(23, 24);
            pbMitarb.Name = "pbMitarb";
            pbMitarb.Size = new Size(137, 172);
            pbMitarb.SizeMode = PictureBoxSizeMode.Zoom;
            pbMitarb.TabIndex = 12;
            pbMitarb.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_prmipr);
            groupBox1.Controls.Add(cb_prmipr);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(li_mapro);
            groupBox1.Location = new Point(38, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(642, 122);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Projekte";
            // 
            // btn_prmipr
            // 
            btn_prmipr.Location = new Point(38, 63);
            btn_prmipr.Name = "btn_prmipr";
            btn_prmipr.Size = new Size(187, 32);
            btn_prmipr.TabIndex = 3;
            btn_prmipr.Text = "zuweisen";
            btn_prmipr.UseVisualStyleBackColor = true;
            btn_prmipr.Click += btn_prmipr_Click;
            // 
            // cb_prmipr
            // 
            cb_prmipr.FormattingEnabled = true;
            cb_prmipr.Location = new Point(30, 29);
            cb_prmipr.Name = "cb_prmipr";
            cb_prmipr.Size = new Size(201, 23);
            cb_prmipr.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(428, 19);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 1;
            label9.Text = "Beteleigung an";
            // 
            // li_mapro
            // 
            li_mapro.FormattingEnabled = true;
            li_mapro.Location = new Point(433, 37);
            li_mapro.Name = "li_mapro";
            li_mapro.Size = new Size(195, 79);
            li_mapro.TabIndex = 0;
            // 
            // cb_Abteilung
            // 
            cb_Abteilung.FormattingEnabled = true;
            cb_Abteilung.Location = new Point(280, 139);
            cb_Abteilung.Name = "cb_Abteilung";
            cb_Abteilung.Size = new Size(152, 23);
            cb_Abteilung.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 147);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 9;
            label6.Text = "Abteilung";
            // 
            // btn_del
            // 
            btn_del.Location = new Point(489, 140);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(159, 28);
            btn_del.TabIndex = 8;
            btn_del.Text = "delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_spch
            // 
            btn_spch.Location = new Point(280, 178);
            btn_spch.Name = "btn_spch";
            btn_spch.Size = new Size(148, 27);
            btn_spch.TabIndex = 7;
            btn_spch.Text = "speichern";
            btn_spch.UseVisualStyleBackColor = true;
            btn_spch.Click += btn_spch_Click;
            // 
            // li_mitab
            // 
            li_mitab.FormattingEnabled = true;
            li_mitab.Location = new Point(476, 10);
            li_mitab.Name = "li_mitab";
            li_mitab.Size = new Size(204, 124);
            li_mitab.TabIndex = 6;
            li_mitab.SelectedIndexChanged += li_mitab_SelectedIndexChanged;
            // 
            // txtBox_mitVor
            // 
            txtBox_mitVor.Location = new Point(280, 101);
            txtBox_mitVor.Name = "txtBox_mitVor";
            txtBox_mitVor.Size = new Size(152, 23);
            txtBox_mitVor.TabIndex = 5;
            // 
            // txtBox_mitNam
            // 
            txtBox_mitNam.Location = new Point(280, 63);
            txtBox_mitNam.Name = "txtBox_mitNam";
            txtBox_mitNam.Size = new Size(152, 23);
            txtBox_mitNam.TabIndex = 4;
            // 
            // txtBox_mitNr
            // 
            txtBox_mitNr.Location = new Point(280, 25);
            txtBox_mitNr.Name = "txtBox_mitNr";
            txtBox_mitNr.ReadOnly = true;
            txtBox_mitNr.Size = new Size(152, 23);
            txtBox_mitNr.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 109);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Mitab Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 71);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Mitab Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Mitarb Nr";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_del_abt);
            tabPage2.Controls.Add(btn_spch_abt);
            tabPage2.Controls.Add(li_abt);
            tabPage2.Controls.Add(txtBox_abtNam);
            tabPage2.Controls.Add(txtBox_abtNr);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(712, 366);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Abteilung";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_del_abt
            // 
            btn_del_abt.Location = new Point(474, 171);
            btn_del_abt.Name = "btn_del_abt";
            btn_del_abt.Size = new Size(140, 28);
            btn_del_abt.TabIndex = 6;
            btn_del_abt.Text = "delete";
            btn_del_abt.UseVisualStyleBackColor = true;
            btn_del_abt.Click += btn_del_abt_Click;
            // 
            // btn_spch_abt
            // 
            btn_spch_abt.Location = new Point(148, 171);
            btn_spch_abt.Name = "btn_spch_abt";
            btn_spch_abt.Size = new Size(145, 27);
            btn_spch_abt.TabIndex = 5;
            btn_spch_abt.Text = "speichern";
            btn_spch_abt.UseVisualStyleBackColor = true;
            btn_spch_abt.Click += btn_spch_abt_Click;
            // 
            // li_abt
            // 
            li_abt.FormattingEnabled = true;
            li_abt.Location = new Point(458, 19);
            li_abt.Name = "li_abt";
            li_abt.Size = new Size(178, 139);
            li_abt.TabIndex = 4;
            li_abt.SelectedIndexChanged += li_abt_SelectedIndexChanged;
            // 
            // txtBox_abtNam
            // 
            txtBox_abtNam.Location = new Point(129, 105);
            txtBox_abtNam.Name = "txtBox_abtNam";
            txtBox_abtNam.Size = new Size(173, 23);
            txtBox_abtNam.TabIndex = 3;
            // 
            // txtBox_abtNr
            // 
            txtBox_abtNr.Location = new Point(129, 56);
            txtBox_abtNr.Name = "txtBox_abtNr";
            txtBox_abtNr.ReadOnly = true;
            txtBox_abtNr.Size = new Size(173, 23);
            txtBox_abtNr.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 115);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 1;
            label5.Text = "AbtName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 59);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "AbtNr";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(btn_del_pro);
            tabPage3.Controls.Add(btn_spch_pro);
            tabPage3.Controls.Add(li_pro);
            tabPage3.Controls.Add(txtBox_prnm);
            tabPage3.Controls.Add(txtBox_prnr);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(712, 366);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Projekt";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(li_btg);
            groupBox2.Location = new Point(42, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(636, 146);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Beteiligung";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(415, 9);
            label10.Name = "label10";
            label10.Size = new Size(160, 15);
            label10.TabIndex = 1;
            label10.Text = "Folgende MA arbeiten daran:";
            // 
            // li_btg
            // 
            li_btg.FormattingEnabled = true;
            li_btg.Location = new Point(415, 31);
            li_btg.Name = "li_btg";
            li_btg.Size = new Size(203, 109);
            li_btg.TabIndex = 0;
            // 
            // btn_del_pro
            // 
            btn_del_pro.Location = new Point(478, 154);
            btn_del_pro.Name = "btn_del_pro";
            btn_del_pro.Size = new Size(140, 31);
            btn_del_pro.TabIndex = 6;
            btn_del_pro.Text = "delete";
            btn_del_pro.UseVisualStyleBackColor = true;
            btn_del_pro.Click += btn_del_pro_Click;
            // 
            // btn_spch_pro
            // 
            btn_spch_pro.Location = new Point(177, 133);
            btn_spch_pro.Name = "btn_spch_pro";
            btn_spch_pro.Size = new Size(141, 30);
            btn_spch_pro.TabIndex = 5;
            btn_spch_pro.Text = "speichern";
            btn_spch_pro.UseVisualStyleBackColor = true;
            btn_spch_pro.Click += btn_spch_pro_Click;
            // 
            // li_pro
            // 
            li_pro.FormattingEnabled = true;
            li_pro.Location = new Point(466, 9);
            li_pro.Name = "li_pro";
            li_pro.Size = new Size(176, 139);
            li_pro.TabIndex = 4;
            li_pro.SelectedIndexChanged += li_pro_SelectedIndexChanged;
            // 
            // txtBox_prnm
            // 
            txtBox_prnm.Location = new Point(160, 92);
            txtBox_prnm.Name = "txtBox_prnm";
            txtBox_prnm.Size = new Size(179, 23);
            txtBox_prnm.TabIndex = 3;
            // 
            // txtBox_prnr
            // 
            txtBox_prnr.Location = new Point(160, 47);
            txtBox_prnr.Name = "txtBox_prnr";
            txtBox_prnr.ReadOnly = true;
            txtBox_prnr.Size = new Size(179, 23);
            txtBox_prnr.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 95);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 1;
            label8.Text = "projName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 54);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 0;
            label7.Text = "projNr";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgv_usicht);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(712, 366);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Übersicht";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_usicht
            // 
            dgv_usicht.AllowUserToAddRows = false;
            dgv_usicht.AllowUserToDeleteRows = false;
            dgv_usicht.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_usicht.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usicht.Columns.AddRange(new DataGridViewColumn[] { MA_Nachname, MA_Vorname, MA_Abteilung, MAinProjekt });
            dgv_usicht.Location = new Point(18, 12);
            dgv_usicht.MultiSelect = false;
            dgv_usicht.Name = "dgv_usicht";
            dgv_usicht.ReadOnly = true;
            dgv_usicht.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_usicht.Size = new Size(675, 339);
            dgv_usicht.TabIndex = 0;
            dgv_usicht.SelectionChanged += dgv_usicht_SelectionChanged;
            // 
            // MA_Nachname
            // 
            MA_Nachname.HeaderText = "Nachname";
            MA_Nachname.Name = "MA_Nachname";
            MA_Nachname.ReadOnly = true;
            // 
            // MA_Vorname
            // 
            MA_Vorname.HeaderText = "Vorname";
            MA_Vorname.Name = "MA_Vorname";
            MA_Vorname.ReadOnly = true;
            // 
            // MA_Abteilung
            // 
            MA_Abteilung.HeaderText = "Abteilung";
            MA_Abteilung.Name = "MA_Abteilung";
            MA_Abteilung.ReadOnly = true;
            // 
            // MAinProjekt
            // 
            MAinProjekt.HeaderText = "Projekt";
            MAinProjekt.Name = "MAinProjekt";
            MAinProjekt.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMitarb).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_usicht).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtBox_mitNam;
        private TextBox txtBox_mitNr;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBox_mitVor;
        private ListBox li_mitab;
        private Button btn_spch;
        private Button btn_del;
        private ListBox li_abt;
        private TextBox txtBox_abtNam;
        private TextBox txtBox_abtNr;
        private Label label5;
        private Label label4;
        private Button btn_del_abt;
        private Button btn_spch_abt;
        private ComboBox cb_Abteilung;
        private Label label6;
        private TabPage tabPage3;
        private ListBox li_pro;
        private TextBox txtBox_prnm;
        private TextBox txtBox_prnr;
        private Label label8;
        private Label label7;
        private Button btn_spch_pro;
        private Button btn_del_pro;
        private GroupBox groupBox1;
        private ListBox li_mapro;
        private Label label9;
        private ComboBox cb_prmipr;
        private Button btn_prmipr;
        private GroupBox groupBox2;
        private Label label10;
        private ListBox li_btg;
        private PictureBox pbMitarb;
        private Button btn_csv;
        private TabPage tabPage4;
        private DataGridView dgv_usicht;
        private DataGridViewTextBoxColumn MA_Nachname;
        private DataGridViewTextBoxColumn MA_Vorname;
        private DataGridViewTextBoxColumn MA_Abteilung;
        private DataGridViewTextBoxColumn MAinProjekt;
        private Button btn_imp;
    }
}
