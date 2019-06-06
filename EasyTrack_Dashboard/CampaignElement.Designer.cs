namespace EasyTrack_Dashboard
{
    partial class CampaignElement
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
            this.campaignStatusLabel = new System.Windows.Forms.Label();
            this.campaignNameLabel = new System.Windows.Forms.Label();
            this.campaignParticipantsCountLabel = new System.Windows.Forms.Label();
            this.campaignStartDateLabel = new System.Windows.Forms.Label();
            this.campaignEndDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // campaignStatusLabel
            // 
            this.campaignStatusLabel.AutoSize = true;
            this.campaignStatusLabel.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.campaignStatusLabel.Image = global::EasyTrack_Dashboard.Properties.Resources.red_dot;
            this.campaignStatusLabel.Location = new System.Drawing.Point(24, 21);
            this.campaignStatusLabel.Name = "campaignStatusLabel";
            this.campaignStatusLabel.Size = new System.Drawing.Size(16, 18);
            this.campaignStatusLabel.TabIndex = 19;
            this.campaignStatusLabel.Tag = "true";
            this.campaignStatusLabel.Text = " ";
            // 
            // campaignNameLabel
            // 
            this.campaignNameLabel.AutoSize = true;
            this.campaignNameLabel.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.campaignNameLabel.Location = new System.Drawing.Point(91, 21);
            this.campaignNameLabel.Name = "campaignNameLabel";
            this.campaignNameLabel.Size = new System.Drawing.Size(112, 18);
            this.campaignNameLabel.TabIndex = 17;
            this.campaignNameLabel.Text = "Campaign name";
            // 
            // campaignParticipantsCountLabel
            // 
            this.campaignParticipantsCountLabel.AutoSize = true;
            this.campaignParticipantsCountLabel.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.campaignParticipantsCountLabel.Location = new System.Drawing.Point(259, 21);
            this.campaignParticipantsCountLabel.Name = "campaignParticipantsCountLabel";
            this.campaignParticipantsCountLabel.Size = new System.Drawing.Size(16, 18);
            this.campaignParticipantsCountLabel.TabIndex = 18;
            this.campaignParticipantsCountLabel.Text = "0";
            // 
            // campaignStartDateLabel
            // 
            this.campaignStartDateLabel.AutoSize = true;
            this.campaignStartDateLabel.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.campaignStartDateLabel.Location = new System.Drawing.Point(363, 11);
            this.campaignStartDateLabel.Name = "campaignStartDateLabel";
            this.campaignStartDateLabel.Size = new System.Drawing.Size(72, 36);
            this.campaignStartDateLabel.TabIndex = 21;
            this.campaignStartDateLabel.Text = "START\r\nDATETIME";
            this.campaignStartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campaignEndDateLabel
            // 
            this.campaignEndDateLabel.AutoSize = true;
            this.campaignEndDateLabel.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.campaignEndDateLabel.Location = new System.Drawing.Point(491, 11);
            this.campaignEndDateLabel.Name = "campaignEndDateLabel";
            this.campaignEndDateLabel.Size = new System.Drawing.Size(72, 36);
            this.campaignEndDateLabel.TabIndex = 22;
            this.campaignEndDateLabel.Text = "END\r\nDATETIME";
            this.campaignEndDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.label3.Location = new System.Drawing.Point(627, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "DETAILS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CampaignElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.campaignEndDateLabel);
            this.Controls.Add(this.campaignStartDateLabel);
            this.Controls.Add(this.campaignStatusLabel);
            this.Controls.Add(this.campaignNameLabel);
            this.Controls.Add(this.campaignParticipantsCountLabel);
            this.MaximumSize = new System.Drawing.Size(3000, 66);
            this.MinimumSize = new System.Drawing.Size(725, 60);
            this.Name = "CampaignElement";
            this.Size = new System.Drawing.Size(800, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label campaignStatusLabel;
        private System.Windows.Forms.Label campaignNameLabel;
        private System.Windows.Forms.Label campaignParticipantsCountLabel;
        private System.Windows.Forms.Label campaignStartDateLabel;
        private System.Windows.Forms.Label campaignEndDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
