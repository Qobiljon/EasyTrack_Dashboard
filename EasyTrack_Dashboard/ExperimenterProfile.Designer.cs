namespace EasyTrack_Dashboard
{
    partial class ExperimenterProfile
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
            this.usersRoleLabel = new System.Windows.Forms.Label();
            this.usersNameLabel = new System.Windows.Forms.Label();
            this.usersAvatarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersAvatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usersRoleLabel
            // 
            this.usersRoleLabel.AutoSize = true;
            this.usersRoleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersRoleLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersRoleLabel.ForeColor = System.Drawing.Color.White;
            this.usersRoleLabel.Location = new System.Drawing.Point(69, 23);
            this.usersRoleLabel.Name = "usersRoleLabel";
            this.usersRoleLabel.Size = new System.Drawing.Size(85, 18);
            this.usersRoleLabel.TabIndex = 5;
            this.usersRoleLabel.Text = "Profile type";
            // 
            // usersNameLabel
            // 
            this.usersNameLabel.AutoSize = true;
            this.usersNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersNameLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersNameLabel.ForeColor = System.Drawing.Color.White;
            this.usersNameLabel.Location = new System.Drawing.Point(69, 5);
            this.usersNameLabel.Name = "usersNameLabel";
            this.usersNameLabel.Size = new System.Drawing.Size(137, 18);
            this.usersNameLabel.TabIndex = 4;
            this.usersNameLabel.Text = "Experimenter name";
            // 
            // usersAvatarPictureBox
            // 
            this.usersAvatarPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.usersAvatarPictureBox.Image = global::EasyTrack_Dashboard.Properties.Resources.avatar_64;
            this.usersAvatarPictureBox.Location = new System.Drawing.Point(5, 5);
            this.usersAvatarPictureBox.Name = "usersAvatarPictureBox";
            this.usersAvatarPictureBox.Size = new System.Drawing.Size(64, 64);
            this.usersAvatarPictureBox.TabIndex = 3;
            this.usersAvatarPictureBox.TabStop = false;
            // 
            // ExperimenterProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.usersRoleLabel);
            this.Controls.Add(this.usersNameLabel);
            this.Controls.Add(this.usersAvatarPictureBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExperimenterProfile";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(283, 74);
            ((System.ComponentModel.ISupportInitialize)(this.usersAvatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usersRoleLabel;
        private System.Windows.Forms.Label usersNameLabel;
        private System.Windows.Forms.PictureBox usersAvatarPictureBox;
    }
}
