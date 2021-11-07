using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeteveDergiProje
{
    public partial class frmYedekleme : Form
    {
        public frmYedekleme()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                txtKayitYeri.Text = diag.SelectedPath;
            }
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string dd = d.Month + "-" + d.Day + "-" + d.Hour + "-" + d.Minute + "-" + d.Second;
            try
            {
                SqlConnection con = new SqlConnection(Genel.conString);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("USE AbonelikProje", con);
                SqlCommand cmd2 = new SqlCommand("BACKUP DATABASE AbonelikProje TO DISK = '" + txtKayitYeri.Text + "\\AbonelikProje_" + dd + ".Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of AbonelikProje';", con);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Yedekleme işlemi başarıyla tamamlandı.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yedekleme yapılamadı! " + ex.Message);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmYedeklemeIslemleri yi = new frmYedeklemeIslemleri();
            yi.Show();
            this.Close();
        }

        private void frmYedekleme_Load(object sender, EventArgs e)
        {
            txtSunucuAdi.Enabled = false;
        }
    }
}
