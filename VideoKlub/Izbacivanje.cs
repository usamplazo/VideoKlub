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
    public partial class Izbacivanje : Form
    {
        TabelaClanova tc = new TabelaClanova();
        SqlConnection konekcija = new SqlConnection(Konekcija.konString);
        public Izbacivanje()
        {
            InitializeComponent();

        }
        private void resetuj()
        {
            listBox1.Items.Clear();
            maskedTextBox1.Clear();
            chbPodaciZaBrisanje.Checked = false;
            toolStripObrisan.Text = "";
            listBox1.Visible = false;
            richTextBoxDuzinaClanstva.Clear();
            richTextBoxDuzinaClanstva.Visible = false;
        }
        private void racunajClanstvo()
        {
            
            dateTimePickerClanDO.Value = System.DateTime.Now;
            TimeSpan trajanje = dateTimePickerClanDO.Value - dateTimePickerClanOD.Value;

            if (trajanje.Days >= 0)
            {
                int brDana = (int)trajanje.Days + 1;
                richTextBoxDuzinaClanstva.Text += brDana.ToString() + " dana ";
            }
            else
            {
                MessageBox.Show("Greska ! ", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li zelite prekinuti clanstvo ? ", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                if (!String.IsNullOrEmpty(maskedTextBox1.Text))
                {
                    PotvrdaPrijavljivanjem po = new PotvrdaPrijavljivanjem();
                    po.ShowDialog();
                    using (SqlCommand komanda = new SqlCommand())
                    {
                        komanda.Connection = konekcija;
                        komanda.CommandText = "UPDATE c SET c.CalnDO = GETDATE() FROM Clanovi c WHERE ClanID = @id AND CalnDO IS NULL";
                        komanda.Parameters.AddWithValue("@id", maskedTextBox1.Text);
                        try
                        {
                            konekcija.Open();
                            int br = komanda.ExecuteNonQuery();
                            if (br == 0)
                            {
                                MessageBox.Show("Izmena nije izvrsena !");
                                chbPodaciZaBrisanje.Checked = false;
                                listBox1.Visible = false;
                                richTextBoxDuzinaClanstva.Clear();
                                richTextBoxDuzinaClanstva.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Clan : " + maskedTextBox1.Text + " je prekinuo clanstvo ! ");
                                toolStripObrisan.Text = "Poslednji uklonjen clan --> ClanID: " + maskedTextBox1.Text;
                                groupBoxDuzinaClanstva.Enabled = true;
                                
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("GRESKA: " + ex.Message);
                        }
                        finally
                        {
                            konekcija.Close();
                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("Niste uneli sve potrebne podatke ! ");
                    chbPodaciZaBrisanje.Checked = false;
                    listBox1.Visible = false;
                    richTextBoxDuzinaClanstva.Clear();
                    richTextBoxDuzinaClanstva.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Brisanje ponisteno !");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            resetuj();
        } 
        private void chbPodaciZaBrisanje_CheckedChanged(object sender, EventArgs e)
        {
        
            if (chbPodaciZaBrisanje.Checked == true && maskedTextBox1.Text != "")
            {
                listBox1.Items.Clear();
                richTextBoxDuzinaClanstva.Clear();
                listBox1.Visible = true;

                errorProvider1.Clear();
                using (SqlCommand komanda = new SqlCommand())
                {
                    komanda.Connection = konekcija;
                    komanda.CommandText = "SELECT ClanID, Ime, Prezime,JMBG, ClanOD, Telefon FROM Clanovi WHERE ClanID = @mtb";
                    komanda.Parameters.AddWithValue("@mtb", maskedTextBox1.Text);
                    SqlDataReader reader = null;
                    
                    try
                    {
                        konekcija.Open();
                        reader = komanda.ExecuteReader();
                        while(reader.Read())
                        {
                            listBox1.Items.Add("ClanID: " + reader[0].ToString());
                            listBox1.Items.Add("Ime: "+reader[1].ToString());
                            listBox1.Items.Add("Prezime: " + reader[2].ToString());
                            listBox1.Items.Add("JMBG: " + reader[3].ToString());
                            listBox1.Items.Add("Telefon: " + reader[5].ToString());
                            DateTime datum = Convert.ToDateTime(reader[4]);
                            listBox1.Items.Add("Clan od: "+ datum.ToShortDateString());
                            dateTimePickerClanOD.Value = datum;

                            richTextBoxDuzinaClanstva.Text = "Clan " + reader[1].ToString() + " " + reader[2].ToString() + " ( " + reader[0].ToString() + ") \nBio je clan video kluba : ";
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
            else
            {
                listBox1.Visible = false;
            }
           
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(maskedTextBox1, "ClanID se sastoji od cifara !");
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                errorProvider1.SetError(maskedTextBox1, "Potreban unos ClanID");
                listBox1.Visible = false;
            }
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            
            racunajClanstvo();
            richTextBoxDuzinaClanstva.Visible = true;
        }

        private void btnPrikaziSveClanove_Click(object sender, EventArgs e)
        {
            tc.ShowDialog();
        }


        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }
    }

