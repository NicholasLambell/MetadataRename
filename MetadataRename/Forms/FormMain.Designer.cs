namespace MetadataRename {
    partial class FormMain {
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
            this.lstFiles = new System.Windows.Forms.ListView();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDesel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvSel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApply = new System.Windows.Forms.Button();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.AllowDrop = true;
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.CheckBoxes = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 27);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(366, 369);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFiles_DragDrop);
            this.lstFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstFiles_DragEnter);
            this.lstFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFiles_KeyDown);
            // 
            // mnuStrip
            // 
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuSelect,
            this.mnuFilter});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(390, 24);
            this.mnuStrip.TabIndex = 1;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuSelect
            // 
            this.mnuSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelAll,
            this.mnuDesel,
            this.mnuInvSel});
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(67, 20);
            this.mnuSelect.Text = "Selection";
            // 
            // mnuSelAll
            // 
            this.mnuSelAll.Name = "mnuSelAll";
            this.mnuSelAll.Size = new System.Drawing.Size(155, 22);
            this.mnuSelAll.Text = "Select All";
            this.mnuSelAll.Click += new System.EventHandler(this.mnuSelAll_Click);
            // 
            // mnuDesel
            // 
            this.mnuDesel.Name = "mnuDesel";
            this.mnuDesel.Size = new System.Drawing.Size(155, 22);
            this.mnuDesel.Text = "Deselect All";
            this.mnuDesel.Click += new System.EventHandler(this.mnuDesel_Click);
            // 
            // mnuInvSel
            // 
            this.mnuInvSel.Name = "mnuInvSel";
            this.mnuInvSel.Size = new System.Drawing.Size(155, 22);
            this.mnuInvSel.Text = "Invert Selection";
            this.mnuInvSel.Click += new System.EventHandler(this.mnuInvSel_Click);
            // 
            // mnuFilter
            // 
            this.mnuFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilterEdit,
            this.mnuFilterClear,
            this.mnuFilterSave,
            this.mnuFilterLoad});
            this.mnuFilter.Name = "mnuFilter";
            this.mnuFilter.Size = new System.Drawing.Size(50, 20);
            this.mnuFilter.Text = "Filters";
            // 
            // mnuFilterEdit
            // 
            this.mnuFilterEdit.Name = "mnuFilterEdit";
            this.mnuFilterEdit.Size = new System.Drawing.Size(101, 22);
            this.mnuFilterEdit.Text = "Edit";
            this.mnuFilterEdit.Click += new System.EventHandler(this.mnuFilterEdit_Click);
            // 
            // mnuFilterClear
            // 
            this.mnuFilterClear.Name = "mnuFilterClear";
            this.mnuFilterClear.Size = new System.Drawing.Size(101, 22);
            this.mnuFilterClear.Text = "Clear";
            this.mnuFilterClear.Click += new System.EventHandler(this.mnuFilterClear_Click);
            // 
            // mnuFilterSave
            // 
            this.mnuFilterSave.Name = "mnuFilterSave";
            this.mnuFilterSave.Size = new System.Drawing.Size(101, 22);
            this.mnuFilterSave.Text = "Save";
            this.mnuFilterSave.Click += new System.EventHandler(this.mnuFilterSave_Click);
            // 
            // mnuFilterLoad
            // 
            this.mnuFilterLoad.Name = "mnuFilterLoad";
            this.mnuFilterLoad.Size = new System.Drawing.Size(101, 22);
            this.mnuFilterLoad.Text = "Load";
            this.mnuFilterLoad.Click += new System.EventHandler(this.mnuFilterLoad_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(12, 403);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(366, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply Filters";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 433);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.MinimumSize = new System.Drawing.Size(406, 472);
            this.Name = "FormMain";
            this.Text = "Bulk Rename Utility";
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuSelect;
        private System.Windows.Forms.ToolStripMenuItem mnuSelAll;
        private System.Windows.Forms.ToolStripMenuItem mnuDesel;
        private System.Windows.Forms.ToolStripMenuItem mnuInvSel;
        private System.Windows.Forms.ToolStripMenuItem mnuFilter;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterLoad;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterClear;
    }
}

