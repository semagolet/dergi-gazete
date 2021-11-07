
namespace GazeteveDergiProje
{
    partial class frmExport
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
            this.components = new System.ComponentModel.Container();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musTelNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musEMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musAboneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.abonelikProjeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonelikProjeDataSet = new GazeteveDergiProje.AbonelikProjeDataSet();
            this.btnGeri = new System.Windows.Forms.Button();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new GazeteveDergiProje.AbonelikProjeDataSetTableAdapters.MusteriTableAdapter();
            this.abonelikProjeDataSet2 = new GazeteveDergiProje.AbonelikProjeDataSet2();
            this.musteriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter1 = new GazeteveDergiProje.AbonelikProjeDataSet2TableAdapters.MusteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = global::GazeteveDergiProje.Properties.Resources.export;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.Location = new System.Drawing.Point(1087, 675);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(277, 127);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Export Et";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musIDDataGridViewTextBoxColumn,
            this.musAdDataGridViewTextBoxColumn,
            this.musSoyadDataGridViewTextBoxColumn,
            this.musTelNumDataGridViewTextBoxColumn,
            this.musEMailDataGridViewTextBoxColumn,
            this.musAdresDataGridViewTextBoxColumn,
            this.musAboneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1352, 573);
            this.dataGridView1.TabIndex = 13;
            // 
            // musIDDataGridViewTextBoxColumn
            // 
            this.musIDDataGridViewTextBoxColumn.DataPropertyName = "MusID";
            this.musIDDataGridViewTextBoxColumn.HeaderText = "MusID";
            this.musIDDataGridViewTextBoxColumn.Name = "musIDDataGridViewTextBoxColumn";
            this.musIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musAdDataGridViewTextBoxColumn
            // 
            this.musAdDataGridViewTextBoxColumn.DataPropertyName = "MusAd";
            this.musAdDataGridViewTextBoxColumn.HeaderText = "MusAd";
            this.musAdDataGridViewTextBoxColumn.Name = "musAdDataGridViewTextBoxColumn";
            this.musAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.musAdDataGridViewTextBoxColumn.Width = 250;
            // 
            // musSoyadDataGridViewTextBoxColumn
            // 
            this.musSoyadDataGridViewTextBoxColumn.DataPropertyName = "MusSoyad";
            this.musSoyadDataGridViewTextBoxColumn.HeaderText = "MusSoyad";
            this.musSoyadDataGridViewTextBoxColumn.Name = "musSoyadDataGridViewTextBoxColumn";
            this.musSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.musSoyadDataGridViewTextBoxColumn.Width = 250;
            // 
            // musTelNumDataGridViewTextBoxColumn
            // 
            this.musTelNumDataGridViewTextBoxColumn.DataPropertyName = "MusTelNum";
            this.musTelNumDataGridViewTextBoxColumn.HeaderText = "MusTelNum";
            this.musTelNumDataGridViewTextBoxColumn.Name = "musTelNumDataGridViewTextBoxColumn";
            this.musTelNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.musTelNumDataGridViewTextBoxColumn.Width = 250;
            // 
            // musEMailDataGridViewTextBoxColumn
            // 
            this.musEMailDataGridViewTextBoxColumn.DataPropertyName = "MusEMail";
            this.musEMailDataGridViewTextBoxColumn.HeaderText = "MusEMail";
            this.musEMailDataGridViewTextBoxColumn.Name = "musEMailDataGridViewTextBoxColumn";
            this.musEMailDataGridViewTextBoxColumn.ReadOnly = true;
            this.musEMailDataGridViewTextBoxColumn.Width = 250;
            // 
            // musAdresDataGridViewTextBoxColumn
            // 
            this.musAdresDataGridViewTextBoxColumn.DataPropertyName = "MusAdres";
            this.musAdresDataGridViewTextBoxColumn.HeaderText = "MusAdres";
            this.musAdresDataGridViewTextBoxColumn.Name = "musAdresDataGridViewTextBoxColumn";
            this.musAdresDataGridViewTextBoxColumn.ReadOnly = true;
            this.musAdresDataGridViewTextBoxColumn.Width = 250;
            // 
            // musAboneDataGridViewTextBoxColumn
            // 
            this.musAboneDataGridViewTextBoxColumn.DataPropertyName = "MusAbone";
            this.musAboneDataGridViewTextBoxColumn.HeaderText = "MusAbone";
            this.musAboneDataGridViewTextBoxColumn.Name = "musAboneDataGridViewTextBoxColumn";
            this.musAboneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriBindingSource1
            // 
            this.musteriBindingSource1.DataMember = "Musteri";
            this.musteriBindingSource1.DataSource = this.abonelikProjeDataSetBindingSource;
            // 
            // abonelikProjeDataSetBindingSource
            // 
            this.abonelikProjeDataSetBindingSource.DataSource = this.abonelikProjeDataSet;
            this.abonelikProjeDataSetBindingSource.Position = 0;
            // 
            // abonelikProjeDataSet
            // 
            this.abonelikProjeDataSet.DataSetName = "AbonelikProjeDataSet";
            this.abonelikProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeri.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Image = global::GazeteveDergiProje.Properties.Resources.cikisi;
            this.btnGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeri.Location = new System.Drawing.Point(12, 675);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(136, 127);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.abonelikProjeDataSetBindingSource;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // abonelikProjeDataSet2
            // 
            this.abonelikProjeDataSet2.DataSetName = "AbonelikProjeDataSet2";
            this.abonelikProjeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource2
            // 
            this.musteriBindingSource2.DataMember = "Musteri";
            this.musteriBindingSource2.DataSource = this.abonelikProjeDataSet2;
            // 
            // musteriTableAdapter1
            // 
            this.musteriTableAdapter1.ClearBeforeFill = true;
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 814);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export";
            this.Load += new System.EventHandler(this.frmExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGeri;
        private AbonelikProjeDataSet abonelikProjeDataSet;
        private System.Windows.Forms.BindingSource abonelikProjeDataSetBindingSource;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private AbonelikProjeDataSetTableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musTelNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musEMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musAboneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource musteriBindingSource1;
        private AbonelikProjeDataSet2 abonelikProjeDataSet2;
        private System.Windows.Forms.BindingSource musteriBindingSource2;
        private AbonelikProjeDataSet2TableAdapters.MusteriTableAdapter musteriTableAdapter1;
    }
}