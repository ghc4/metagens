using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public partial class FormTextBox : Form {
        public FormTextBox() {
            InitializeComponent();
        }

        private void textBoxText_MouseUp(object sender, MouseEventArgs e) {
            if (textBoxText.SelectedText.Length == 0) return;
            Clipboard.SetText(textBoxText.SelectedText);
            HighlightText(textBoxText, textBoxText.SelectedText, Color.Yellow);
        }

        public void HighlightText(RichTextBox myRtb, string word, Color color) {
            myRtb.DeselectAll();
            myRtb.Text = myRtb.Text.ToString();

            
            if (word == string.Empty)
                return;

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1) {
                myRtb.Select(index, word.Length);
                myRtb.SelectionBackColor = color;
                startIndex = index + word.Length;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            myRtb.SelectionColor = Color.Black;
        }
    }
}
