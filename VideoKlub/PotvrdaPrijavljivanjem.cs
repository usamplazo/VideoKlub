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
    public partial class PotvrdaPrijavljivanjem : Form
    {
        TabelaClanova tc = new TabelaClanova();
        public PotvrdaPrijavljivanjem()
        {
            InitializeComponent();
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

        private void btnPrijaviSE_Click(object sender, EventArgs e)
        {
            if (proveraRadnika() && !String.IsNullOrEmpty(maskedTextBoxJMBG.Text) && !String.IsNullOrEmpty(tbPassword.Text))
            {
                this.Close();
            }
        }

        private void btnPrikaziSveClanove_Click(object sender, EventArgs e)
        {
            tc.ShowDialog();
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Morate umeti ID radnika !");
                tbPassword.Focus();

            }
        }

        private void maskedTextBoxJMBG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(maskedTextBoxJMBG, "JMBG se sastoji iz 13 cifara");
        }
    }
}
