namespace Youtube_downloader
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.menuNotifyicon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHomeform = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSavelocation = new System.Windows.Forms.TextBox();
            this.txtUserinput = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSelectfolder = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.browseSavelocation = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Webbrowser = new System.Windows.Forms.WebBrowser();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuNotifyicon.SuspendLayout();
            this.menuHomeform.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNotifyicon
            // 
            this.menuNotifyicon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNotifyicon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.menuNotifyicon.Name = "menuNotifyicon";
            this.menuNotifyicon.Size = new System.Drawing.Size(115, 52);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // menuHomeform
            // 
            this.menuHomeform.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuHomeform.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuHomeform.Name = "menuHomeform";
            this.menuHomeform.Size = new System.Drawing.Size(115, 52);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // txtSavelocation
            // 
            this.txtSavelocation.Location = new System.Drawing.Point(239, 12);
            this.txtSavelocation.Name = "txtSavelocation";
            this.txtSavelocation.Size = new System.Drawing.Size(294, 22);
            this.txtSavelocation.TabIndex = 2;
            // 
            // txtUserinput
            // 
            this.txtUserinput.AllowDrop = true;
            this.txtUserinput.Location = new System.Drawing.Point(12, 52);
            this.txtUserinput.Multiline = true;
            this.txtUserinput.Name = "txtUserinput";
            this.txtUserinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserinput.Size = new System.Drawing.Size(719, 41);
            this.txtUserinput.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(342, 96);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelectfolder
            // 
            this.btnSelectfolder.Location = new System.Drawing.Point(542, 9);
            this.btnSelectfolder.Name = "btnSelectfolder";
            this.btnSelectfolder.Size = new System.Drawing.Size(103, 28);
            this.btnSelectfolder.TabIndex = 6;
            this.btnSelectfolder.Text = "Select folder";
            this.btnSelectfolder.UseVisualStyleBackColor = true;
            this.btnSelectfolder.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(651, 9);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(85, 28);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.buttonSavelocation_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.menuNotifyicon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            // 
            // Webbrowser
            // 
            this.Webbrowser.Location = new System.Drawing.Point(12, 200);
            this.Webbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Webbrowser.Name = "Webbrowser";
            this.Webbrowser.Size = new System.Drawing.Size(719, 433);
            this.Webbrowser.TabIndex = 9;
            this.Webbrowser.Url = new System.Uri("http://Youtube.com", System.UriKind.Absolute);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 117);
            this.ContextMenuStrip = this.menuHomeform;
            this.Controls.Add(this.Webbrowser);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSelectfolder);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtUserinput);
            this.Controls.Add(this.txtSavelocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube downloader";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMain_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMain_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formMain_MouseUp_1);
            this.menuNotifyicon.ResumeLayout(false);
            this.menuHomeform.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuNotifyicon;
        private System.Windows.Forms.ContextMenuStrip menuHomeform;
        private System.Windows.Forms.TextBox txtSavelocation;
        private System.Windows.Forms.TextBox txtUserinput;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSelectfolder;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.FolderBrowserDialog browseSavelocation;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.WebBrowser Webbrowser;
        private System.Windows.Forms.ImageList imageList1;
    }
}

