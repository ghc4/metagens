
namespace MetaGens {
    partial class PanelDatabaseFilter {
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
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.checkBoxUniqueTax = new System.Windows.Forms.CheckBox();
            this.dataGridViewSelection = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddSelection = new System.Windows.Forms.Button();
            this.buttonUpdateDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AllowUserToResizeRows = false;
            this.dataGridViewData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewData.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewData.Location = new System.Drawing.Point(3, 61);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersVisible = false;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.ShowEditingIcon = false;
            this.dataGridViewData.Size = new System.Drawing.Size(944, 281);
            this.dataGridViewData.TabIndex = 4;
            this.dataGridViewData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewData_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(7, 21);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(213, 20);
            this.textBoxFilter.TabIndex = 0;
            // 
            // checkBoxUniqueTax
            // 
            this.checkBoxUniqueTax.AutoSize = true;
            this.checkBoxUniqueTax.Checked = true;
            this.checkBoxUniqueTax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUniqueTax.Location = new System.Drawing.Point(441, 10);
            this.checkBoxUniqueTax.Name = "checkBoxUniqueTax";
            this.checkBoxUniqueTax.Size = new System.Drawing.Size(92, 17);
            this.checkBoxUniqueTax.TabIndex = 2;
            this.checkBoxUniqueTax.Text = "Unique TaxID";
            this.checkBoxUniqueTax.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelection
            // 
            this.dataGridViewSelection.AllowUserToAddRows = false;
            this.dataGridViewSelection.AllowUserToDeleteRows = false;
            this.dataGridViewSelection.AllowUserToResizeRows = false;
            this.dataGridViewSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSelection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelection.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewSelection.Location = new System.Drawing.Point(3, 394);
            this.dataGridViewSelection.Name = "dataGridViewSelection";
            this.dataGridViewSelection.ReadOnly = true;
            this.dataGridViewSelection.RowHeadersVisible = false;
            this.dataGridViewSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSelection.Size = new System.Drawing.Size(944, 162);
            this.dataGridViewSelection.TabIndex = 6;
            this.dataGridViewSelection.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSelection_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selection";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload.BackColor = System.Drawing.Color.White;
            this.buttonDownload.FlatAppearance.BorderSize = 0;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonDownload.Image = global::MetaGens.Properties.Resources.icons8_download_32px;
            this.buttonDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownload.Location = new System.Drawing.Point(754, 562);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(193, 40);
            this.buttonDownload.TabIndex = 7;
            this.buttonDownload.Text = "  DOWNLOAD SELECTED";
            this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
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
            this.buttonRefresh.Location = new System.Drawing.Point(226, 10);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(158, 31);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "  REFRESH DATA";
            this.buttonRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddSelection
            // 
            this.buttonAddSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSelection.BackColor = System.Drawing.Color.White;
            this.buttonAddSelection.FlatAppearance.BorderSize = 0;
            this.buttonAddSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSelection.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonAddSelection.Image = global::MetaGens.Properties.Resources.icons8_open_box_16px_1;
            this.buttonAddSelection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddSelection.Location = new System.Drawing.Point(789, 348);
            this.buttonAddSelection.Name = "buttonAddSelection";
            this.buttonAddSelection.Size = new System.Drawing.Size(158, 31);
            this.buttonAddSelection.TabIndex = 5;
            this.buttonAddSelection.Text = "  ADD SELECTION";
            this.buttonAddSelection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddSelection.UseVisualStyleBackColor = false;
            this.buttonAddSelection.Click += new System.EventHandler(this.buttonAddSelection_Click);
            // 
            // buttonUpdateDatabase
            // 
            this.buttonUpdateDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateDatabase.BackColor = System.Drawing.Color.White;
            this.buttonUpdateDatabase.FlatAppearance.BorderSize = 0;
            this.buttonUpdateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateDatabase.Font = new System.Drawing.Font("DejaVu Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonUpdateDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(111)))));
            this.buttonUpdateDatabase.Image = global::MetaGens.Properties.Resources.icons8_refresh_24px;
            this.buttonUpdateDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateDatabase.Location = new System.Drawing.Point(705, 15);
            this.buttonUpdateDatabase.Name = "buttonUpdateDatabase";
            this.buttonUpdateDatabase.Size = new System.Drawing.Size(242, 31);
            this.buttonUpdateDatabase.TabIndex = 3;
            this.buttonUpdateDatabase.Text = "  UPDATE DATABASE FROM NCBI";
            this.buttonUpdateDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdateDatabase.UseVisualStyleBackColor = false;
            this.buttonUpdateDatabase.Click += new System.EventHandler(this.buttonUpdateDatabase_Click);
            // 
            // PanelDatabaseFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxUniqueTax);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonAddSelection);
            this.Controls.Add(this.buttonUpdateDatabase);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewSelection);
            this.Controls.Add(this.dataGridViewData);
            this.Name = "PanelDatabaseFilter";
            this.Size = new System.Drawing.Size(950, 604);
            this.Load += new System.EventHandler(this.PanelDatabaseFilter_Load);
            this.VisibleChanged += new System.EventHandler(this.PanelDatabaseFilter_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxUniqueTax;
        private System.Windows.Forms.DataGridView dataGridViewSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonAddSelection;
        private System.Windows.Forms.Button buttonUpdateDatabase;
    }
}
