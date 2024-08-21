namespace AudioPlayer
{
    partial class FrmAudioPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAudioPlayer));
            btnPlay = new Button();
            btnPause = new Button();
            btnStop = new Button();
            lblName = new Label();
            btnOpen = new Button();
            lblVolume = new Label();
            txtVolume = new TextBox();
            btnDown = new Button();
            btnUp = new Button();
            btnNext = new Button();
            btnPrev = new Button();
            lstFiles = new ListBox();
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            ascendingToolStripMenuItem = new ToolStripMenuItem();
            descendingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            resources.ApplyResources(btnPlay, "btnPlay");
            btnPlay.Name = "btnPlay";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            resources.ApplyResources(btnPause, "btnPause");
            btnPause.Name = "btnPause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            resources.ApplyResources(btnStop, "btnStop");
            btnStop.Name = "btnStop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.AutoEllipsis = true;
            lblName.Name = "lblName";
            // 
            // btnOpen
            // 
            resources.ApplyResources(btnOpen, "btnOpen");
            btnOpen.Name = "btnOpen";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // lblVolume
            // 
            resources.ApplyResources(lblVolume, "lblVolume");
            lblVolume.Name = "lblVolume";
            // 
            // txtVolume
            // 
            resources.ApplyResources(txtVolume, "txtVolume");
            txtVolume.Name = "txtVolume";
            txtVolume.TextChanged += txtVolume_TextChanged;
            // 
            // btnDown
            // 
            resources.ApplyResources(btnDown, "btnDown");
            btnDown.Name = "btnDown";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnUp
            // 
            resources.ApplyResources(btnUp, "btnUp");
            btnUp.Name = "btnUp";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            resources.ApplyResources(btnPrev, "btnPrev");
            btnPrev.Name = "btnPrev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // lstFiles
            // 
            resources.ApplyResources(lstFiles, "lstFiles");
            lstFiles.FormattingEnabled = true;
            lstFiles.Name = "lstFiles";
            lstFiles.DoubleClick += lstFiles_DoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { orderToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ascendingToolStripMenuItem, descendingToolStripMenuItem });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            resources.ApplyResources(orderToolStripMenuItem, "orderToolStripMenuItem");
            // 
            // ascendingToolStripMenuItem
            // 
            ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            resources.ApplyResources(ascendingToolStripMenuItem, "ascendingToolStripMenuItem");
            ascendingToolStripMenuItem.Click += ascendingToolStripMenuItem_Click;
            // 
            // descendingToolStripMenuItem
            // 
            descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            resources.ApplyResources(descendingToolStripMenuItem, "descendingToolStripMenuItem");
            descendingToolStripMenuItem.Click += descendingToolStripMenuItem_Click;
            // 
            // FrmAudioPlayer
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            Controls.Add(lstFiles);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(btnUp);
            Controls.Add(btnDown);
            Controls.Add(txtVolume);
            Controls.Add(lblVolume);
            Controls.Add(btnOpen);
            Controls.Add(lblName);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Controls.Add(btnPlay);
            MainMenuStrip = menuStrip1;
            Name = "FrmAudioPlayer";
            Load += FrmAudioPlayer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private Button btnPause;
        private Button btnStop;
        private Label lblName;
        private Button btnOpen;
        private Label lblVolume;
        private TextBox txtVolume;
        private Button btnDown;
        private Button btnUp;
        private Button btnNext;
        private Button btnPrev;
        private ListBox lstFiles;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem ascendingToolStripMenuItem;
        private ToolStripMenuItem descendingToolStripMenuItem;
    }
}
