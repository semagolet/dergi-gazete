
namespace GazeteveDergiProje
{
    partial class frmMusteriler
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
            this.listMusteriler = new System.Windows.Forms.ListView();
            this.chMusteriAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMusteriSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMusteriTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMusteriEposta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMusteriAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAboneNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtAdresi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAboneNo = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupMusteriEkle = new System.Windows.Forms.GroupBox();
            this.groupMusteriSil = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEpostaSil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtAboneNo)).BeginInit();
            this.groupMusteriEkle.SuspendLayout();
            this.groupMusteriSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeri.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Image = global::GazeteveDergiProje.Properties.Resources.cikisi;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(41, 714);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(136, 127);
            this.btnGeri.TabIndex = 21;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // listMusteriler
            // 
            this.listMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMusteriAd,
            this.chMusteriSoyadi,
            this.chMusteriTel,
            this.chMusteriEposta,
            this.chMusteriAdres,
            this.chAboneNo});
            this.listMusteriler.HideSelection = false;
            this.listMusteriler.Location = new System.Drawing.Point(41, 34);
            this.listMusteriler.Name = "listMusteriler";
            this.listMusteriler.Size = new System.Drawing.Size(1441, 271);
            this.listMusteriler.TabIndex = 22;
            this.listMusteriler.UseCompatibleStateImageBehavior = false;
            this.listMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // chMusteriAd
            // 
            this.chMusteriAd.Text = "Adı";
            this.chMusteriAd.Width = 136;
            // 
            // chMusteriSoyadi
            // 
            this.chMusteriSoyadi.Text = "Soyadı";
            this.chMusteriSoyadi.Width = 194;
            // 
            // chMusteriTel
            // 
            this.chMusteriTel.Text = "Telefon Numarası";
            this.chMusteriTel.Width = 200;
            // 
            // chMusteriEposta
            // 
            this.chMusteriEposta.Text = "Eposta Adresi";
            this.chMusteriEposta.Width = 320;
            // 
            // chMusteriAdres
            // 
            this.chMusteriAdres.Text = "Adresi";
            this.chMusteriAdres.Width = 350;
            // 
            // chAboneNo
            // 
            this.chAboneNo.Text = "Abonelik Numarası";
            this.chAboneNo.Width = 212;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNo.Location = new System.Drawing.Point(446, 91);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(247, 33);
            this.txtTelNo.TabIndex = 25;
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdi.Location = new System.Drawing.Point(11, 91);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(186, 33);
            this.txtAdi.TabIndex = 26;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyadi.Location = new System.Drawing.Point(203, 91);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(237, 33);
            this.txtSoyadi.TabIndex = 27;
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEposta.Location = new System.Drawing.Point(699, 91);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(247, 33);
            this.txtEposta.TabIndex = 28;
            // 
            // txtAdresi
            // 
            this.txtAdresi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresi.Location = new System.Drawing.Point(952, 91);
            this.txtAdresi.Name = "txtAdresi";
            this.txtAdresi.Size = new System.Drawing.Size(247, 33);
            this.txtAdresi.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Telefon Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(694, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Eposta Adresi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(947, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Adresi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1200, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Abonelik Numarası :";
            // 
            // txtAboneNo
            // 
            this.txtAboneNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAboneNo.Location = new System.Drawing.Point(1205, 91);
            this.txtAboneNo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtAboneNo.Name = "txtAboneNo";
            this.txtAboneNo.Size = new System.Drawing.Size(230, 33);
            this.txtAboneNo.TabIndex = 37;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Image = global::GazeteveDergiProje.Properties.Resources.ekle;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(1205, 152);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(230, 123);
            this.btnEkle.TabIndex = 38;
            this.btnEkle.Text = "Müşteri Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Image = global::GazeteveDergiProje.Properties.Resources.sil;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(261, 102);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(230, 123);
            this.btnSil.TabIndex = 39;
            this.btnSil.Text = "Müşteri Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupMusteriEkle
            // 
            this.groupMusteriEkle.Controls.Add(this.btnEkle);
            this.groupMusteriEkle.Controls.Add(this.label1);
            this.groupMusteriEkle.Controls.Add(this.txtTelNo);
            this.groupMusteriEkle.Controls.Add(this.txtAdi);
            this.groupMusteriEkle.Controls.Add(this.txtAboneNo);
            this.groupMusteriEkle.Controls.Add(this.txtSoyadi);
            this.groupMusteriEkle.Controls.Add(this.label6);
            this.groupMusteriEkle.Controls.Add(this.txtEposta);
            this.groupMusteriEkle.Controls.Add(this.label5);
            this.groupMusteriEkle.Controls.Add(this.txtAdresi);
            this.groupMusteriEkle.Controls.Add(this.label4);
            this.groupMusteriEkle.Controls.Add(this.label2);
            this.groupMusteriEkle.Controls.Add(this.label3);
            this.groupMusteriEkle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMusteriEkle.Location = new System.Drawing.Point(41, 311);
            this.groupMusteriEkle.Name = "groupMusteriEkle";
            this.groupMusteriEkle.Size = new System.Drawing.Size(1441, 293);
            this.groupMusteriEkle.TabIndex = 40;
            this.groupMusteriEkle.TabStop = false;
            this.groupMusteriEkle.Text = "Müşteri Ekle";
            // 
            // groupMusteriSil
            // 
            this.groupMusteriSil.Controls.Add(this.label7);
            this.groupMusteriSil.Controls.Add(this.txtEpostaSil);
            this.groupMusteriSil.Controls.Add(this.btnSil);
            this.groupMusteriSil.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMusteriSil.Location = new System.Drawing.Point(985, 610);
            this.groupMusteriSil.Name = "groupMusteriSil";
            this.groupMusteriSil.Size = new System.Drawing.Size(497, 231);
            this.groupMusteriSil.TabIndex = 41;
            this.groupMusteriSil.TabStop = false;
            this.groupMusteriSil.Text = "Müşteri Sil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Müşteri Eposta Adresi :";
            // 
            // txtEpostaSil
            // 
            this.txtEpostaSil.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpostaSil.Location = new System.Drawing.Point(11, 65);
            this.txtEpostaSil.Name = "txtEpostaSil";
            this.txtEpostaSil.Size = new System.Drawing.Size(480, 33);
            this.txtEpostaSil.TabIndex = 38;
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 853);
            this.Controls.Add(this.groupMusteriSil);
            this.Controls.Add(this.groupMusteriEkle);
            this.Controls.Add(this.listMusteriler);
            this.Controls.Add(this.btnGeri);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAboneNo)).EndInit();
            this.groupMusteriEkle.ResumeLayout(false);
            this.groupMusteriEkle.PerformLayout();
            this.groupMusteriSil.ResumeLayout(false);
            this.groupMusteriSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView listMusteriler;
        private System.Windows.Forms.ColumnHeader chMusteriAd;
        private System.Windows.Forms.ColumnHeader chMusteriTel;
        private System.Windows.Forms.ColumnHeader chMusteriEposta;
        private System.Windows.Forms.ColumnHeader chMusteriAdres;
        private System.Windows.Forms.ColumnHeader chAboneNo;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtAdresi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtAboneNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupMusteriEkle;
        private System.Windows.Forms.GroupBox groupMusteriSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEpostaSil;
        private System.Windows.Forms.ColumnHeader chMusteriSoyadi;
    }
}