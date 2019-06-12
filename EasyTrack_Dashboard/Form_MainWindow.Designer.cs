namespace EasyTrack_Dashboard
{
    partial class Form_MainWindow
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
            this.appTopBarPanel = new System.Windows.Forms.Panel();
            this.toggleFeaturesButton = new System.Windows.Forms.Button();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.rootSplitContaner = new System.Windows.Forms.SplitContainer();
            this.feedbacksButton = new System.Windows.Forms.Button();
            this.logsButton = new System.Windows.Forms.Button();
            this.userStatsButton = new System.Windows.Forms.Button();
            this.campaignsButton = new System.Windows.Forms.Button();
            this.experimenterProfile = new EasyTrack_Dashboard.UC_Experimenter();
            this.rootTabControl = new System.Windows.Forms.TabControl();
            this.campaignsTabPage = new System.Windows.Forms.TabPage();
            this.campaignStatsPanel = new System.Windows.Forms.Panel();
            this.topCampaignDescrPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.campaignsTopBarPanel = new System.Windows.Forms.Panel();
            this.createNewCampaignButton = new System.Windows.Forms.Button();
            this.campaignListLabel = new System.Windows.Forms.Label();
            this.userStatsTabPage = new System.Windows.Forms.TabPage();
            this.userStatsPanel = new System.Windows.Forms.Panel();
            this.topUsersDescrPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userStatsTopBarPanel = new System.Windows.Forms.Panel();
            this.userStatsLabel = new System.Windows.Forms.Label();
            this.logsTabPage = new System.Windows.Forms.TabPage();
            this.logsPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.logsTopBarPanel = new System.Windows.Forms.Panel();
            this.logsLabel = new System.Windows.Forms.Label();
            this.feedbacksTabPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.feedbacksTopBarPanel = new System.Windows.Forms.Panel();
            this.feedbacksLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appTopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootSplitContaner)).BeginInit();
            this.rootSplitContaner.Panel1.SuspendLayout();
            this.rootSplitContaner.Panel2.SuspendLayout();
            this.rootSplitContaner.SuspendLayout();
            this.rootTabControl.SuspendLayout();
            this.campaignsTabPage.SuspendLayout();
            this.campaignStatsPanel.SuspendLayout();
            this.topCampaignDescrPanel.SuspendLayout();
            this.campaignsTopBarPanel.SuspendLayout();
            this.userStatsTabPage.SuspendLayout();
            this.userStatsPanel.SuspendLayout();
            this.topUsersDescrPanel.SuspendLayout();
            this.userStatsTopBarPanel.SuspendLayout();
            this.logsTabPage.SuspendLayout();
            this.logsPanel.SuspendLayout();
            this.logsTopBarPanel.SuspendLayout();
            this.feedbacksTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.feedbacksTopBarPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appTopBarPanel
            // 
            this.appTopBarPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.appTopBarPanel.Controls.Add(this.toggleFeaturesButton);
            this.appTopBarPanel.Controls.Add(this.appTitleLabel);
            this.appTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.appTopBarPanel.Location = new System.Drawing.Point(0, 24);
            this.appTopBarPanel.Name = "appTopBarPanel";
            this.appTopBarPanel.Size = new System.Drawing.Size(1048, 41);
            this.appTopBarPanel.TabIndex = 1;
            // 
            // toggleFeaturesButton
            // 
            this.toggleFeaturesButton.BackColor = System.Drawing.Color.Transparent;
            this.toggleFeaturesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleFeaturesButton.FlatAppearance.BorderSize = 0;
            this.toggleFeaturesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.toggleFeaturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleFeaturesButton.Image = global::EasyTrack_Dashboard.Properties.Resources.menu;
            this.toggleFeaturesButton.Location = new System.Drawing.Point(14, 8);
            this.toggleFeaturesButton.Name = "toggleFeaturesButton";
            this.toggleFeaturesButton.Size = new System.Drawing.Size(28, 22);
            this.toggleFeaturesButton.TabIndex = 1;
            this.toggleFeaturesButton.TabStop = false;
            this.toggleFeaturesButton.UseVisualStyleBackColor = false;
            this.toggleFeaturesButton.Click += new System.EventHandler(this.toggleFeaturesButton_Click);
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.appTitleLabel.ForeColor = System.Drawing.Color.White;
            this.appTitleLabel.Location = new System.Drawing.Point(49, 8);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(114, 26);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "EasyTrack";
            // 
            // rootSplitContaner
            // 
            this.rootSplitContaner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootSplitContaner.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.rootSplitContaner.IsSplitterFixed = true;
            this.rootSplitContaner.Location = new System.Drawing.Point(0, 65);
            this.rootSplitContaner.Name = "rootSplitContaner";
            // 
            // rootSplitContaner.Panel1
            // 
            this.rootSplitContaner.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.rootSplitContaner.Panel1.Controls.Add(this.feedbacksButton);
            this.rootSplitContaner.Panel1.Controls.Add(this.logsButton);
            this.rootSplitContaner.Panel1.Controls.Add(this.userStatsButton);
            this.rootSplitContaner.Panel1.Controls.Add(this.campaignsButton);
            this.rootSplitContaner.Panel1.Controls.Add(this.experimenterProfile);
            this.rootSplitContaner.Panel1.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.rootSplitContaner.Panel1MinSize = 200;
            // 
            // rootSplitContaner.Panel2
            // 
            this.rootSplitContaner.Panel2.Controls.Add(this.rootTabControl);
            this.rootSplitContaner.Panel2MinSize = 700;
            this.rootSplitContaner.Size = new System.Drawing.Size(1048, 476);
            this.rootSplitContaner.SplitterDistance = 230;
            this.rootSplitContaner.SplitterWidth = 1;
            this.rootSplitContaner.TabIndex = 2;
            // 
            // feedbacksButton
            // 
            this.feedbacksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedbacksButton.FlatAppearance.BorderSize = 0;
            this.feedbacksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.feedbacksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbacksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.feedbacksButton.ForeColor = System.Drawing.Color.White;
            this.feedbacksButton.Location = new System.Drawing.Point(14, 300);
            this.feedbacksButton.Name = "feedbacksButton";
            this.feedbacksButton.Size = new System.Drawing.Size(200, 46);
            this.feedbacksButton.TabIndex = 11;
            this.feedbacksButton.Text = "Feedbacks";
            this.feedbacksButton.UseVisualStyleBackColor = true;
            this.feedbacksButton.Click += new System.EventHandler(this.feedbacksButton_Click);
            // 
            // logsButton
            // 
            this.logsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logsButton.FlatAppearance.BorderSize = 0;
            this.logsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.logsButton.ForeColor = System.Drawing.Color.White;
            this.logsButton.Location = new System.Drawing.Point(14, 235);
            this.logsButton.Name = "logsButton";
            this.logsButton.Size = new System.Drawing.Size(200, 46);
            this.logsButton.TabIndex = 10;
            this.logsButton.Text = "Logs";
            this.logsButton.UseVisualStyleBackColor = true;
            this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
            // 
            // userStatsButton
            // 
            this.userStatsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userStatsButton.FlatAppearance.BorderSize = 0;
            this.userStatsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userStatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userStatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.userStatsButton.ForeColor = System.Drawing.Color.White;
            this.userStatsButton.Location = new System.Drawing.Point(14, 169);
            this.userStatsButton.Name = "userStatsButton";
            this.userStatsButton.Size = new System.Drawing.Size(200, 46);
            this.userStatsButton.TabIndex = 9;
            this.userStatsButton.Text = "User stats";
            this.userStatsButton.UseVisualStyleBackColor = true;
            this.userStatsButton.Click += new System.EventHandler(this.userStatsButton_Click);
            // 
            // campaignsButton
            // 
            this.campaignsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campaignsButton.FlatAppearance.BorderSize = 0;
            this.campaignsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.campaignsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campaignsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.campaignsButton.ForeColor = System.Drawing.Color.White;
            this.campaignsButton.Location = new System.Drawing.Point(14, 103);
            this.campaignsButton.Name = "campaignsButton";
            this.campaignsButton.Size = new System.Drawing.Size(200, 46);
            this.campaignsButton.TabIndex = 8;
            this.campaignsButton.Text = "Campaigns";
            this.campaignsButton.UseVisualStyleBackColor = true;
            this.campaignsButton.Click += new System.EventHandler(this.campaignsButton_Click);
            // 
            // experimenterProfile
            // 
            this.experimenterProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.experimenterProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.experimenterProfile.ExperimenterProfileType = "Experimenter";
            this.experimenterProfile.ExperimenterUsername = "Kevin";
            this.experimenterProfile.ForeColor = System.Drawing.Color.White;
            this.experimenterProfile.Location = new System.Drawing.Point(0, 0);
            this.experimenterProfile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.experimenterProfile.Name = "experimenterProfile";
            this.experimenterProfile.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.experimenterProfile.Size = new System.Drawing.Size(230, 59);
            this.experimenterProfile.TabIndex = 7;
            // 
            // rootTabControl
            // 
            this.rootTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.rootTabControl.Controls.Add(this.campaignsTabPage);
            this.rootTabControl.Controls.Add(this.userStatsTabPage);
            this.rootTabControl.Controls.Add(this.logsTabPage);
            this.rootTabControl.Controls.Add(this.feedbacksTabPage);
            this.rootTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.rootTabControl.Location = new System.Drawing.Point(0, 0);
            this.rootTabControl.Name = "rootTabControl";
            this.rootTabControl.SelectedIndex = 2;
            this.rootTabControl.Size = new System.Drawing.Size(817, 476);
            this.rootTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.rootTabControl.TabIndex = 1;
            // 
            // campaignsTabPage
            // 
            this.campaignsTabPage.BackColor = System.Drawing.Color.SteelBlue;
            this.campaignsTabPage.Controls.Add(this.campaignStatsPanel);
            this.campaignsTabPage.Controls.Add(this.campaignsTopBarPanel);
            this.campaignsTabPage.Location = new System.Drawing.Point(4, 5);
            this.campaignsTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.campaignsTabPage.Name = "campaignsTabPage";
            this.campaignsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.campaignsTabPage.Size = new System.Drawing.Size(809, 467);
            this.campaignsTabPage.TabIndex = 0;
            this.campaignsTabPage.Text = "tabPage1";
            // 
            // campaignStatsPanel
            // 
            this.campaignStatsPanel.BackColor = System.Drawing.Color.White;
            this.campaignStatsPanel.Controls.Add(this.topCampaignDescrPanel);
            this.campaignStatsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campaignStatsPanel.Location = new System.Drawing.Point(3, 37);
            this.campaignStatsPanel.Name = "campaignStatsPanel";
            this.campaignStatsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.campaignStatsPanel.Size = new System.Drawing.Size(803, 427);
            this.campaignStatsPanel.TabIndex = 4;
            // 
            // topCampaignDescrPanel
            // 
            this.topCampaignDescrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topCampaignDescrPanel.Controls.Add(this.label11);
            this.topCampaignDescrPanel.Controls.Add(this.label10);
            this.topCampaignDescrPanel.Controls.Add(this.label9);
            this.topCampaignDescrPanel.Controls.Add(this.label5);
            this.topCampaignDescrPanel.Controls.Add(this.label6);
            this.topCampaignDescrPanel.Controls.Add(this.label7);
            this.topCampaignDescrPanel.Controls.Add(this.label8);
            this.topCampaignDescrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topCampaignDescrPanel.Location = new System.Drawing.Point(10, 10);
            this.topCampaignDescrPanel.Name = "topCampaignDescrPanel";
            this.topCampaignDescrPanel.Size = new System.Drawing.Size(783, 13);
            this.topCampaignDescrPanel.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(715, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "Acions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(614, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "Anomalies";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "Date of modification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date of creation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Participants";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Campaign name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status";
            // 
            // campaignsTopBarPanel
            // 
            this.campaignsTopBarPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.campaignsTopBarPanel.Controls.Add(this.createNewCampaignButton);
            this.campaignsTopBarPanel.Controls.Add(this.campaignListLabel);
            this.campaignsTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.campaignsTopBarPanel.Location = new System.Drawing.Point(3, 3);
            this.campaignsTopBarPanel.Name = "campaignsTopBarPanel";
            this.campaignsTopBarPanel.Size = new System.Drawing.Size(803, 34);
            this.campaignsTopBarPanel.TabIndex = 3;
            // 
            // createNewCampaignButton
            // 
            this.createNewCampaignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewCampaignButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.createNewCampaignButton.FlatAppearance.BorderSize = 0;
            this.createNewCampaignButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.createNewCampaignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewCampaignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.createNewCampaignButton.ForeColor = System.Drawing.Color.Lime;
            this.createNewCampaignButton.Image = global::EasyTrack_Dashboard.Properties.Resources.new_campaign;
            this.createNewCampaignButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createNewCampaignButton.Location = new System.Drawing.Point(453, 0);
            this.createNewCampaignButton.Name = "createNewCampaignButton";
            this.createNewCampaignButton.Size = new System.Drawing.Size(350, 34);
            this.createNewCampaignButton.TabIndex = 2;
            this.createNewCampaignButton.Text = "CREATE NEW CAMPAIGN";
            this.createNewCampaignButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewCampaignButton.UseVisualStyleBackColor = true;
            this.createNewCampaignButton.Click += new System.EventHandler(this.createNewCampaignButton_Click_1);
            // 
            // campaignListLabel
            // 
            this.campaignListLabel.AutoSize = true;
            this.campaignListLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.campaignListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.campaignListLabel.ForeColor = System.Drawing.Color.White;
            this.campaignListLabel.Location = new System.Drawing.Point(0, 0);
            this.campaignListLabel.Name = "campaignListLabel";
            this.campaignListLabel.Size = new System.Drawing.Size(201, 25);
            this.campaignListLabel.TabIndex = 0;
            this.campaignListLabel.Text = "CAMPAIGNS LIST";
            // 
            // userStatsTabPage
            // 
            this.userStatsTabPage.BackColor = System.Drawing.Color.SteelBlue;
            this.userStatsTabPage.Controls.Add(this.userStatsPanel);
            this.userStatsTabPage.Controls.Add(this.userStatsTopBarPanel);
            this.userStatsTabPage.Location = new System.Drawing.Point(4, 5);
            this.userStatsTabPage.Name = "userStatsTabPage";
            this.userStatsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userStatsTabPage.Size = new System.Drawing.Size(809, 467);
            this.userStatsTabPage.TabIndex = 1;
            this.userStatsTabPage.Text = "tabPage2";
            // 
            // userStatsPanel
            // 
            this.userStatsPanel.BackColor = System.Drawing.Color.White;
            this.userStatsPanel.Controls.Add(this.topUsersDescrPanel);
            this.userStatsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userStatsPanel.Location = new System.Drawing.Point(3, 33);
            this.userStatsPanel.Name = "userStatsPanel";
            this.userStatsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.userStatsPanel.Size = new System.Drawing.Size(803, 431);
            this.userStatsPanel.TabIndex = 0;
            // 
            // topUsersDescrPanel
            // 
            this.topUsersDescrPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.topUsersDescrPanel.Controls.Add(this.label12);
            this.topUsersDescrPanel.Controls.Add(this.label4);
            this.topUsersDescrPanel.Controls.Add(this.label3);
            this.topUsersDescrPanel.Controls.Add(this.label2);
            this.topUsersDescrPanel.Controls.Add(this.label1);
            this.topUsersDescrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topUsersDescrPanel.Location = new System.Drawing.Point(10, 10);
            this.topUsersDescrPanel.Name = "topUsersDescrPanel";
            this.topUsersDescrPanel.Size = new System.Drawing.Size(783, 13);
            this.topUsersDescrPanel.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(410, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "Campaign";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount of data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last synchronized time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active";
            // 
            // userStatsTopBarPanel
            // 
            this.userStatsTopBarPanel.Controls.Add(this.userStatsLabel);
            this.userStatsTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userStatsTopBarPanel.Location = new System.Drawing.Point(3, 3);
            this.userStatsTopBarPanel.Name = "userStatsTopBarPanel";
            this.userStatsTopBarPanel.Size = new System.Drawing.Size(803, 30);
            this.userStatsTopBarPanel.TabIndex = 5;
            // 
            // userStatsLabel
            // 
            this.userStatsLabel.AutoSize = true;
            this.userStatsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.userStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userStatsLabel.ForeColor = System.Drawing.Color.White;
            this.userStatsLabel.Location = new System.Drawing.Point(0, 0);
            this.userStatsLabel.Name = "userStatsLabel";
            this.userStatsLabel.Size = new System.Drawing.Size(211, 25);
            this.userStatsLabel.TabIndex = 0;
            this.userStatsLabel.Text = "USER STATISTICS";
            // 
            // logsTabPage
            // 
            this.logsTabPage.BackColor = System.Drawing.Color.SteelBlue;
            this.logsTabPage.Controls.Add(this.logsPanel);
            this.logsTabPage.Controls.Add(this.logsTopBarPanel);
            this.logsTabPage.Location = new System.Drawing.Point(4, 5);
            this.logsTabPage.Name = "logsTabPage";
            this.logsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.logsTabPage.Size = new System.Drawing.Size(809, 467);
            this.logsTabPage.TabIndex = 2;
            this.logsTabPage.Text = "tabPage1";
            // 
            // logsPanel
            // 
            this.logsPanel.BackColor = System.Drawing.Color.White;
            this.logsPanel.Controls.Add(this.label13);
            this.logsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsPanel.Location = new System.Drawing.Point(3, 33);
            this.logsPanel.Name = "logsPanel";
            this.logsPanel.Size = new System.Drawing.Size(803, 431);
            this.logsPanel.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(803, 431);
            this.label13.TabIndex = 1;
            this.label13.Text = "[ EMPTY LIST ]";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logsTopBarPanel
            // 
            this.logsTopBarPanel.Controls.Add(this.logsLabel);
            this.logsTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logsTopBarPanel.Location = new System.Drawing.Point(3, 3);
            this.logsTopBarPanel.Name = "logsTopBarPanel";
            this.logsTopBarPanel.Size = new System.Drawing.Size(803, 30);
            this.logsTopBarPanel.TabIndex = 7;
            // 
            // logsLabel
            // 
            this.logsLabel.AutoSize = true;
            this.logsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logsLabel.ForeColor = System.Drawing.Color.White;
            this.logsLabel.Location = new System.Drawing.Point(0, 0);
            this.logsLabel.Name = "logsLabel";
            this.logsLabel.Size = new System.Drawing.Size(192, 25);
            this.logsLabel.TabIndex = 0;
            this.logsLabel.Text = "ANOMALY LOGS";
            // 
            // feedbacksTabPage
            // 
            this.feedbacksTabPage.BackColor = System.Drawing.Color.SteelBlue;
            this.feedbacksTabPage.Controls.Add(this.panel3);
            this.feedbacksTabPage.Controls.Add(this.feedbacksTopBarPanel);
            this.feedbacksTabPage.Location = new System.Drawing.Point(4, 5);
            this.feedbacksTabPage.Name = "feedbacksTabPage";
            this.feedbacksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.feedbacksTabPage.Size = new System.Drawing.Size(809, 467);
            this.feedbacksTabPage.TabIndex = 3;
            this.feedbacksTabPage.Text = "tabPage2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.feedbackLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 431);
            this.panel3.TabIndex = 8;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedbackLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedbackLabel.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.feedbackLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.feedbackLabel.Location = new System.Drawing.Point(0, 0);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(803, 431);
            this.feedbackLabel.TabIndex = 0;
            this.feedbackLabel.Text = "If you have any suggestion or concert about EasyTrack platform,\r\nplease don\'t hes" +
    "itate to directly contact with the EasyTrack support\r\nteam via email: easytracl_" +
    "support@googlegroups.com";
            this.feedbackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.feedbackLabel.Click += new System.EventHandler(this.feedbackLabel_Click);
            // 
            // feedbacksTopBarPanel
            // 
            this.feedbacksTopBarPanel.Controls.Add(this.feedbacksLabel);
            this.feedbacksTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.feedbacksTopBarPanel.Location = new System.Drawing.Point(3, 3);
            this.feedbacksTopBarPanel.Name = "feedbacksTopBarPanel";
            this.feedbacksTopBarPanel.Size = new System.Drawing.Size(803, 30);
            this.feedbacksTopBarPanel.TabIndex = 7;
            // 
            // feedbacksLabel
            // 
            this.feedbacksLabel.AutoSize = true;
            this.feedbacksLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.feedbacksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feedbacksLabel.ForeColor = System.Drawing.Color.White;
            this.feedbacksLabel.Location = new System.Drawing.Point(0, 0);
            this.feedbacksLabel.Name = "feedbacksLabel";
            this.feedbacksLabel.Size = new System.Drawing.Size(148, 25);
            this.feedbacksLabel.TabIndex = 0;
            this.feedbacksLabel.Text = "FEEDBACKS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Form_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1048, 541);
            this.Controls.Add(this.rootSplitContaner);
            this.Controls.Add(this.appTopBarPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1064, 580);
            this.Name = "Form_MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyTrack: Large-scale Mobile User Study Monitoring Platform";
            this.appTopBarPanel.ResumeLayout(false);
            this.appTopBarPanel.PerformLayout();
            this.rootSplitContaner.Panel1.ResumeLayout(false);
            this.rootSplitContaner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rootSplitContaner)).EndInit();
            this.rootSplitContaner.ResumeLayout(false);
            this.rootTabControl.ResumeLayout(false);
            this.campaignsTabPage.ResumeLayout(false);
            this.campaignStatsPanel.ResumeLayout(false);
            this.topCampaignDescrPanel.ResumeLayout(false);
            this.topCampaignDescrPanel.PerformLayout();
            this.campaignsTopBarPanel.ResumeLayout(false);
            this.campaignsTopBarPanel.PerformLayout();
            this.userStatsTabPage.ResumeLayout(false);
            this.userStatsPanel.ResumeLayout(false);
            this.topUsersDescrPanel.ResumeLayout(false);
            this.topUsersDescrPanel.PerformLayout();
            this.userStatsTopBarPanel.ResumeLayout(false);
            this.userStatsTopBarPanel.PerformLayout();
            this.logsTabPage.ResumeLayout(false);
            this.logsPanel.ResumeLayout(false);
            this.logsTopBarPanel.ResumeLayout(false);
            this.logsTopBarPanel.PerformLayout();
            this.feedbacksTabPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.feedbacksTopBarPanel.ResumeLayout(false);
            this.feedbacksTopBarPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel appTopBarPanel;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Button toggleFeaturesButton;
        private System.Windows.Forms.SplitContainer rootSplitContaner;
        private System.Windows.Forms.TabControl rootTabControl;
        private System.Windows.Forms.TabPage campaignsTabPage;
        private System.Windows.Forms.TabPage userStatsTabPage;
        private System.Windows.Forms.TabPage logsTabPage;
        private System.Windows.Forms.TabPage feedbacksTabPage;
        private System.Windows.Forms.Label campaignListLabel;
        private System.Windows.Forms.Panel campaignsTopBarPanel;
        private UC_Experimenter experimenterProfile;
        private System.Windows.Forms.Button campaignsButton;
        private System.Windows.Forms.Button userStatsButton;
        private System.Windows.Forms.Button logsButton;
        private System.Windows.Forms.Button feedbacksButton;
        private System.Windows.Forms.Panel userStatsTopBarPanel;
        private System.Windows.Forms.Label userStatsLabel;
        private System.Windows.Forms.Panel logsTopBarPanel;
        private System.Windows.Forms.Label logsLabel;
        private System.Windows.Forms.Panel feedbacksTopBarPanel;
        private System.Windows.Forms.Label feedbacksLabel;
        private System.Windows.Forms.Button createNewCampaignButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel userStatsPanel;
        private System.Windows.Forms.Panel topUsersDescrPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel campaignStatsPanel;
        private System.Windows.Forms.Panel topCampaignDescrPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel logsPanel;
        private System.Windows.Forms.Label label13;
    }
}

