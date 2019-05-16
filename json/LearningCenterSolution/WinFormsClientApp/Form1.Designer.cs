namespace WinFormsClientApp {
    partial class frmMain {
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
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UpdateSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DeleteSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_GetAllSubjects = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FindSubject = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgView
            // 
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Location = new System.Drawing.Point(12, 97);
            this.dtgView.Name = "dtgView";
            this.dtgView.Size = new System.Drawing.Size(606, 403);
            this.dtgView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_AddSubject,
            this.TSMI_UpdateSubject,
            this.TSMI_DeleteSubject,
            this.TSMI_GetAllSubjects,
            this.TSMI_FindSubject});
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            // 
            // TSMI_AddSubject
            // 
            this.TSMI_AddSubject.Name = "TSMI_AddSubject";
            this.TSMI_AddSubject.Size = new System.Drawing.Size(180, 22);
            this.TSMI_AddSubject.Text = "Add Subject";
            this.TSMI_AddSubject.Click += new System.EventHandler(this.TSMI_AddSubject_Click);
            // 
            // TSMI_UpdateSubject
            // 
            this.TSMI_UpdateSubject.Name = "TSMI_UpdateSubject";
            this.TSMI_UpdateSubject.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UpdateSubject.Text = "Update Subject";
            this.TSMI_UpdateSubject.Click += new System.EventHandler(this.TSMI_UpdateSubject_Click);
            // 
            // TSMI_DeleteSubject
            // 
            this.TSMI_DeleteSubject.Name = "TSMI_DeleteSubject";
            this.TSMI_DeleteSubject.Size = new System.Drawing.Size(180, 22);
            this.TSMI_DeleteSubject.Text = "Delete Subject";
            this.TSMI_DeleteSubject.Click += new System.EventHandler(this.TSMI_DeleteSubject_Click);
            // 
            // TSMI_GetAllSubjects
            // 
            this.TSMI_GetAllSubjects.Name = "TSMI_GetAllSubjects";
            this.TSMI_GetAllSubjects.Size = new System.Drawing.Size(180, 22);
            this.TSMI_GetAllSubjects.Text = "Get All Subjects";
            this.TSMI_GetAllSubjects.Click += new System.EventHandler(this.TSMI_GetAllSubjects_Click);
            // 
            // TSMI_FindSubject
            // 
            this.TSMI_FindSubject.Name = "TSMI_FindSubject";
            this.TSMI_FindSubject.Size = new System.Drawing.Size(180, 22);
            this.TSMI_FindSubject.Text = "Find Subject";
            this.TSMI_FindSubject.Click += new System.EventHandler(this.TSMI_FindSubject_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 512);
            this.Controls.Add(this.dtgView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Learning Center Management";
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddSubject;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdateSubject;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DeleteSubject;
        private System.Windows.Forms.ToolStripMenuItem TSMI_GetAllSubjects;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FindSubject;
    }
}

