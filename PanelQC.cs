using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using Renci.SshNet;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime;
using MoreLinq;
using System.Collections.Concurrent;
using System.Threading;

namespace MetaGens {
    public partial class PanelQC : UserControl {

        public ConcurrentDictionary<string, string> reads = new ConcurrentDictionary<string, string>();
        private List<KeyValuePair<string, string>> readsSortedList = new List<KeyValuePair<string, string>>();
        private ConcurrentDictionary<string, string> readsRaw = new ConcurrentDictionary<string, string>();
        public string nl = Environment.NewLine;
        Int64 seqCount = 0;

        public PanelQC() {
            InitializeComponent();

            chartPhred.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Silver;
            chartPhred.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Silver;
            chartPerBase.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Silver;
            chartPerBase.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Silver;

        }

        public void Clear() {
            reads.Clear();
            readsSortedList.Clear();
            readsRaw.Clear();
            chartPerBase.Series[0].Points.Clear();
            chartPhred.Series[0].Points.Clear();
            imageBoxSpectrogram.Image = null;
            Statics.Data.Clear();
            textBoxInfo.Clear();
            seqCount = 0;
        }

        private void buttonReport_Click(object sender, EventArgs e) {
            //textBoxConsole.Clear();

            if (Statics.Paths.CurrentSamplePath == "") {
                MessageBox.Show("Please select the Project and the Sample first.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            RunQC();

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            //RunExternalExe("cmd.exe", $@"/c Data\Bin\Scripts\FastQC.bat {Statics.Paths.CurrentSamplePath}");
        }


        private void RunQC() {
            Cursor = Cursors.WaitCursor;
            reads.Clear();
            Statics.Data.Clear();
            readsSortedList.Clear();
            Statics.Controls.ButtonFilter.Enabled = true;

            //GCLatencyMode gcOldMode = GCSettings.LatencyMode;
            //GCSettings.LatencyMode = GCLatencyMode.SustainedLowLatency;

            try {
                GC.TryStartNoGCRegion(1024 * 1024 * 243, true);
            } catch (Exception) {
            }

            //textBoxConsole.Text += Environment.NewLine + "Processing file.. ";
            progressBar1.Value = 0;
            toolStripStatusLabel.Text = "READING FILE...";
            Application.DoEvents();

            int trimStart = trackBarTrimStart.Value;
            int trimEnd = trackBarTrimEnd.Value;



            string seqData = "";
            bool readSeq = false;
            bool readQual = false;

            long totalBytes = 0;
            string fname = Path.Combine(Statics.Paths.CurrentSamplePath, Statics.Paths.CurrentSampleName + ".fastq");

            if (!File.Exists(fname)) {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long fileLength = new System.IO.FileInfo(fname).Length;
            int minimumReadSize = trackBarMinimumReadSize.Value;
            int minimumPhred = trackBarMinimumPhred.Value;
            long limitSequences = 0;
            Int64 readsRemovedMinPhred = 0;
            Int64 readsRemovedMinLength = 0;
            try {
                limitSequences = Convert.ToInt64(numericUpDownLimitSequences.Value);
            } catch (Exception) {

            }

            //for (int i = 0; i < 1000; i++) {
            //    readsQuals[i] = 0;
            //}

            if (seqCount < limitSequences || limitSequences == 0) {
                readsRaw.Clear();
                totalBytes = 0;
                seqCount = 0;
                foreach (string linei in File.ReadLines(fname)) {
                    totalBytes += linei.Length;
                    if (seqCount % 50000 == 0) {
                        progressBar1.Value = (int)(((float)totalBytes / (float)fileLength) * 100);
                        toolStripStatusLabel.Text = "READING FILE... " + seqCount.ToString("N0");
                        Application.DoEvents();
                    }

                    if (limitSequences > 0 && seqCount >= limitSequences) break;
                    if (linei.StartsWith("@")) {
                        readSeq = true;
                        continue;
                    }
                    if (linei.StartsWith("+")) {
                        readQual = true;
                        continue;
                    }

                    if (readSeq) {
                        seqData = linei;
                    }
                    if (readQual) {
                        readsRaw[seqData] = linei;
                        seqCount++;
                    }
                    readSeq = false;
                    readQual = false;
                }
            }

            toolStripStatusLabel.Text = "APPLYING TRIM... ";
            Application.DoEvents();
            var dt = readsRaw
                .AsParallel()
                .Where(kv => (kv.Key.Length - (trimStart + trimEnd)) > 0)
                .Select(kv => (kv.Key.Substring(trimStart, kv.Key.Length - (trimStart + trimEnd)), kv.Value.Substring(trimStart, kv.Value.Length - (trimStart + trimEnd))))
                .ToArray();

            toolStripStatusLabel.Text = "COMPUTING READ QUALITY... ";
            Application.DoEvents();
            var d = dt
                .AsParallel()
                .Select(kv => (kv.Item1, (int)kv.Item2.Select(x => Convert.ToInt32(x) - 33).ToArray().Average()))
                .ToArray();

            toolStripStatusLabel.Text = "FILTERING MINIMUM PHREAD... ";
            Application.DoEvents();
            d = d
                .AsParallel()
                .Select(x => x)
                .Where(x => x.Item2 > minimumPhred && x.Item1.Length >= minimumReadSize)
                .ToArray();

            toolStripStatusLabel.Text = "COMPUTING READS... ";
            Application.DoEvents();
            d.ForEach(x => reads[x.Item1] = "x");

            toolStripStatusLabel.Text = "COMPUTING QUALITY GRAPH... ";
            Application.DoEvents();

            Dictionary<int, int> readsQuals = new Dictionary<int, int>();
            readsQuals = d
                .GroupBy(x => x.Item2)
                .Select(group => (group.Key, group.Count()))
                .ToDictionary<int, int>();


            if (reads.Count < 100) {
                MessageBox.Show("Less than 100 sequences found. Check your parameters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                toolStripStatusLabel.Text = "Ready";
                Cursor = Cursors.Default;
                return;
            }


            textBoxInfo.Text = "Total reads...........: " + seqCount.ToString("N0").PadLeft(12);
            textBoxInfo.Text += nl + "Total unique reads....: " + reads.Count.ToString("N0").PadLeft(12);
            textBoxInfo.Text += nl + "Reads removed (phred).: " + readsRemovedMinPhred.ToString("N0").PadLeft(12);
            textBoxInfo.Text += nl + "Reads removed (length): " + readsRemovedMinLength.ToString("N0").PadLeft(12);
            textBoxInfo.Text += nl + "Reads length (mean)...: " + reads.Keys.AsParallel().Select(x => x.Length).Average().ToString("N0").PadLeft(12);
            textBoxInfo.Text += nl + "Total bases...........: " + reads.Keys.AsParallel().Select(x => x.Length).Sum().ToString("N0").PadLeft(12);
            progressBar1.Value = 0;


            chartPhred.Series[0].Points.Clear();
            var max = readsQuals.Select(kv => kv).Where(kv => kv.Value > 0).Select(kv => kv.Key).Max();
            foreach (var i in readsQuals.Keys.OrderBy(x => x).Where(x => x > 0 && x <= 45)) {
                chartPhred.Series[0].Points.AddXY(i, readsQuals[i]);
            }

            progressBar1.Value = 0;

            toolStripStatusLabel.Text = "PROCESSING STATISTICS...";
            Application.DoEvents();

            Int64 a = 0, g = 0, c = 0, t = 0, gc = 0;

            a = reads.Keys.AsParallel().Select(x => x.Count(xx => xx == 'A')).Sum();
            progressBar1.Value = 25;
            Application.DoEvents();
            g = reads.Keys.AsParallel().Select(x => x.Count(xx => xx == 'G')).Sum();
            progressBar1.Value = 50;
            Application.DoEvents();
            c = reads.Keys.AsParallel().Select(x => x.Count(xx => xx == 'C')).Sum();
            progressBar1.Value = 75;
            Application.DoEvents();
            t = reads.Keys.AsParallel().Select(x => x.Count(xx => xx == 'T')).Sum();
            progressBar1.Value = 100;
            Application.DoEvents();

            Int64 tot = a + c + g + t;

            chartPerBase.Series[0].Points.Clear();
            chartPerBase.Series[0].Points.AddXY("A", (((float)a) / tot) * 100.0);
            chartPerBase.Series[0].Points.AddXY("G", (((float)g) / tot) * 100.0);
            chartPerBase.Series[0].Points.AddXY("C", (((float)c) / tot) * 100.0);
            chartPerBase.Series[0].Points.AddXY("T", (((float)t) / tot) * 100.0);

            //labelGCRatio.Text = "GC count: " + gc.ToString("N0");

            toolStripStatusLabel.Text = "COMPUTING GHCINDEX.. PHASE 1";
            progressBar1.Value = 0;
            Application.DoEvents();

            ConcurrentBag<KeyValuePair<string, string>> cb = new ConcurrentBag<KeyValuePair<string, string>>();

            var readsD = reads.Keys.AsParallel().Select(x => new KeyValuePair<string, string>(x, Statics.GhcIndex(x, "G"))).ToDictionary<string, string>();

            toolStripStatusLabel.Text = "COMPUTING GHCINDEX.. PHASE 2";
            progressBar1.Value = 0;
            Application.DoEvents();

            readsD.ForEach(x => Statics.Data.reads[x.Key] = x.Value);

            toolStripStatusLabel.Text = "COMPUTING GHCINDEX.. PHASE 3";
            progressBar1.Value = 0;
            Application.DoEvents();

            string nada = "";
            foreach (var r in Statics.Data.reads.AsParallel().Where(x => x.Value.Length < 20).Select(x => x.Key).ToList()) {
                Statics.Data.reads.TryRemove(r, out nada);
            }

            textBoxInfo.Text += nl + "Total ghc reads.......: " + Statics.Data.reads.Count().ToString("N0").PadLeft(12);

            //toolStripStatusLabel.Text = "COMPUTING GHCINDEX5.. PHASE 1";
            //progressBar1.Value = 0;
            //Application.DoEvents();

            //var reads5 = Statics.Data.reads.AsParallel().Select(x => new KeyValuePair<string, string>(x.Value, Statics.GhcIndex5(x.Value))).ToArray();
            //reads5.Where(x => x.Value.Length >= trackBarGhc5.Value).ForEach(x => Statics.Data.reads5[x.Key] = x.Value);

            //textBoxInfo.Text += nl + "Total ghc5 reads......: " + Statics.Data.reads5.Count().ToString("N0").PadLeft(12);

            readsSortedList = Statics.Data.reads.ToList();
            readsSortedList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            toolStripStatusLabel.Text = "COMPUTING SPECTROGRAM..";
            progressBar1.Value = 0;
            Application.DoEvents();

            if (imageBoxSpectrogram.Image != null) imageBoxSpectrogram.Image.Dispose();
            imageBoxSpectrogram.Image = new Bitmap(imageBoxSpectrogram.Width * 10, imageBoxSpectrogram.Height * 2);
            int px = 0;
            foreach (var i in readsSortedList) {
                int py = 0;
                foreach (var n in i.Key) {
                    if (n == 'A') ((Bitmap)imageBoxSpectrogram.Image).SetPixel(px, py, Color.Green);
                    if (n == 'C') ((Bitmap)imageBoxSpectrogram.Image).SetPixel(px, py, Color.Blue);
                    if (n == 'G') ((Bitmap)imageBoxSpectrogram.Image).SetPixel(px, py, Color.Black);
                    if (n == 'T') ((Bitmap)imageBoxSpectrogram.Image).SetPixel(px, py, Color.Red);
                    if (n == 'U') ((Bitmap)imageBoxSpectrogram.Image).SetPixel(px, py, Color.Red);
                    if (n == 'N') ((Bitmap)imageBoxSpectrogram.Image).SetPixel(px, py, Color.White);
                    py++;
                }
                px++;
                if (px >= imageBoxSpectrogram.Image.Width) break;
            }
            imageBoxSpectrogram.Refresh();

            toolStripStatusLabel.Text = "Ready";
            progressBar1.Value = 0;

            //GCSettings.LatencyMode = gcOldMode;
            try {
                GC.EndNoGCRegion();
            } catch (Exception) {
            }
            Cursor = Cursors.Default;
        }



        private void buttonReportView_Click(object sender, EventArgs e) {
            if (Statics.Paths.CurrentSamplePath == "") {
                MessageBox.Show("Please select the Project and the Sample first.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String fname = "";
            foreach (var f in Directory.GetFiles(Statics.Paths.CurrentSamplePath)) {
                if (f.EndsWith(".fastq")) {
                    fname = f;
                    break;
                }
            }
            if (fname == "") {
                MessageBox.Show("Cant find any fastq in current sample folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fnameWoExt = Path.GetFileNameWithoutExtension(fname);

            if (!File.Exists(Path.Combine(Statics.Paths.CurrentSamplePath, fnameWoExt + "_fastqc.html"))) {
                MessageBox.Show("Cant find the FastQC Report file in current sample folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                var s = "file://" + Statics.Paths.CurrentSamplePath.Replace(@"\", @"/") + "/" + fnameWoExt + "_fastqc.html";
                System.Diagnostics.Process.Start(s);
            } catch (Exception exc) {
                MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTrim_Click(object sender, EventArgs e) {
            //textBoxConsole.Clear();

            if (Statics.Paths.CurrentSamplePath == "") {
                MessageBox.Show("Please select the Project and the Sample first.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String fname = "";
            foreach (var f in Directory.GetFiles(Statics.Paths.CurrentSamplePath)) {
                if (f.EndsWith(".fastq")) {
                    fname = f;
                    break;
                }
            }
            if (fname == "") {
                MessageBox.Show("Cant find any fastq in current sample folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = $@"/k Data\Bin\Scripts\Trim.bat {Statics.Paths.CurrentSamplePath} {Path.GetFileName(fname)}";
            //process.StartInfo = startInfo;
            //process.Start();

            RunExternalExe("cmd.exe", $@"/k Data\Bin\Scripts\Trim.bat {Statics.Paths.CurrentSamplePath} {Path.GetFileName(fname)}");
        }

        private void buttonTrimReport_Click(object sender, EventArgs e) {
            if (Statics.Paths.CurrentSamplePath == "") {
                MessageBox.Show("Please select the Project and the Sample first.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String fname = "";
            foreach (var f in Directory.GetFiles(Statics.Paths.CurrentSamplePath)) {
                if (f.EndsWith(".fastq")) {
                    fname = f;
                    break;
                }
            }

            if (fname == "") {
                MessageBox.Show("Cant find any fastq in current sample folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fnameWoExt = Path.GetFileNameWithoutExtension(fname);

            if (!File.Exists(Path.Combine(Statics.Paths.CurrentSamplePath, fnameWoExt + "_trimmed_fastqc.html"))) {
                MessageBox.Show("Cant find the Trimmed FastQC Report file in current sample folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                var s = "file://" + Statics.Paths.CurrentSamplePath.Replace(@"\", @"/") + "/" + fnameWoExt + "_trimmed_fastqc.html";
                System.Diagnostics.Process.Start(s);
            } catch (Exception exc) {
                MessageBox.Show("Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveHost_Click(object sender, EventArgs e) {
            //textBoxConsole.Clear();

            if (Statics.Paths.CurrentSamplePath == "") {
                MessageBox.Show("Please select the Project and the Sample first.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String fname = "";
            foreach (var f in Directory.GetFiles(Statics.Paths.CurrentSamplePath)) {
                if (f.EndsWith(".fastq")) {
                    fname = f;
                    break;
                }
            }
            if (fname == "") {
                MessageBox.Show("Cant find any fastq in current sample folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = $@"/k Data\Bin\Scripts\RemoveHost.bat {Statics.Paths.CurrentSamplePath} {Path.GetFileNameWithoutExtension(fname)}";
            //process.StartInfo = startInfo;
            //process.Start();

            RunExternalExe("cmd.exe", $@"/k Data\Bin\Scripts\RemoveHost.bat {Statics.Paths.CurrentSamplePath} {Path.GetFileNameWithoutExtension(fname)}");
        }

        private void button1_Click(object sender, EventArgs e) {
            RunExternalExe("ping", "8.8.8.8");
        }





        public void RunExternalExe(string filename, string arguments = null) {
            var process = new Process();

            process.StartInfo.FileName = filename;
            if (!string.IsNullOrEmpty(arguments)) {
                process.StartInfo.Arguments = arguments;
            }

            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;

            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.OutputDataReceived += Process_OutputDataReceived;
            process.ErrorDataReceived += Process_OutputDataReceived;

            //(sender, args) => stdOutput.AppendLine(args.Data); // Use AppendLine rather than Append since args.Data is one line of output, not including the newline character.

            try {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                //stdError = process.StandardError.ReadToEnd();
                //process.WaitForExit();
            } catch (Exception e) {
                Invoke((MethodInvoker)delegate {
                    //textBoxConsole.AppendText(Environment.NewLine + "OS error while executing " + Format(filename, arguments) + ": " + e.Message);
                });
                return;
            }

            //if (process.ExitCode != 0) {
            //    var message = new StringBuilder();

            //    if (!string.IsNullOrEmpty(stdError)) {
            //        message.AppendLine(stdError);
            //    }

            //    if (stdOutput.Length != 0) {
            //        message.AppendLine("Std output:");
            //        message.AppendLine(stdOutput.ToString());
            //    }

            //    Invoke((MethodInvoker)delegate {
            //        textBoxConsole.Text += Environment.NewLine + "OS error while executing " + Format(filename, arguments);
            //    });
            //}
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e) {
            try {
                Invoke((MethodInvoker)delegate {
                    //textBoxConsole.AppendText(Environment.NewLine + e.Data.ToString());
                });
            } catch (Exception exc) {

            }
        }

        private string Format(string filename, string arguments) {
            return "'" + filename + ((string.IsNullOrEmpty(arguments)) ? string.Empty : " " + arguments) + "'";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e) {
            int v = trackBarMinimumPhred.Value;
            double x = 100 - (Math.Pow(10, (v * -1) / 10) * 100);
            labelMinimumPhred.Text = $"Phred: {v} - Accuracy: {x}%";
        }

        private void trackBarTrimStart_ValueChanged(object sender, EventArgs e) {
            labelTrimStart.Text = trackBarTrimStart.Value.ToString();
        }

        private void trackBarTrimEnd_ValueChanged(object sender, EventArgs e) {
            labelTrimEnd.Text = trackBarTrimEnd.Value.ToString();
        }

        private void buttonViewSeq_Click(object sender, EventArgs e) {
            FormViewSeq f = new FormViewSeq();
            f.SetReads(readsSortedList);
            f.Show();
        }

        private void PanelQC_Load(object sender, EventArgs e) {
            trackBar1_ValueChanged(null, null);
            trackBarMinimumReadSize_ValueChanged(null, null);
            trackBarGhc5_ValueChanged(null, null);
        }

        private void trackBarMinimumReadSize_ValueChanged(object sender, EventArgs e) {
            labelMinimumReadSize.Text = trackBarMinimumReadSize.Value.ToString();
        }

        private void trackBarGhc5_ValueChanged(object sender, EventArgs e) {
            labelGhc5.Text = trackBarGhc5.Value.ToString();
        }
    }

}
