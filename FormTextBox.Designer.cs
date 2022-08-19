
namespace MetaGens {
    partial class FormTextBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextBox));
            this.textBoxText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxText.Font = new System.Drawing.Font("DejaVu Sans Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxText.Location = new System.Drawing.Point(0, 0);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(1024, 384);
            this.textBoxText.TabIndex = 1;
            this.textBoxText.Text = "";
            this.textBoxText.WordWrap = false;
            this.textBoxText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxText_MouseUp);
            // 
            // FormTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 384);
            this.Controls.Add(this.textBoxText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTextBox";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox textBoxText;
    }
}