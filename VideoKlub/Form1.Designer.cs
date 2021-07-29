
namespace VideoKlub
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxKartica = new System.Windows.Forms.GroupBox();
            this.rbMC = new System.Windows.Forms.RadioButton();
            this.rbAE = new System.Windows.Forms.RadioButton();
            this.rbVisa = new System.Windows.Forms.RadioButton();
            this.mtbBrojKartice = new System.Windows.Forms.MaskedTextBox();
            this.mtbCCV = new System.Windows.Forms.MaskedTextBox();
            this.mtbDatumIsteka = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbKartica = new System.Windows.Forms.RadioButton();
            this.rbKes = new System.Windows.Forms.RadioButton();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.groupBoxInformacije = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxJMBG = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbClanID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxPol = new System.Windows.Forms.GroupBox();
            this.rbZena = new System.Windows.Forms.RadioButton();
            this.rbMuskarac = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tbKes = new System.Windows.Forms.TextBox();
            this.groupBoxClanarina = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbGodisnja = new System.Windows.Forms.RadioButton();
            this.rbMesecna = new System.Windows.Forms.RadioButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.clanoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxKartica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxInformacije.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxPol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxClanarina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxKartica
            // 
            this.groupBoxKartica.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxKartica.Controls.Add(this.rbMC);
            this.groupBoxKartica.Controls.Add(this.rbAE);
            this.groupBoxKartica.Controls.Add(this.rbVisa);
            this.groupBoxKartica.Controls.Add(this.mtbBrojKartice);
            this.groupBoxKartica.Controls.Add(this.mtbCCV);
            this.groupBoxKartica.Controls.Add(this.mtbDatumIsteka);
            this.groupBoxKartica.Controls.Add(this.pictureBox1);
            this.groupBoxKartica.Controls.Add(this.label8);
            this.groupBoxKartica.Controls.Add(this.l);
            this.groupBoxKartica.Controls.Add(this.label6);
            this.groupBoxKartica.Enabled = false;
            this.groupBoxKartica.Location = new System.Drawing.Point(16, 120);
            this.groupBoxKartica.Name = "groupBoxKartica";
            this.groupBoxKartica.Size = new System.Drawing.Size(412, 208);
            this.groupBoxKartica.TabIndex = 17;
            this.groupBoxKartica.TabStop = false;
            this.groupBoxKartica.Text = "Podaci za placanje karticom";
            // 
            // rbMC
            // 
            this.rbMC.AutoSize = true;
            this.rbMC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMC.Location = new System.Drawing.Point(167, 89);
            this.rbMC.Name = "rbMC";
            this.rbMC.Size = new System.Drawing.Size(14, 13);
            this.rbMC.TabIndex = 21;
            this.rbMC.UseVisualStyleBackColor = true;
            // 
            // rbAE
            // 
            this.rbAE.AutoSize = true;
            this.rbAE.Checked = true;
            this.rbAE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAE.Location = new System.Drawing.Point(42, 89);
            this.rbAE.Name = "rbAE";
            this.rbAE.Size = new System.Drawing.Size(14, 13);
            this.rbAE.TabIndex = 20;
            this.rbAE.TabStop = true;
            this.rbAE.UseVisualStyleBackColor = true;
            // 
            // rbVisa
            // 
            this.rbVisa.AutoSize = true;
            this.rbVisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbVisa.Location = new System.Drawing.Point(299, 89);
            this.rbVisa.Name = "rbVisa";
            this.rbVisa.Size = new System.Drawing.Size(14, 13);
            this.rbVisa.TabIndex = 20;
            this.rbVisa.UseVisualStyleBackColor = true;
            // 
            // mtbBrojKartice
            // 
            this.mtbBrojKartice.Location = new System.Drawing.Point(9, 133);
            this.mtbBrojKartice.Mask = "0000 0000 0000 0000";
            this.mtbBrojKartice.Name = "mtbBrojKartice";
            this.mtbBrojKartice.Size = new System.Drawing.Size(372, 20);
            this.mtbBrojKartice.TabIndex = 16;
            this.mtbBrojKartice.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbBrojKartice_MaskInputRejected);
            this.mtbBrojKartice.Validating += new System.ComponentModel.CancelEventHandler(this.mtbBrojKartice_Validating);
            // 
            // mtbCCV
            // 
            this.mtbCCV.Location = new System.Drawing.Point(200, 172);
            this.mtbCCV.Mask = "000";
            this.mtbCCV.Name = "mtbCCV";
            this.mtbCCV.Size = new System.Drawing.Size(181, 20);
            this.mtbCCV.TabIndex = 18;
            this.mtbCCV.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCCV_MaskInputRejected);
            this.mtbCCV.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCCV_Validating);
            // 
            // mtbDatumIsteka
            // 
            this.mtbDatumIsteka.Location = new System.Drawing.Point(9, 172);
            this.mtbDatumIsteka.Mask = "00/00";
            this.mtbDatumIsteka.Name = "mtbDatumIsteka";
            this.mtbDatumIsteka.Size = new System.Drawing.Size(181, 20);
            this.mtbDatumIsteka.TabIndex = 17;
            this.mtbDatumIsteka.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbDatumIsteka_MaskInputRejected);
            this.mtbDatumIsteka.Validating += new System.ComponentModel.CancelEventHandler(this.mtbDatumIsteka_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 64);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "CCV";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(6, 156);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(115, 13);
            this.l.TabIndex = 5;
            this.l.Text = "Datum isteka (MM/YY)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Broj kartice";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbKartica);
            this.groupBox3.Controls.Add(this.rbKes);
            this.groupBox3.Location = new System.Drawing.Point(121, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(85, 67);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Placanje";
            // 
            // rbKartica
            // 
            this.rbKartica.AutoSize = true;
            this.rbKartica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbKartica.Location = new System.Drawing.Point(7, 38);
            this.rbKartica.Name = "rbKartica";
            this.rbKartica.Size = new System.Drawing.Size(57, 17);
            this.rbKartica.TabIndex = 17;
            this.rbKartica.Text = "kartica";
            this.rbKartica.UseVisualStyleBackColor = true;
            this.rbKartica.CheckedChanged += new System.EventHandler(this.rbKartica_CheckedChanged);
            // 
            // rbKes
            // 
            this.rbKes.AutoSize = true;
            this.rbKes.Checked = true;
            this.rbKes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbKes.Location = new System.Drawing.Point(7, 20);
            this.rbKes.Name = "rbKes";
            this.rbKes.Size = new System.Drawing.Size(42, 17);
            this.rbKes.TabIndex = 0;
            this.rbKes.TabStop = true;
            this.rbKes.Text = "kes";
            this.rbKes.UseVisualStyleBackColor = true;
            this.rbKes.CheckedChanged += new System.EventHandler(this.Pretplata);
            this.rbKes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbKes_MouseClick);
            // 
            // btnOdustani
            // 
            this.btnOdustani.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdustani.Location = new System.Drawing.Point(155, 377);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(133, 33);
            this.btnOdustani.TabIndex = 26;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotvrdi.Location = new System.Drawing.Point(12, 375);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(133, 35);
            this.btnPotvrdi.TabIndex = 25;
            this.btnPotvrdi.Text = "POTVRDI";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // groupBoxInformacije
            // 
            this.groupBoxInformacije.Controls.Add(this.panel5);
            this.groupBoxInformacije.Controls.Add(this.panel4);
            this.groupBoxInformacije.Controls.Add(this.panel3);
            this.groupBoxInformacije.Controls.Add(this.panel2);
            this.groupBoxInformacije.Controls.Add(this.panel1);
            this.groupBoxInformacije.Controls.Add(this.groupBoxPol);
            this.groupBoxInformacije.Location = new System.Drawing.Point(12, 37);
            this.groupBoxInformacije.Name = "groupBoxInformacije";
            this.groupBoxInformacije.Size = new System.Drawing.Size(276, 332);
            this.groupBoxInformacije.TabIndex = 24;
            this.groupBoxInformacije.TabStop = false;
            this.groupBoxInformacije.Text = "INFORMACIJE";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.maskedTextBoxTelefon);
            this.panel5.Location = new System.Drawing.Point(15, 266);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 46);
            this.panel5.TabIndex = 30;
            this.panel5.Enter += new System.EventHandler(this.panel5_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon";
            // 
            // maskedTextBoxTelefon
            // 
            this.helpProvider1.SetHelpString(this.maskedTextBoxTelefon, "Mobilni telefon formata (npr. 06X XXXX XXX)");
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(56, 12);
            this.maskedTextBoxTelefon.Mask = "\\0\\60 0000 000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.helpProvider1.SetShowHelp(this.maskedTextBoxTelefon, true);
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxTelefon.TabIndex = 12;
            this.maskedTextBoxTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxTelefon_MaskInputRejected);
            this.maskedTextBoxTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxTelefon_Validating);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.maskedTextBoxJMBG);
            this.panel4.Location = new System.Drawing.Point(15, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 40);
            this.panel4.TabIndex = 30;
            this.panel4.Enter += new System.EventHandler(this.panel4_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "JMBG";
            // 
            // maskedTextBoxJMBG
            // 
            this.helpProvider1.SetHelpKeyword(this.maskedTextBoxJMBG, "");
            this.helpProvider1.SetHelpString(this.maskedTextBoxJMBG, "Jedinstveni maticni broj gradjanina");
            this.maskedTextBoxJMBG.Location = new System.Drawing.Point(57, 10);
            this.maskedTextBoxJMBG.Mask = "0000000000000";
            this.maskedTextBoxJMBG.Name = "maskedTextBoxJMBG";
            this.helpProvider1.SetShowHelp(this.maskedTextBoxJMBG, true);
            this.maskedTextBoxJMBG.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxJMBG.TabIndex = 11;
            this.maskedTextBoxJMBG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxJMBG_MaskInputRejected);
            this.maskedTextBoxJMBG.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxJMBG_Validating);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbPrezime);
            this.panel3.Location = new System.Drawing.Point(15, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 39);
            this.panel3.TabIndex = 30;
            this.panel3.Enter += new System.EventHandler(this.panel3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(56, 10);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(149, 20);
            this.tbPrezime.TabIndex = 9;
            this.tbPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrezime_Validating);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbIme);
            this.panel2.Location = new System.Drawing.Point(15, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 35);
            this.panel2.TabIndex = 30;
            this.panel2.Enter += new System.EventHandler(this.panel2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(56, 7);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(149, 20);
            this.tbIme.TabIndex = 8;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbClanID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 36);
            this.panel1.TabIndex = 30;
            this.panel1.Enter += new System.EventHandler(this.panel1_Enter);
            // 
            // tbClanID
            // 
            this.tbClanID.Location = new System.Drawing.Point(57, 8);
            this.tbClanID.Name = "tbClanID";
            this.tbClanID.Size = new System.Drawing.Size(149, 20);
            this.tbClanID.TabIndex = 14;
            this.tbClanID.Validating += new System.ComponentModel.CancelEventHandler(this.tbClanID_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "ClanID";
            // 
            // groupBoxPol
            // 
            this.groupBoxPol.Controls.Add(this.rbZena);
            this.groupBoxPol.Controls.Add(this.rbMuskarac);
            this.groupBoxPol.Location = new System.Drawing.Point(15, 155);
            this.groupBoxPol.Name = "groupBoxPol";
            this.groupBoxPol.Size = new System.Drawing.Size(212, 59);
            this.groupBoxPol.TabIndex = 13;
            this.groupBoxPol.TabStop = false;
            this.groupBoxPol.Text = "Pol";
            this.groupBoxPol.Enter += new System.EventHandler(this.groupBoxPol_Enter);
            // 
            // rbZena
            // 
            this.rbZena.AutoSize = true;
            this.rbZena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbZena.Location = new System.Drawing.Point(114, 20);
            this.rbZena.Name = "rbZena";
            this.rbZena.Size = new System.Drawing.Size(50, 17);
            this.rbZena.TabIndex = 1;
            this.rbZena.Text = "Zena";
            this.rbZena.UseVisualStyleBackColor = true;
            // 
            // rbMuskarac
            // 
            this.rbMuskarac.AutoSize = true;
            this.rbMuskarac.Checked = true;
            this.rbMuskarac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMuskarac.Location = new System.Drawing.Point(19, 20);
            this.rbMuskarac.Name = "rbMuskarac";
            this.rbMuskarac.Size = new System.Drawing.Size(72, 17);
            this.rbMuskarac.TabIndex = 0;
            this.rbMuskarac.TabStop = true;
            this.rbMuskarac.Text = "Muskarac";
            this.rbMuskarac.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.uToolStripMenuItem.Text = "Pocetak";
            this.uToolStripMenuItem.Click += new System.EventHandler(this.uToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // tbKes
            // 
            this.tbKes.Cursor = System.Windows.Forms.Cursors.No;
            this.tbKes.Location = new System.Drawing.Point(269, 55);
            this.tbKes.Name = "tbKes";
            this.tbKes.ReadOnly = true;
            this.tbKes.Size = new System.Drawing.Size(100, 20);
            this.tbKes.TabIndex = 17;
            // 
            // groupBoxClanarina
            // 
            this.groupBoxClanarina.Controls.Add(this.label3);
            this.groupBoxClanarina.Controls.Add(this.rbGodisnja);
            this.groupBoxClanarina.Controls.Add(this.rbMesecna);
            this.groupBoxClanarina.Controls.Add(this.tbKes);
            this.groupBoxClanarina.Controls.Add(this.groupBoxKartica);
            this.groupBoxClanarina.Controls.Add(this.groupBox3);
            this.groupBoxClanarina.Location = new System.Drawing.Point(309, 37);
            this.groupBoxClanarina.Name = "groupBoxClanarina";
            this.groupBoxClanarina.Size = new System.Drawing.Size(446, 373);
            this.groupBoxClanarina.TabIndex = 23;
            this.groupBoxClanarina.TabStop = false;
            this.groupBoxClanarina.Text = "CLANARINA";
            this.groupBoxClanarina.Enter += new System.EventHandler(this.groupBoxClanarina_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Za placanje";
            // 
            // rbGodisnja
            // 
            this.rbGodisnja.AutoSize = true;
            this.rbGodisnja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGodisnja.Location = new System.Drawing.Point(25, 62);
            this.rbGodisnja.Name = "rbGodisnja";
            this.rbGodisnja.Size = new System.Drawing.Size(64, 17);
            this.rbGodisnja.TabIndex = 19;
            this.rbGodisnja.Text = "godisnja";
            this.rbGodisnja.UseVisualStyleBackColor = true;
            this.rbGodisnja.CheckedChanged += new System.EventHandler(this.Pretplata);
            // 
            // rbMesecna
            // 
            this.rbMesecna.AutoSize = true;
            this.rbMesecna.Checked = true;
            this.rbMesecna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMesecna.Location = new System.Drawing.Point(25, 41);
            this.rbMesecna.Name = "rbMesecna";
            this.rbMesecna.Size = new System.Drawing.Size(68, 17);
            this.rbMesecna.TabIndex = 18;
            this.rbMesecna.TabStop = true;
            this.rbMesecna.Text = "mesecna";
            this.rbMesecna.UseVisualStyleBackColor = true;
            this.rbMesecna.CheckedChanged += new System.EventHandler(this.Pretplata);
            // 
            // clanoviBindingSource
            // 
            this.clanoviBindingSource.DataMember = "Clanovi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(790, 443);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.groupBoxInformacije);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxClanarina);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uclani";
            this.groupBoxKartica.ResumeLayout(false);
            this.groupBoxKartica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxInformacije.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxPol.ResumeLayout(false);
            this.groupBoxPol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxClanarina.ResumeLayout(false);
            this.groupBoxClanarina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clanoviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKartica;
        private System.Windows.Forms.RadioButton rbMC;
        private System.Windows.Forms.RadioButton rbAE;
        private System.Windows.Forms.RadioButton rbVisa;
        private System.Windows.Forms.MaskedTextBox mtbBrojKartice;
        private System.Windows.Forms.MaskedTextBox mtbCCV;
        private System.Windows.Forms.MaskedTextBox mtbDatumIsteka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource clanoviBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbKartica;
        private System.Windows.Forms.RadioButton rbKes;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.GroupBox groupBoxInformacije;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxJMBG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox groupBoxClanarina;
        private System.Windows.Forms.TextBox tbKes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxPol;
        private System.Windows.Forms.RadioButton rbZena;
        private System.Windows.Forms.RadioButton rbMuskarac;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.RadioButton rbGodisnja;
        private System.Windows.Forms.RadioButton rbMesecna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbClanID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

