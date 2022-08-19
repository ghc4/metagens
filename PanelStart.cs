using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace MetaGens {
    public partial class PanelStart : UserControl {
        public PanelStart() {
            InitializeComponent();
        }

        private void PanelStart_Load(object sender, EventArgs e) {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController")) {
                
                string nl = Environment.NewLine;
                foreach (ManagementObject obj in searcher.Get()) {
                    string s = "";
                    s += nl + "Name  -  " + obj["Name"];
                    s += nl + "DeviceID  -  " + obj["DeviceID"];
                    s += nl + "AdapterRAM  -  " + obj["AdapterRAM"];
                    s += nl + "AdapterDACType  -  " + obj["AdapterDACType"];
                    s += nl + "Monochrome  -  " + obj["Monochrome"];
                    s += nl + "InstalledDisplayDrivers  -  " + obj["InstalledDisplayDrivers"];
                    s += nl + "DriverVersion  -  " + obj["DriverVersion"];
                    s += nl + "VideoProcessor  -  " + obj["VideoProcessor"];
                    s += nl + "VideoArchitecture  -  " + obj["VideoArchitecture"];
                    s += nl + "VideoMemoryType  -  " + obj["VideoMemoryType"];
                    textBox1.Text += s;
                }
            }
        }
    }
}
