
namespace GazeteveDergiProje
{
    partial class frmYedeklemeIslemleri
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
            this.btnGeriYukle = new System.Windows.Forms.Button();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Image = global::GazeteveDergiProje.Properties.Resources.geri32;
            this.btnGeri.Location = new System.Drawing.Point(13, 252);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(86, 86);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriYukle.Image = global::GazeteveDergiProje.Properties.Resources.import;
            this.btnGeriYukle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeriYukle.Location = new System.Drawing.Point(12, 68);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(242, 177);
            this.btnGeriYukle.TabIndex = 8;
            this.btnGeriYukle.Text = "       Yedeği Geri Yükle";
            this.btnGeriYukle.UseVisualStyleBackColor = true;
            this.btnGeriYukle.Click += new System.EventHandler(this.btnGeriYukle_Click);
            // 
            // btnYedekle
            // 
            this.btnYedekle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYedekle.Image = global::GazeteveDergiProje.Properties.Resources.export;
            this.btnYedekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYedekle.Location = new System.Drawing.Point(268, 68);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(242, 177);
            this.btnYedekle.TabIndex = 7;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // frmYedeklemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 350);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnGeriYukle);
            this.Controls.Add(this.btnYedekle);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmYedeklemeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekleme Islemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Button btnGeriYukle;
        private System.Windows.Forms.Button btnGeri;
    }
}