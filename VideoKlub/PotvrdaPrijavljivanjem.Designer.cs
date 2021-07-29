
namespace VideoKlub
{
    partial class PotvrdaPrijavljivanjem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PotvrdaPrijavljivanjem));
            this.groupBoxAdministrator = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxJMBG = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrikaziSveClanove = new System.Windows.Forms.Button();
            this.btnPrijaviSE = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxAdministrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAdministrator
            // 
            this.groupBoxAdministrator.Controls.Add(this.maskedTextBoxJMBG);
            this.groupBoxAdministrator.Controls.Add(this.label7);
            this.groupBoxAdministrator.Controls.Add(this.btnPrikaziSveClanove);
            this.groupBoxAdministrator.Controls.Add(this.btnPrijaviSE);
            this.groupBoxAdministrator.Controls.Add(this.label10);
            this.groupBoxAdministrator.Controls.Add(this.tbPassword);
            this.groupBoxAdministrator.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAdministrator.Name = "groupBoxAdministrator";
            this.groupBoxAdministrator.Size = new System.Drawing.Size(324, 169);
            this.groupBoxAdministrator.TabIndex = 38;
            this.groupBoxAdministrator.TabStop = false;
            this.groupBoxAdministrator.Text = "POTVRDITE AKCIJU PRIJAVLJIVANJEM";
            // 
            // maskedTextBoxJMBG
            // 
            this.maskedTextBoxJMBG.Location = new System.Drawing.Point(96, 57);
            this.maskedTextBoxJMBG.Mask = "0000000000000";
            this.maskedTextBoxJMBG.Name = "maskedTextBoxJMBG";
            this.maskedTextBoxJMBG.PasswordChar = '*';
            this.maskedTextBoxJMBG.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxJMBG.TabIndex = 11;
            this.maskedTextBoxJMBG.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxJMBG_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sifra";
            // 
            // btnPrikaziSveClanove
            // 
            this.btnPrikaziSveClanove.BackColor = System.Drawing.Color.Transparent;
            this.btnPrikaziSveClanove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikaziSveClanove.Enabled = false;
            this.btnPrikaziSveClanove.Font = new System.Drawing.Font("Yu Gothic Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziSveClanove.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrikaziSveClanove.Location = new System.Drawing.Point(163, 108);
            this.btnPrikaziSveClanove.Name = "btnPrikaziSveClanove";
            this.btnPrikaziSveClanove.Size = new System.Drawing.Size(115, 39);
            this.btnPrikaziSveClanove.TabIndex = 27;
            this.btnPrikaziSveClanove.Text = "SPISAK CLANOVA";
            this.btnPrikaziSveClanove.UseVisualStyleBackColor = false;
            this.btnPrikaziSveClanove.Click += new System.EventHandler(this.btnPrikaziSveClanove_Click);
            // 
            // btnPrijaviSE
            // 
            this.btnPrijaviSE.BackColor = System.Drawing.Color.Transparent;
            this.btnPrijaviSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijaviSE.Font = new System.Drawing.Font("Yu Gothic Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijaviSE.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrijaviSE.Location = new System.Drawing.Point(37, 108);
            this.btnPrijaviSE.Name = "btnPrijaviSE";
            this.btnPrijaviSE.Size = new System.Drawing.Size(96, 39);
            this.btnPrijaviSE.TabIndex = 19;
            this.btnPrijaviSE.Text = "PRIJAVI SE ";
            this.btnPrijaviSE.UseVisualStyleBackColor = false;
            this.btnPrijaviSE.Click += new System.EventHandler(this.btnPrijaviSE_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "RadnikID";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(96, 24);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(149, 20);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PotvrdaPrijavljivanjem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 192);
            this.Controls.Add(this.groupBoxAdministrator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PotvrdaPrijavljivanjem";
            this.Text = "PotvrdaPrijavljivanjem";
            this.groupBoxAdministrator.ResumeLayout(false);
            this.groupBoxAdministrator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdministrator;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxJMBG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrikaziSveClanove;
        private System.Windows.Forms.Button btnPrijaviSE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}