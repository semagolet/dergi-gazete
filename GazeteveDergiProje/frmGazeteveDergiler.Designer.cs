
namespace GazeteveDergiProje
{
    partial class frmGazeteveDergiler
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
            this.listGazete = new System.Windows.Forms.ListView();
            this.chGazeteler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDergi = new System.Windows.Forms.ListView();
            this.chDergiler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDergiFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDergiKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGazeteAdi = new System.Windows.Forms.TextBox();
            this.lblFiyat1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGazeteAdi = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGazeteSil = new System.Windows.Forms.Button();
            this.btnGazeteEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDergiAdi = new System.Windows.Forms.Label();
            this.btnGuncelle2 = new System.Windows.Forms.Button();
            this.btnDergiSil = new System.Windows.Forms.Button();
            this.btnDergiEkle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtDergiAdi = new System.Windows.Forms.TextBox();
            this.txtGazeteFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtGazeteKategori = new System.Windows.Forms.NumericUpDown();
            this.txtDergiKategori = new System.Windows.Forms.NumericUpDown();
            this.txtDergiFiyat = new System.Windows.Forms.NumericUpDown();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbKategori2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtGazeteFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGazeteKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDergiKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDergiFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // listGazete
            // 
            this.listGazete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGazeteler,
            this.chFiyat,
            this.chKategori});
            this.listGazete.HideSelection = false;
            this.listGazete.Location = new System.Drawing.Point(63, 65);
            this.listGazete.Name = "listGazete";
            this.listGazete.Size = new System.Drawing.Size(673, 393);
            this.listGazete.TabIndex = 0;
            this.listGazete.UseCompatibleStateImageBehavior = false;
            this.listGazete.View = System.Windows.Forms.View.Details;
            this.listGazete.SelectedIndexChanged += new System.EventHandler(this.listGazete_SelectedIndexChanged);
            // 
            // chGazeteler
            // 
            this.chGazeteler.Text = "GAZETELER";
            this.chGazeteler.Width = 215;
            // 
            // chFiyat
            // 
            this.chFiyat.Text = "FIYAT";
            this.chFiyat.Width = 140;
            // 
            // chKategori
            // 
            this.chKategori.Text = "KATEGORI";
            this.chKategori.Width = 314;
            // 
            // listDergi
            // 
            this.listDergi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDergiler,
            this.chDergiFiyat,
            this.chDergiKategori});
            this.listDergi.HideSelection = false;
            this.listDergi.Location = new System.Drawing.Point(798, 65);
            this.listDergi.Name = "listDergi";
            this.listDergi.Size = new System.Drawing.Size(673, 393);
            this.listDergi.TabIndex = 1;
            this.listDergi.UseCompatibleStateImageBehavior = false;
            this.listDergi.View = System.Windows.Forms.View.Details;
            // 
            // chDergiler
            // 
            this.chDergiler.Text = "DERGILER";
            this.chDergiler.Width = 215;
            // 
            // chDergiFiyat
            // 
            this.chDergiFiyat.Text = "FIYAT";
            this.chDergiFiyat.Width = 140;
            // 
            // chDergiKategori
            // 
            this.chDergiKategori.Text = "KATEGORI";
            this.chDergiKategori.Width = 314;
            // 
            // txtGazeteAdi
            // 
            this.txtGazeteAdi.Location = new System.Drawing.Point(63, 651);
            this.txtGazeteAdi.Name = "txtGazeteAdi";
            this.txtGazeteAdi.Size = new System.Drawing.Size(327, 33);
            this.txtGazeteAdi.TabIndex = 2;
            // 
            // lblFiyat1
            // 
            this.lblFiyat1.AutoSize = true;
            this.lblFiyat1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiyat1.Location = new System.Drawing.Point(391, 618);
            this.lblFiyat1.Name = "lblFiyat1";
            this.lblFiyat1.Size = new System.Drawing.Size(71, 25);
            this.lblFiyat1.TabIndex = 9;
            this.lblFiyat1.Text = "Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kategori No :";
            // 
            // lblGazeteAdi
            // 
            this.lblGazeteAdi.AutoSize = true;
            this.lblGazeteAdi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGazeteAdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGazeteAdi.Location = new System.Drawing.Point(60, 618);
            this.lblGazeteAdi.Name = "lblGazeteAdi";
            this.lblGazeteAdi.Size = new System.Drawing.Size(139, 25);
            this.lblGazeteAdi.TabIndex = 8;
            this.lblGazeteAdi.Text = "Gazete Adı :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Image = global::GazeteveDergiProje.Properties.Resources.guncelle;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(514, 494);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(222, 75);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGazeteSil
            // 
            this.btnGazeteSil.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGazeteSil.Image = global::GazeteveDergiProje.Properties.Resources.sil;
            this.btnGazeteSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGazeteSil.Location = new System.Drawing.Point(291, 494);
            this.btnGazeteSil.Name = "btnGazeteSil";
            this.btnGazeteSil.Size = new System.Drawing.Size(217, 75);
            this.btnGazeteSil.TabIndex = 6;
            this.btnGazeteSil.Text = "Gazete Sil";
            this.btnGazeteSil.UseVisualStyleBackColor = true;
            this.btnGazeteSil.Click += new System.EventHandler(this.btnGazeteSil_Click);
            // 
            // btnGazeteEkle
            // 
            this.btnGazeteEkle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGazeteEkle.Image = global::GazeteveDergiProje.Properties.Resources.ekle;
            this.btnGazeteEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGazeteEkle.Location = new System.Drawing.Point(63, 494);
            this.btnGazeteEkle.Name = "btnGazeteEkle";
            this.btnGazeteEkle.Size = new System.Drawing.Size(222, 75);
            this.btnGazeteEkle.TabIndex = 5;
            this.btnGazeteEkle.Text = "Gazete Ekle";
            this.btnGazeteEkle.UseVisualStyleBackColor = true;
            this.btnGazeteEkle.Click += new System.EventHandler(this.btnGazeteEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1295, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kategori No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1126, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fiyat :";
            // 
            // lblDergiAdi
            // 
            this.lblDergiAdi.AutoSize = true;
            this.lblDergiAdi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDergiAdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDergiAdi.Location = new System.Drawing.Point(793, 618);
            this.lblDergiAdi.Name = "lblDergiAdi";
            this.lblDergiAdi.Size = new System.Drawing.Size(119, 25);
            this.lblDergiAdi.TabIndex = 17;
            this.lblDergiAdi.Text = "Dergi Adı :";
            // 
            // btnGuncelle2
            // 
            this.btnGuncelle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle2.Image = global::GazeteveDergiProje.Properties.Resources.guncelle;
            this.btnGuncelle2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle2.Location = new System.Drawing.Point(1249, 494);
            this.btnGuncelle2.Name = "btnGuncelle2";
            this.btnGuncelle2.Size = new System.Drawing.Size(222, 75);
            this.btnGuncelle2.TabIndex = 16;
            this.btnGuncelle2.Text = "Güncelle";
            this.btnGuncelle2.UseVisualStyleBackColor = true;
            this.btnGuncelle2.Click += new System.EventHandler(this.btnGuncelle2_Click);
            // 
            // btnDergiSil
            // 
            this.btnDergiSil.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDergiSil.Image = global::GazeteveDergiProje.Properties.Resources.sil;
            this.btnDergiSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDergiSil.Location = new System.Drawing.Point(1026, 494);
            this.btnDergiSil.Name = "btnDergiSil";
            this.btnDergiSil.Size = new System.Drawing.Size(217, 75);
            this.btnDergiSil.TabIndex = 15;
            this.btnDergiSil.Text = "Dergi Sil";
            this.btnDergiSil.UseVisualStyleBackColor = true;
            this.btnDergiSil.Click += new System.EventHandler(this.btnDergiSil_Click);
            // 
            // btnDergiEkle
            // 
            this.btnDergiEkle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDergiEkle.Image = global::GazeteveDergiProje.Properties.Resources.ekle;
            this.btnDergiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDergiEkle.Location = new System.Drawing.Point(798, 494);
            this.btnDergiEkle.Name = "btnDergiEkle";
            this.btnDergiEkle.Size = new System.Drawing.Size(222, 75);
            this.btnDergiEkle.TabIndex = 14;
            this.btnDergiEkle.Text = "Dergi Ekle";
            this.btnDergiEkle.UseVisualStyleBackColor = true;
            this.btnDergiEkle.Click += new System.EventHandler(this.btnDergiEkle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeri.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Image = global::GazeteveDergiProje.Properties.Resources.cikisi;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(63, 714);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(136, 127);
            this.btnGeri.TabIndex = 20;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtDergiAdi
            // 
            this.txtDergiAdi.Location = new System.Drawing.Point(798, 650);
            this.txtDergiAdi.Name = "txtDergiAdi";
            this.txtDergiAdi.Size = new System.Drawing.Size(327, 33);
            this.txtDergiAdi.TabIndex = 23;
            // 
            // txtGazeteFiyat
            // 
            this.txtGazeteFiyat.Location = new System.Drawing.Point(396, 651);
            this.txtGazeteFiyat.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtGazeteFiyat.Name = "txtGazeteFiyat";
            this.txtGazeteFiyat.Size = new System.Drawing.Size(164, 33);
            this.txtGazeteFiyat.TabIndex = 29;
            // 
            // txtGazeteKategori
            // 
            this.txtGazeteKategori.Location = new System.Drawing.Point(566, 651);
            this.txtGazeteKategori.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtGazeteKategori.Name = "txtGazeteKategori";
            this.txtGazeteKategori.Size = new System.Drawing.Size(170, 33);
            this.txtGazeteKategori.TabIndex = 30;
            // 
            // txtDergiKategori
            // 
            this.txtDergiKategori.Location = new System.Drawing.Point(1301, 651);
            this.txtDergiKategori.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtDergiKategori.Name = "txtDergiKategori";
            this.txtDergiKategori.Size = new System.Drawing.Size(170, 33);
            this.txtDergiKategori.TabIndex = 33;
            // 
            // txtDergiFiyat
            // 
            this.txtDergiFiyat.Location = new System.Drawing.Point(1131, 651);
            this.txtDergiFiyat.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtDergiFiyat.Name = "txtDergiFiyat";
            this.txtDergiFiyat.Size = new System.Drawing.Size(164, 33);
            this.txtDergiFiyat.TabIndex = 32;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(566, 690);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(170, 32);
            this.cbKategori.TabIndex = 34;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // cbKategori2
            // 
            this.cbKategori2.FormattingEnabled = true;
            this.cbKategori2.Location = new System.Drawing.Point(1301, 690);
            this.cbKategori2.Name = "cbKategori2";
            this.cbKategori2.Size = new System.Drawing.Size(170, 32);
            this.cbKategori2.TabIndex = 35;
            this.cbKategori2.SelectedIndexChanged += new System.EventHandler(this.cbKategori2_SelectedIndexChanged);
            // 
            // frmGazeteveDergiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 853);
            this.Controls.Add(this.cbKategori2);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.txtDergiKategori);
            this.Controls.Add(this.txtDergiFiyat);
            this.Controls.Add(this.txtGazeteKategori);
            this.Controls.Add(this.txtGazeteFiyat);
            this.Controls.Add(this.txtDergiAdi);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDergiAdi);
            this.Controls.Add(this.btnGuncelle2);
            this.Controls.Add(this.btnDergiSil);
            this.Controls.Add(this.btnDergiEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFiyat1);
            this.Controls.Add(this.lblGazeteAdi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGazeteSil);
            this.Controls.Add(this.btnGazeteEkle);
            this.Controls.Add(this.txtGazeteAdi);
            this.Controls.Add(this.listDergi);
            this.Controls.Add(this.listGazete);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmGazeteveDergiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gazete ve Dergiler";
            this.Load += new System.EventHandler(this.frmGazeteveDergiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGazeteFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGazeteKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDergiKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDergiFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listGazete;
        private System.Windows.Forms.ColumnHeader chGazeteler;
        private System.Windows.Forms.ColumnHeader chFiyat;
        private System.Windows.Forms.ColumnHeader chKategori;
        private System.Windows.Forms.ListView listDergi;
        private System.Windows.Forms.ColumnHeader chDergiler;
        private System.Windows.Forms.ColumnHeader chDergiFiyat;
        private System.Windows.Forms.ColumnHeader chDergiKategori;
        private System.Windows.Forms.TextBox txtGazeteAdi;
        private System.Windows.Forms.Button btnGazeteEkle;
        private System.Windows.Forms.Button btnGazeteSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblGazeteAdi;
        private System.Windows.Forms.Label lblFiyat1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDergiAdi;
        private System.Windows.Forms.Button btnGuncelle2;
        private System.Windows.Forms.Button btnDergiSil;
        private System.Windows.Forms.Button btnDergiEkle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtDergiAdi;
        private System.Windows.Forms.NumericUpDown txtGazeteFiyat;
        private System.Windows.Forms.NumericUpDown txtGazeteKategori;
        private System.Windows.Forms.NumericUpDown txtDergiKategori;
        private System.Windows.Forms.NumericUpDown txtDergiFiyat;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbKategori2;
    }
}