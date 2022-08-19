using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public partial class FormMain : Form {
        private PanelStart panelStart;
        private PanelProject panelProject;
        private PanelQC panelQualityControl;
        private PanelDataExplorer panelDataExplorer;
        private PanelDownloadSample panelDownload;
        private PanelDatabaseFilter panelDatabaseFilter;
        private PanelQuery panelQuery;

        public FormMain() {
            InitializeComponent();

            Directory.CreateDirectory(Statics.Paths.Bin);
            Directory.CreateDirectory(Statics.Paths.Projects);
        }
        
        private void Form1_Load(object sender, EventArgs e) {
            Statics.Clear();
            Statics.Start();
            panelStart = new PanelStart();
            panelProject = new PanelProject();
            panelQualityControl = new PanelQC();
            panelDataExplorer = new PanelDataExplorer();
            panelDownload = new PanelDownloadSample();
            panelDatabaseFilter = new PanelDatabaseFilter();
            panelQuery = new PanelQuery();

            buttonStart_Click(null, null);

            Directory.CreateDirectory(Path.Combine("Data", "Projects"));
            Directory.CreateDirectory(Path.Combine("Data", "Bin"));
            Directory.CreateDirectory(Path.Combine("Data", "Refs"));

            Statics.Controls.FormMain = this;
            Statics.Controls.FormDataExplorer = panelDataExplorer;
            Statics.Controls.FormQualityControl = panelQualityControl;
            Statics.Controls.FormDatabaseFilter = panelDatabaseFilter;
            Statics.Controls.FormQuery = panelQuery;
            Statics.Controls.ButtonMain = buttonStart;
            Statics.Controls.ButtonDataExplorer = buttonDataExplorer;
            Statics.Controls.ButtonQualityControl = buttonQualityControl;
            Statics.Controls.ButtonFilter = buttonFilter;
            Statics.Controls.ButtonQuery = buttonQuery;
            Statics.Controls.ButtonReports = buttonReports;

            Statics.Controls.ButtonQuery.Enabled = false;
            Statics.Controls.ButtonFilter.Enabled = false;
            Statics.Controls.ButtonQualityControl.Enabled = false;
            Statics.Controls.ButtonReports.Enabled = false;
        }


        private void buttonStart_Click(object sender, EventArgs e) {
            labelPanelName.Text = "START";
            panelDock.Controls.Clear();    
            panelDock.Controls.Add(panelStart);
            panelStart.Dock = DockStyle.Fill;
        }

        private void buttonProject_Click(object sender, EventArgs e) {
            //labelPanelName.Text = "PROJECT";
            //panelDock.Controls.Clear();
            //panelDock.Controls.Add(panelProject);
            //panelProject.Dock = DockStyle.Fill;
        }

        private void buttonQualityControl_Click(object sender, EventArgs e) {
            labelPanelName.Text = "QUALITY CONTROL";
            panelDock.Controls.Clear();
            panelDock.Controls.Add(panelQualityControl);
            panelQualityControl.Dock = DockStyle.Fill;
        }

        private void labelUfcspa_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.ufcspa.edu.br/english/graduate-programs/health-sciences");
        }

        private void buttonDataExplorer_Click(object sender, EventArgs e) {
            labelPanelName.Text = "DATA EXPLORER";
            panelDock.Controls.Clear();
            panelDock.Controls.Add(panelDataExplorer);
            panelDataExplorer.Dock = DockStyle.Fill;
        }

        private void buttonDownload_Click(object sender, EventArgs e) {
            labelPanelName.Text = "DOWNLOAD";
            panelDock.Controls.Clear();
            panelDock.Controls.Add(panelDownload);
            panelDownload.Dock = DockStyle.Fill;
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            labelPanelName.Text = "DATABASE FILTER";
            panelDock.Controls.Clear();
            panelDock.Controls.Add(panelDatabaseFilter);
            panelDatabaseFilter.Dock = DockStyle.Fill;
        }

        private void labelProjectName_Click(object sender, EventArgs e) {
            var sel = Path.Combine(Statics.Paths.CurrentSamplePath, Statics.Paths.CurrentSampleName + ".info.csv");
            if (File.Exists(sel)) {
                if (sel.ToLower().EndsWith(".info.csv")) {
                    var f = new FormInfo();
                    f.Show();
                    f.FillGrid(sel);
                }
            } else {
                MessageBox.Show("Sample info not found. Try to download it on Data Explorer");
            }
        }

        private void buttonAlignment_Click(object sender, EventArgs e) {
            labelPanelName.Text = "DATABASE QUERY";
            panelDock.Controls.Clear();
            panelDock.Controls.Add(panelQuery);
            panelQuery.Dock = DockStyle.Fill;
        }
    }
}
