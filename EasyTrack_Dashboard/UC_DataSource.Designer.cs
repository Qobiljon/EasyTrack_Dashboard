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
            this.labelSourceName = new System.Windows.Forms.Label();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.dataSrcCheckBox = new System.Windows.Forms.CheckBox();
            this.dataRateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSourceName
            // 
            this.labelSourceName.AutoSize = true;
            this.labelSourceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSourceName.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.labelSourceName.Location = new System.Drawing.Point(10, 10);
            this.labelSourceName.Name = "labelSourceName";
            this.labelSourceName.Size = new System.Drawing.Size(120, 22);
            this.labelSourceName.TabIndex = 0;
            this.labelSourceName.Text = "Accelerometer";
            this.labelSourceName.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDeviceName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic);
            this.labelDeviceName.Location = new System.Drawing.Point(10, 38);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(81, 14);
            this.labelDeviceName.TabIndex = 1;
            this.labelDeviceName.Text = "wearable-tizen";
            this.labelDeviceName.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // dataSrcCheckBox
            // 
            this.dataSrcCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSrcCheckBox.AutoSize = true;
            this.dataSrcCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dataSrcCheckBox.Location = new System.Drawing.Point(339, 6);
            this.dataSrcCheckBox.Name = "dataSrcCheckBox";
            this.dataSrcCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dataSrcCheckBox.TabIndex = 2;
            this.dataSrcCheckBox.TabStop = false;
            this.dataSrcCheckBox.UseVisualStyleBackColor = true;
            this.dataSrcCheckBox.CheckedChanged += new System.EventHandler(this.dataSrcCheckBox_CheckedChanged);
            // 
            // dataRateTextBox
            // 
            this.dataRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRateTextBox.Enabled = false;
            this.dataRateTextBox.Location = new System.Drawing.Point(253, 37);
            this.dataRateTextBox.Name = "dataRateTextBox";
            this.dataRateTextBox.Size = new System.Drawing.Size(71, 21);
            this.dataRateTextBox.TabIndex = 3;
            this.dataRateTextBox.Text = "1000";
            this.dataRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataRateTextBox.TextChanged += new System.EventHandler(this.dataRateTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "MS";
            this.label1.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "DATARATE";
            this.label2.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            // 
            // DataSourceElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataRateTextBox);
            this.Controls.Add(this.labelSourceName);
            this.Controls.Add(this.dataSrcCheckBox);
            this.Controls.Add(this.labelDeviceName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(300, 64);
            this.MinimumSize = new System.Drawing.Size(360, 64);
            this.Name = "DataSourceElement";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(358, 62);
            this.Click += new System.EventHandler(this.dataSrcCheckToggle_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSourceName;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.CheckBox dataSrcCheckBox;
        private System.Windows.Forms.TextBox dataRateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
