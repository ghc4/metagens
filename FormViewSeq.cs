using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public partial class FormViewSeq : Form {
        private int seqSkip = 0;
        private List<KeyValuePair<string, string>> readsp;
        public FormViewSeq() {
            InitializeComponent();
        }

        private void FormViewSeq_Load(object sender, EventArgs e) {

        }

        public void SetReads(List<KeyValuePair<string, string>> reads) {
            readsp = reads;
            RefreshReads();
        }

        public void RefreshReads() {
            textBoxSequences.Clear();
            textBoxSequences.Text += $"Sequences: {readsp.Count}";
            foreach(var i in readsp.Skip(seqSkip).Take(28)) {
                //textBoxSequences.Text += Environment.NewLine + i.Value + ":" + i.Key;
                textBoxSequences.Text += Environment.NewLine + i.Key;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            seqSkip += 20;
            RefreshReads();
        }

        private void button2_Click(object sender, EventArgs e) {
            seqSkip = seqSkip > 20 ? seqSkip - 20 : 0;
            RefreshReads();
        }
    }
}
