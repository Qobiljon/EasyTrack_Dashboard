namespace EasyTrack_Dashboard
{
    partial class Form_CampaignCreatorWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.proceedButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rootTabControl = new System.Windows.Forms.TabControl();
            this.campaignDetailsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.campaignDetailsRightPanel = new System.Windows.Forms.Panel();
            this.campaignManagersPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addExperimenterButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.campaignDetailsLeftPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.campaignDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.campaignEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.campaignStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.campaignNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSourcesTabPage = new System.Windows.Forms.TabPage();
            this.dataSourcesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.recruitingTabPage = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.newParticipantUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addParticipantButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.participantsListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.confirmDetailsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.confirmDataSourcesLabel = new System.Windows.Forms.Label();
            this.confirmPeriodLabel = new System.Windows.Forms.Label();
            this.confirmDescriptionLabel = new System.Windows.Forms.Label();
            this.confirmNameLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentExperimenterProfile = new EasyTrack_Dashboard.UC_Experimenter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rootTabControl.SuspendLayout();
            this.campaignDetailsTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.campaignDetailsRightPanel.SuspendLayout();
            this.campaignManagersPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.campaignDetailsLeftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.dataSourcesTabPage.SuspendLayout();
            this.recruitingTabPage.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.confirmDetailsTabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.proceedButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 647);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 45);
            this.panel1.TabIndex = 3;
            // 
            // proceedButton
            // 
            this.proceedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceedButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.proceedButton.Location = new System.Drawing.Point(1203, 0);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(253, 45);
            this.proceedButton.TabIndex = 0;
            this.proceedButton.Text = "PROCEED";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rootTabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1456, 647);
            this.panel2.TabIndex = 4;
            // 
            // rootTabControl
            // 
            this.rootTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.rootTabControl.Controls.Add(this.campaignDetailsTabPage);
            this.rootTabControl.Controls.Add(this.dataSourcesTabPage);
            this.rootTabControl.Controls.Add(this.recruitingTabPage);
            this.rootTabControl.Controls.Add(this.confirmDetailsTabPage);
            this.rootTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.rootTabControl.Location = new System.Drawing.Point(0, 0);
            this.rootTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.rootTabControl.Name = "rootTabControl";
            this.rootTabControl.SelectedIndex = 0;
            this.rootTabControl.Size = new System.Drawing.Size(1456, 647);
            this.rootTabControl.TabIndex = 3;
            // 
            // campaignDetailsTabPage
            // 
            this.campaignDetailsTabPage.Controls.Add(this.tableLayoutPanel1);
            this.campaignDetailsTabPage.Controls.Add(this.label1);
            this.campaignDetailsTabPage.Location = new System.Drawing.Point(4, 5);
            this.campaignDetailsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.campaignDetailsTabPage.Name = "campaignDetailsTabPage";
            this.campaignDetailsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.campaignDetailsTabPage.Size = new System.Drawing.Size(1448, 638);
            this.campaignDetailsTabPage.TabIndex = 0;
            this.campaignDetailsTabPage.Text = "Campaign Details TabPage";
            this.campaignDetailsTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.campaignDetailsRightPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.campaignDetailsLeftPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1440, 584);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // campaignDetailsRightPanel
            // 
            this.campaignDetailsRightPanel.Controls.Add(this.campaignManagersPanel);
            this.campaignDetailsRightPanel.Controls.Add(this.tableLayoutPanel2);
            this.campaignDetailsRightPanel.Controls.Add(this.label6);
            this.campaignDetailsRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campaignDetailsRightPanel.Enabled = false;
            this.campaignDetailsRightPanel.Location = new System.Drawing.Point(724, 4);
            this.campaignDetailsRightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.campaignDetailsRightPanel.Name = "campaignDetailsRightPanel";
            this.campaignDetailsRightPanel.Padding = new System.Windows.Forms.Padding(17, 22, 17, 22);
            this.campaignDetailsRightPanel.Size = new System.Drawing.Size(712, 576);
            this.campaignDetailsRightPanel.TabIndex = 1;
            // 
            // campaignManagersPanel
            // 
            this.campaignManagersPanel.AutoScroll = true;
            this.campaignManagersPanel.Controls.Add(this.currentExperimenterProfile);
            this.campaignManagersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campaignManagersPanel.Location = new System.Drawing.Point(17, 48);
            this.campaignManagersPanel.Name = "campaignManagersPanel";
            this.campaignManagersPanel.Size = new System.Drawing.Size(678, 471);
            this.campaignManagersPanel.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addExperimenterButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 519);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(678, 35);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(5, 5);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(532, 25);
            this.textBox3.TabIndex = 0;
            // 
            // addExperimenterButton
            // 
            this.addExperimenterButton.AutoSize = true;
            this.addExperimenterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addExperimenterButton.Location = new System.Drawing.Point(545, 3);
            this.addExperimenterButton.Name = "addExperimenterButton";
            this.addExperimenterButton.Size = new System.Drawing.Size(130, 29);
            this.addExperimenterButton.TabIndex = 1;
            this.addExperimenterButton.Text = "ADD";
            this.addExperimenterButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label6.Size = new System.Drawing.Size(436, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Campaign Managers (Not available in MVP version of this application)";
            // 
            // campaignDetailsLeftPanel
            // 
            this.campaignDetailsLeftPanel.Controls.Add(this.panel5);
            this.campaignDetailsLeftPanel.Controls.Add(this.panel4);
            this.campaignDetailsLeftPanel.Controls.Add(this.panel3);
            this.campaignDetailsLeftPanel.Controls.Add(this.panel6);
            this.campaignDetailsLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campaignDetailsLeftPanel.Location = new System.Drawing.Point(4, 4);
            this.campaignDetailsLeftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.campaignDetailsLeftPanel.Name = "campaignDetailsLeftPanel";
            this.campaignDetailsLeftPanel.Size = new System.Drawing.Size(712, 576);
            this.campaignDetailsLeftPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.campaignDescriptionTextBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 333);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(23, 30, 23, 30);
            this.panel5.Size = new System.Drawing.Size(712, 243);
            this.panel5.TabIndex = 3;
            // 
            // campaignDescriptionTextBox
            // 
            this.campaignDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campaignDescriptionTextBox.Location = new System.Drawing.Point(23, 56);
            this.campaignDescriptionTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.campaignDescriptionTextBox.Multiline = true;
            this.campaignDescriptionTextBox.Name = "campaignDescriptionTextBox";
            this.campaignDescriptionTextBox.Size = new System.Drawing.Size(666, 157);
            this.campaignDescriptionTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(23, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Description";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.campaignEndDatePicker);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 222);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(17, 22, 17, 22);
            this.panel4.Size = new System.Drawing.Size(712, 111);
            this.panel4.TabIndex = 2;
            // 
            // campaignEndDatePicker
            // 
            this.campaignEndDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campaignEndDatePicker.Location = new System.Drawing.Point(17, 48);
            this.campaignEndDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.campaignEndDatePicker.Name = "campaignEndDatePicker";
            this.campaignEndDatePicker.Size = new System.Drawing.Size(678, 25);
            this.campaignEndDatePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "End Date";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.campaignStartDatePicker);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(17, 22, 17, 22);
            this.panel3.Size = new System.Drawing.Size(712, 111);
            this.panel3.TabIndex = 1;
            // 
            // campaignStartDatePicker
            // 
            this.campaignStartDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campaignStartDatePicker.Location = new System.Drawing.Point(17, 48);
            this.campaignStartDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.campaignStartDatePicker.Name = "campaignStartDatePicker";
            this.campaignStartDatePicker.Size = new System.Drawing.Size(678, 25);
            this.campaignStartDatePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start date";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.campaignNameTextBox);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(17, 22, 17, 22);
            this.panel6.Size = new System.Drawing.Size(712, 111);
            this.panel6.TabIndex = 0;
            // 
            // campaignNameTextBox
            // 
            this.campaignNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.campaignNameTextBox.Location = new System.Drawing.Point(17, 48);
            this.campaignNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.campaignNameTextBox.Name = "campaignNameTextBox";
            this.campaignNameTextBox.Size = new System.Drawing.Size(678, 25);
            this.campaignNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1440, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMPAIGN DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataSourcesTabPage
            // 
            this.dataSourcesTabPage.Controls.Add(this.dataSourcesFlowLayoutPanel);
            this.dataSourcesTabPage.Location = new System.Drawing.Point(4, 5);
            this.dataSourcesTabPage.Name = "dataSourcesTabPage";
            this.dataSourcesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataSourcesTabPage.Size = new System.Drawing.Size(1491, 638);
            this.dataSourcesTabPage.TabIndex = 1;
            this.dataSourcesTabPage.Text = "tabPage1";
            this.dataSourcesTabPage.UseVisualStyleBackColor = true;
            // 
            // dataSourcesFlowLayoutPanel
            // 
            this.dataSourcesFlowLayoutPanel.AutoScroll = true;
            this.dataSourcesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSourcesFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.dataSourcesFlowLayoutPanel.Name = "dataSourcesFlowLayoutPanel";
            this.dataSourcesFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.dataSourcesFlowLayoutPanel.Size = new System.Drawing.Size(1485, 632);
            this.dataSourcesFlowLayoutPanel.TabIndex = 0;
            // 
            // recruitingTabPage
            // 
            this.recruitingTabPage.Controls.Add(this.panel8);
            this.recruitingTabPage.Controls.Add(this.panel7);
            this.recruitingTabPage.Location = new System.Drawing.Point(4, 5);
            this.recruitingTabPage.Name = "recruitingTabPage";
            this.recruitingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recruitingTabPage.Size = new System.Drawing.Size(1491, 638);
            this.recruitingTabPage.TabIndex = 3;
            this.recruitingTabPage.Text = "tabPage1";
            this.recruitingTabPage.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.newParticipantUsernameTextBox);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.addParticipantButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(3, 610);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1485, 25);
            this.panel8.TabIndex = 1;
            // 
            // newParticipantUsernameTextBox
            // 
            this.newParticipantUsernameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.newParticipantUsernameTextBox.Location = new System.Drawing.Point(128, 0);
            this.newParticipantUsernameTextBox.Name = "newParticipantUsernameTextBox";
            this.newParticipantUsernameTextBox.Size = new System.Drawing.Size(734, 25);
            this.newParticipantUsernameTextBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "USERNAME";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addParticipantButton
            // 
            this.addParticipantButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addParticipantButton.Location = new System.Drawing.Point(1149, 0);
            this.addParticipantButton.Name = "addParticipantButton";
            this.addParticipantButton.Size = new System.Drawing.Size(336, 25);
            this.addParticipantButton.TabIndex = 2;
            this.addParticipantButton.Text = "ADD PARTICIPANT";
            this.addParticipantButton.UseVisualStyleBackColor = true;
            this.addParticipantButton.Click += new System.EventHandler(this.addParticipantButton_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.participantsListBox);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1485, 632);
            this.panel7.TabIndex = 0;
            // 
            // participantsListBox
            // 
            this.participantsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantsListBox.FormattingEnabled = true;
            this.participantsListBox.ItemHeight = 18;
            this.participantsListBox.Location = new System.Drawing.Point(0, 29);
            this.participantsListBox.Name = "participantsListBox";
            this.participantsListBox.Size = new System.Drawing.Size(1485, 603);
            this.participantsListBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Participants";
            // 
            // confirmDetailsTabPage
            // 
            this.confirmDetailsTabPage.Controls.Add(this.tableLayoutPanel3);
            this.confirmDetailsTabPage.Location = new System.Drawing.Point(4, 5);
            this.confirmDetailsTabPage.Name = "confirmDetailsTabPage";
            this.confirmDetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.confirmDetailsTabPage.Size = new System.Drawing.Size(1491, 638);
            this.confirmDetailsTabPage.TabIndex = 2;
            this.confirmDetailsTabPage.Text = "tabPage1";
            this.confirmDetailsTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.confirmDataSourcesLabel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.confirmPeriodLabel, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.confirmDescriptionLabel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.confirmNameLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1485, 632);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // confirmDataSourcesLabel
            // 
            this.confirmDataSourcesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmDataSourcesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmDataSourcesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmDataSourcesLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.confirmDataSourcesLabel.Location = new System.Drawing.Point(745, 504);
            this.confirmDataSourcesLabel.Name = "confirmDataSourcesLabel";
            this.confirmDataSourcesLabel.Size = new System.Drawing.Size(737, 128);
            this.confirmDataSourcesLabel.TabIndex = 15;
            this.confirmDataSourcesLabel.Text = "Accelerometer, Gyroscope, Heart Rate Monitor";
            this.confirmDataSourcesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPeriodLabel
            // 
            this.confirmPeriodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPeriodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmPeriodLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmPeriodLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.confirmPeriodLabel.Location = new System.Drawing.Point(745, 378);
            this.confirmPeriodLabel.Name = "confirmPeriodLabel";
            this.confirmPeriodLabel.Size = new System.Drawing.Size(737, 126);
            this.confirmPeriodLabel.TabIndex = 14;
            this.confirmPeriodLabel.Text = "2019-02-01 to 2019-05-01";
            this.confirmPeriodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmDescriptionLabel
            // 
            this.confirmDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmDescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmDescriptionLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.confirmDescriptionLabel.Location = new System.Drawing.Point(745, 252);
            this.confirmDescriptionLabel.Name = "confirmDescriptionLabel";
            this.confirmDescriptionLabel.Size = new System.Drawing.Size(737, 126);
            this.confirmDescriptionLabel.TabIndex = 13;
            this.confirmDescriptionLabel.Text = "This is a test campaign created by Kevin";
            this.confirmDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmNameLabel
            // 
            this.confirmNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmNameLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.confirmNameLabel.Location = new System.Drawing.Point(745, 126);
            this.confirmNameLabel.Name = "confirmNameLabel";
            this.confirmNameLabel.Size = new System.Drawing.Size(737, 126);
            this.confirmNameLabel.TabIndex = 12;
            this.confirmNameLabel.Text = "Test campaign by Kevin";
            this.confirmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Calibri", 24F);
            this.label15.Location = new System.Drawing.Point(3, 504);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(736, 128);
            this.label15.TabIndex = 10;
            this.label15.Text = "Data Sources";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Calibri", 24F);
            this.label13.Location = new System.Drawing.Point(3, 378);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(736, 126);
            this.label13.TabIndex = 8;
            this.label13.Text = "Period";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Calibri", 24F);
            this.label11.Location = new System.Drawing.Point(3, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(736, 126);
            this.label11.TabIndex = 4;
            this.label11.Text = "Description";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F);
            this.label9.Location = new System.Drawing.Point(3, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(736, 126);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(736, 126);
            this.label7.TabIndex = 0;
            this.label7.Text = "CONFIRM CAMAIGN DETAILS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentExperimenterProfile
            // 
            this.currentExperimenterProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentExperimenterProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentExperimenterProfile.ExperimenterProfileType = "Experimenter";
            this.currentExperimenterProfile.ExperimenterUsername = "Kevin";
            this.currentExperimenterProfile.Location = new System.Drawing.Point(0, 0);
            this.currentExperimenterProfile.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.currentExperimenterProfile.Name = "currentExperimenterProfile";
            this.currentExperimenterProfile.Padding = new System.Windows.Forms.Padding(11, 15, 11, 15);
            this.currentExperimenterProfile.Size = new System.Drawing.Size(678, 86);
            this.currentExperimenterProfile.TabIndex = 0;
            // 
            // Form_CampaignCreatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(912, 731);
            this.Name = "Form_CampaignCreatorWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CampaignCreatorForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rootTabControl.ResumeLayout(false);
            this.campaignDetailsTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.campaignDetailsRightPanel.ResumeLayout(false);
            this.campaignDetailsRightPanel.PerformLayout();
            this.campaignManagersPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.campaignDetailsLeftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.dataSourcesTabPage.ResumeLayout(false);
            this.recruitingTabPage.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.confirmDetailsTabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl rootTabControl;
        private System.Windows.Forms.TabPage campaignDetailsTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel campaignDetailsRightPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addExperimenterButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel campaignDetailsLeftPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox campaignDescriptionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker campaignEndDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker campaignStartDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox campaignNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel campaignManagersPanel;
        private UC_Experimenter currentExperimenterProfile;
        private System.Windows.Forms.TabPage dataSourcesTabPage;
        private System.Windows.Forms.FlowLayoutPanel dataSourcesFlowLayoutPanel;
        private System.Windows.Forms.TabPage confirmDetailsTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label confirmDataSourcesLabel;
        private System.Windows.Forms.Label confirmPeriodLabel;
        private System.Windows.Forms.Label confirmDescriptionLabel;
        private System.Windows.Forms.Label confirmNameLabel;
        private System.Windows.Forms.TabPage recruitingTabPage;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox participantsListBox;
        private System.Windows.Forms.Button addParticipantButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newParticipantUsernameTextBox;
    }
}