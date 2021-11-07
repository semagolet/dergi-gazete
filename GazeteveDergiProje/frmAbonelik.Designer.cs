
namespace GazeteveDergiProje
{
    partial class frmAbonelik
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.listAbone = new System.Windows.Forms.ListView();
            this.chAbonelikNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAboneTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAboneTarih2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAbone = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSonucAdres = new System.Windows.Forms.TextBox();
            this.txtSonucAbone = new System.Windows.Forms.TextBox();
            this.txtSonucSoyad = new System.Windows.Forms.TextBox();
            this.txtSonucAd = new System.Windows.Forms.TextBox();
            this.btnAdaGore = new System.Windows.Forms.Button();
            this.btnAboneGore = new System.Windows.Forms.Button();
            this.btnSoyadaGore = new System.Windows.Forms.Button();
            this.btnAdreseGore = new System.Windows.Forms.Button();
            this.btnAdSoyadaGore = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupArama = new System.Windows.Forms.GroupBox();
            this.groupAbone = new System.Windows.Forms.GroupBox();
            this.txtDergiNo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGazteAdi = new System.Windows.Forms.Label();
            this.txtGazeteNo = new System.Windows.Forms.NumericUpDown();
            this.btnAboneBitir = new System.Windows.Forms.Button();
            this.btnAboneBasla = new System.Windows.Forms.Button();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblAboneNo = new System.Windows.Forms.Label();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtAboneNo = new System.Windows.Forms.NumericUpDown();
            this.groupArama.SuspendLayout();
            this.groupAbone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDergiNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGazeteNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAboneNo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeri.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Image = global::GazeteveDergiProje.Properties.Resources.cikisi;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(50, 712);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(136, 127);
            this.btnGeri.TabIndex = 21;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // listAbone
            // 
            this.listAbone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAbonelikNo,
            this.chAboneTarih,
            this.chAboneTarih2});
            this.listAbone.HideSelection = false;
            this.listAbone.Location = new System.Drawing.Point(52, 81);
            this.listAbone.Name = "listAbone";
            this.listAbone.Size = new System.Drawing.Size(710, 385);
            this.listAbone.TabIndex = 22;
            this.listAbone.UseCompatibleStateImageBehavior = false;
            this.listAbone.View = System.Windows.Forms.View.Details;
            // 
            // chAbonelikNo
            // 
            this.chAbonelikNo.Text = "Abonelik Numarası";
            this.chAbonelikNo.Width = 206;
            // 
            // chAboneTarih
            // 
            this.chAboneTarih.Text = "Abonelik Başlangıç Tarihi";
            this.chAboneTarih.Width = 265;
            // 
            // chAboneTarih2
            // 
            this.chAboneTarih2.Text = "Abonelik Bitiş Tarihi";
            this.chAboneTarih2.Width = 234;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.Location = new System.Drawing.Point(11, 57);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(160, 33);
            this.txtAd.TabIndex = 23;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.Location = new System.Drawing.Point(190, 57);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(160, 33);
            this.txtSoyad.TabIndex = 24;
            // 
            // txtAbone
            // 
            this.txtAbone.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbone.Location = new System.Drawing.Point(369, 57);
            this.txtAbone.Name = "txtAbone";
            this.txtAbone.Size = new System.Drawing.Size(160, 33);
            this.txtAbone.TabIndex = 25;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(548, 57);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(160, 33);
            this.txtAdres.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Abone No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Adres :";
            // 
            // txtSonucAdres
            // 
            this.txtSonucAdres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonucAdres.Location = new System.Drawing.Point(548, 341);
            this.txtSonucAdres.Name = "txtSonucAdres";
            this.txtSonucAdres.Size = new System.Drawing.Size(160, 33);
            this.txtSonucAdres.TabIndex = 34;
            // 
            // txtSonucAbone
            // 
            this.txtSonucAbone.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonucAbone.Location = new System.Drawing.Point(369, 341);
            this.txtSonucAbone.Name = "txtSonucAbone";
            this.txtSonucAbone.Size = new System.Drawing.Size(160, 33);
            this.txtSonucAbone.TabIndex = 33;
            // 
            // txtSonucSoyad
            // 
            this.txtSonucSoyad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonucSoyad.Location = new System.Drawing.Point(190, 341);
            this.txtSonucSoyad.Name = "txtSonucSoyad";
            this.txtSonucSoyad.Size = new System.Drawing.Size(160, 33);
            this.txtSonucSoyad.TabIndex = 32;
            // 
            // txtSonucAd
            // 
            this.txtSonucAd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonucAd.Location = new System.Drawing.Point(11, 341);
            this.txtSonucAd.Name = "txtSonucAd";
            this.txtSonucAd.Size = new System.Drawing.Size(160, 33);
            this.txtSonucAd.TabIndex = 31;
            // 
            // btnAdaGore
            // 
            this.btnAdaGore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaGore.Location = new System.Drawing.Point(11, 99);
            this.btnAdaGore.Name = "btnAdaGore";
            this.btnAdaGore.Size = new System.Drawing.Size(160, 96);
            this.btnAdaGore.TabIndex = 35;
            this.btnAdaGore.Text = "Ada Göre";
            this.btnAdaGore.UseVisualStyleBackColor = true;
            this.btnAdaGore.Click += new System.EventHandler(this.btnAdaGore_Click);
            // 
            // btnAboneGore
            // 
            this.btnAboneGore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboneGore.Location = new System.Drawing.Point(369, 99);
            this.btnAboneGore.Name = "btnAboneGore";
            this.btnAboneGore.Size = new System.Drawing.Size(339, 96);
            this.btnAboneGore.TabIndex = 36;
            this.btnAboneGore.Text = "Abone Numarasına Göre";
            this.btnAboneGore.UseVisualStyleBackColor = true;
            this.btnAboneGore.Click += new System.EventHandler(this.btnAboneGore_Click);
            // 
            // btnSoyadaGore
            // 
            this.btnSoyadaGore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoyadaGore.Location = new System.Drawing.Point(190, 99);
            this.btnSoyadaGore.Name = "btnSoyadaGore";
            this.btnSoyadaGore.Size = new System.Drawing.Size(160, 96);
            this.btnSoyadaGore.TabIndex = 37;
            this.btnSoyadaGore.Text = "Soyada Göre";
            this.btnSoyadaGore.UseVisualStyleBackColor = true;
            this.btnSoyadaGore.Click += new System.EventHandler(this.btnSoyadaGore_Click);
            // 
            // btnAdreseGore
            // 
            this.btnAdreseGore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdreseGore.Location = new System.Drawing.Point(369, 201);
            this.btnAdreseGore.Name = "btnAdreseGore";
            this.btnAdreseGore.Size = new System.Drawing.Size(339, 104);
            this.btnAdreseGore.TabIndex = 38;
            this.btnAdreseGore.Text = "Adrese Göre";
            this.btnAdreseGore.UseVisualStyleBackColor = true;
            this.btnAdreseGore.Click += new System.EventHandler(this.btnAdreseGore_Click);
            // 
            // btnAdSoyadaGore
            // 
            this.btnAdSoyadaGore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdSoyadaGore.Location = new System.Drawing.Point(11, 201);
            this.btnAdSoyadaGore.Name = "btnAdSoyadaGore";
            this.btnAdSoyadaGore.Size = new System.Drawing.Size(339, 104);
            this.btnAdSoyadaGore.TabIndex = 39;
            this.btnAdSoyadaGore.Text = "Ad ve Soyada Göre";
            this.btnAdSoyadaGore.UseVisualStyleBackColor = true;
            this.btnAdSoyadaGore.Click += new System.EventHandler(this.btnAdSoyadaGore_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Abone No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Soyad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Ad :";
            // 
            // groupArama
            // 
            this.groupArama.Controls.Add(this.label1);
            this.groupArama.Controls.Add(this.label5);
            this.groupArama.Controls.Add(this.txtAd);
            this.groupArama.Controls.Add(this.label6);
            this.groupArama.Controls.Add(this.txtSoyad);
            this.groupArama.Controls.Add(this.label7);
            this.groupArama.Controls.Add(this.txtAbone);
            this.groupArama.Controls.Add(this.label8);
            this.groupArama.Controls.Add(this.txtAdres);
            this.groupArama.Controls.Add(this.btnAdSoyadaGore);
            this.groupArama.Controls.Add(this.label2);
            this.groupArama.Controls.Add(this.btnAdreseGore);
            this.groupArama.Controls.Add(this.label3);
            this.groupArama.Controls.Add(this.btnSoyadaGore);
            this.groupArama.Controls.Add(this.label4);
            this.groupArama.Controls.Add(this.btnAboneGore);
            this.groupArama.Controls.Add(this.txtSonucAd);
            this.groupArama.Controls.Add(this.btnAdaGore);
            this.groupArama.Controls.Add(this.txtSonucSoyad);
            this.groupArama.Controls.Add(this.txtSonucAdres);
            this.groupArama.Controls.Add(this.txtSonucAbone);
            this.groupArama.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupArama.Location = new System.Drawing.Point(787, 68);
            this.groupArama.Name = "groupArama";
            this.groupArama.Size = new System.Drawing.Size(721, 398);
            this.groupArama.TabIndex = 44;
            this.groupArama.TabStop = false;
            this.groupArama.Text = "Abone Arama";
            // 
            // groupAbone
            // 
            this.groupAbone.Controls.Add(this.txtDergiNo);
            this.groupAbone.Controls.Add(this.label9);
            this.groupAbone.Controls.Add(this.lblGazteAdi);
            this.groupAbone.Controls.Add(this.txtGazeteNo);
            this.groupAbone.Controls.Add(this.btnAboneBitir);
            this.groupAbone.Controls.Add(this.btnAboneBasla);
            this.groupAbone.Controls.Add(this.lblBitis);
            this.groupAbone.Controls.Add(this.lblBaslangic);
            this.groupAbone.Controls.Add(this.lblAboneNo);
            this.groupAbone.Controls.Add(this.dateBitis);
            this.groupAbone.Controls.Add(this.dateBaslangic);
            this.groupAbone.Controls.Add(this.txtAboneNo);
            this.groupAbone.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAbone.Location = new System.Drawing.Point(52, 472);
            this.groupAbone.Name = "groupAbone";
            this.groupAbone.Size = new System.Drawing.Size(1456, 234);
            this.groupAbone.TabIndex = 45;
            this.groupAbone.TabStop = false;
            this.groupAbone.Text = "Abonelik İşlemleri";
            // 
            // txtDergiNo
            // 
            this.txtDergiNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDergiNo.Location = new System.Drawing.Point(1104, 80);
            this.txtDergiNo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtDergiNo.Name = "txtDergiNo";
            this.txtDergiNo.Size = new System.Drawing.Size(339, 33);
            this.txtDergiNo.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1099, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Dergi No :";
            // 
            // lblGazteAdi
            // 
            this.lblGazteAdi.AutoSize = true;
            this.lblGazteAdi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGazteAdi.Location = new System.Drawing.Point(731, 54);
            this.lblGazteAdi.Name = "lblGazteAdi";
            this.lblGazteAdi.Size = new System.Drawing.Size(133, 25);
            this.lblGazteAdi.TabIndex = 44;
            this.lblGazteAdi.Text = "Gazete No :";
            // 
            // txtGazeteNo
            // 
            this.txtGazeteNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGazeteNo.Location = new System.Drawing.Point(735, 80);
            this.txtGazeteNo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtGazeteNo.Name = "txtGazeteNo";
            this.txtGazeteNo.Size = new System.Drawing.Size(349, 33);
            this.txtGazeteNo.TabIndex = 51;
            // 
            // btnAboneBitir
            // 
            this.btnAboneBitir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboneBitir.Location = new System.Drawing.Point(1104, 120);
            this.btnAboneBitir.Name = "btnAboneBitir";
            this.btnAboneBitir.Size = new System.Drawing.Size(339, 97);
            this.btnAboneBitir.TabIndex = 47;
            this.btnAboneBitir.Text = "Abonelik Bitir";
            this.btnAboneBitir.UseVisualStyleBackColor = true;
            this.btnAboneBitir.Click += new System.EventHandler(this.btnAboneBitir_Click);
            // 
            // btnAboneBasla
            // 
            this.btnAboneBasla.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboneBasla.Location = new System.Drawing.Point(735, 120);
            this.btnAboneBasla.Name = "btnAboneBasla";
            this.btnAboneBasla.Size = new System.Drawing.Size(350, 97);
            this.btnAboneBasla.TabIndex = 44;
            this.btnAboneBasla.Text = "Abonelik Başlat";
            this.btnAboneBasla.UseVisualStyleBackColor = true;
            this.btnAboneBasla.Click += new System.EventHandler(this.btnAboneBasla_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitis.Location = new System.Drawing.Point(421, 53);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(120, 25);
            this.lblBitis.TabIndex = 46;
            this.lblBitis.Text = "Bitiş Tarihi :";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslangic.Location = new System.Drawing.Point(149, 53);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(182, 25);
            this.lblBaslangic.TabIndex = 45;
            this.lblBaslangic.Text = "Başlangıç Tarihi :";
            // 
            // lblAboneNo
            // 
            this.lblAboneNo.AutoSize = true;
            this.lblAboneNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboneNo.Location = new System.Drawing.Point(6, 53);
            this.lblAboneNo.Name = "lblAboneNo";
            this.lblAboneNo.Size = new System.Drawing.Size(128, 25);
            this.lblAboneNo.TabIndex = 44;
            this.lblAboneNo.Text = "Abone No :";
            // 
            // dateBitis
            // 
            this.dateBitis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBitis.Location = new System.Drawing.Point(444, 80);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(266, 33);
            this.dateBitis.TabIndex = 2;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBaslangic.Location = new System.Drawing.Point(154, 81);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(266, 33);
            this.dateBaslangic.TabIndex = 1;
            // 
            // txtAboneNo
            // 
            this.txtAboneNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAboneNo.Location = new System.Drawing.Point(11, 81);
            this.txtAboneNo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtAboneNo.Name = "txtAboneNo";
            this.txtAboneNo.Size = new System.Drawing.Size(123, 33);
            this.txtAboneNo.TabIndex = 0;
            // 
            // frmAbonelik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 853);
            this.Controls.Add(this.groupAbone);
            this.Controls.Add(this.groupArama);
            this.Controls.Add(this.listAbone);
            this.Controls.Add(this.btnGeri);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAbonelik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbonelik";
            this.Load += new System.EventHandler(this.frmAbonelik_Load);
            this.groupArama.ResumeLayout(false);
            this.groupArama.PerformLayout();
            this.groupAbone.ResumeLayout(false);
            this.groupAbone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDergiNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGazeteNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAboneNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView listAbone;
        private System.Windows.Forms.ColumnHeader chAbonelikNo;
        private System.Windows.Forms.ColumnHeader chAboneTarih;
        private System.Windows.Forms.ColumnHeader chAboneTarih2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAbone;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSonucAdres;
        private System.Windows.Forms.TextBox txtSonucAbone;
        private System.Windows.Forms.TextBox txtSonucSoyad;
        private System.Windows.Forms.TextBox txtSonucAd;
        private System.Windows.Forms.Button btnAdaGore;
        private System.Windows.Forms.Button btnAboneGore;
        private System.Windows.Forms.Button btnSoyadaGore;
        private System.Windows.Forms.Button btnAdreseGore;
        private System.Windows.Forms.Button btnAdSoyadaGore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupArama;
        private System.Windows.Forms.GroupBox groupAbone;
        private System.Windows.Forms.Button btnAboneBitir;
        private System.Windows.Forms.Button btnAboneBasla;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblAboneNo;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.NumericUpDown txtAboneNo;
        private System.Windows.Forms.NumericUpDown txtDergiNo;
        private System.Windows.Forms.NumericUpDown txtGazeteNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGazteAdi;
    }
}