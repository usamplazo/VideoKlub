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
    public partial class PocetnaForma : Form
    {
        TabelaClanova tc = new TabelaClanova();
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        public PocetnaForma()
        {
            InitializeComponent();
            groupBoxNajtrazeniji.Enabled = false;
            richTextBox1.Enabled = false;
            PopuniComboFilmovi();
            tabControl1.Enabled = false;
            menuStrip2.Enabled = false;
            btnOdjava.Enabled = false;
            groupBoxKazna.Enabled = false;
            dtpDatumIznajmljivanja.Value = System.DateTime.Now;
            dtpDatumVracanja.Value = System.DateTime.Now;
        }
        private void PopuniComboFilmovi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT FilmID, Naziv FROM Filmovi", Konekcija.konString);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxFilmovi.DataSource = dt;
            comboBoxFilmovi.DisplayMember = "Naziv";
            comboBoxFilmovi.ValueMember = "FilmID";

            cmbFilmoviVracanje.DataSource = dt;
            cmbFilmoviVracanje.DisplayMember = "Naziv";
            cmbFilmoviVracanje.ValueMember = "FilmID";
        }
        private void uclaniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 uclani = new Form1();
            uclani.ShowDialog();
        }

        private void izbaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izbacivanje izb = new Izbacivanje();
            izb.ShowDialog();
        }

        private bool proveraRadnika()
        {
            SqlConnection konekcija = new SqlConnection(Konekcija.konString);
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.Connection = konekcija;
                komanda.CommandText = "SELECT RadnikID, JMBG FROM Radnici WHERE RadnikID = @id AND JMBG = @jmbg";
                komanda.Parameters.AddWithValue("@id", tbPassword.Text);
                komanda.Parameters.AddWithValue("@jmbg", maskedTextBoxJMBG.Text);
                SqlDataReader reader = null;
                try
                {
                    konekcija.Open();
                    reader = komanda.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Nisu uneti pravilni podaci ! ", "Greksa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    errorProvider1.Clear();
                    MessageBox.Show("Uspesno ste prijavljeni ! ", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnOdjava.Enabled = true;
                    btnPrijaviSE.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
                return true;
            }
        }



        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Morate umeti ID radnika !");
                tbPassword.Focus();

            }
        }

        private void btnPrikaziSveClanove_Click(object sender, EventArgs e)
        {
            tc.ShowDialog();
        }

        private void btnPrijaviSE_Click(object sender, EventArgs e)
        {
            if (proveraRadnika() && !String.IsNullOrEmpty(maskedTextBoxJMBG.Text) && !String.IsNullOrEmpty(tbPassword.Text))
            {
                groupBoxNajtrazeniji.Enabled = true;
                richTextBox1.Enabled = true;
                btnPrikaziSveClanove.Enabled = true;
                tabControl1.Enabled = true;
                menuStrip2.Enabled = true;

            }
        }

        private void oDJAVISEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maskedTextBoxJMBG.Clear();
            tbPassword.Clear();
            btnPrijaviSE.Enabled = true;
            tabControl1.Enabled = false;
            btnPrikaziSveClanove.Enabled = false;
            groupBoxNajtrazeniji.Enabled = false;
            richTextBox1.Clear();
            richTextBox1.Enabled = false;
            btnPrikaziSveClanove.Enabled = false;
            odustaniOdVracanja();
            odustaniOdIznajmljivanja();
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izbaciToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Izbacivanje iz = new Izbacivanje();
            iz.ShowDialog();
        }

        private void uclaniToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 ucl = new Form1();
            ucl.ShowDialog();
        }

        private void ProveriZaduzenje()
        {
            using (SqlCommand komanda = new SqlCommand())
            {
                komanda.Connection = konekcija;
                komanda.CommandText = "SELECT DatumVracanja FROM Iznajmljivanje_Filmova WHERE ClanID = @id AND DatumVracanja IS NULL";
                komanda.Parameters.AddWithValue("@id", tbClanIDIznajmljivanje.Text);
                SqlDataReader reader = null;
                try
                {
                    konekcija.Open();
                    reader = komanda.ExecuteReader();
                    if (reader == null)
                    {
                        MessageBox.Show("Clan " + tbClanIDIznajmljivanje.Text + " ne moze da iznajmi filmove !", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        IznajmljivanjeFilma();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska : " + ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }

            }
        }
        private void IznajmljivanjeFilma()
        {
            if (ProveraClana())
            {
                using (SqlCommand komanda = new SqlCommand())
                {
                    SqlConnection konekcija = new SqlConnection(Konekcija.konString);
                    komanda.Connection = konekcija;

                    komanda.CommandText = "INSERT INTO Iznajmljivanje_Filmova(FilmID, ClanID, DatumIznajmljivanja, Radnik) VALUES(@film, @clan, @datum, @radnik)";
                    komanda.Parameters.AddWithValue("@film", comboBoxFilmovi.SelectedValue);
                    komanda.Parameters.AddWithValue("@clan", tbClanIDIznajmljivanje.Text);
                    komanda.Parameters.AddWithValue("@datum", System.DateTime.Now);
                    komanda.Parameters.AddWithValue("@radnik", tbPassword.Text);
                    try
                    {
                        konekcija.Open();
                        komanda.ExecuteNonQuery();
                        MessageBox.Show("Uspesno iznajmljen film Clanu : ! " + tbClanIDIznajmljivanje.Text, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        odustaniOdIznajmljivanja();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greska: " + ex.Message);
                    }
                    finally
                    {
                        konekcija.Close();
                    }

                    dtpDatumIznajmljivanja.Value = System.DateTime.Now.AddDays(10);
                }
            }
        }
        private bool ProveraClana()
        {
            using (SqlCommand komanda = new SqlCommand())
            {
                SqlConnection konekcija = new SqlConnection(Konekcija.konString);
                komanda.Connection = konekcija;
                komanda.CommandText = "SELECT ClanID FROM Clanovi WHERE ClanID = @clan";
                komanda.Parameters.AddWithValue("@clan", tbClanIDIznajmljivanje.Text);
                SqlDataReader reader = null;
                try
                {
                    konekcija.Open();
                    reader = komanda.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Ne postoji clan sa unteim id-jem !", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message);
                }
                finally
                {

                    konekcija.Close();

                }
                return true;
            }
        }

        private bool ProveraClanaZaVracanje()
        {
            using (SqlCommand komanda = new SqlCommand())
            {
                SqlConnection konekcija = new SqlConnection(Konekcija.konString);
                komanda.Connection = konekcija;
                komanda.CommandText = "SELECT ClanID FROM Clanovi WHERE ClanID = @clan";
                komanda.Parameters.AddWithValue("@clan", tbCalnIDVracanje.Text);
                SqlDataReader reader = null;
                try
                {
                    konekcija.Open();
                    reader = komanda.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Ne postoji clan sa unteim id-jem !", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska: " + ex.Message);
                }
                finally
                {

                    konekcija.Close();

                }
                return true;
            }
        }
        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbClanIDIznajmljivanje.Text))
            {
                errorProvider1.Clear();
                ProveriZaduzenje();
            }
            else
            {
                MessageBox.Show("Morate uneti sve potrebne podatke za iznajmljivanje ! ", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            odustaniOdIznajmljivanja();
        }
        private void odustaniOdIznajmljivanja()
        {
            tbClanIDIznajmljivanje.Clear();
            dtpDatumIznajmljivanja.Value = System.DateTime.Now;
        }
        private void tbClanIDIznajmljivanje_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbClanIDIznajmljivanje.Text))
            {
                errorProvider1.SetError(tbClanIDIznajmljivanje, "Morate uneti validan ID clana prilikom iznajmljivanja");
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                SqlConnection konekcija = new SqlConnection(Konekcija.konString);
                using (SqlCommand komanda = new SqlCommand())
                {
                    komanda.Connection = konekcija;
                    komanda.CommandText = "SELECT Reziser, Zanr, GodinaIzdanja, Ocena, Naziv FROM Filmovi WHERE Naziv = @i";
                    komanda.Parameters.AddWithValue("@i", item.Text);
                    SqlDataReader reader = null;
                    StringBuilder sb = new StringBuilder();
                    try
                    {
                        konekcija.Open();
                        reader = komanda.ExecuteReader();
                        while (reader.Read())
                        {


                            sb.Append("Reziser: " + reader[0].ToString() + "\n\nZanr: " + reader[1].ToString() + "\n\nGod. izdanja:  " + reader[2].ToString() + "\n\nOcena:  " + reader[3].ToString());

                        }
                        richTextBox1.Text = sb.ToString();
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

        private void maskedTextBoxJMBG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(maskedTextBoxJMBG, "JMBG se sastoji iz 13 cifara");
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            
            btnPrikaziSveClanove.Enabled = false;
            tbPassword.Clear();
            maskedTextBoxJMBG.Clear();
            groupBoxNajtrazeniji.Enabled = false;
            richTextBox1.Enabled = false;
            tabControl1.Enabled = false;
            menuStrip2.Enabled = false;
            btnPrijaviSE.Enabled = true;
            odustaniOdIznajmljivanja();
            odustaniOdVracanja();
        }


        private void btnVratiFilm_Click(object sender, EventArgs e)
        {
            VracanjeFilma();
        }

        private void tbCalnIDVracanje_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbCalnIDVracanje.Text))
            {
                errorProvider1.SetError(tbClanIDIznajmljivanje, "Morate uneti ID clana !");
            }
        }
        private void odustaniOdVracanja()
        {

            tbCalnIDVracanje.Clear();
            rtbKazna.Clear();
            tbIznosKazne.Clear();
            tbKaznaID.Clear();
            dtpDatumVracanja.Value = System.DateTime.Now;
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            odustaniOdVracanja();
        }
        private void VracanjeFilma()
        {
            if (ProveraClanaZaVracanje())
            {
                using (SqlCommand komanda = new SqlCommand())
                {
                    SqlConnection konekcija = new SqlConnection(Konekcija.konString);
                    komanda.Connection = konekcija;

                    komanda.CommandText = "UPDATE Iznajmljivanje_Filmova SET DatumVracanja = @datum WHERE ClanID = @clan and FilmID = @film";
                    komanda.Parameters.AddWithValue("@datum", dtpDatumVracanja.Value);
                    komanda.Parameters.AddWithValue("@clan", tbCalnIDVracanje.Text);
                    komanda.Parameters.AddWithValue("@film", comboBoxFilmovi.SelectedValue);
                   
                    try
                    {
                        konekcija.Open();
                        komanda.ExecuteNonQuery();
                        MessageBox.Show("Uspesno vracen film  ! ", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        odustaniOdIznajmljivanja();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greska: " + ex.Message);
                    }
                    finally
                    {
                        konekcija.Close();
                    }
                }
                    TimeSpan trajanje = dtpDatumVracanja.Value - dtpDatumIznajmljivanja.Value;
                    if (trajanje.Days >= 10)
                    {
                        Random rnd = new Random();
                        int IDkazna = rnd.Next(100000, 999999);
                        tbKaznaID.Text = IDkazna.ToString();
                        groupBoxKazna.Enabled = true;
                        int brDana = (int)trajanje.Days + 1;
                        rtbKazna.Text = "Film je vracen nakon\n"+ brDana.ToString() + " dana \n";
                        tbIznosKazne.Text = "1000.00";
                    } 
                        
            }
        }

        private void btnBeleziKaznu_Click(object sender, EventArgs e)
        {
            using (SqlCommand komanda = new SqlCommand())
            {
                SqlConnection konekcija = new SqlConnection(Konekcija.konString);
                komanda.Connection = konekcija;
                komanda.CommandText = "INSERT INTO Kazne (KaznaID, ClanID, DatumPisanja, VisinaNadoknade, TipKazne, Placena) VALUES(@id, @clan, @datum, @iznos, @tip, @placeno)";
                komanda.Parameters.AddWithValue("@id", tbKaznaID.Text);
                komanda.Parameters.AddWithValue("@clan", tbCalnIDVracanje.Text);
                komanda.Parameters.AddWithValue("@datum", System.DateTime.Now);
                komanda.Parameters.AddWithValue("@iznos", tbIznosKazne.Text);
                komanda.Parameters.AddWithValue("@tip", rtbKazna.Text);
                if (chbPlacanjeOdmah.Checked)
                    komanda.Parameters.AddWithValue("@placeno", "da");
                else
                    komanda.Parameters.AddWithValue("@placeno", "ne");
                try
                {
                    konekcija.Open();
                    int prom = komanda.ExecuteNonQuery();
                    if (prom > 0)
                        MessageBox.Show("Kazna je zavedena !", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Greska , nije zavedena kazna !", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Greska "+ex.Message);
                }
                finally
                {
                    konekcija.Close();
                }
            }
        }

        private void tbKaznaID_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(tbKaznaID.Text))
            {
                errorProvider1.SetError(tbKaznaID, "Polje mora biti popunjeno ! ");
            }
        }
    }
}
    

