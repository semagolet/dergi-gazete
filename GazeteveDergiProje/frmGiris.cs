using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeteveDergiProje
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(Genel.conString);
                SqlCommand cmd = new SqlCommand("sp_role_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@kadi", txtKullanici.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr[1].ToString() == "1000") // 1000 = Admin
                    {
                        Genel.rol = "Admin";
                    }
                    else if (dr[1].ToString() == "1001") // 1001 = Satış Danışmanı
                    {
                        Genel.rol = "SatisDanismani";
                    }
                    else if (dr[1].ToString() == "1002") // 1002 = Ürün Sorumlusu
                    {
                        Genel.rol = "UrunSorumlusu";
                    }
                    frmAnaMenu anaMenu = new frmAnaMenu();
                    anaMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
