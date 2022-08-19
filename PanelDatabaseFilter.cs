using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public struct idxs {
        public static int acession = 0;
        public static int asm = 15;
        public static int ftp = 19;
    }

    public partial class PanelDatabaseFilter : UserControl {

        private List<List<string>> lines = new List<List<string>>();
        private List<string> uniques = new List<string>();


        public PanelDatabaseFilter() {
            InitializeComponent();
            LoadSummary();
        }

        private void LoadSummary() {
            dataGridViewSelection.DataSource = Statics.Data.DatabaseFilterSelection;
            dataGridViewData.DataSource = Statics.Data.DatabaseFilterData;
            Statics.Data.DatabaseFilterData.TableName = "dataGridViewData";
            Statics.Data.DatabaseFilterSelection.TableName = "dataGridViewSelection";
            foreach (var line in File.ReadLines(Statics.Paths.RefsSummary)) {
                if (line.StartsWith("# assembly_accession")) {
                    foreach (var col in line.Split('\t')) {
                        var v = col.Replace("# ", "").ToUpper().Replace("_", " ");
                        if (!Statics.Data.DatabaseFilterData.Columns.Contains(v)) Statics.Data.DatabaseFilterData.Columns.Add(v);
                        if (!Statics.Data.DatabaseFilterSelection.Columns.Contains(v)) Statics.Data.DatabaseFilterSelection.Columns.Add(v);
                    }
                }
                if (line.StartsWith("#")) continue;
                var ll = line.Split('\t').ToList();
                for (int i = 0; i < ll.Count; i++) {
                    if (i != idxs.acession && i != idxs.asm && i != idxs.ftp) ll[i] = ll[i].ToUpper();
                }
                lines.Add(ll);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e) {
            var f = textBoxFilter.Text.Trim().ToUpper();
            if (f.Length < 4) {
                MessageBox.Show("Filter string is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var linesx = from x in lines.AsParallel() where x[0].Contains(f) || x[1].Contains(f) || x[5] == f || x[6] == f || x[7].Contains(f) select x;
            var taxid = new List<string>();
            Statics.Data.DatabaseFilterData.Rows.Clear();
            int cnt = 0;
            foreach (var line in linesx) {
                if (taxid.Contains(line[6]) && checkBoxUniqueTax.Checked) continue;
                taxid.Add(line[6]);
                Statics.Data.DatabaseFilterData.Rows.Add(line.ToArray());
                if (++cnt > 2000) break;
            }
        }

        private void dataGridViewData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            Statics.Data.DatabaseFilterSelection.Rows.Add(Statics.Data.DatabaseFilterData.Rows[e.RowIndex].ItemArray);
            SerializeDataGrid();
        }

        private void dataGridViewSelection_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            try {
                Statics.Data.DatabaseFilterSelection.Rows.RemoveAt(e.RowIndex);
            } catch (Exception) {

            }
            SerializeDataGrid();
        }

        private void PanelDatabaseFilter_Load(object sender, EventArgs e) {
            DeSerializeDataGrid();
            Statics.Controls.ButtonQuery.Enabled = true;
        }

        private void buttonDownload_Click(object sender, EventArgs e) {
            List<Statics.DownloadRefSeqData> urls = new List<Statics.DownloadRefSeqData>();
            foreach (DataGridViewRow sel in dataGridViewSelection.Rows) {
                var u = new Statics.DownloadRefSeqData();
                u.urlbase = sel.Cells[idxs.ftp].Value.ToString();
                u.accession = sel.Cells[idxs.acession].Value.ToString();
                u.asm = sel.Cells[idxs.asm].Value.ToString(); ;
                u.name = u.accession + "_" + u.asm + "_genomic.fna.gz";
                u.urlfile = u.urlbase + "/" + u.name;
                u.md5file = "md5checksums.txt";
                u.urlmd5 = u.urlbase + "/" + u.md5file;
                u.pathname = u.accession + "@" + u.asm;
                urls.Add(u);
            }
            var f = new FormDownloadRef();
            f.refSeqDatas = urls;
            f.ShowDialog();
        }

        private void buttonAddSelection_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow srow in dataGridViewData.SelectedRows) {
                Statics.Data.DatabaseFilterSelection.Rows.Add(Statics.Data.DatabaseFilterData.Rows[srow.Index].ItemArray);
            }
            SerializeDataGrid();
        }

        public void SerializeDataGrid() {
            if (Statics.Paths.CurrentSamplePath.Length < 2) {
                MessageBox.Show("Select project and sample first");
            }
            string filename = Path.Combine(Statics.Paths.CurrentSamplePath, "marshal.PanelDatabaseFilter.dataGridViewSelection.xml");
            Statics.Data.DatabaseFilterSelection.WriteXml(filename);
        }

        public void DeSerializeDataGrid() {
            if (Statics.Paths.CurrentSamplePath.Length < 2) {
                MessageBox.Show("Select project and sample first");
            }
            Statics.Data.DatabaseFilterSelection.Rows.Clear();
            string filename = Path.Combine(Statics.Paths.CurrentSamplePath, "marshal.PanelDatabaseFilter.dataGridViewSelection.xml");
            if (File.Exists(filename)) {
                try {
                    Statics.Data.DatabaseFilterSelection.ReadXml(filename);
                } catch (Exception) {

                }
            }
        }

        private void PanelDatabaseFilter_VisibleChanged(object sender, EventArgs e) {
            DeSerializeDataGrid();
            Statics.Controls.ButtonQuery.Enabled = true;
        }

        private void buttonUpdateDatabase_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            WebClient client = new WebClient();
            try {
                client.DownloadFile("ftp://ftp.ncbi.nlm.nih.gov/genomes/refseq/assembly_summary_refseq.txt", Statics.Paths.RefsSummary);
            } catch (Exception exc) {
                Cursor = Cursors.Default;
                MessageBox.Show("Error downloading summary: "+exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadSummary();
            MessageBox.Show("Summary updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cursor = Cursors.Default;
        }
    }
}

