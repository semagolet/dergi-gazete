
namespace GazeteveDergiProje
{
    partial class frmYedekYukle
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSunucuAdi = new System.Windows.Forms.Label();
            this.txtKayitYeri = new System.Windows.Forms.TextBox();
            this.txtSunucuAdi = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriYukle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(634, 262);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(43, 33);
            this.btnKayit.TabIndex = 17;
            this.btnKayit.Text = "...";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kayıt Yeri     :";
            // 
            // lblSunucuAdi
            // 
            this.lblSunucuAdi.AutoSize = true;
            this.lblSunucuAdi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunucuAdi.Location = new System.Drawing.Point(198, 165);
            this.lblSunucuAdi.Name = "lblSunucuAdi";
            this.lblSunucuAdi.Size = new System.Drawing.Size(141, 25);
            this.lblSunucuAdi.TabIndex = 15;
            this.lblSunucuAdi.Text = "Sunucu Adı :";
            // 
            // txtKayitYeri
            // 
            this.txtKayitYeri.Location = new System.Drawing.Point(345, 262);
            this.txtKayitYeri.Name = "txtKayitYeri";
            this.txtKayitYeri.Size = new System.Drawing.Size(283, 33);
            this.txtKayitYeri.TabIndex = 12;
            // 
            // txtSunucuAdi
            // 
            this.txtSunucuAdi.Location = new System.Drawing.Point(345, 162);
            this.txtSunucuAdi.Name = "txtSunucuAdi";
            this.txtSunucuAdi.Size = new System.Drawing.Size(283, 33);
            this.txtSunucuAdi.TabIndex = 11;
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCikis.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Image = global::GazeteveDergiProje.Properties.Resources.cikisi;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(12, 385);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(136, 127);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriYukle.Image = global::GazeteveDergiProje.Properties.Resources.import;
            this.btnGeriYukle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeriYukle.Location = new System.Drawing.Point(597, 385);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(222, 127);
            this.btnGeriYukle.TabIndex = 18;
            this.btnGeriYukle.Text = "       Yedeği Geri Yükle";
            this.btnGeriYukle.UseVisualStyleBackColor = true;
            this.btnGeriYukle.Click += new System.EventHandler(this.btnGeriYukle_Click);
            // 
            // frmYedekYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 524);
            this.Controls.Add(this.btnGeriYukle);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSunucuAdi);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtKayitYeri);
            this.Controls.Add(this.txtSunucuAdi);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmYedekYukle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYedekYukle";
            this.Load += new System.EventHandler(this.frmYedekYukle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSunucuAdi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtKayitYeri;
        private System.Windows.Forms.TextBox txtSunucuAdi;
        private System.Windows.Forms.Button btnGeriYukle;
    }
}