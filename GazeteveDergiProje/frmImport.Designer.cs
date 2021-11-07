
namespace GazeteveDergiProje
{
    partial class frmImport
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aboneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneBasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneBitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneGazeteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneDergiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aboneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.abonelikProjeDataSet = new GazeteveDergiProje.AbonelikProjeDataSet();
            this.aboneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aboneTableAdapter = new GazeteveDergiProje.AbonelikProjeDataSetTableAdapters.AboneTableAdapter();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbImport = new System.Windows.Forms.ComboBox();
            this.btnImportEtme = new System.Windows.Forms.Button();
            this.abonelikProjeDataSet1 = new GazeteveDergiProje.AbonelikProjeDataSet1();
            this.aboneBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aboneTableAdapter1 = new GazeteveDergiProje.AbonelikProjeDataSet1TableAdapters.AboneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource2)).BeginInit();
            this.SuspendLayout();
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
            this.btnGeri.TabIndex = 5;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aboneIDDataGridViewTextBoxColumn,
            this.aboneBasDataGridViewTextBoxColumn,
            this.aboneBitDataGridViewTextBoxColumn,
            this.aboneGazeteDataGridViewTextBoxColumn,
            this.aboneDergiDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.aboneBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(108, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 379);
            this.dataGridView1.TabIndex = 6;
            // 
            // aboneIDDataGridViewTextBoxColumn
            // 
            this.aboneIDDataGridViewTextBoxColumn.DataPropertyName = "AboneID";
            this.aboneIDDataGridViewTextBoxColumn.HeaderText = "AboneID";
            this.aboneIDDataGridViewTextBoxColumn.Name = "aboneIDDataGridViewTextBoxColumn";
            // 
            // aboneBasDataGridViewTextBoxColumn
            // 
            this.aboneBasDataGridViewTextBoxColumn.DataPropertyName = "AboneBas";
            this.aboneBasDataGridViewTextBoxColumn.HeaderText = "AboneBas";
            this.aboneBasDataGridViewTextBoxColumn.Name = "aboneBasDataGridViewTextBoxColumn";
            this.aboneBasDataGridViewTextBoxColumn.Width = 200;
            // 
            // aboneBitDataGridViewTextBoxColumn
            // 
            this.aboneBitDataGridViewTextBoxColumn.DataPropertyName = "AboneBit";
            this.aboneBitDataGridViewTextBoxColumn.HeaderText = "AboneBit";
            this.aboneBitDataGridViewTextBoxColumn.Name = "aboneBitDataGridViewTextBoxColumn";
            this.aboneBitDataGridViewTextBoxColumn.Width = 200;
            // 
            // aboneGazeteDataGridViewTextBoxColumn
            // 
            this.aboneGazeteDataGridViewTextBoxColumn.DataPropertyName = "AboneGazete";
            this.aboneGazeteDataGridViewTextBoxColumn.HeaderText = "AboneGazete";
            this.aboneGazeteDataGridViewTextBoxColumn.Name = "aboneGazeteDataGridViewTextBoxColumn";
            this.aboneGazeteDataGridViewTextBoxColumn.Width = 250;
            // 
            // aboneDergiDataGridViewTextBoxColumn
            // 
            this.aboneDergiDataGridViewTextBoxColumn.DataPropertyName = "AboneDergi";
            this.aboneDergiDataGridViewTextBoxColumn.HeaderText = "AboneDergi";
            this.aboneDergiDataGridViewTextBoxColumn.Name = "aboneDergiDataGridViewTextBoxColumn";
            this.aboneDergiDataGridViewTextBoxColumn.Width = 250;
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // aboneBindingSource1
            // 
            this.aboneBindingSource1.DataMember = "Abone";
            this.aboneBindingSource1.DataSource = this.abonelikProjeDataSet;
            // 
            // abonelikProjeDataSet
            // 
            this.abonelikProjeDataSet.DataSetName = "AbonelikProjeDataSet";
            this.abonelikProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aboneBindingSource
            // 
            this.aboneBindingSource.DataMember = "Abone";
            this.aboneBindingSource.DataSource = this.abonelikProjeDataSet;
            // 
            // aboneTableAdapter
            // 
            this.aboneTableAdapter.ClearBeforeFill = true;
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(242, 503);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(946, 33);
            this.txtDosyaAdi.TabIndex = 7;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(1194, 503);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(62, 33);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dosya Adı :";
            // 
            // cmbImport
            // 
            this.cmbImport.FormattingEnabled = true;
            this.cmbImport.Location = new System.Drawing.Point(242, 574);
            this.cmbImport.Name = "cmbImport";
            this.cmbImport.Size = new System.Drawing.Size(946, 32);
            this.cmbImport.TabIndex = 10;
            this.cmbImport.SelectedIndexChanged += new System.EventHandler(this.cmbImport_SelectedIndexChanged);
            // 
            // btnImportEtme
            // 
            this.btnImportEtme.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportEtme.Image = global::GazeteveDergiProje.Properties.Resources.import;
            this.btnImportEtme.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportEtme.Location = new System.Drawing.Point(1087, 675);
            this.btnImportEtme.Name = "btnImportEtme";
            this.btnImportEtme.Size = new System.Drawing.Size(277, 127);
            this.btnImportEtme.TabIndex = 11;
            this.btnImportEtme.Text = "Import Et";
            this.btnImportEtme.UseVisualStyleBackColor = true;
            this.btnImportEtme.Click += new System.EventHandler(this.btnImportEtme_Click);
            // 
            // abonelikProjeDataSet1
            // 
            this.abonelikProjeDataSet1.DataSetName = "AbonelikProjeDataSet1";
            this.abonelikProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aboneBindingSource2
            // 
            this.aboneBindingSource2.DataMember = "Abone";
            this.aboneBindingSource2.DataSource = this.abonelikProjeDataSet1;
            // 
            // aboneTableAdapter1
            // 
            this.aboneTableAdapter1.ClearBeforeFill = true;
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 814);
            this.Controls.Add(this.btnImportEtme);
            this.Controls.Add(this.cmbImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtDosyaAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.Load += new System.EventHandler(this.frmImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonelikProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AbonelikProjeDataSet abonelikProjeDataSet;
        private System.Windows.Forms.BindingSource aboneBindingSource;
        private AbonelikProjeDataSetTableAdapters.AboneTableAdapter aboneTableAdapter;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbImport;
        private System.Windows.Forms.Button btnImportEtme;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneBasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneBitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneGazeteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneDergiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource aboneBindingSource1;
        private AbonelikProjeDataSet1 abonelikProjeDataSet1;
        private System.Windows.Forms.BindingSource aboneBindingSource2;
        private AbonelikProjeDataSet1TableAdapters.AboneTableAdapter aboneTableAdapter1;
    }
}