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
using System.Net;
using System.Diagnostics;

namespace MetaGens {
    public partial class PanelDataExplorer : UserControl {
        public PanelDataExplorer() {
            InitializeComponent();
        }


        private void PanelProject_Load(object sender, EventArgs e) {
            RefreshProjects();
        }


        private void RefreshProjects() {
            Statics.Clear();
            listBoxProjects.Items.Clear();
            listBoxSamples.Items.Clear();
            listBoxFiles.Items.Clear();
            foreach (var dir in Directory.GetDirectories(Statics.Paths.Projects)) {
                if (Directory.Exists(dir)) {
                    listBoxProjects.Items.Add(Path.GetFileName(dir));
                }
            }
        }

        private void RefreshSamples() {
            listBoxSamples.Items.Clear();
            listBoxFiles.Items.Clear();
            if (!Directory.Exists(Statics.Paths.CurrentProjectPath)) {
                MessageBox.Show("Please, select project.");
                return;
            }

            foreach (var dir in Directory.GetDirectories(Statics.Paths.CurrentProjectPath)) {
                if (Directory.Exists(dir)) {
                    listBoxSamples.Items.Add(Path.GetFileName(dir));
                }
            }
        }

        private void RefreshFiles() {
            if (!Directory.Exists(Statics.Paths.CurrentSamplePath)) {
                MessageBox.Show("Please, select project and sample.");
                return;
            }

            listBoxFiles.Items.Clear();
            foreach (var dir in Directory.GetFiles(Statics.Paths.CurrentSamplePath)) {
                if (File.Exists(dir)) {
                    listBoxFiles.Items.Add(Path.GetFileName(dir));
                }
            }
        }


        private void buttonProjectNew_Click(object sender, EventArgs e) {
            using (WinFormsUtils.Prompt prompt = new WinFormsUtils.Prompt("New project name", "New project name")) {
                string fileName = prompt.Result.Replace(" ", "_"); 
                foreach (var c in Path.GetInvalidFileNameChars()) { fileName = fileName.Replace(c, '_'); }
                Directory.CreateDirectory(Path.Combine(Statics.Paths.Projects, fileName));
            }
            RefreshProjects();
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }


        private void listBoxProjects_MouseDoubleClick(object sender, MouseEventArgs e) {
            Statics.Controls.ButtonQualityControl.Enabled = false;
            Statics.Controls.ButtonFilter.Enabled = false;
            Statics.Controls.ButtonQuery.Enabled = false;
            Statics.Clear();
            if (listBoxProjects.SelectedIndex >= 0) {
                Statics.Paths.CurrentProjectPath = Path.Combine(Statics.Paths.Projects, listBoxProjects.SelectedItem.ToString());
                Statics.Paths.CurrentProjectName = listBoxProjects.SelectedItem.ToString().ToUpper();
                (ParentForm as FormMain).labelProjectName.Text = Statics.Paths.CurrentProjectName;
                RefreshSamples();
            }
        }



        private void buttonSampleNew_Click(object sender, EventArgs e) {
            using (WinFormsUtils.Prompt prompt = new WinFormsUtils.Prompt("New samples name", "New samples name")) {
                string fileName = prompt.Result.Replace(" ", "_");
                foreach (var c in Path.GetInvalidFileNameChars()) { fileName = fileName.Replace(c, '_'); }
                Directory.CreateDirectory(Path.Combine(Statics.Paths.CurrentProjectPath, fileName));
            }
            RefreshSamples();
        }

        private void listBoxSamples_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (listBoxSamples.SelectedIndex >= 0) {
                Statics.Paths.CurrentSamplePath = Path.Combine(Statics.Paths.CurrentProjectPath, listBoxSamples.SelectedItem.ToString());
                Statics.Paths.CurrentSampleName = listBoxSamples.SelectedItem.ToString().ToUpper();
                (ParentForm as FormMain).labelProjectName.Text = "Project: " + Statics.Paths.CurrentProjectName + "  /  Sample: " + Statics.Paths.CurrentSampleName;
                RefreshFiles();
                Statics.Controls.ButtonQuery.Enabled = false;
                Statics.Controls.ButtonFilter.Enabled = false;
                Statics.Controls.ButtonReports.Enabled = false;
                Statics.Controls.ButtonQualityControl.Enabled = true;
                Statics.Controls.FormQualityControl.Clear();
            }
        }

        private void listBoxFiles_MouseDoubleClick(object sender, MouseEventArgs e) {
            var sel = listBoxFiles.Text;
            if(sel.Length>0) {
                if (sel.ToLower().EndsWith(".sra")) {
                    var res = MessageBox.Show("Convert to FASTQ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(res == DialogResult.Yes) {
                        string srap = Statics.Paths.CurrentSamplePath;
                        string sraf = Statics.Paths.CurrentSamplePath + '\\' + sel;
                        System.Diagnostics.Process.Start("CMD.exe", $"/K Data\\bin\\sratoolkit.2.10.9-win64\\bin\\fastq-dump.exe --split-spot -O {srap} {sraf}");
                    }
                }

                if (sel.ToLower().EndsWith(".info.csv")) {
                    var f = new FormInfo();
                    f.Show();
                    f.FillGrid(Path.Combine(Statics.Paths.CurrentSamplePath, sel));
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            string srap = Statics.Paths.CurrentSamplePath;
            string sra = Statics.Paths.CurrentSampleName;

            WebClient client = new WebClient();
            client.DownloadFile(new Uri($"http://trace.ncbi.nlm.nih.gov/Traces/sra/sra.cgi?save=efetch&db=sra&rettype=runinfo&term={sra}"), $@"{srap}\{sra}.info.csv");
            RefreshFiles();
            Cursor = Cursors.Default;
            MessageBox.Show("Download completed");
        }

        private void buttonDownloadSample_Click(object sender, EventArgs e) {
            var f = new FormDownloadSample();
            f.ShowDialog();
        }

        private void buttonSamplesRefresh_Click(object sender, EventArgs e) {
            RefreshSamples();
        }

        private void buttonProjectsRefresh_Click(object sender, EventArgs e) {
            RefreshProjects();
        }

        private void buttonFilesRefresh_Click(object sender, EventArgs e) {
            RefreshFiles();
        }

        private void buttonSampleDelete_Click(object sender, EventArgs e) {
            if (Statics.Paths.CurrentSamplePath.Length > 2 && Statics.Paths.CurrentSamplePath.ToLower().Contains(Statics.Paths.Projects.ToLower())) {
                var res = MessageBox.Show("Confirm delete? It can't be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) {
                    Directory.Delete(Statics.Paths.CurrentSamplePath, true);
                }
                RefreshSamples();
            } else {
                MessageBox.Show("Select sample to delete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonNcbi_Click(object sender, EventArgs e) {
            Process.Start("https://trace.ncbi.nlm.nih.gov/Traces/sra/?run=" + Statics.Paths.CurrentSampleName);
        }
    }
}
