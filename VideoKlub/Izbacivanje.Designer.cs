
namespace VideoKlub
{
    partial class Izbacivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izbacivanje));
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripObrisan = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBoxPrekidClanstva = new System.Windows.Forms.GroupBox();
            this.chbPodaciZaBrisanje = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDuzinaClanstva = new System.Windows.Forms.GroupBox();
            this.richTextBoxDuzinaClanstva = new System.Windows.Forms.RichTextBox();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.dateTimePickerClanDO = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerClanOD = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBoxPrekidClanstva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBoxDuzinaClanstva.SuspendLayout();
            this.SuspendLayout();
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.uToolStripMenuItem.Text = "Pocetak";
            this.uToolStripMenuItem.Click += new System.EventHandler(this.uToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStripObrisan
            // 
            this.toolStripObrisan.Name = "toolStripObrisan";
            this.toolStripObrisan.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripObrisan});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(653, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdustani.Location = new System.Drawing.Point(163, 197);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(133, 23);
            this.btnOdustani.TabIndex = 29;
            this.btnOdustani.Text = "RESETUJ / ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ClanID";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(154, 27);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(46, 20);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox1_Validating);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.Location = new System.Drawing.Point(11, 197);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(133, 23);
            this.btnObrisi.TabIndex = 28;
            this.btnObrisi.Text = "PREKINI CLANSTVO";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // groupBoxPrekidClanstva
            // 
            this.groupBoxPrekidClanstva.Controls.Add(this.chbPodaciZaBrisanje);
            this.groupBoxPrekidClanstva.Controls.Add(this.listBox1);
            this.groupBoxPrekidClanstva.Controls.Add(this.label4);
            this.groupBoxPrekidClanstva.Controls.Add(this.maskedTextBox1);
            this.groupBoxPrekidClanstva.Controls.Add(this.btnObrisi);
            this.groupBoxPrekidClanstva.Controls.Add(this.btnOdustani);
            this.groupBoxPrekidClanstva.Location = new System.Drawing.Point(12, 27);
            this.groupBoxPrekidClanstva.Name = "groupBoxPrekidClanstva";
            this.groupBoxPrekidClanstva.Size = new System.Drawing.Size(314, 258);
            this.groupBoxPrekidClanstva.TabIndex = 26;
            this.groupBoxPrekidClanstva.TabStop = false;
            this.groupBoxPrekidClanstva.Text = "PREKIDANJE CLANSTVA";
            // 
            // chbPodaciZaBrisanje
            // 
            this.chbPodaciZaBrisanje.AutoSize = true;
            this.chbPodaciZaBrisanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbPodaciZaBrisanje.Location = new System.Drawing.Point(43, 64);
            this.chbPodaciZaBrisanje.Name = "chbPodaciZaBrisanje";
            this.chbPodaciZaBrisanje.Size = new System.Drawing.Size(134, 17);
            this.chbPodaciZaBrisanje.TabIndex = 16;
            this.chbPodaciZaBrisanje.Text = "Detaljni podaci o clanu";
            this.chbPodaciZaBrisanje.UseVisualStyleBackColor = true;
            this.chbPodaciZaBrisanje.CheckedChanged += new System.EventHandler(this.chbPodaciZaBrisanje_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 95);
            this.listBox1.TabIndex = 14;
            this.listBox1.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "efekatLeptira.jpg");
            this.imageList1.Images.SetKeyName(1, "svemocniBrus.jpg");
            this.imageList1.Images.SetKeyName(2, "tajnaBesprekornogUma.jpg");
            this.imageList1.Images.SetKeyName(3, "babyDr.jpg");
            this.imageList1.Images.SetKeyName(4, "elCamino.jpg");
            this.imageList1.Images.SetKeyName(5, "Hango.jpg");
            this.imageList1.Images.SetKeyName(6, "hango2.jpg");
            this.imageList1.Images.SetKeyName(7, "hango3.jpg");
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // groupBoxDuzinaClanstva
            // 
            this.groupBoxDuzinaClanstva.Controls.Add(this.richTextBoxDuzinaClanstva);
            this.groupBoxDuzinaClanstva.Controls.Add(this.btnPrikaz);
            this.groupBoxDuzinaClanstva.Controls.Add(this.dateTimePickerClanDO);
            this.groupBoxDuzinaClanstva.Controls.Add(this.label2);
            this.groupBoxDuzinaClanstva.Controls.Add(this.label1);
            this.groupBoxDuzinaClanstva.Controls.Add(this.dateTimePickerClanOD);
            this.groupBoxDuzinaClanstva.Location = new System.Drawing.Point(342, 37);
            this.groupBoxDuzinaClanstva.Name = "groupBoxDuzinaClanstva";
            this.groupBoxDuzinaClanstva.Size = new System.Drawing.Size(299, 248);
            this.groupBoxDuzinaClanstva.TabIndex = 36;
            this.groupBoxDuzinaClanstva.TabStop = false;
            this.groupBoxDuzinaClanstva.Text = "DUZINA CLANSTVA";
            // 
            // richTextBoxDuzinaClanstva
            // 
            this.richTextBoxDuzinaClanstva.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBoxDuzinaClanstva.Location = new System.Drawing.Point(16, 146);
            this.richTextBoxDuzinaClanstva.Name = "richTextBoxDuzinaClanstva";
            this.richTextBoxDuzinaClanstva.ReadOnly = true;
            this.richTextBoxDuzinaClanstva.Size = new System.Drawing.Size(267, 96);
            this.richTextBoxDuzinaClanstva.TabIndex = 21;
            this.richTextBoxDuzinaClanstva.Text = "";
            this.richTextBoxDuzinaClanstva.Visible = false;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikaz.Location = new System.Drawing.Point(112, 92);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(79, 36);
            this.btnPrikaz.TabIndex = 20;
            this.btnPrikaz.Text = "PRIKAZ";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // dateTimePickerClanDO
            // 
            this.dateTimePickerClanDO.CustomFormat = "";
            this.dateTimePickerClanDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerClanDO.Location = new System.Drawing.Point(181, 49);
            this.dateTimePickerClanDO.Name = "dateTimePickerClanDO";
            this.dateTimePickerClanDO.Size = new System.Drawing.Size(102, 20);
            this.dateTimePickerClanDO.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clan do: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clan od: ";
            // 
            // dateTimePickerClanOD
            // 
            this.dateTimePickerClanOD.Enabled = false;
            this.dateTimePickerClanOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerClanOD.Location = new System.Drawing.Point(16, 49);
            this.dateTimePickerClanOD.Name = "dateTimePickerClanOD";
            this.dateTimePickerClanOD.Size = new System.Drawing.Size(102, 20);
            this.dateTimePickerClanOD.TabIndex = 0;
            // 
            // Izbacivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(653, 314);
            this.Controls.Add(this.groupBoxDuzinaClanstva);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxPrekidClanstva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Izbacivanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PREKID CLANSTVA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxPrekidClanstva.ResumeLayout(false);
            this.groupBoxPrekidClanstva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBoxDuzinaClanstva.ResumeLayout(false);
            this.groupBoxDuzinaClanstva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripObrisan;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox groupBoxPrekidClanstva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chbPodaciZaBrisanje;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBoxDuzinaClanstva;
        private System.Windows.Forms.RichTextBox richTextBoxDuzinaClanstva;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.DateTimePicker dateTimePickerClanDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerClanOD;
    }
}