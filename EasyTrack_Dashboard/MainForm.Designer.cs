namespace EasyTrack_Dashboard
{
    partial class MainForm
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
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.toggleFeaturesButton = new System.Windows.Forms.Button();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.rootSplitContaner = new System.Windows.Forms.SplitContainer();
            this.experimenterProfile1 = new EasyTrack_Dashboard.ExperimenterProfile();
            this.feedbacksLabel = new System.Windows.Forms.Label();
            this.labelLogs = new System.Windows.Forms.Label();
            this.userStatsLabel = new System.Windows.Forms.Label();
            this.campaignsLabel = new System.Windows.Forms.Label();
            this.rootTabControl = new System.Windows.Forms.TabControl();
            this.campaignsTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.campaignListLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userStatsTabPage = new System.Windows.Forms.TabPage();
            this.logsTabPage = new System.Windows.Forms.TabPage();
            this.feedbacksTabPage = new System.Windows.Forms.TabPage();
            this.topBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootSplitContaner)).BeginInit();
            this.rootSplitContaner.Panel1.SuspendLayout();
            this.rootSplitContaner.Panel2.SuspendLayout();
            this.rootSplitContaner.SuspendLayout();
            this.rootTabControl.SuspendLayout();
            this.campaignsTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.topBarPanel.Controls.Add(this.toggleFeaturesButton);
            this.topBarPanel.Controls.Add(this.appTitleLabel);
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(1384, 44);
            this.topBarPanel.TabIndex = 1;
            // 
            // toggleFeaturesButton
            // 
            this.toggleFeaturesButton.BackColor = System.Drawing.Color.Transparent;
            this.toggleFeaturesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleFeaturesButton.FlatAppearance.BorderSize = 0;
            this.toggleFeaturesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.toggleFeaturesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.toggleFeaturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleFeaturesButton.Location = new System.Drawing.Point(12, 9);
            this.toggleFeaturesButton.Name = "toggleFeaturesButton";
            this.toggleFeaturesButton.Size = new System.Drawing.Size(24, 24);
            this.toggleFeaturesButton.TabIndex = 1;
            this.toggleFeaturesButton.TabStop = false;
            this.toggleFeaturesButton.UseVisualStyleBackColor = false;
            this.toggleFeaturesButton.Click += new System.EventHandler(this.toggleFeaturesButton_Click);
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.appTitleLabel.ForeColor = System.Drawing.Color.White;
            this.appTitleLabel.Location = new System.Drawing.Point(42, 9);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(114, 27);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "EasyTrack";
            // 
            // rootSplitContaner
            // 
            this.rootSplitContaner.BackColor = System.Drawing.Color.DodgerBlue;
            this.rootSplitContaner.IsSplitterFixed = true;
            this.rootSplitContaner.Location = new System.Drawing.Point(0, 45);
            this.rootSplitContaner.Name = "rootSplitContaner";
            // 
            // rootSplitContaner.Panel1
            // 
            this.rootSplitContaner.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.rootSplitContaner.Panel1.Controls.Add(this.experimenterProfile1);
            this.rootSplitContaner.Panel1.Controls.Add(this.feedbacksLabel);
            this.rootSplitContaner.Panel1.Controls.Add(this.labelLogs);
            this.rootSplitContaner.Panel1.Controls.Add(this.userStatsLabel);
            this.rootSplitContaner.Panel1.Controls.Add(this.campaignsLabel);
            this.rootSplitContaner.Panel1.Margin = new System.Windows.Forms.Padding(10);
            // 
            // rootSplitContaner.Panel2
            // 
            this.rootSplitContaner.Panel2.Controls.Add(this.rootTabControl);
            this.rootSplitContaner.Size = new System.Drawing.Size(1384, 716);
            this.rootSplitContaner.SplitterDistance = 300;
            this.rootSplitContaner.SplitterWidth = 1;
            this.rootSplitContaner.TabIndex = 2;
            // 
            // experimenterProfile1
            // 
            this.experimenterProfile1.BackColor = System.Drawing.Color.SteelBlue;
            this.experimenterProfile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.experimenterProfile1.Location = new System.Drawing.Point(0, 0);
            this.experimenterProfile1.Margin = new System.Windows.Forms.Padding(5);
            this.experimenterProfile1.Name = "experimenterProfile1";
            this.experimenterProfile1.Padding = new System.Windows.Forms.Padding(5);
            this.experimenterProfile1.Size = new System.Drawing.Size(300, 64);
            this.experimenterProfile1.TabIndex = 7;
            // 
            // feedbacksLabel
            // 
            this.feedbacksLabel.AutoSize = true;
            this.feedbacksLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedbacksLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feedbacksLabel.ForeColor = System.Drawing.Color.White;
            this.feedbacksLabel.Location = new System.Drawing.Point(12, 292);
            this.feedbacksLabel.Name = "feedbacksLabel";
            this.feedbacksLabel.Size = new System.Drawing.Size(172, 38);
            this.feedbacksLabel.TabIndex = 6;
            this.feedbacksLabel.Text = "Feedbacks";
            this.feedbacksLabel.Click += new System.EventHandler(this.feedbacksLabel_Click);
            // 
            // labelLogs
            // 
            this.labelLogs.AutoSize = true;
            this.labelLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogs.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogs.ForeColor = System.Drawing.Color.White;
            this.labelLogs.Location = new System.Drawing.Point(12, 234);
            this.labelLogs.Name = "labelLogs";
            this.labelLogs.Size = new System.Drawing.Size(86, 38);
            this.labelLogs.TabIndex = 5;
            this.labelLogs.Text = "Logs";
            this.labelLogs.Click += new System.EventHandler(this.labelLogs_Click);
            // 
            // userStatsLabel
            // 
            this.userStatsLabel.AutoSize = true;
            this.userStatsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userStatsLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userStatsLabel.ForeColor = System.Drawing.Color.White;
            this.userStatsLabel.Location = new System.Drawing.Point(12, 181);
            this.userStatsLabel.Name = "userStatsLabel";
            this.userStatsLabel.Size = new System.Drawing.Size(162, 38);
            this.userStatsLabel.TabIndex = 4;
            this.userStatsLabel.Text = "User stats";
            this.userStatsLabel.Click += new System.EventHandler(this.userStatsLabel_Click);
            // 
            // campaignsLabel
            // 
            this.campaignsLabel.AutoSize = true;
            this.campaignsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campaignsLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.campaignsLabel.ForeColor = System.Drawing.Color.White;
            this.campaignsLabel.Location = new System.Drawing.Point(12, 128);
            this.campaignsLabel.Name = "campaignsLabel";
            this.campaignsLabel.Size = new System.Drawing.Size(178, 38);
            this.campaignsLabel.TabIndex = 3;
            this.campaignsLabel.Text = "Campaigns";
            this.campaignsLabel.Click += new System.EventHandler(this.campaignsLabel_Click);
            // 
            // rootTabControl
            // 
            this.rootTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rootTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.rootTabControl.Controls.Add(this.campaignsTabPage);
            this.rootTabControl.Controls.Add(this.userStatsTabPage);
            this.rootTabControl.Controls.Add(this.logsTabPage);
            this.rootTabControl.Controls.Add(this.feedbacksTabPage);
            this.rootTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.rootTabControl.Location = new System.Drawing.Point(-4, -5);
            this.rootTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.rootTabControl.Name = "rootTabControl";
            this.rootTabControl.SelectedIndex = 0;
            this.rootTabControl.Size = new System.Drawing.Size(1103, 725);
            this.rootTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.rootTabControl.TabIndex = 1;
            // 
            // campaignsTabPage
            // 
            this.campaignsTabPage.BackColor = System.Drawing.Color.DodgerBlue;
            this.campaignsTabPage.Controls.Add(this.panel1);
            this.campaignsTabPage.Controls.Add(this.flowLayoutPanel1);
            this.campaignsTabPage.Location = new System.Drawing.Point(4, 5);
            this.campaignsTabPage.Name = "campaignsTabPage";
            this.campaignsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.campaignsTabPage.Size = new System.Drawing.Size(1095, 716);
            this.campaignsTabPage.TabIndex = 0;
            this.campaignsTabPage.Text = "tabPage1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.campaignListLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 32);
            this.panel1.TabIndex = 3;
            // 
            // campaignListLabel
            // 
            this.campaignListLabel.AutoSize = true;
            this.campaignListLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.campaignListLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.campaignListLabel.ForeColor = System.Drawing.Color.White;
            this.campaignListLabel.Location = new System.Drawing.Point(0, 0);
            this.campaignListLabel.Name = "campaignListLabel";
            this.campaignListLabel.Size = new System.Drawing.Size(180, 25);
            this.campaignListLabel.TabIndex = 0;
            this.campaignListLabel.Text = "CAMPAIGNS LIST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Image = global::EasyTrack_Dashboard.Properties.Resources.new_campaign4;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(808, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CREATE NEW CAMPAIGN      ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1089, 667);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // userStatsTabPage
            // 
            this.userStatsTabPage.BackColor = System.Drawing.Color.Green;
            this.userStatsTabPage.Location = new System.Drawing.Point(4, 5);
            this.userStatsTabPage.Name = "userStatsTabPage";
            this.userStatsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userStatsTabPage.Size = new System.Drawing.Size(1095, 716);
            this.userStatsTabPage.TabIndex = 1;
            this.userStatsTabPage.Text = "tabPage2";
            // 
            // logsTabPage
            // 
            this.logsTabPage.BackColor = System.Drawing.Color.Yellow;
            this.logsTabPage.Location = new System.Drawing.Point(4, 5);
            this.logsTabPage.Name = "logsTabPage";
            this.logsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.logsTabPage.Size = new System.Drawing.Size(1095, 716);
            this.logsTabPage.TabIndex = 2;
            this.logsTabPage.Text = "tabPage1";
            // 
            // feedbacksTabPage
            // 
            this.feedbacksTabPage.BackColor = System.Drawing.Color.Orange;
            this.feedbacksTabPage.Location = new System.Drawing.Point(4, 5);
            this.feedbacksTabPage.Name = "feedbacksTabPage";
            this.feedbacksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.feedbacksTabPage.Size = new System.Drawing.Size(1095, 716);
            this.feedbacksTabPage.TabIndex = 3;
            this.feedbacksTabPage.Text = "tabPage2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.rootSplitContaner);
            this.Controls.Add(this.topBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyTrack: Large-scale Mobile User Study Monitoring Platform";
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            this.rootSplitContaner.Panel1.ResumeLayout(false);
            this.rootSplitContaner.Panel1.PerformLayout();
            this.rootSplitContaner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rootSplitContaner)).EndInit();
            this.rootSplitContaner.ResumeLayout(false);
            this.rootTabControl.ResumeLayout(false);
            this.campaignsTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Button toggleFeaturesButton;
        private System.Windows.Forms.SplitContainer rootSplitContaner;
        private System.Windows.Forms.Label campaignsLabel;
        private System.Windows.Forms.Label userStatsLabel;
        private System.Windows.Forms.Label labelLogs;
        private System.Windows.Forms.Label feedbacksLabel;
        private System.Windows.Forms.TabControl rootTabControl;
        private System.Windows.Forms.TabPage campaignsTabPage;
        private System.Windows.Forms.TabPage userStatsTabPage;
        private System.Windows.Forms.TabPage logsTabPage;
        private System.Windows.Forms.TabPage feedbacksTabPage;
        private System.Windows.Forms.Label campaignListLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ExperimenterProfile experimenterProfile1;
    }
}

