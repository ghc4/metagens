using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public class SSH {
        private DataConnection dataConnection;

        public void Connect(DataConnection dataConnection) {
            this.dataConnection = dataConnection;
        }

        public string RunCommand(string cmd) {
            try {
                SshClient cSSH = new SshClient(dataConnection.host, int.Parse(dataConnection.port), dataConnection.username, dataConnection.password);
                cSSH.Connect();
                SshCommand x = cSSH.RunCommand(cmd);
                cSSH.Disconnect();
                cSSH.Dispose();
                return x.Result;
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
            return null;
        }

        public List<Renci.SshNet.Sftp.SftpFile> ListFiles(string dir) {
            List<Renci.SshNet.Sftp.SftpFile> files = new List<Renci.SshNet.Sftp.SftpFile>();
            using (var client = new Renci.SshNet.SftpClient(dataConnection.host, int.Parse(dataConnection.port), dataConnection.username, dataConnection.password)) {
                client.Connect();
                var rfiles = client.ListDirectory(dir);
                foreach (var file in rfiles) {
                    if (file.IsDirectory) {
                        files.Add(file);
                    }
                }
                client.Disconnect();
            }
            return files;
        }
    }

    [Serializable]
    public class DataConnection {
        public string host;
        public string port;
        public string username;
        public string password;
    }
}
