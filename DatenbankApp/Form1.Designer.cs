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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(36, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(720, 394);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            // btn_del
            // 
            btn_del.Location = new Point(472, 297);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(166, 28);
            btn_del.TabIndex = 8;
            btn_del.Text = "delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_spch
            // 
            btn_spch.Location = new Point(210, 228);
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
            li_mitab.Location = new Point(463, 56);
            li_mitab.Name = "li_mitab";
            li_mitab.Size = new Size(182, 229);
            li_mitab.TabIndex = 6;
            li_mitab.SelectedIndexChanged += li_mitab_SelectedIndexChanged;
            // 
            // txtBox_mitVor
            // 
            txtBox_mitVor.Location = new Point(193, 175);
            txtBox_mitVor.Name = "txtBox_mitVor";
            txtBox_mitVor.Size = new Size(196, 23);
            txtBox_mitVor.TabIndex = 5;
            // 
            // txtBox_mitNam
            // 
            txtBox_mitNam.Location = new Point(193, 114);
            txtBox_mitNam.Name = "txtBox_mitNam";
            txtBox_mitNam.Size = new Size(196, 23);
            txtBox_mitNam.TabIndex = 4;
            // 
            // txtBox_mitNr
            // 
            txtBox_mitNr.Location = new Point(193, 53);
            txtBox_mitNr.Name = "txtBox_mitNr";
            txtBox_mitNr.ReadOnly = true;
            txtBox_mitNr.Size = new Size(196, 23);
            txtBox_mitNr.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 178);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Mitab Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 117);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Mitab Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 56);
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
            btn_del_abt.Location = new Point(476, 273);
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
            li_abt.Location = new Point(455, 46);
            li_abt.Name = "li_abt";
            li_abt.Size = new Size(178, 214);
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
    }
}
