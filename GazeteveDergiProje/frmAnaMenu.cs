using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeteveDergiProje
{
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void frmAnaMenu_Load(object sender, EventArgs e) // Yetkiye göre seçenek belirle.
        {
            if (Genel.rol == "Admin")
            {
                btnMusteri.Enabled = true;
                btnAbonelik.Enabled = true;
                btnGazeteveDergi.Enabled = true;
                btnSilinen.Enabled = true;
                btnYedek.Enabled = true;
                btnImpExp.Enabled = true;
            }
            else if (Genel.rol == "SatisDanismani")
            {
                btnMusteri.Enabled = true;
                btnAbonelik.Enabled = true;
                btnGazeteveDergi.Enabled = false;
                btnSilinen.Enabled = false;
                btnYedek.Enabled = false;
                btnImpExp.Enabled = false;
            }
            else if (Genel.rol == "UrunSorumlusu")
            {
                btnMusteri.Enabled = false;
                btnAbonelik.Enabled = false;
                btnGazeteveDergi.Enabled = true;
                btnSilinen.Enabled = false;
                btnYedek.Enabled = false;
                btnImpExp.Enabled = false;
            }
            else
            {
                MessageBox.Show("Yetki algılanmadı. Çıkış yapılıyor..");
                frmGiris giris = new frmGiris();
                giris.Show();
                this.Close();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e) // Giriş ekranına geri dön.
        {
            frmGiris giris = new frmGiris();
            giris.Show();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e) // Programdan cikis yap.
        {
            Application.Exit();
        }

        private void btnGazeteveDergi_Click(object sender, EventArgs e)
        {
            frmGazeteveDergiler gvd = new frmGazeteveDergiler();
            gvd.Show();
            this.Hide();
        }

        private void btnAbonelik_Click(object sender, EventArgs e)
        {
            frmAbonelik abonelik = new frmAbonelik();
            abonelik.Show();
            this.Hide();
        }

        private void btnYedek_Click(object sender, EventArgs e)
        {
            frmYedeklemeIslemleri yedekleme = new frmYedeklemeIslemleri();
            yedekleme.Show();
            this.Hide();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriler musteri = new frmMusteriler();
            musteri.Show();
            this.Hide();
        }

        private void btnImpExp_Click(object sender, EventArgs e)
        {
            frmImportExport ie = new frmImportExport();
            ie.Show();
            this.Hide();
        }
    }
}
