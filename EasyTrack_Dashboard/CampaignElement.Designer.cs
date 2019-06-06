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
            this.labelParticipantAmountOfData = new System.Windows.Forms.Label();
            this.labelParticipantStatus = new System.Windows.Forms.Label();
            this.labelParticipantUsername = new System.Windows.Forms.Label();
            this.labelParticipantLastSyncTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelParticipantAmountOfData
            // 
            this.labelParticipantAmountOfData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParticipantAmountOfData.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.labelParticipantAmountOfData.Image = global::EasyTrack_Dashboard.Properties.Resources.arrow_up;
            this.labelParticipantAmountOfData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelParticipantAmountOfData.Location = new System.Drawing.Point(535, 21);
            this.labelParticipantAmountOfData.Name = "labelParticipantAmountOfData";
            this.labelParticipantAmountOfData.Size = new System.Drawing.Size(144, 18);
            this.labelParticipantAmountOfData.TabIndex = 20;
            this.labelParticipantAmountOfData.Text = "123456 samples";
            this.labelParticipantAmountOfData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelParticipantStatus
            // 
            this.labelParticipantStatus.AutoSize = true;
            this.labelParticipantStatus.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.labelParticipantStatus.Image = global::EasyTrack_Dashboard.Properties.Resources.red_dot;
            this.labelParticipantStatus.Location = new System.Drawing.Point(24, 21);
            this.labelParticipantStatus.Name = "labelParticipantStatus";
            this.labelParticipantStatus.Size = new System.Drawing.Size(16, 18);
            this.labelParticipantStatus.TabIndex = 19;
            this.labelParticipantStatus.Tag = "true";
            this.labelParticipantStatus.Text = " ";
            // 
            // labelParticipantUsername
            // 
            this.labelParticipantUsername.AutoSize = true;
            this.labelParticipantUsername.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.labelParticipantUsername.Location = new System.Drawing.Point(116, 21);
            this.labelParticipantUsername.Name = "labelParticipantUsername";
            this.labelParticipantUsername.Size = new System.Drawing.Size(64, 18);
            this.labelParticipantUsername.TabIndex = 17;
            this.labelParticipantUsername.Text = "User #1";
            // 
            // labelParticipantLastSyncTime
            // 
            this.labelParticipantLastSyncTime.AutoSize = true;
            this.labelParticipantLastSyncTime.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.labelParticipantLastSyncTime.Location = new System.Drawing.Point(274, 21);
            this.labelParticipantLastSyncTime.Name = "labelParticipantLastSyncTime";
            this.labelParticipantLastSyncTime.Size = new System.Drawing.Size(96, 18);
            this.labelParticipantLastSyncTime.TabIndex = 18;
            this.labelParticipantLastSyncTime.Text = "37 mins ago";
            // 
            // CampaignElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelParticipantAmountOfData);
            this.Controls.Add(this.labelParticipantStatus);
            this.Controls.Add(this.labelParticipantUsername);
            this.Controls.Add(this.labelParticipantLastSyncTime);
            this.MaximumSize = new System.Drawing.Size(3000, 66);
            this.MinimumSize = new System.Drawing.Size(725, 60);
            this.Name = "CampaignElement";
            this.Size = new System.Drawing.Size(723, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParticipantAmountOfData;
        private System.Windows.Forms.Label labelParticipantStatus;
        private System.Windows.Forms.Label labelParticipantUsername;
        private System.Windows.Forms.Label labelParticipantLastSyncTime;
    }
}
