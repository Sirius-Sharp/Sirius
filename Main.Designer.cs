namespace Sirius_Sharp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            fileExplorerToolStripMenuItem = new ToolStripMenuItem();
            recognizeTextToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            setWorkspaceToolStripMenuItem = new ToolStripMenuItem();
            OFDialog = new OpenFileDialog();
            SFDialog = new SaveFileDialog();
            statusStrip1 = new StatusStrip();
            TSFname = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            TSProgbar = new ToolStripProgressBar();
            statusStrip2 = new StatusStrip();
            richTextBox2 = new RichTextBox();
            MainTextBox = new RichTextBox();
            FExplorer = new TreeView();
            panel1 = new Panel();
            folderBrowserDialog1 = new FolderBrowserDialog();
            defpathlbl = new Label();
            toolTip1 = new ToolTip(components);
            blinklabel = new Label();
            OCRPictureBox = new PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OCRPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, projectToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(861, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileExplorerToolStripMenuItem, recognizeTextToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // fileExplorerToolStripMenuItem
            // 
            fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
            fileExplorerToolStripMenuItem.Size = new Size(192, 26);
            fileExplorerToolStripMenuItem.Text = "File Explorer";
            fileExplorerToolStripMenuItem.Click += fileExplorerToolStripMenuItem_Click;
            // 
            // recognizeTextToolStripMenuItem
            // 
            recognizeTextToolStripMenuItem.Name = "recognizeTextToolStripMenuItem";
            recognizeTextToolStripMenuItem.Size = new Size(192, 26);
            recognizeTextToolStripMenuItem.Text = "Recognize Text";
            recognizeTextToolStripMenuItem.Click += recognizeTextToolStripMenuItem_Click;
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setWorkspaceToolStripMenuItem });
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(69, 24);
            projectToolStripMenuItem.Text = "Project";
            // 
            // setWorkspaceToolStripMenuItem
            // 
            setWorkspaceToolStripMenuItem.Name = "setWorkspaceToolStripMenuItem";
            setWorkspaceToolStripMenuItem.Size = new Size(189, 26);
            setWorkspaceToolStripMenuItem.Text = "Set Workspace";
            setWorkspaceToolStripMenuItem.Click += setWorkspaceToolStripMenuItem_Click;
            // 
            // OFDialog
            // 
            OFDialog.FileOk += OFDialog_FileOk;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { TSFname, toolStripStatusLabel1, TSProgbar });
            statusStrip1.Location = new Point(0, 531);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(861, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // TSFname
            // 
            TSFname.Name = "TSFname";
            TSFname.Size = new Size(67, 20);
            TSFname.Text = "filename";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(49, 20);
            toolStripStatusLabel1.Text = "Status";
            // 
            // TSProgbar
            // 
            TSProgbar.Name = "TSProgbar";
            TSProgbar.Size = new Size(100, 18);
            TSProgbar.Click += TSProgbar_Click;
            // 
            // statusStrip2
            // 
            statusStrip2.ImageScalingSize = new Size(20, 20);
            statusStrip2.Location = new Point(0, 389);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(861, 22);
            statusStrip2.TabIndex = 4;
            statusStrip2.Text = "statusStrip2";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Bottom;
            richTextBox2.Location = new Point(0, 411);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(861, 120);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // MainTextBox
            // 
            MainTextBox.Dock = DockStyle.Fill;
            MainTextBox.Location = new Point(0, 28);
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(861, 361);
            MainTextBox.TabIndex = 5;
            MainTextBox.Text = "";
            MainTextBox.TextChanged += MainTextBox_TextChanged;
            // 
            // FExplorer
            // 
            FExplorer.Dock = DockStyle.Bottom;
            FExplorer.Location = new Point(0, 274);
            FExplorer.Name = "FExplorer";
            FExplorer.Size = new Size(861, 115);
            FExplorer.TabIndex = 6;
            FExplorer.AfterSelect += FExplorer_AfterSelect;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 20);
            panel1.TabIndex = 7;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // defpathlbl
            // 
            defpathlbl.AutoSize = true;
            defpathlbl.Location = new Point(822, 51);
            defpathlbl.Name = "defpathlbl";
            defpathlbl.Size = new Size(27, 20);
            defpathlbl.TabIndex = 8;
            defpathlbl.Text = "C:\\";
            defpathlbl.Visible = false;
            // 
            // blinklabel
            // 
            blinklabel.AutoSize = true;
            blinklabel.Location = new Point(799, 31);
            blinklabel.Name = "blinklabel";
            blinklabel.Size = new Size(50, 20);
            blinklabel.TabIndex = 9;
            blinklabel.Text = "label1";
            blinklabel.Visible = false;
            // 
            // OCRPictureBox
            // 
            OCRPictureBox.Location = new Point(691, 102);
            OCRPictureBox.Name = "OCRPictureBox";
            OCRPictureBox.Size = new Size(129, 110);
            OCRPictureBox.TabIndex = 10;
            OCRPictureBox.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 557);
            Controls.Add(OCRPictureBox);
            Controls.Add(blinklabel);
            Controls.Add(defpathlbl);
            Controls.Add(panel1);
            Controls.Add(FExplorer);
            Controls.Add(MainTextBox);
            Controls.Add(statusStrip2);
            Controls.Add(richTextBox2);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "New Blank";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OCRPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private OpenFileDialog OFDialog;
        private SaveFileDialog SFDialog;
        private ToolStripMenuItem openToolStripMenuItem;
        private StatusStrip statusStrip1;
        private StatusStrip statusStrip2;
        private RichTextBox richTextBox2;
        private RichTextBox MainTextBox;
        private ToolStripStatusLabel TSFname;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TreeView FExplorer;
        private Panel panel1;
        private ToolStripProgressBar TSProgbar;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem setWorkspaceToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label defpathlbl;
        private ToolTip toolTip1;
        private Label blinklabel;
        private ToolStripMenuItem fileExplorerToolStripMenuItem;
        private ToolStripMenuItem recognizeTextToolStripMenuItem;
        private PictureBox OCRPictureBox;
    }
}