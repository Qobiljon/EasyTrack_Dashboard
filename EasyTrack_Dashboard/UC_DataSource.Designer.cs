namespace EasyTrack_Dashboard
{
    partial class UC_DataSource
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataSrcIconLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSourceName = new System.Windows.Forms.Label();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataRateTextBox = new System.Windows.Forms.TextBox();
            this.dataSrcCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSrcIconLabel
            // 
            this.dataSrcIconLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataSrcIconLabel.Location = new System.Drawing.Point(0, 0);
            this.dataSrcIconLabel.Name = "dataSrcIconLabel";
            this.dataSrcIconLabel.Size = new System.Drawing.Size(70, 70);
            this.dataSrcIconLabel.TabIndex = 3;
            this.dataSrcIconLabel.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSourceName);
            this.panel1.Controls.Add(this.labelDeviceName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataRateTextBox);
            this.panel1.Controls.Add(this.dataSrcCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(70, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(328, 70);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // labelSourceName
            // 
            this.labelSourceName.AutoSize = true;
            this.labelSourceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSourceName.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.labelSourceName.Location = new System.Drawing.Point(10, 10);
            this.labelSourceName.Name = "labelSourceName";
            this.labelSourceName.Size = new System.Drawing.Size(120, 22);
            this.labelSourceName.TabIndex = 12;
            this.labelSourceName.Text = "Accelerometer";
            this.labelSourceName.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDeviceName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic);
            this.labelDeviceName.Location = new System.Drawing.Point(10, 46);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(81, 14);
            this.labelDeviceName.TabIndex = 13;
            this.labelDeviceName.Text = "wearable-tizen";
            this.labelDeviceName.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "DATARATE";
            this.label2.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "MS";
            this.label1.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // dataRateTextBox
            // 
            this.dataRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRateTextBox.Enabled = false;
            this.dataRateTextBox.Location = new System.Drawing.Point(225, 44);
            this.dataRateTextBox.Name = "dataRateTextBox";
            this.dataRateTextBox.Size = new System.Drawing.Size(71, 21);
            this.dataRateTextBox.TabIndex = 9;
            this.dataRateTextBox.Text = "1000";
            this.dataRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataSrcCheckBox
            // 
            this.dataSrcCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSrcCheckBox.AutoSize = true;
            this.dataSrcCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dataSrcCheckBox.Location = new System.Drawing.Point(310, 3);
            this.dataSrcCheckBox.Name = "dataSrcCheckBox";
            this.dataSrcCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dataSrcCheckBox.TabIndex = 8;
            this.dataSrcCheckBox.TabStop = false;
            this.dataSrcCheckBox.UseVisualStyleBackColor = true;
            this.dataSrcCheckBox.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // UC_DataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataSrcIconLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(400, 72);
            this.MinimumSize = new System.Drawing.Size(400, 72);
            this.Name = "UC_DataSource";
            this.Size = new System.Drawing.Size(398, 70);
            this.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dataSrcIconLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSourceName;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataRateTextBox;
        private System.Windows.Forms.CheckBox dataSrcCheckBox;
    }
}
