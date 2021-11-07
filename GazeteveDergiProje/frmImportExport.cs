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
    public partial class frmImportExport : Form
    {
        public frmImportExport()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaMenu menu = new frmAnaMenu();
            menu.Show();
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImport imp = new frmImport();
            imp.Show();
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            frmExport exp = new frmExport();
            exp.Show();
            this.Close();
        }
    }
}
