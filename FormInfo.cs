using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public partial class FormInfo : Form {
        public FormInfo() {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e) {

        }

        public void FillGrid(string fname) {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("c1", "");
            dataGridView1.Columns.Add("c2", "");
            dataGridView1.Rows.Clear();

            try {
                var ls = File.ReadAllLines(fname).Take(2).Select(x => x.Split(',')).ToArray();

                for (int i = 0; i < ls[0].Length; i++) {
                    dataGridView1.Rows.Add(ls[0][i], ls[1][i]);
                }
            } catch (Exception) {
                MessageBox.Show("Unable to read info file. Check the info download.");
            }
        }
    }
}
