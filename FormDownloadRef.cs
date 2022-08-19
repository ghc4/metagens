using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public partial class FormDownloadRef : Form {
        public List<Statics.DownloadRefSeqData> refSeqDatas = new List<Statics.DownloadRefSeqData>();

        public FormDownloadRef() {
            InitializeComponent();
        }

        private bool VerifyChecksumBeforeDownload(string urlChecksum, string filename) {
            WebClient client = new WebClient();
            string chk = client.DownloadString(urlChecksum);
            if (File.Exists(filename)) {
                using (var md5 = MD5.Create()) {
                    using (var stream = File.OpenRead(filename)) {
                        string chksum = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                        return chk.Contains(chksum);
                    }
                }
            }
            return false;
        }

        private void StartDownload() {
            toolStripStatusLabel1.Text = "Downloading...";
            Application.DoEvents();
            var t = Task.Run(() => {
                refSeqDatas.AsParallel().WithDegreeOfParallelism(4).ForAll(x => {
                    string path = Path.Combine(Statics.Paths.Refs, x.pathname);
                    Directory.CreateDirectory(path);
                    var pathDecompressed = Path.Combine(path, "genomic.fna");
                    path = Path.Combine(path, "genomic.fna.gz");
                    WebClient client = new WebClient();
                    if (VerifyChecksumBeforeDownload(x.urlmd5, path)) {
                        this.BeginInvoke((MethodInvoker)delegate {
                            textBoxLog.AppendText(Environment.NewLine + "Checksum ok: " + x.name);
                            Application.DoEvents();
                        });
                        if(!File.Exists(pathDecompressed)) {
                            Decompress(path);
                        }
                    } else {
                        this.BeginInvoke((MethodInvoker)delegate {
                            textBoxLog.AppendText(Environment.NewLine + "Downloading: " + x.name);
                            Application.DoEvents();
                        });
                        try {
                            client.DownloadFile(new Uri(x.urlfile), path);
                            Decompress(path);
                        } catch (Exception exc) {
                            this.BeginInvoke((MethodInvoker)delegate {
                                textBoxLog.AppendText(Environment.NewLine + "Downloading: " + x.name + " -> fail: " + exc.Message);
                                Application.DoEvents();
                            });
                        } finally {
                            this.BeginInvoke((MethodInvoker)delegate {
                                textBoxLog.AppendText(Environment.NewLine + "Downloading: " + x.name + " -> done.");
                                Application.DoEvents();
                            });
                        }
                    }
                });
            });
            t.ContinueWith(x => this.BeginInvoke((MethodInvoker)delegate {
                toolStripStatusLabel1.Text = "Ready.";
                this.BeginInvoke((MethodInvoker)delegate {
                    textBoxLog.AppendText(Environment.NewLine + "Download done.");
                    Application.DoEvents();
                });
                Application.DoEvents();
            }));
        }

        public static void Decompress(string fileToDecompress) {
            using (FileStream originalFileStream = File.OpenRead(fileToDecompress)) {
                string newFileName = Path.Combine(Path.GetDirectoryName(fileToDecompress), Path.GetFileNameWithoutExtension(fileToDecompress));
                using (FileStream decompressedFileStream = File.Create(newFileName)) {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress)) {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        private void FormDownloadRef_Load(object sender, EventArgs e) {
            StartDownload();
        }
    }



}
