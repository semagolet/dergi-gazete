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
    public partial class frmAbonelik : Form
    {

        SqlDataReader dr;

        public frmAbonelik()
        {
            InitializeComponent();
        }

        private void frmAbonelik_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                listAbone.Items.Clear();
                con.Open();
                SqlCommand cbAbone = new SqlCommand("select  AboneID , AboneBas ,AboneBit from Abone", con);
                dr = cbAbone.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["AboneID"].ToString());
                    item.SubItems.Add(dr["AboneBas"].ToString());
                    item.SubItems.Add(dr["AboneBit"].ToString());

                    listAbone.Items.Add(item);
                }
                con.Close();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaMenu anaMenu = new frmAnaMenu();
            anaMenu.Show();
            this.Close();
        }

        private void btnAdaGore_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("AdaGore", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusAd", txtAd.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show(txtAd.Text + " isimli müşteri bulundu.");
                    musteri.ad = dr["MusAd"].ToString();
                    musteri.soyad = dr["MusSoyad"].ToString();
                    musteri.aboneNo = (int)dr["MusAbone"];
                    musteri.adres = dr["MusAdres"].ToString();
                    txtSonucAd.Text = musteri.ad;
                    txtSonucSoyad.Text = musteri.soyad;
                    txtSonucAbone.Text = musteri.aboneNo.ToString();
                    txtSonucAdres.Text = musteri.adres;
                }
                else
                {
                    MessageBox.Show("Arama bulunamadı.");
                }
                con.Close();
            }
        }

        private void btnSoyadaGore_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SoyadaGore", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusSoyad", txtSoyad.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show(txtSoyad.Text + " isimli müşteri bulundu.");
                    musteri.ad = dr["MusAd"].ToString();
                    musteri.soyad = dr["MusSoyad"].ToString();
                    musteri.aboneNo = (int)dr["MusAbone"];
                    musteri.adres = dr["MusAdres"].ToString();
                    txtSonucAd.Text = musteri.ad;
                    txtSonucSoyad.Text = musteri.soyad;
                    txtSonucAbone.Text = musteri.aboneNo.ToString();
                    txtSonucAdres.Text = musteri.adres;
                }
                else
                {
                    MessageBox.Show("Arama bulunamadı.");
                }
                con.Close();
            }
        }

        private void btnAdSoyadaGore_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("AdANDsoyad", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusAd", txtAd.Text);
                cmd.Parameters.AddWithValue("@MusSoyad", txtSoyad.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " isimli müşteri bulundu.");
                    musteri.ad = dr["MusAd"].ToString();
                    musteri.soyad = dr["MusSoyad"].ToString();
                    musteri.aboneNo = (int)dr["MusAbone"];
                    musteri.adres = dr["MusAdres"].ToString();
                    txtSonucAd.Text = musteri.ad;
                    txtSonucSoyad.Text = musteri.soyad;
                    txtSonucAbone.Text = musteri.aboneNo.ToString();
                    txtSonucAdres.Text = musteri.adres;
                }
                else
                {
                    MessageBox.Show("Arama bulunamadı.");
                }
                con.Close();
            }
        }

        private void btnAboneGore_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = new Musteri();
                using (SqlConnection con = new SqlConnection(Genel.conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AboneGore", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MusAbone", txtAbone.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show(txtAbone.Text + " numaralı müşteri bulundu.");
                        musteri.ad = dr["MusAd"].ToString();
                        musteri.soyad = dr["MusSoyad"].ToString();
                        musteri.aboneNo = (int)dr["MusAbone"];
                        musteri.adres = dr["MusAdres"].ToString();
                        txtSonucAd.Text = musteri.ad;
                        txtSonucSoyad.Text = musteri.soyad;
                        txtSonucAbone.Text = musteri.aboneNo.ToString();
                        txtSonucAdres.Text = musteri.adres;
                    }
                    else
                    {
                        MessageBox.Show("Arama bulunamadı.");
                    }
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayı olarak giriniz!");
            }
        }

        private void btnAdreseGore_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("AdreseGore", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusAdres", txtAd.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " isimli müşteri bulundu.");
                    musteri.ad = dr["MusAd"].ToString();
                    musteri.soyad = dr["MusSoyad"].ToString();
                    musteri.aboneNo = (int)dr["MusAbone"];
                    musteri.adres = dr["MusAdres"].ToString();
                    txtSonucAd.Text = musteri.ad;
                    txtSonucSoyad.Text = musteri.soyad;
                    txtSonucAbone.Text = musteri.aboneNo.ToString();
                    txtSonucAdres.Text = musteri.adres;
                }
                else
                {
                    MessageBox.Show("Arama bulunamadı.");
                }
                con.Close();
            }
        }

        private void btnAboneBasla_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("aboneAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AboneID", txtAboneNo.Text.Trim());
                cmd.Parameters.AddWithValue("@AboneBas", dateBaslangic.Value.ToString());
                cmd.Parameters.AddWithValue("@AboneBit", dateBitis.Value.ToString());
                cmd.Parameters.AddWithValue("@AboneGazete", txtGazeteNo.Text.Trim());
                cmd.Parameters.AddWithValue("@AboneDergi", txtDergiNo.Text.Trim());
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(txtAboneNo.Text + " numaralı abonelik başlatıldı.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Abonelik daha önceden atanmış!");
                }

                con.Close();
                frmAbonelik abone = new frmAbonelik();
                abone.Show();
                this.Close();
            }
        }

        private void btnAboneBitir_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                string query = "Select * from Abone Where AboneID = '" + txtAboneNo.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if(dtbl.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("Delete From Abone Where AboneID = '" + txtAboneNo.Text.Trim() + "'", con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(txtAboneNo.Text + " numaralı abonelik silindi.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Silme işlemi yapılamadı!");
                    }
                    con.Close();
                    frmAbonelik abonelik = new frmAbonelik();
                    abonelik.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Silme işlemi geçersiz!");
                    con.Close();
                }
            }
        }
    }
}
