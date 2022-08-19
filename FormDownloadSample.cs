using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public partial class FormDownloadSample : Form {
        private long counter = 0;

        public FormDownloadSample() {
            InitializeComponent();
        }
        
        private void startDownload() {
            counter = 0;
            this.BeginInvoke((MethodInvoker)delegate {
                toolStripStatusLabel1.Text = "Downloading..";
            });
            string sra = textBoxSampleId.Text;
            string srp = Path.Combine(Statics.Paths.CurrentProjectPath, sra);
            Directory.CreateDirectory(srp);

            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                //client.DownloadFileAsync(new Uri($"https://sra-download.ncbi.nlm.nih.gov/srapub/{sra}"), $@"{srp}\{sra}.sra");
                client.DownloadFileAsync(new Uri($"https://sra-pub-run-odp.s3.amazonaws.com/sra/{sra}/{sra}"), $@"{srp}\{sra}.sra");
            });
            thread.Start();
        }
        
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            counter++;
            try {
                this.BeginInvoke((MethodInvoker)delegate {
                    if (counter % 200 == 0) {
                        toolStripStatusLabel1.Text = "Downloaded " + e.BytesReceived.ToString("N0") + " of " + e.TotalBytesToReceive.ToString("N0");
                        progressBar1.Value = e.ProgressPercentage;
                        Application.DoEvents();
                    }
                });
            } catch (Exception) {

            }
        }
        
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate {
                if (e.Error != null) {
                    if (e.Error.InnerException != null) {
                        MessageBox.Show(e.Error.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        MessageBox.Show(e.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                progressBar1.Value = 0;
                toolStripStatusLabel1.Text = "Ready ";
                Application.DoEvents();
            });
        }

        private void buttonDownloadSRA_Click(object sender, EventArgs e) {
            if (Statics.Paths.CurrentProjectName == "") {
                MessageBox.Show("Please select the Project first.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            startDownload();
        }
    }
}
