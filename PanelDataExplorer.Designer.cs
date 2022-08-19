namespace MetaGens {
    partial class PanelDataExplorer {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonProjectsRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonProjectNew = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSamplesRefresh = new System.Windows.Forms.Button();
            this.buttonDownloadSample = new System.Windows.Forms.Button();
            this.buttonSampleDelete = new System.Windows.Forms.Button();
            this.buttonSampleNew = new System.Windows.Forms.Button();
            this.listBoxSamples = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFilesRefresh = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonNcbi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxProjects.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 15;
            this.listBoxProjects.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3"});
            this.listBoxProjects.Location = new System.Drawing.Point(6, 19);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.ScrollAlwaysVisible = true;
            this.listBoxProjects.Size = new System.Drawing.Size(190, 465);
            this.listBoxProjects.TabIndex = 0;
            this.listBoxProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProjects_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.buttonProjectsRefresh);
            this.groupBox1.Controls.Add(this.listBoxProjects);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonProjectNew);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 551);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projects";
            // 
            // buttonProjectsRefresh
            // 
            this.buttonProjectsRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProjectsRefresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonProjectsRefresh.FlatAppearance.BorderSize = 0;
            this.buttonProjectsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjectsRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonProjectsRefresh.Image = global::MetaGens.Properties.Resources.icons8_refresh_16px;
            this.buttonProjectsRefresh.Location = new System.Drawing.Point(142, 447);
            this.buttonProjectsRefresh.Name = "buttonProjectsRefresh";
            this.buttonProjectsRefresh.Size = new System.Drawing.Size(30, 30);
            this.buttonProjectsRefresh.TabIndex = 3;
            this.buttonProjectsRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProjectsRefresh.UseVisualStyleBackColor = false;
            this.buttonProjectsRefresh.Click += new System.EventHandler(this.buttonProjectsRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonDelete.Image = global::MetaGens.Properties.Resources.icons8_delete_16px_2;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(113, 522);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            // 
            // buttonProjectNew
            // 
            this.buttonProjectNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProjectNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonProjectNew.FlatAppearance.BorderSize = 0;
            this.buttonProjectNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjectNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonProjectNew.Image = global::MetaGens.Properties.Resources.icons8_open_box_16px_1;
            this.buttonProjectNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjectNew.Location = new System.Drawing.Point(6, 522);
            this.buttonProjectNew.Name = "buttonProjectNew";
            this.buttonProjectNew.Size = new System.Drawing.Size(83, 23);
            this.buttonProjectNew.TabIndex = 3;
            this.buttonProjectNew.Text = "New";
            this.buttonProjectNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProjectNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProjectNew.UseVisualStyleBackColor = false;
            this.buttonProjectNew.Click += new System.EventHandler(this.buttonProjectNew_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.buttonSamplesRefresh);
            this.groupBox2.Controls.Add(this.buttonDownloadSample);
            this.groupBox2.Controls.Add(this.buttonSampleDelete);
            this.groupBox2.Controls.Add(this.buttonSampleNew);
            this.groupBox2.Controls.Add(this.listBoxSamples);
            this.groupBox2.Location = new System.Drawing.Point(219, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 551);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Samples";
            // 
            // buttonSamplesRefresh
            // 
            this.buttonSamplesRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSamplesRefresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSamplesRefresh.FlatAppearance.BorderSize = 0;
            this.buttonSamplesRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSamplesRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonSamplesRefresh.Image = global::MetaGens.Properties.Resources.icons8_refresh_16px;
            this.buttonSamplesRefresh.Location = new System.Drawing.Point(140, 447);
            this.buttonSamplesRefresh.Name = "buttonSamplesRefresh";
            this.buttonSamplesRefresh.Size = new System.Drawing.Size(30, 30);
            this.buttonSamplesRefresh.TabIndex = 3;
            this.buttonSamplesRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSamplesRefresh.UseVisualStyleBackColor = false;
            this.buttonSamplesRefresh.Click += new System.EventHandler(this.buttonSamplesRefresh_Click);
            // 
            // buttonDownloadSample
            // 
            this.buttonDownloadSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDownloadSample.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDownloadSample.FlatAppearance.BorderSize = 0;
            this.buttonDownloadSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonDownloadSample.Image = global::MetaGens.Properties.Resources.icons8_open_box_16px_1;
            this.buttonDownloadSample.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownloadSample.Location = new System.Drawing.Point(6, 522);
            this.buttonDownloadSample.Name = "buttonDownloadSample";
            this.buttonDownloadSample.Size = new System.Drawing.Size(83, 23);
            this.buttonDownloadSample.TabIndex = 3;
            this.buttonDownloadSample.Text = "Download";
            this.buttonDownloadSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownloadSample.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDownloadSample.UseVisualStyleBackColor = false;
            this.buttonDownloadSample.Click += new System.EventHandler(this.buttonDownloadSample_Click);
            // 
            // buttonSampleDelete
            // 
            this.buttonSampleDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSampleDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSampleDelete.FlatAppearance.BorderSize = 0;
            this.buttonSampleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSampleDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonSampleDelete.Image = global::MetaGens.Properties.Resources.icons8_delete_16px_2;
            this.buttonSampleDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSampleDelete.Location = new System.Drawing.Point(113, 497);
            this.buttonSampleDelete.Name = "buttonSampleDelete";
            this.buttonSampleDelete.Size = new System.Drawing.Size(83, 23);
            this.buttonSampleDelete.TabIndex = 3;
            this.buttonSampleDelete.Text = "Delete";
            this.buttonSampleDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSampleDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSampleDelete.UseVisualStyleBackColor = false;
            this.buttonSampleDelete.Click += new System.EventHandler(this.buttonSampleDelete_Click);
            // 
            // buttonSampleNew
            // 
            this.buttonSampleNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSampleNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSampleNew.FlatAppearance.BorderSize = 0;
            this.buttonSampleNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSampleNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonSampleNew.Image = global::MetaGens.Properties.Resources.icons8_open_box_16px_1;
            this.buttonSampleNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSampleNew.Location = new System.Drawing.Point(6, 497);
            this.buttonSampleNew.Name = "buttonSampleNew";
            this.buttonSampleNew.Size = new System.Drawing.Size(83, 23);
            this.buttonSampleNew.TabIndex = 3;
            this.buttonSampleNew.Text = "New";
            this.buttonSampleNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSampleNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSampleNew.UseVisualStyleBackColor = false;
            this.buttonSampleNew.Click += new System.EventHandler(this.buttonSampleNew_Click);
            // 
            // listBoxSamples
            // 
            this.listBoxSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSamples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSamples.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSamples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.listBoxSamples.FormattingEnabled = true;
            this.listBoxSamples.ItemHeight = 15;
            this.listBoxSamples.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3"});
            this.listBoxSamples.Location = new System.Drawing.Point(6, 19);
            this.listBoxSamples.Name = "listBoxSamples";
            this.listBoxSamples.ScrollAlwaysVisible = true;
            this.listBoxSamples.Size = new System.Drawing.Size(190, 465);
            this.listBoxSamples.TabIndex = 0;
            this.listBoxSamples.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSamples_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonFilesRefresh);
            this.groupBox3.Controls.Add(this.listBoxFiles);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.buttonNcbi);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(432, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 551);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Files";
            // 
            // buttonFilesRefresh
            // 
            this.buttonFilesRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilesRefresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFilesRefresh.FlatAppearance.BorderSize = 0;
            this.buttonFilesRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilesRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonFilesRefresh.Image = global::MetaGens.Properties.Resources.icons8_refresh_16px;
            this.buttonFilesRefresh.Location = new System.Drawing.Point(397, 447);
            this.buttonFilesRefresh.Name = "buttonFilesRefresh";
            this.buttonFilesRefresh.Size = new System.Drawing.Size(30, 30);
            this.buttonFilesRefresh.TabIndex = 3;
            this.buttonFilesRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFilesRefresh.UseVisualStyleBackColor = false;
            this.buttonFilesRefresh.Click += new System.EventHandler(this.buttonFilesRefresh_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFiles.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 15;
            this.listBoxFiles.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3"});
            this.listBoxFiles.Location = new System.Drawing.Point(6, 19);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.ScrollAlwaysVisible = true;
            this.listBoxFiles.Size = new System.Drawing.Size(445, 465);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFiles_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.button3.Image = global::MetaGens.Properties.Resources.icons8_delete_16px_2;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(368, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // buttonNcbi
            // 
            this.buttonNcbi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNcbi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNcbi.FlatAppearance.BorderSize = 0;
            this.buttonNcbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNcbi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonNcbi.Image = global::MetaGens.Properties.Resources.icons8_open_box_16px_1;
            this.buttonNcbi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNcbi.Location = new System.Drawing.Point(218, 522);
            this.buttonNcbi.Name = "buttonNcbi";
            this.buttonNcbi.Size = new System.Drawing.Size(72, 23);
            this.buttonNcbi.TabIndex = 3;
            this.buttonNcbi.Text = "NCBI";
            this.buttonNcbi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNcbi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNcbi.UseVisualStyleBackColor = false;
            this.buttonNcbi.Click += new System.EventHandler(this.buttonNcbi_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.button2.Image = global::MetaGens.Properties.Resources.icons8_open_box_16px_1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(95, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Download Info";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.button4.Image = global::MetaGens.Properties.Resources.icons8_open_box_16px_1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(6, 522);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "New";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // PanelDataExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "PanelDataExplorer";
            this.Size = new System.Drawing.Size(919, 579);
            this.Load += new System.EventHandler(this.PanelProject_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonProjectNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxSamples;
        private System.Windows.Forms.Button buttonSampleNew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDownloadSample;
        private System.Windows.Forms.Button buttonSamplesRefresh;
        private System.Windows.Forms.Button buttonProjectsRefresh;
        private System.Windows.Forms.Button buttonFilesRefresh;
        private System.Windows.Forms.Button buttonSampleDelete;
        private System.Windows.Forms.Button buttonNcbi;
    }
}
