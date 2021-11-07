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
    public partial class frmYedeklemeIslemleri : Form
    {
        public frmYedeklemeIslemleri()
        {
            InitializeComponent();
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            frmYedekleme yedekleme = new frmYedekleme();
            yedekleme.Show();
            this.Hide();
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            frmYedekYukle yedekYukle = new frmYedekYukle();
            yedekYukle.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaMenu ana = new frmAnaMenu();
            ana.Show();
            this.Close();
        }
    }
}
