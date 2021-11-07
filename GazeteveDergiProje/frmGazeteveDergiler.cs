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
    public partial class frmGazeteveDergiler : Form
    {

        SqlDataReader dr;

        public frmGazeteveDergiler()
        {
            InitializeComponent();
        }

        private void frmGazeteveDergiler_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString)) // Gazete listesi
            {
                listGazete.Items.Clear();
                con.Open();
                SqlCommand cbGazete = new SqlCommand("select  k.KategoriAD , g.GazeteAd , g.GazeteFiyat from Gazete g inner join Kategori k on k.KategoriID = g.GazeteKategori", con);
                dr = cbGazete.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["GazeteAd"].ToString());
                    item.SubItems.Add(dr["GazeteFiyat"].ToString() + " TL");
                    item.SubItems.Add(dr["KategoriAd"].ToString());

                    listGazete.Items.Add(item);
                }
                con.Close();
            }

            using (SqlConnection con = new SqlConnection(Genel.conString)) // Dergi listesi
            {
                listDergi.Items.Clear();
                con.Open();
                SqlCommand cbDergi = new SqlCommand("select  k.KategoriAD , d.DergiAd , d.DergiFiyat from Dergi d inner join Kategori k on k.KategoriID = d.DergiKategori", con);
                dr = cbDergi.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["DergiAd"].ToString());
                    item.SubItems.Add(dr["DergiFiyat"].ToString() + " TL");
                    item.SubItems.Add(dr["KategoriAd"].ToString());

                    listDergi.Items.Add(item);
                }
                con.Close();
            }

            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                cbKategori.Items.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kategori", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbKategori.Items.Add(dr["KategoriID"] + " " + dr["KategoriAD"]);
                    cbKategori2.Items.Add(dr["KategoriID"] + " " + dr["KategoriAD"]);
                }
                con.Close();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmAnaMenu menu = new frmAnaMenu();
            menu.Show();
            this.Close();
        }

        private void btnGazeteEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("gazeteAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GazeteKategori", txtGazeteKategori.Text.Trim());
                cmd.Parameters.AddWithValue("@GazeteAd", txtGazeteAdi.Text.Trim());
                cmd.Parameters.AddWithValue("@GazeteFiyat", txtGazeteFiyat.Text.Trim());
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(txtGazeteAdi.Text + " gazetesi veritabanına eklendi.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Gazete eklenemedi! Lütfen kontrol ediniz.");
                }

                con.Close();

                frmGazeteveDergiler gvd = new frmGazeteveDergiler();
                gvd.Show();
                this.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmGazeteveDergiler gvd = new frmGazeteveDergiler();
            gvd.Show();
            this.Close();
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            frmGazeteveDergiler gvd = new frmGazeteveDergiler();
            gvd.Show();
            this.Close();
        }

        private void btnDergiEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("dergiAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DergiKategori", txtDergiKategori.Text.Trim());
                cmd.Parameters.AddWithValue("@DergiAd", txtDergiAdi.Text.Trim());
                cmd.Parameters.AddWithValue("@DergiFiyat", txtDergiFiyat.Text.Trim());
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(txtDergiAdi.Text + " dergisi veritabanına eklendi.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Dergi eklenemedi! Lütfen kontrol ediniz.");
                }        
                con.Close();
                frmGazeteveDergiler gvd = new frmGazeteveDergiler();
                gvd.Show();
                this.Close();
            }
        }

        private void btnGazeteSil_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                string query = "Select * from Gazete Where GazeteAd = '" + txtGazeteAdi.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE from Gazete Where GazeteAd = '" + txtGazeteAdi.Text.Trim() + "'", con); ;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(txtGazeteAdi.Text + " gazetesi silindi.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Geçersiz silme işlemi yaptınız.");
                    }
                    con.Close();
                    
                    frmGazeteveDergiler gvd = new frmGazeteveDergiler();
                    gvd.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Geçersiz silme işlemi yaptınız!");
                    con.Close();
                }
            }
        }

        private void btnDergiSil_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                string query = "Select * from Dergi Where DergiAd = '" + txtDergiAdi.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE from Dergi Where DergiAd = '" + txtDergiAdi.Text.Trim() + "'", con); ;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(txtDergiAdi.Text + " dergisi silindi.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Geçersiz silme işlemi yaptınız.");
                    }
                    con.Close();

                    frmGazeteveDergiler gvd = new frmGazeteveDergiler();
                    gvd.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Geçersiz silme işlemi yaptınız!");
                    con.Close();
                }
            }
        }

        private void listGazete_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbKategori.SelectedItem.ToString();
            txtGazeteKategori.Text = id.Substring(0, id.IndexOf(" "));
        }

        private void cbKategori2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbKategori2.SelectedItem.ToString();
            txtGazeteKategori.Text = id.Substring(0, id.IndexOf(" "));
        }
    }
}
