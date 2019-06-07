namespace EasyTrack_Dashboard
{
    partial class Form_DashboardWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.appTopBarPanel = new System.Windows.Forms.Panel();
            this.exportLabel = new System.Windows.Forms.Label();
            this.surveysLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.rootTabControl = new System.Windows.Forms.TabControl();
            this.summaryTabPage = new System.Windows.Forms.TabPage();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.surveysTabPage = new System.Windows.Forms.TabPage();
            this.exportTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.appTopBarPanel.SuspendLayout();
            this.rootTabControl.SuspendLayout();
            this.summaryTabPage.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // appTopBarPanel
            // 
            this.appTopBarPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.appTopBarPanel.Controls.Add(this.exportLabel);
            this.appTopBarPanel.Controls.Add(this.surveysLabel);
            this.appTopBarPanel.Controls.Add(this.usersLabel);
            this.appTopBarPanel.Controls.Add(this.summaryLabel);
            this.appTopBarPanel.Controls.Add(this.appTitleLabel);
            this.appTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.appTopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.appTopBarPanel.Name = "appTopBarPanel";
            this.appTopBarPanel.Size = new System.Drawing.Size(1084, 41);
            this.appTopBarPanel.TabIndex = 3;
            // 
            // exportLabel
            // 
            this.exportLabel.AutoSize = true;
            this.exportLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.exportLabel.ForeColor = System.Drawing.Color.White;
            this.exportLabel.Location = new System.Drawing.Point(900, 9);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(102, 26);
            this.exportLabel.TabIndex = 4;
            this.exportLabel.Text = "EXPORT";
            this.exportLabel.Click += new System.EventHandler(this.exportLabel_Click);
            // 
            // surveysLabel
            // 
            this.surveysLabel.AutoSize = true;
            this.surveysLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.surveysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.surveysLabel.ForeColor = System.Drawing.Color.White;
            this.surveysLabel.Location = new System.Drawing.Point(774, 9);
            this.surveysLabel.Name = "surveysLabel";
            this.surveysLabel.Size = new System.Drawing.Size(120, 26);
            this.surveysLabel.TabIndex = 3;
            this.surveysLabel.Text = "SURVEYS";
            this.surveysLabel.Click += new System.EventHandler(this.surveysLabel_Click);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usersLabel.ForeColor = System.Drawing.Color.White;
            this.usersLabel.Location = new System.Drawing.Point(679, 9);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(89, 26);
            this.usersLabel.TabIndex = 2;
            this.usersLabel.Text = "USERS";
            this.usersLabel.Click += new System.EventHandler(this.usersLabel_Click);
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.summaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.summaryLabel.ForeColor = System.Drawing.Color.Black;
            this.summaryLabel.Location = new System.Drawing.Point(547, 9);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(126, 26);
            this.summaryLabel.TabIndex = 1;
            this.summaryLabel.Text = "SUMMARY";
            this.summaryLabel.Click += new System.EventHandler(this.summaryLabel_Click);
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.appTitleLabel.ForeColor = System.Drawing.Color.White;
            this.appTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(226, 26);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "EasyTrack Dashboard";
            // 
            // rootTabControl
            // 
            this.rootTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.rootTabControl.Controls.Add(this.summaryTabPage);
            this.rootTabControl.Controls.Add(this.usersTabPage);
            this.rootTabControl.Controls.Add(this.surveysTabPage);
            this.rootTabControl.Controls.Add(this.exportTabPage);
            this.rootTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.rootTabControl.Location = new System.Drawing.Point(0, 41);
            this.rootTabControl.Name = "rootTabControl";
            this.rootTabControl.SelectedIndex = 2;
            this.rootTabControl.Size = new System.Drawing.Size(1084, 620);
            this.rootTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.rootTabControl.TabIndex = 6;
            // 
            // summaryTabPage
            // 
            this.summaryTabPage.BackColor = System.Drawing.Color.SteelBlue;
            this.summaryTabPage.Controls.Add(this.summaryPanel);
            this.summaryTabPage.Location = new System.Drawing.Point(4, 5);
            this.summaryTabPage.Name = "summaryTabPage";
            this.summaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.summaryTabPage.Size = new System.Drawing.Size(1076, 611);
            this.summaryTabPage.TabIndex = 0;
            this.summaryTabPage.Text = "tabPage1";
            // 
            // summaryPanel
            // 
            this.summaryPanel.AutoScroll = true;
            this.summaryPanel.BackColor = System.Drawing.Color.White;
            this.summaryPanel.Controls.Add(this.chart1);
            this.summaryPanel.Controls.Add(this.label1);
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryPanel.Location = new System.Drawing.Point(3, 3);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Padding = new System.Windows.Forms.Padding(10);
            this.summaryPanel.Size = new System.Drawing.Size(1070, 605);
            this.summaryPanel.TabIndex = 6;
            // 
            // usersTabPage
            // 
            this.usersTabPage.BackColor = System.Drawing.Color.SteelBlue;
            this.usersTabPage.Location = new System.Drawing.Point(4, 5);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersTabPage.Size = new System.Drawing.Size(1076, 611);
            this.usersTabPage.TabIndex = 1;
            this.usersTabPage.Text = "tabPage1";
            // 
            // surveysTabPage
            // 
            this.surveysTabPage.BackColor = System.Drawing.Color.SteelBlue;
            this.surveysTabPage.Location = new System.Drawing.Point(4, 5);
            this.surveysTabPage.Name = "surveysTabPage";
            this.surveysTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.surveysTabPage.Size = new System.Drawing.Size(1076, 611);
            this.surveysTabPage.TabIndex = 2;
            this.surveysTabPage.Text = "tabPage1";
            // 
            // exportTabPage
            // 
            this.exportTabPage.BackColor = System.Drawing.Color.SteelBlue;
            this.exportTabPage.Location = new System.Drawing.Point(4, 5);
            this.exportTabPage.Name = "exportTabPage";
            this.exportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.exportTabPage.Size = new System.Drawing.Size(1076, 611);
            this.exportTabPage.TabIndex = 3;
            this.exportTabPage.Text = "tabPage1";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1050, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Completeness";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 36);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Completeness";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1050, 559);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form_DashboardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.rootTabControl);
            this.Controls.Add(this.appTopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DashboardWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.appTopBarPanel.ResumeLayout(false);
            this.appTopBarPanel.PerformLayout();
            this.rootTabControl.ResumeLayout(false);
            this.summaryTabPage.ResumeLayout(false);
            this.summaryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel appTopBarPanel;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.Label surveysLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.TabControl rootTabControl;
        private System.Windows.Forms.TabPage summaryTabPage;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.TabPage usersTabPage;
        private System.Windows.Forms.TabPage surveysTabPage;
        private System.Windows.Forms.TabPage exportTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}