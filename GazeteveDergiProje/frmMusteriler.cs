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
    public partial class frmMusteriler : Form
    {

        SqlDataReader dr;

        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                listMusteriler.Items.Clear();
                con.Open();
                SqlCommand cbMusteriler = new SqlCommand("SELECT MusAd, MusSoyad, MusTelNum, MusEMail, MusAdres, MusAbone from Musteri", con);
                dr = cbMusteriler.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MusAd"].ToString());
                    item.SubItems.Add(dr["MusSoyad"].ToString());
                    item.SubItems.Add(dr["MusTelNum"].ToString());
                    item.SubItems.Add(dr["MusEMail"].ToString());
                    item.SubItems.Add(dr["MusAdres"].ToString());
                    item.SubItems.Add(dr["MusAbone"].ToString());

                    listMusteriler.Items.Add(item);
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("musteriAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusAd", txtAdi.Text.Trim());
                cmd.Parameters.AddWithValue("@MusSoyad", txtSoyadi.Text.Trim());
                cmd.Parameters.AddWithValue("@MusTelNum", txtTelNo.Text.Trim());
                cmd.Parameters.AddWithValue("@MusEMail", txtEposta.Text.Trim());
                cmd.Parameters.AddWithValue("@MusAdres", txtAdresi.Text.Trim());
                cmd.Parameters.AddWithValue("@MusAbone", txtAboneNo.Text.Trim());
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(txtAdi.Text + " " + txtSoyadi.Text + " isimli müşteri eklendi.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Veritabanına bağlanılamadı.");
                }
                con.Close();

                frmMusteriler mus = new frmMusteriler();
                mus.Show();
                this.Close();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Genel.conString))
            {
                con.Open();
                string query = "Select * from Musteri Where MusEMail = '" + txtEpostaSil.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    SqlCommand cmd = new SqlCommand("DELETE from Musteri Where MusEMail = '" + txtEpostaSil.Text.Trim() + "'", con); ;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri veritabanından kaldırıldı.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Geçersiz silme işlemi yaptınız.");
                    }
                    con.Close();

                    frmMusteriler mus = new frmMusteriler();
                    mus.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Geçersiz silme işlemi yaptınız!");
                    con.Close();
                }
            }
        }
    }
}
