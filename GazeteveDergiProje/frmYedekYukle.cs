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
    public partial class frmYedekYukle : Form
    {
        public frmYedekYukle()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.InitialDirectory = @"C:\";
            ofd1.Title = "Browse Text Files";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.DefaultExt = "BAK";
            ofd1.Filter = "Text files (*.bak)|*.bak";
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                txtKayitYeri.Text = ofd1.FileName;
            }
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"SERVER=" + txtSunucuAdi.Text + "; Database=Master; Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("USE master;", con);
            SqlCommand cmd1 = new SqlCommand("create database AbonelikProjeRESTORED", con);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();
            SqlConnection sqlcon1 = new SqlConnection(@"SERVER=" + txtSunucuAdi.Text + "; Database=AbonelikProjeRESTORED; Integrated Security=true");
            sqlcon1.Open();
            SqlCommand cmd4 = new SqlCommand("USE master;", sqlcon1);
            SqlCommand cmd2 = new SqlCommand("ALTER DATABASE AbonelikProjeRESTORED SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", sqlcon1);
            SqlCommand cmd3 = new SqlCommand("RESTORE DATABASE AbonelikProjeRESTORED FROM DISK = '" + txtKayitYeri.Text + "' WITH REPLACE ", sqlcon1);
            cmd4.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            MessageBox.Show("Yedek başarıyla geri yüklenmiştir.");
            sqlcon1.Close();
        }

        private void frmYedekYukle_Load(object sender, EventArgs e)
        {
            //txtSunucuAdi.Text = "WIP";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmYedeklemeIslemleri y = new frmYedeklemeIslemleri();
            y.Show();
            this.Close();
        }
    }
}
