using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaGens {
    public class WinFormsUtils {


        public class Prompt : IDisposable {
            //using(Prompt prompt = new Prompt("text", "caption")){
            //  string result = prompt.Result;
            //}


            private Form prompt { get; set; }
            public string Result { get; }

            public Prompt(string text, string caption) {
                Result = ShowDialog(text, caption);
            }
            //use a using statement
            private string ShowDialog(string text, string caption) {
                prompt = new Form() {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen,
                    TopMost = true
                };
                Label textLabel = new Label() { Left = 50, Top = 50, Text = text, Dock = DockStyle.Top, TextAlign = ContentAlignment.MiddleLeft };
                TextBox textBox = new TextBox() { Left = 50, Top = 30, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 60, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }

            public void Dispose() {
                //See Marcus comment
                if (prompt != null) {
                    prompt.Dispose();
                }
            }
        }
    }
}
