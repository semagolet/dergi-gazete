using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace GazeteveDergiProje
{
    public partial class frmImport : Form
    {

        DataTableCollection tableCollection;

        public frmImport()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmImportExport ie = new frmImportExport();
            ie.Show();
            this.Close();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abonelikProjeDataSet1.Abone' table. You can move, or remove it, as needed.
            this.aboneTableAdapter1.Fill(this.abonelikProjeDataSet1.Abone);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDosyaAdi.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cmbImport.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cmbImport.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void cmbImport_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cmbImport.SelectedItem.ToString()];
            if (dt != null)
            {
                List<Abone> aboneler = new List<Abone>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Abone abone = new Abone();
                    abone.AboneID = dt.Rows[i]["AboneID"].ToString();
                    abone.AboneBas = dt.Rows[i]["AboneBas"].ToString();
                    abone.AboneBit = dt.Rows[i]["AboneBit"].ToString();
                    abone.AboneGazete = dt.Rows[i]["AboneGazete"].ToString();
                    abone.AboneDergi = dt.Rows[i]["AboneDergi"].ToString();
                    aboneler.Add(abone);
                }
                aboneBindingSource.DataSource = aboneler;
            }
        }

        private void btnImportEtme_Click(object sender, EventArgs e)
        {
            try
            {
                DapperPlusManager.Entity<Abone>().Table("Aboneler");
                List<Abone> aboneler = aboneBindingSource.DataSource as List<Abone>;
                if (aboneler != null)
                {
                    using (IDbConnection db = new SqlConnection(Genel.conString))
                    {
                        db.BulkInsert(aboneler);
                    }
                }
                MessageBox.Show("İşlem tamamlandı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
