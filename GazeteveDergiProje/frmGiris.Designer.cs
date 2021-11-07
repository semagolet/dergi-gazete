
namespace GazeteveDergiProje
{
    partial class frmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblKullaniciGirisi = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(545, 225);
            this.txtKullanici.MaxLength = 25;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(231, 33);
            this.txtKullanici.TabIndex = 0;
            this.txtKullanici.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(545, 288);
            this.txtSifre.MaxLength = 25;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(231, 33);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // lblKullaniciGirisi
            // 
            this.lblKullaniciGirisi.AutoSize = true;
            this.lblKullaniciGirisi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciGirisi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciGirisi.Location = new System.Drawing.Point(584, 126);
            this.lblKullaniciGirisi.Name = "lblKullaniciGirisi";
            this.lblKullaniciGirisi.Size = new System.Drawing.Size(153, 25);
            this.lblKullaniciGirisi.TabIndex = 2;
            this.lblKullaniciGirisi.Text = "Kullanıcı Girişi";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(388, 228);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(151, 25);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.Location = new System.Drawing.Point(473, 291);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(66, 25);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre :";
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Location = new System.Drawing.Point(545, 343);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(108, 46);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(668, 343);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(108, 46);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GazeteveDergiProje.Properties.Resources.giris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblKullaniciGirisi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblKullaniciGirisi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
    }
}

