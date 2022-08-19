namespace MetaGens {
    partial class PanelQC {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chartPhred = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPerBase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMinimumPhred = new System.Windows.Forms.Label();
            this.trackBarMinimumPhred = new System.Windows.Forms.TrackBar();
            this.imageBoxSpectrogram = new Cyotek.Windows.Forms.ImageBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownLimitSequences = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelTrimEnd = new System.Windows.Forms.Label();
            this.labelTrimStart = new System.Windows.Forms.Label();
            this.trackBarTrimEnd = new System.Windows.Forms.TrackBar();
            this.trackBarTrimStart = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonViewSeq = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelMinimumReadSize = new System.Windows.Forms.Label();
            this.trackBarMinimumReadSize = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelGhc5 = new System.Windows.Forms.Label();
            this.trackBarGhc5 = new System.Windows.Forms.TrackBar();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerBase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinimumPhred)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimitSequences)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrimEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrimStart)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinimumReadSize)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGhc5)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1,
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // chartPhred
            // 
            this.chartPhred.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPhred.BorderSkin.BorderColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.BorderColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chartPhred.ChartAreas.Add(chartArea1);
            this.chartPhred.Location = new System.Drawing.Point(285, 167);
            this.chartPhred.Name = "chartPhred";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartPhred.Series.Add(series1);
            this.chartPhred.Size = new System.Drawing.Size(418, 190);
            this.chartPhred.TabIndex = 7;
            this.chartPhred.Text = "chart1";
            // 
            // chartPerBase
            // 
            this.chartPerBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartPerBase.ChartAreas.Add(chartArea2);
            this.chartPerBase.Location = new System.Drawing.Point(709, 167);
            this.chartPerBase.Name = "chartPerBase";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartPerBase.Series.Add(series2);
            this.chartPerBase.Size = new System.Drawing.Size(177, 190);
            this.chartPerBase.TabIndex = 7;
            this.chartPerBase.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(282, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phred score";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(706, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Per base (%)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInfo);
            this.groupBox1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(3, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 190);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo.Font = new System.Drawing.Font("DejaVu Sans Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.Location = new System.Drawing.Point(3, 16);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(263, 171);
            this.textBoxInfo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMinimumPhred);
            this.groupBox2.Controls.Add(this.trackBarMinimumPhred);
            this.groupBox2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 64);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minimum phred";
            // 
            // labelMinimumPhred
            // 
            this.labelMinimumPhred.AutoSize = true;
            this.labelMinimumPhred.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimumPhred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.labelMinimumPhred.Location = new System.Drawing.Point(17, 43);
            this.labelMinimumPhred.Name = "labelMinimumPhred";
            this.labelMinimumPhred.Size = new System.Drawing.Size(21, 15);
            this.labelMinimumPhred.TabIndex = 8;
            this.labelMinimumPhred.Text = "20";
            // 
            // trackBarMinimumPhred
            // 
            this.trackBarMinimumPhred.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarMinimumPhred.Location = new System.Drawing.Point(6, 13);
            this.trackBarMinimumPhred.Maximum = 42;
            this.trackBarMinimumPhred.Name = "trackBarMinimumPhred";
            this.trackBarMinimumPhred.Size = new System.Drawing.Size(219, 45);
            this.trackBarMinimumPhred.TabIndex = 0;
            this.trackBarMinimumPhred.Value = 20;
            this.trackBarMinimumPhred.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // imageBoxSpectrogram
            // 
            this.imageBoxSpectrogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxSpectrogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imageBoxSpectrogram.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.None;
            this.imageBoxSpectrogram.Location = new System.Drawing.Point(3, 363);
            this.imageBoxSpectrogram.Name = "imageBoxSpectrogram";
            this.imageBoxSpectrogram.Size = new System.Drawing.Size(883, 262);
            this.imageBoxSpectrogram.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownLimitSequences);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.Location = new System.Drawing.Point(240, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 64);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Read count limit";
            // 
            // numericUpDownLimitSequences
            // 
            this.numericUpDownLimitSequences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownLimitSequences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownLimitSequences.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numericUpDownLimitSequences.Location = new System.Drawing.Point(9, 32);
            this.numericUpDownLimitSequences.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericUpDownLimitSequences.Name = "numericUpDownLimitSequences";
            this.numericUpDownLimitSequences.Size = new System.Drawing.Size(175, 23);
            this.numericUpDownLimitSequences.TabIndex = 12;
            this.numericUpDownLimitSequences.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownLimitSequences.ThousandsSeparator = true;
            this.numericUpDownLimitSequences.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max reads to analyse (0=unlim)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelTrimEnd);
            this.groupBox4.Controls.Add(this.labelTrimStart);
            this.groupBox4.Controls.Add(this.trackBarTrimEnd);
            this.groupBox4.Controls.Add(this.trackBarTrimStart);
            this.groupBox4.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox4.Location = new System.Drawing.Point(3, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 64);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trim (start/end)";
            // 
            // labelTrimEnd
            // 
            this.labelTrimEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTrimEnd.AutoSize = true;
            this.labelTrimEnd.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrimEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.labelTrimEnd.Location = new System.Drawing.Point(252, 43);
            this.labelTrimEnd.Name = "labelTrimEnd";
            this.labelTrimEnd.Size = new System.Drawing.Size(14, 15);
            this.labelTrimEnd.TabIndex = 8;
            this.labelTrimEnd.Text = "0";
            // 
            // labelTrimStart
            // 
            this.labelTrimStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTrimStart.AutoSize = true;
            this.labelTrimStart.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrimStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.labelTrimStart.Location = new System.Drawing.Point(17, 43);
            this.labelTrimStart.Name = "labelTrimStart";
            this.labelTrimStart.Size = new System.Drawing.Size(14, 15);
            this.labelTrimStart.TabIndex = 8;
            this.labelTrimStart.Text = "0";
            // 
            // trackBarTrimEnd
            // 
            this.trackBarTrimEnd.Location = new System.Drawing.Point(237, 13);
            this.trackBarTrimEnd.Maximum = 300;
            this.trackBarTrimEnd.Name = "trackBarTrimEnd";
            this.trackBarTrimEnd.Size = new System.Drawing.Size(181, 45);
            this.trackBarTrimEnd.TabIndex = 0;
            this.trackBarTrimEnd.ValueChanged += new System.EventHandler(this.trackBarTrimEnd_ValueChanged);
            // 
            // trackBarTrimStart
            // 
            this.trackBarTrimStart.Location = new System.Drawing.Point(6, 13);
            this.trackBarTrimStart.Maximum = 300;
            this.trackBarTrimStart.Name = "trackBarTrimStart";
            this.trackBarTrimStart.Size = new System.Drawing.Size(181, 45);
            this.trackBarTrimStart.TabIndex = 0;
            this.trackBarTrimStart.ValueChanged += new System.EventHandler(this.trackBarTrimStart_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Image = global::MetaGens.Properties.Resources.icons8_barbershop_24px;
            this.checkBox1.Location = new System.Drawing.Point(728, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 30);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "  REMOVE ADAPTERS";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            // 
            // buttonReport
            // 
            this.buttonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReport.BackColor = System.Drawing.Color.White;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonReport.Image = global::MetaGens.Properties.Resources.icons8_services_24px;
            this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.Location = new System.Drawing.Point(728, 9);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(158, 31);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "  PROCESS";
            this.buttonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonViewSeq
            // 
            this.buttonViewSeq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewSeq.BackColor = System.Drawing.Color.White;
            this.buttonViewSeq.FlatAppearance.BorderSize = 0;
            this.buttonViewSeq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewSeq.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonViewSeq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonViewSeq.Image = global::MetaGens.Properties.Resources.icons8_view_24px;
            this.buttonViewSeq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewSeq.Location = new System.Drawing.Point(728, 46);
            this.buttonViewSeq.Name = "buttonViewSeq";
            this.buttonViewSeq.Size = new System.Drawing.Size(158, 31);
            this.buttonViewSeq.TabIndex = 3;
            this.buttonViewSeq.Text = "  VIEW SEQ";
            this.buttonViewSeq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonViewSeq.UseVisualStyleBackColor = false;
            this.buttonViewSeq.Click += new System.EventHandler(this.buttonViewSeq_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelMinimumReadSize);
            this.groupBox5.Controls.Add(this.trackBarMinimumReadSize);
            this.groupBox5.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox5.Location = new System.Drawing.Point(436, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 64);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Minimum read size";
            // 
            // labelMinimumReadSize
            // 
            this.labelMinimumReadSize.AutoSize = true;
            this.labelMinimumReadSize.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimumReadSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.labelMinimumReadSize.Location = new System.Drawing.Point(17, 43);
            this.labelMinimumReadSize.Name = "labelMinimumReadSize";
            this.labelMinimumReadSize.Size = new System.Drawing.Size(21, 15);
            this.labelMinimumReadSize.TabIndex = 8;
            this.labelMinimumReadSize.Text = "20";
            // 
            // trackBarMinimumReadSize
            // 
            this.trackBarMinimumReadSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarMinimumReadSize.Location = new System.Drawing.Point(6, 13);
            this.trackBarMinimumReadSize.Maximum = 1000;
            this.trackBarMinimumReadSize.Name = "trackBarMinimumReadSize";
            this.trackBarMinimumReadSize.Size = new System.Drawing.Size(219, 45);
            this.trackBarMinimumReadSize.TabIndex = 0;
            this.trackBarMinimumReadSize.Value = 40;
            this.trackBarMinimumReadSize.ValueChanged += new System.EventHandler(this.trackBarMinimumReadSize_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelGhc5);
            this.groupBox6.Controls.Add(this.trackBarGhc5);
            this.groupBox6.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox6.Location = new System.Drawing.Point(436, 73);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(231, 64);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Minimum ghc5 size";
            this.groupBox6.Visible = false;
            // 
            // labelGhc5
            // 
            this.labelGhc5.AutoSize = true;
            this.labelGhc5.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGhc5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.labelGhc5.Location = new System.Drawing.Point(17, 43);
            this.labelGhc5.Name = "labelGhc5";
            this.labelGhc5.Size = new System.Drawing.Size(21, 15);
            this.labelGhc5.TabIndex = 8;
            this.labelGhc5.Text = "20";
            // 
            // trackBarGhc5
            // 
            this.trackBarGhc5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGhc5.Location = new System.Drawing.Point(6, 13);
            this.trackBarGhc5.Maximum = 30;
            this.trackBarGhc5.Name = "trackBarGhc5";
            this.trackBarGhc5.Size = new System.Drawing.Size(219, 45);
            this.trackBarGhc5.TabIndex = 0;
            this.trackBarGhc5.Value = 14;
            this.trackBarGhc5.ValueChanged += new System.EventHandler(this.trackBarGhc5_ValueChanged);
            // 
            // PanelQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.imageBoxSpectrogram);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonViewSeq);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartPerBase);
            this.Controls.Add(this.chartPhred);
            this.Controls.Add(this.statusStrip1);
            this.Name = "PanelQC";
            this.Size = new System.Drawing.Size(895, 650);
            this.Load += new System.EventHandler(this.PanelQC_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerBase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinimumPhred)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimitSequences)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrimEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrimStart)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinimumReadSize)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGhc5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhred;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPerBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelMinimumPhred;
        private System.Windows.Forms.TrackBar trackBarMinimumPhred;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private Cyotek.Windows.Forms.ImageBox imageBoxSpectrogram;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownLimitSequences;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelTrimEnd;
        private System.Windows.Forms.Label labelTrimStart;
        private System.Windows.Forms.TrackBar trackBarTrimEnd;
        private System.Windows.Forms.TrackBar trackBarTrimStart;
        private System.Windows.Forms.Button buttonViewSeq;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelMinimumReadSize;
        private System.Windows.Forms.TrackBar trackBarMinimumReadSize;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelGhc5;
        private System.Windows.Forms.TrackBar trackBarGhc5;
    }
}
