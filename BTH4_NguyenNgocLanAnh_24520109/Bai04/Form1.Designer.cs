namespace Bai04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewFileMenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFontDialogToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewFile = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.cboFont = new System.Windows.Forms.ToolStripComboBox();
            this.cboSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbMain
            // 
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbMain.Location = new System.Drawing.Point(0, 52);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(650, 329);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            this.rtbMain.TextChanged += new System.EventHandler(this.rtbMain_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.OpenFontDialogToolstrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewFileMenustrip,
            this.OpenFileMenustrip,
            this.SaveMenustrip,
            this.ExitMenustrip});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // CreateNewFileMenustrip
            // 
            this.CreateNewFileMenustrip.Image = ((System.Drawing.Image)(resources.GetObject("CreateNewFileMenustrip.Image")));
            this.CreateNewFileMenustrip.Name = "CreateNewFileMenustrip";
            this.CreateNewFileMenustrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateNewFileMenustrip.Size = new System.Drawing.Size(205, 22);
            this.CreateNewFileMenustrip.Text = "Tạo văn bản mới";
            this.CreateNewFileMenustrip.Click += new System.EventHandler(this.CreateNewFileMenustrip_Click);
            // 
            // OpenFileMenustrip
            // 
            this.OpenFileMenustrip.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileMenustrip.Image")));
            this.OpenFileMenustrip.Name = "OpenFileMenustrip";
            this.OpenFileMenustrip.Size = new System.Drawing.Size(205, 22);
            this.OpenFileMenustrip.Text = "Mở tập tin";
            this.OpenFileMenustrip.Click += new System.EventHandler(this.OpenFileMenustrip_Click);
            // 
            // SaveMenustrip
            // 
            this.SaveMenustrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveMenustrip.Image")));
            this.SaveMenustrip.Name = "SaveMenustrip";
            this.SaveMenustrip.ShortcutKeyDisplayString = "";
            this.SaveMenustrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenustrip.Size = new System.Drawing.Size(205, 22);
            this.SaveMenustrip.Text = "Lưu văn bản";
            this.SaveMenustrip.Click += new System.EventHandler(this.SaveMenustrip_Click);
            // 
            // ExitMenustrip
            // 
            this.ExitMenustrip.Name = "ExitMenustrip";
            this.ExitMenustrip.Size = new System.Drawing.Size(205, 22);
            this.ExitMenustrip.Text = "Thoát";
            this.ExitMenustrip.Click += new System.EventHandler(this.ExitMenustrip_Click);
            // 
            // OpenFontDialogToolstrip
            // 
            this.OpenFontDialogToolstrip.Name = "OpenFontDialogToolstrip";
            this.OpenFontDialogToolstrip.Size = new System.Drawing.Size(74, 20);
            this.OpenFontDialogToolstrip.Text = "Định dạng";
            this.OpenFontDialogToolstrip.Click += new System.EventHandler(this.OpenFontDialogToolstrip_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewFile,
            this.btnSave,
            this.cboFont,
            this.cboSize,
            this.btnBold,
            this.btnItalic,
            this.btnUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(650, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewFile
            // 
            this.btnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("btnNewFile.Image")));
            this.btnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(23, 22);
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboFont
            // 
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(200, 25);
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // cboSize
            // 
            this.cboSize.DropDownWidth = 121;
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(80, 25);
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "toolStripButton3";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "toolStripButton4";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "toolStripButton5";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 381);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFontDialogToolstrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateNewFileMenustrip;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenustrip;
        private System.Windows.Forms.ToolStripMenuItem SaveMenustrip;
        private System.Windows.Forms.ToolStripMenuItem ExitMenustrip;
        private System.Windows.Forms.ToolStripButton btnNewFile;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripComboBox cboFont;
        private System.Windows.Forms.ToolStripComboBox cboSize;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
    }
}

