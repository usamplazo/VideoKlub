using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VideoKlub
{
    public partial class Form1 : Form
    {
        TabelaClanova tc = new TabelaClanova();
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        public Form1()
        {
            InitializeComponent();
            toolStripProgressBar1.Maximum = 7;
            toolStripProgressBar1.Step = 1;
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbIme.Text))
            {
                errorProvider1.SetError(tbIme, "Morate uneti ime clana !");

            }
            else
            {
                errorProvider1.Clear();
               
            }

        }

        private void tbPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbPrezime.Text))
            {
                errorProvider1.SetError(tbPrezime, "Morate uneti prezime clana !");

            }
            else
            {
                errorProvider1.Clear();
               
            }
        }

        private void maskedTextBoxJMBG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(maskedTextBoxJMBG, "JMBG se sastoji iz 13 cifara");
        }

        private void maskedTextBoxTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(maskedTextBoxTelefon, "Pogresan unos broja mobilnog telefona");
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBoxJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxJMBG.Text == "")
            {
                errorProvider1.SetError(maskedTextBoxJMBG, "Morate uneti JMBG");
            }
        }

        private void maskedTextBoxTelefon_Validating(object sender, CancelEventArgs e)
        {

            if (maskedTextBoxTelefon.Text == "")
            {
                errorProvider1.SetError(maskedTextBoxTelefon, "Morate uneti mobilni telefon");
            }
        }
        private void dodajClana()
        {
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.Connection = konekcija;
                komanda.CommandText = "INSERT INTO Clanovi(ClanID, Ime, Prezime, Pol, JMBG, Telefon, ClanOD) VALUES(@clan, @ime, @prezime, @pol, @jmbg, @tel, @clanod)";
                komanda.Parameters.AddWithValue("@clan", tbClanID.Text);
                komanda.Parameters.AddWithValue("@ime", tbIme.Text);
                komanda.Parameters.AddWithValue("@prezime", tbPrezime.Text);
                if (rbMuskarac.Checked == true)
                    komanda.Parameters.AddWithValue("@pol", rbMuskarac.Text);
                if (rbZena.Checked == true)
                    komanda.Parameters.AddWithValue("@pol", rbZena.Text);
                komanda.Parameters.AddWithValue("@jmbg", maskedTextBoxJMBG.Text);
                komanda.Parameters.AddWithValue("@tel", maskedTextBoxTelefon.Text);
                komanda.Parameters.AddWithValue("@clanod", System.DateTime.Now);

                try
                {
                    konekcija.Open();
                    komanda.ExecuteNonQuery();

                    MessageBox.Show("Dodat je novi clan video kluba !", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetuj();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
        }
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbClanID.Text) || !String.IsNullOrEmpty(tbIme.Text) || !String.IsNullOrEmpty(tbPrezime.Text) || !String.IsNullOrEmpty(maskedTextBoxJMBG.Text) || !String.IsNullOrEmpty(maskedTextBoxTelefon.Text))
            {
                errorProvider1.Clear();
                PotvrdaPrijavljivanjem po = new PotvrdaPrijavljivanjem();
                po.ShowDialog();
                dodajClana();
                if (rbKartica.Checked == true)
                {
                    if (!String.IsNullOrEmpty(mtbBrojKartice.Text) || !String.IsNullOrEmpty(mtbDatumIsteka.Text) || !String.IsNullOrEmpty(mtbCCV.Text))
                    {

                        using (SqlCommand komanda = new SqlCommand())
                        {
                            errorProvider1.Clear();
                            komanda.Connection = konekcija;
                            komanda.CommandText = "INSERT INTO KredKartice(BrojKartice, DatumIsteka, CVC, Tip) VALUES(@brKar, @datum, @c, @tp)";
                            komanda.Parameters.AddWithValue("@brKar", mtbBrojKartice.Text);
                            komanda.Parameters.AddWithValue("@datum", mtbDatumIsteka.Text);
                            komanda.Parameters.AddWithValue("@c", mtbCCV.Text);
                            if (rbAE.Checked == true)
                                komanda.Parameters.AddWithValue("@tp", "American Express");
                            else if (rbMC.Checked == true)
                                komanda.Parameters.AddWithValue("@tp", "Master Card");
                            else
                                komanda.Parameters.AddWithValue("@tp", "Visa");

                            try
                            {
                                konekcija.Open();
                                komanda.ExecuteNonQuery();
                                komanda.CommandText = "SELECT ID FROM KredKartice WHERE BrojKartice = @brK";
                                komanda.Parameters.AddWithValue("@brK", mtbBrojKartice.Text);
                                int kartID = (int)komanda.ExecuteScalar();
                                komanda.CommandText = "UPDATE Clanovi SET KredKarID = @id WHERE ClanID = @clan";
                                komanda.Parameters.AddWithValue("@id", kartID);
                                komanda.Parameters.AddWithValue("@clan", tbClanID.Text);
                                komanda.ExecuteNonQuery();
                                toolStripProgressBar1.Value = 0;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Greska " + ex.Message);
                            }
                            finally
                            {
                                konekcija.Close();
                            }

                        }
                    }

                }
                
            }
            else
            {
                MessageBox.Show("Nisu uneti svi potrebni podaci za clanstvo ! ", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbKartica_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxKartica.Enabled = true;
        }

        private void mtbBrojKartice_Validating(object sender, CancelEventArgs e)
        {
            if (mtbBrojKartice.Text == "")
            {
                errorProvider1.SetError(mtbBrojKartice, "Morate uneti broj kartice !");
            }
            
        }

        private void mtbDatumIsteka_Validating(object sender, CancelEventArgs e)
        {
            if (mtbDatumIsteka.Text == "")
            {
                errorProvider1.SetError(mtbDatumIsteka, "Morate uneti datum isteka !");
            }
           
        }

        private void mtbCCV_Validating(object sender, CancelEventArgs e)
        {
            if (mtbCCV.Text == "")
            {
                errorProvider1.SetError(mtbCCV, "Morate uneti CCV/CVC broj !");
            }
            
        }

        private void Pretplata(object sender, EventArgs e)
        {
            tbKes.Clear();
            if (rbGodisnja.Checked)
            {
                tbKes.Text = "12.000";
            }
            if(rbMesecna.Checked)
            {
                tbKes.Text = "1000";
            }
        }

        private void tbClanID_Validating(object sender, CancelEventArgs e)
        {
            if(tbClanID.Text == "")
            {
                errorProvider1.SetError(tbClanID, "Morate uneti ClanID");
            }
            
        }

        private void rbKes_MouseClick(object sender, MouseEventArgs e)
        {
            groupBoxKartica.Enabled = false;
        }

        private void groupBoxClanarina_Enter(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
        }

        private void panel2_Enter(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
        }

        private void panel3_Enter(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
        }

        private void groupBoxPol_Enter(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
        }

        private void panel4_Enter(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
        }

        private void panel5_Enter(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
        }

        private void resetuj()
        {
            tbClanID.Clear();
            tbIme.Clear();
            tbPrezime.Clear();
            rbMuskarac.Checked = true;
            maskedTextBoxJMBG.Clear();
            maskedTextBoxTelefon.Clear();
            rbMesecna.Checked = true;
            rbKes.Checked = true;
            rbAE.Checked = true;
            mtbBrojKartice.Clear();
            mtbCCV.Clear();
            mtbDatumIsteka.Clear();

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            resetuj();
        }

        private void mtbBrojKartice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(mtbBrojKartice, "Broj kartice mora imati 16 cifara !");
        }

        private void mtbDatumIsteka_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(mtbDatumIsteka, "Datum isteka se sastoji iz 4 cifre !");
        }

        private void mtbCCV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(mtbCCV, "CCV se sastoji iz 3 cifre !");
        }
    }
}
