using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {

    public partial class PanelQuery : UserControl {

        private ConcurrentDictionary<string, string> seqsGhc = new ConcurrentDictionary<string, string>();
        private ConcurrentDictionary<string, string> seqsGhc5 = new ConcurrentDictionary<string, string>();
        private ConcurrentDictionary<string, ConcurrentDictionary<string, string>> seqsMatch = new ConcurrentDictionary<string, ConcurrentDictionary<string, string>>();
        private DataTable dt = new DataTable();
        private Dictionary<Control, string> controlsLabels = new Dictionary<Control, string>();
        private bool running = false;

        public PanelQuery() {
            InitializeComponent();
        }

        public void Clear() {
            seqsGhc.Clear();
            seqsGhc5.Clear();
            seqsMatch.Clear();
            dt.Clear();
            running = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e) {
            RefreshRefSeqs(false);
        }

        private void RefreshRefSeqs(bool rebuild) {
            GC.TryStartNoGCRegion(1024 * 1024 * 243, true);
            textBoxLog.Clear();
            foreach (DataRow sel in Statics.Data.DatabaseFilterSelection.Rows) {
                var acession = sel.ItemArray[idxs.acession].ToString();
                var asm = sel.ItemArray[idxs.asm].ToString();
                var u = acession + "@" + asm;

                textBoxLog.Text += u + Environment.NewLine;
                var fnameFna = Path.Combine(Statics.Paths.Refs, u, "genomic.fna");
                var fnameGhc = Path.Combine(Statics.Paths.Refs, u, "genomic.fna.ghc");
                var fnameGhc5 = Path.Combine(Statics.Paths.Refs, u, "genomic.fna.ghc5");
                if (File.Exists(fnameGhc) && !rebuild) {
                    seqsGhc[u] = File.ReadAllText(fnameGhc);
                }
                if (File.Exists(fnameFna) && (!File.Exists(fnameGhc) || rebuild)) {
                    textBoxLog.Text += "Reading " + fnameFna + Environment.NewLine;
                    Application.DoEvents();

                    string seq = String.Join("", File.ReadAllLines(fnameFna).Skip(1).ToArray());

                    textBoxLog.Text += "GhcIndex..." + Environment.NewLine;
                    Application.DoEvents();

                    File.WriteAllText(fnameGhc, Statics.GhcIndex(seq, "G"));
                }

                //if (File.Exists(fnameGhc) && (!File.Exists(fnameGhc5) || rebuild)) {
                //    textBoxLog.Text += "Building GHC5 -> " + fnameGhc5 + Environment.NewLine;
                //    Application.DoEvents();
                //    File.WriteAllText(fnameGhc5, Statics.GhcIndex5(File.ReadAllText(fnameGhc)));
                //}

                if (!File.Exists(fnameFna)) {
                    textBoxLog.Text += Environment.NewLine + "File " + fnameFna + " not found!";
                }

                if (File.Exists(fnameGhc)) {
                    seqsGhc[u] = File.ReadAllText(fnameGhc);
                }

                if (File.Exists(fnameGhc5)) {
                    seqsGhc5[u] = File.ReadAllText(fnameGhc5);
                }
            }
            textBoxLog.Text += Environment.NewLine + "DONE!";
            try {
                GC.EndNoGCRegion();
            } catch (Exception) {
            }
        }

        private void ResetDataGridViewResult() {
            dataGridViewResult.DataSource = dt;
            dt.DefaultView.Sort = String.Empty;
            dt.Rows.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("ACCESSION");
            dt.Columns.Add("ORGANISM");
            dt.Columns.Add("MATCHES", typeof(int));
            dt.Columns.Add("STATUS");
            //dt.Columns.Add("FIRST INDEX");
        }

        private void DisableAllButtonsButOne(Control theOne) {
            running = true;
            pictureBoxProcessing.Visible = true;
            foreach (Control c in ParentForm.Controls["panel1"].Controls) {
                if (c == theOne) continue;
                if (c is Button) {
                    ((Button)c).Enabled = false;
                }
            }
            foreach (Control c in Controls) {
                if (c == theOne) continue;
                if (c is Button) {
                    ((Button)c).Enabled = false;
                }
            }
        }

        private void EnableAllButtons() {
            running = false;
            pictureBoxProcessing.Visible = false;
            ParentForm.Enabled = true;
            foreach (Control c in ParentForm.Controls["panel1"].Controls) {
                if (c is Button) {
                    ((Button)c).Enabled = true;
                }
            }
            foreach (Control c in Controls) {
                if (c is Button) {
                    ((Button)c).Enabled = true;
                }
            }
            foreach (var c in controlsLabels) {
                c.Key.Text = c.Value;
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e) {
            if (running) {
                buttonQuery.Text = "  WAIT..";
                buttonQuery.Enabled = false;
                running = false;
                return;
            }
            DisableAllButtonsButOne(buttonQuery);

            if (seqsGhc.Count == 0) {
                buttonRefresh_Click(null, null);
            }

            buttonQuery.Text = "  STOP";
            seqsMatch.Clear();
            Application.DoEvents();
            ResetDataGridViewResult();
            textBoxLog.Clear();
            textBoxLog.AppendText(Environment.NewLine + "Total reads: " + Statics.Data.reads.Count().ToString("N0"));
            textBoxLog.AppendText(Environment.NewLine + "Total reads len: " + Statics.Data.reads.Select(x => x.Value.Length).Sum().ToString("N0"));
            textBoxLog.AppendText(Environment.NewLine + "Total refseqs: " + seqsGhc.Count().ToString("N0"));
            textBoxLog.AppendText(Environment.NewLine + "Total refseqs len: " + seqsGhc.Select(x => x.Value.Length).Sum().ToString("N0"));

            Task.Run(() => {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                foreach (var seq in seqsGhc) {
                    if (running == false) break;
                    var name = Statics.Data.DatabaseFilterSelection.AsEnumerable().Where(x => x.Field<string>("ASSEMBLY ACCESSION") == seq.Key.Split('@')[0]).Select(x => x.Field<string>("ORGANISM NAME")).FirstOrDefault();
                    if (name is null) name = "--";
                    Invoke((MethodInvoker)delegate {
                        dt.Rows.Add(seq.Key, name, "0", "COMPUTING");
                        Application.DoEvents();
                    });
                    var l = Statics.Data.reads.AsParallel().Select(x => x).Where(x => seq.Value.Contains(x.Value)).Select(x => x).ToArray();
                    if (!seqsMatch.ContainsKey(name)) {
                        seqsMatch[name] = new ConcurrentDictionary<string, string>();
                    }
                    if (l.Count() > 0) {
                        Invoke((MethodInvoker)delegate {
                            for (int i = 0; i < dt.Rows.Count; i++) {
                                if (dt.Rows[i][0].ToString() == seq.Key) {
                                    dt.Rows[i][2] = l.Count();
                                    dt.Rows[i][3] = "DONE";
                                }
                            }
                            Application.DoEvents();
                        });
                        foreach (var kv in l) {
                            seqsMatch[name][kv.Key] = kv.Value;
                        }
                    } else {
                        Invoke((MethodInvoker)delegate {
                            for (int i = 0; i < dt.Rows.Count; i++) {
                                if (dt.Rows[i][0].ToString() == seq.Key) {
                                    dt.Rows[i][2] = 0;
                                    dt.Rows[i][3] = "DONE";
                                }
                            }
                            Application.DoEvents();
                        });
                    }
                }
                sw.Stop();
                Invoke((MethodInvoker)delegate {
                    textBoxLog.AppendText(Environment.NewLine + "=== DONE ===");
                    textBoxLog.AppendText(Environment.NewLine + "Elapsed: " + sw.Elapsed.ToString());
                    Application.DoEvents();
                    EnableAllButtons();
                });
            });
        }

        private void buttonRebuild_Click(object sender, EventArgs e) {
            RefreshRefSeqs(true);
        }

        private void buttonQuery5_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            seqsMatch.Clear();
            Application.DoEvents();
            ResetDataGridViewResult();
            textBoxLog.Clear();
            textBoxLog.AppendText(Environment.NewLine + "Total reads: " + Statics.Data.reads5.Count().ToString("N0"));
            textBoxLog.AppendText(Environment.NewLine + "Total reads len: " + Statics.Data.reads5.Select(x => x.Value.Length).Sum().ToString("N0"));
            textBoxLog.AppendText(Environment.NewLine + "Total refseqs: " + seqsGhc.Count().ToString("N0"));
            textBoxLog.AppendText(Environment.NewLine + "Total refseqs len: " + seqsGhc.Select(x => x.Value.Length).Sum().ToString("N0"));
            foreach (var seq in seqsGhc) {
                var l = Statics.Data.reads5.AsParallel().Select(x => x).Where(x => seq.Value.Contains(x.Value)).Select(x => x).ToArray();
                var name = Statics.Data.DatabaseFilterSelection.AsEnumerable().Where(x => x.Field<string>("ASSEMBLY ACCESSION") == seq.Key.Split('@')[0]).Select(x => x.Field<string>("ORGANISM NAME")).FirstOrDefault();
                if (name == null) {
                    continue;
                }
                if (!seqsMatch.ContainsKey(name)) {
                    seqsMatch[name] = new ConcurrentDictionary<string, string>();
                }
                if (l.Count() > 0) {
                    dt.Rows.Add(seq.Key, name, l.Count());
                    Application.DoEvents();
                    foreach (var kv in l) {
                        seqsMatch[name][kv.Key] = kv.Value;
                    }
                } else {
                    dt.Rows.Add(seq.Key, name, 0);
                }
                Application.DoEvents();
            }
            textBoxLog.AppendText(Environment.NewLine + "=== DONE ===");
            Cursor = Cursors.Default;
        }

        private void dataGridViewResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (((int)dataGridViewResult.Rows[e.RowIndex].Cells["MATCHES"].Value) > 0) {
                dataGridViewResult.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
            } else {
                dataGridViewResult.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
            }
        }

        private void dataGridViewResult_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            var accession = dataGridViewResult.Rows[e.RowIndex].Cells[0].Value.ToString();
            var name = dataGridViewResult.Rows[e.RowIndex].Cells[1].Value.ToString();
            var f = new FormTextBox();
            f.textBoxText.Text = "> " + name + ":" + accession + Environment.NewLine;
            f.textBoxText.Text += string.Join(Environment.NewLine, seqsMatch[name]
                .Select(x => x.Key + "  " + x.Value)
                .OrderBy(x => x)
                .ToArray());
            f.Show();
            f.BringToFront();
        }

        private void PanelQuery_Load(object sender, EventArgs e) {
            controlsLabels[buttonQuery] = buttonQuery.Text;
            controlsLabels[buttonQuery5] = buttonQuery5.Text;
        }
    }
}

