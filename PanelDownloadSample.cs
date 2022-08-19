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
using System.Threading;
using System.Net;

namespace MetaGens {
    public partial class PanelDownloadSample : UserControl {
        public PanelDownloadSample() {
            InitializeComponent();
        }
                
        private void PanelProject_Load(object sender, EventArgs e) {
        
        }

        private void buttonDownloadSRA_Click(object sender, EventArgs e) {
            if(Statics.Paths.CurrentProjectName == "") {
                MessageBox.Show("Please select the Project first.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            startDownload();
        }


        private void startDownload() {
            this.BeginInvoke((MethodInvoker)delegate {
                toolStripStatusLabel.Text = "Downloading..";
            });
            string sra = textBoxSampleId.Text;
            string srp = Path.Combine(Statics.Paths.CurrentProjectPath, sra);
            Directory.CreateDirectory(srp);

            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri($"https://sra-download.ncbi.nlm.nih.gov/srapub/{sra}"), $@"{srp}\{sra}.sra");
            });
            thread.Start();
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate {
                toolStripStatusLabel.Text = "Downloaded " + e.BytesReceived.ToString() + " of " + e.TotalBytesToReceive.ToString();
                progressBar1.Value = e.ProgressPercentage;
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate {
                if (e.Error != null) {
                    MessageBox.Show(e.Error.InnerException.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                toolStripStatusLabel.Text = "Ready ";
            });
        }

        private void buttonConvert_Click(object sender, EventArgs e) {
            string srap = Statics.Paths.CurrentSamplePath;
            string sraf = Statics.Paths.CurrentSamplePath + '\\' + textBoxSampleId.Text + ".sra";

            System.Diagnostics.Process.Start("CMD.exe", $"/K Data\\bin\\sratoolkit.2.10.9-win64\\bin\\fastq-dump.exe --split-spot -O {srap} {sraf}");
        }
    }


    
}
