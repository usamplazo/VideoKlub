using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoKlub
{
    public partial class TabelaClanova : Form
    {
        public TabelaClanova()
        {
            InitializeComponent();
        }

        private void TabelaClanova_Load(object sender, EventArgs e)
        {
            
            this.clanoviTableAdapter.Fill(this.videoKlubDataSet.Clanovi);



        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                this.clanoviTableAdapter.Update(this.videoKlubDataSet.Clanovi);
                MessageBox.Show("Uspesno unete izmene !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }
    }
}
