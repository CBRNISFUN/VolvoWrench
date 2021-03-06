﻿namespace VolvoWrench
{
    sealed partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportDemoDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescanFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goldSourceToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netdecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heatmapGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourcerunsWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourcerunsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HotkeyTimer = new System.Windows.Forms.Timer(this.components);
            this.openAsavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(849, 471);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDemoDataToolStripMenuItem,
            this.showLogToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.rescanFileToolStripMenuItem,
            this.renameDemoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 134);
            // 
            // exportDemoDataToolStripMenuItem
            // 
            this.exportDemoDataToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exportDemoDataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exportDemoDataToolStripMenuItem.Name = "exportDemoDataToolStripMenuItem";
            this.exportDemoDataToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.exportDemoDataToolStripMenuItem.Text = "Export demo data";
            this.exportDemoDataToolStripMenuItem.Click += new System.EventHandler(this.exportDemoDataToolStripMenuItem_Click);
            // 
            // showLogToolStripMenuItem
            // 
            this.showLogToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showLogToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            this.showLogToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.showLogToolStripMenuItem.Text = "Show log";
            this.showLogToolStripMenuItem.Click += new System.EventHandler(this.showLogToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copyAllToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.copyAllToolStripMenuItem.Text = "Copy all";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // rescanFileToolStripMenuItem
            // 
            this.rescanFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rescanFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.rescanFileToolStripMenuItem.Name = "rescanFileToolStripMenuItem";
            this.rescanFileToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.rescanFileToolStripMenuItem.Text = "Rescan file";
            this.rescanFileToolStripMenuItem.Click += new System.EventHandler(this.rescanFileToolStripMenuItem_Click);
            // 
            // renameDemoToolStripMenuItem
            // 
            this.renameDemoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.renameDemoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.renameDemoToolStripMenuItem.Name = "renameDemoToolStripMenuItem";
            this.renameDemoToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.renameDemoToolStripMenuItem.Text = "Rename demo";
            this.renameDemoToolStripMenuItem.Click += new System.EventHandler(this.renameDemoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.goldSourceToolsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(849, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.openAsavToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // goldSourceToolsToolStripMenuItem
            // 
            this.goldSourceToolsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.goldSourceToolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goldSourceToolsToolStripMenuItem.Name = "goldSourceToolsToolStripMenuItem";
            this.goldSourceToolsToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.goldSourceToolsToolStripMenuItem.Text = "GoldSource Tools";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netdecodeToolStripMenuItem,
            this.heatmapGeneratorToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.toolsToolStripMenuItem.Text = "Source Tools";
            // 
            // netdecodeToolStripMenuItem
            // 
            this.netdecodeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.netdecodeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.netdecodeToolStripMenuItem.Name = "netdecodeToolStripMenuItem";
            this.netdecodeToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.netdecodeToolStripMenuItem.Text = "Netdecode";
            this.netdecodeToolStripMenuItem.Click += new System.EventHandler(this.netdecodeToolStripMenuItem_Click);
            // 
            // heatmapGeneratorToolStripMenuItem
            // 
            this.heatmapGeneratorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.heatmapGeneratorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.heatmapGeneratorToolStripMenuItem.Name = "heatmapGeneratorToolStripMenuItem";
            this.heatmapGeneratorToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.heatmapGeneratorToolStripMenuItem.Text = "Heatmap generator";
            this.heatmapGeneratorToolStripMenuItem.Click += new System.EventHandler(this.heatmapGeneratorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Checked = true;
            this.helpToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem,
            this.sourcerunsWikiToolStripMenuItem,
            this.sourcerunsToolStripMenuItem});
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Image = global::VolvoWrench.Properties.Resources.bulb;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShowShortcutKeys = false;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkForUpdateToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.checkForUpdateToolStripMenuItem.Text = "Check for update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // sourcerunsWikiToolStripMenuItem
            // 
            this.sourcerunsWikiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sourcerunsWikiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sourcerunsWikiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourcerunsWikiToolStripMenuItem.Image")));
            this.sourcerunsWikiToolStripMenuItem.Name = "sourcerunsWikiToolStripMenuItem";
            this.sourcerunsWikiToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.sourcerunsWikiToolStripMenuItem.Text = "Sourceruns Wiki";
            this.sourcerunsWikiToolStripMenuItem.Click += new System.EventHandler(this.sourcerunsWikiToolStripMenuItem_Click);
            // 
            // sourcerunsToolStripMenuItem
            // 
            this.sourcerunsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sourcerunsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sourcerunsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourcerunsToolStripMenuItem.Image")));
            this.sourcerunsToolStripMenuItem.Name = "sourcerunsToolStripMenuItem";
            this.sourcerunsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.sourcerunsToolStripMenuItem.Text = "Sourceruns";
            this.sourcerunsToolStripMenuItem.Click += new System.EventHandler(this.sourcerunsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkeysToolStripMenuItem,
            this.fontToolStripMenuItem1});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // hotkeysToolStripMenuItem
            // 
            this.hotkeysToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hotkeysToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            this.hotkeysToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.hotkeysToolStripMenuItem.Text = "Hotkeys";
            this.hotkeysToolStripMenuItem.Click += new System.EventHandler(this.hotkeysToolStripMenuItem_Click_1);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fontToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.fontToolStripMenuItem1.Text = "Font";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
            // 
            // HotkeyTimer
            // 
            this.HotkeyTimer.Enabled = true;
            this.HotkeyTimer.Tick += new System.EventHandler(this.HotkeyTimer_Tick);
            // 
            // openAsavToolStripMenuItem
            // 
            this.openAsavToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openAsavToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.openAsavToolStripMenuItem.Name = "openAsavToolStripMenuItem";
            this.openAsavToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openAsavToolStripMenuItem.Text = "Open a *.sav";
            this.openAsavToolStripMenuItem.Click += new System.EventHandler(this.openAsavToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(849, 499);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Main";
            this.Text = "VolvoWrench";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportDemoDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescanFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameDemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netdecodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heatmapGeneratorToolStripMenuItem;
        private System.Windows.Forms.Timer HotkeyTimer;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourcerunsWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourcerunsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goldSourceToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openAsavToolStripMenuItem;
    }
}

