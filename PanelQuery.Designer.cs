
namespace MetaGens {
    partial class PanelQuery {
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
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.pictureBoxProcessing = new System.Windows.Forms.PictureBox();
            this.buttonQuery5 = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonRebuild = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLog.Font = new System.Drawing.Font("DejaVu Sans Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.Location = new System.Drawing.Point(3, 40);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(944, 187);
            this.textBoxLog.TabIndex = 6;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewResult.Location = new System.Drawing.Point(3, 233);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(944, 368);
            this.dataGridViewResult.TabIndex = 7;
            this.dataGridViewResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewResult_CellFormatting);
            this.dataGridViewResult.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewResult_CellMouseDoubleClick);
            // 
            // pictureBoxProcessing
            // 
            this.pictureBoxProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxProcessing.Image = global::MetaGens.Properties.Resources.processing;
            this.pictureBoxProcessing.Location = new System.Drawing.Point(821, 117);
            this.pictureBoxProcessing.Name = "pictureBoxProcessing";
            this.pictureBoxProcessing.Size = new System.Drawing.Size(108, 108);
            this.pictureBoxProcessing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProcessing.TabIndex = 8;
            this.pictureBoxProcessing.TabStop = false;
            this.pictureBoxProcessing.Visible = false;
            // 
            // buttonQuery5
            // 
            this.buttonQuery5.BackColor = System.Drawing.Color.White;
            this.buttonQuery5.FlatAppearance.BorderSize = 0;
            this.buttonQuery5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuery5.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonQuery5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonQuery5.Image = global::MetaGens.Properties.Resources.icons8_data_24px;
            this.buttonQuery5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuery5.Location = new System.Drawing.Point(331, 3);
            this.buttonQuery5.Name = "buttonQuery5";
            this.buttonQuery5.Size = new System.Drawing.Size(158, 31);
            this.buttonQuery5.TabIndex = 1;
            this.buttonQuery5.Text = "  QUERY 5";
            this.buttonQuery5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQuery5.UseVisualStyleBackColor = false;
            this.buttonQuery5.Visible = false;
            this.buttonQuery5.Click += new System.EventHandler(this.buttonQuery5_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.BackColor = System.Drawing.Color.White;
            this.buttonQuery.FlatAppearance.BorderSize = 0;
            this.buttonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuery.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonQuery.Image = global::MetaGens.Properties.Resources.icons8_data_24px;
            this.buttonQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuery.Location = new System.Drawing.Point(167, 3);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(158, 31);
            this.buttonQuery.TabIndex = 1;
            this.buttonQuery.Text = "  QUERY";
            this.buttonQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQuery.UseVisualStyleBackColor = false;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonRebuild
            // 
            this.buttonRebuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRebuild.BackColor = System.Drawing.Color.White;
            this.buttonRebuild.FlatAppearance.BorderSize = 0;
            this.buttonRebuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRebuild.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRebuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonRebuild.Image = global::MetaGens.Properties.Resources.icons8_refresh_24px;
            this.buttonRebuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRebuild.Location = new System.Drawing.Point(789, 3);
            this.buttonRebuild.Name = "buttonRebuild";
            this.buttonRebuild.Size = new System.Drawing.Size(158, 31);
            this.buttonRebuild.TabIndex = 1;
            this.buttonRebuild.Text = "  REBUILD";
            this.buttonRebuild.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRebuild.UseVisualStyleBackColor = false;
            this.buttonRebuild.Click += new System.EventHandler(this.buttonRebuild_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.White;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonRefresh.Image = global::MetaGens.Properties.Resources.icons8_refresh_24px;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(3, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(158, 31);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "  REFRESH DATA";
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // PanelQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxProcessing);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonQuery5);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonRebuild);
            this.Controls.Add(this.buttonRefresh);
            this.Name = "PanelQuery";
            this.Size = new System.Drawing.Size(950, 604);
            this.Load += new System.EventHandler(this.PanelQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonRebuild;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonQuery5;
        private System.Windows.Forms.PictureBox pictureBoxProcessing;
    }
}
