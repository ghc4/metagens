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

namespace MetaGens {
    public partial class PanelProject : UserControl {
        public PanelProject() {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e) {
            var d = new DataConnection();
            d.host = textBoxHost.Text;
            d.port = textBoxPort.Text;
            d.username = textBoxUsername.Text;
            d.password = textBoxPassword.Text;

            toolStripStatusLabel.Text = "Saving settings...";
            try {
                IFormatter formatter = new SoapFormatter();
                Stream stream = new FileStream("dataconnection.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, d);
                stream.Close();
            } catch (Exception exc) {
                MessageBox.Show("Unable to save connection settings. Please check permissions. " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            toolStripStatusLabel.Text = "Running command...";
            RunCommand(d);
            toolStripStatusLabel.Text = "Listing projects...";
            ListProjects(d);

            toolStripStatusLabel.Text = "Ready";
        }

        private void RunCommand(DataConnection d) {
            try {
                SSH ssh = new SSH();
                ssh.Connect(d);
                var r = ssh.RunCommand("ls -l /data/MetaGens");
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }

        private void ListProjects(DataConnection d) {
            try {
                SSH ssh = new SSH();
                ssh.Connect(d);
                var r = ssh.ListFiles("/data/MetaGens/");

                listBoxProjects.Items.Clear();
                var ff = from x in r where x.Name != "." && x.Name!=".." orderby x.Name select x.Name;
                foreach(var f in ff) {
                    listBoxProjects.Items.Add(f);
                }


            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }



        private void PanelProject_Load(object sender, EventArgs e) {
            listBoxProjects.Items.Clear();

            DataConnection d = null;
            try {
                IFormatter formatter = new SoapFormatter();
                Stream stream = new FileStream("dataconnection.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                d = (DataConnection)formatter.Deserialize(stream);
                stream.Close();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }

            if (d != null) {
                textBoxHost.Text = d.host;
                textBoxPort.Text = d.port;
                textBoxUsername.Text = d.username;
                textBoxPassword.Text = d.password;
            }
        }
    }


    
}
